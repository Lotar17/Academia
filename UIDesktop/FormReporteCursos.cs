using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Entities;
using Dominio;

namespace UIDesktop
{
    public partial class FormReporteCursos : Form
    {
        private List<Curso> cursos;

        public FormReporteCursos()
        {
            InitializeComponent();
            retrieveCursos();
        }

        public async void retrieveCursos()
        {
            Controller controller = new Controller();
            cursos = await controller.cursosGetAll();
            dgv_Cursos.DataSource = cursos;
            dgv_Cursos.Columns["IdComisionNavigation"].Visible = false;
            dgv_Cursos.Columns["IdMateriaNavigation"].Visible = false;
            dgv_Cursos.Columns["AlumnosInscripciones"].Visible = false;
            dgv_Cursos.Columns["DocentesCursos"].Visible = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            guardar.ShowDialog();
            string paginahtml_text = Properties.Resources.Plantilla.ToString();
            paginahtml_text = paginahtml_text.Replace("@nombre_usuario", UsuarioLoginCache._NombreUsuario);
            paginahtml_text = paginahtml_text.Replace("@nombreapellido", UsuarioLoginCache._Apellido + ", " + UsuarioLoginCache._Nombre);
            paginahtml_text = paginahtml_text.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            Controller controller = new Controller();
            foreach (DataGridViewRow row in dgv_Cursos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["AnioCalendario"].Value.ToString() + "</td>";
                filas += "<td>" + controller.materiaGetOne(int.Parse(row.Cells["IdMateria"].Value.ToString())).DescMateria + "</td>";
                filas += "<td>" + controller.comisionGetOne(int.Parse(row.Cells["IdComision"].Value.ToString())).DescComision + "</td>";
                filas += "<td>" + row.Cells["Cupo"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            paginahtml_text = paginahtml_text.Replace("@filas", filas);

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Rosario_Central_logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    using (StringReader sr = new StringReader(paginahtml_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
