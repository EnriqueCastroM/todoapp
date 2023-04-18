using ClosedXML.Excel;

namespace todoapp
{
    using ClosedXML.Excel;
    using System.IO;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarTarea_Click(object sender, EventArgs e)
        {
            string nuevaTarea = textBoxNuevaTarea.Text.Trim();

            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                string tarea = $"{nuevaTarea} ({dateTimePickerVencimiento.Value.ToShortDateString()})";
                listBoxTareas.Items.Add(new ListViewItem { Text = tarea, Checked = checkBoxCompletada.Checked });
                textBoxNuevaTarea.Clear();
            }
        }


        private void buttonEliminarTarea_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedIndex != -1)
            {
                listBoxTareas.Items.RemoveAt(listBoxTareas.SelectedIndex);
            }
        }

        private void buttonExportarTareas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de Excel (*.xlsx)|*.xlsx",
                FileName = "Tareas pendientes.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet = workbook.Worksheets.Add("Tareas");

                    worksheet.Cell(1, 1).Value = "Tareas";
                    worksheet.Cell(1, 2).Value = "Fecha de vencimiento";
                    worksheet.Cell(1, 3).Value = "Completada";

                    for (int i = 1; i <= 3; i++)
                    {
                        worksheet.Cell(1, i).Style.Font.Bold = true;
                    }

                    for (int i = 0; i < listBoxTareas.Items.Count; i++)
                    {
                        ListViewItem item = listBoxTareas.Items[i] as ListViewItem;
                        string[] tareaInfo = item.Text.Split('(');
                        string tarea = tareaInfo[0].Trim();
                        string fechaVencimiento = tareaInfo[1].Trim(' ', ')');

                        worksheet.Cell(i + 2, 1).Value = tarea;
                        worksheet.Cell(i + 2, 2).Value = fechaVencimiento;
                        worksheet.Cell(i + 2, 3).Value = item.Checked ? "Sí" : "No";
                    }

                    workbook.SaveAs(saveFileDialog.FileName);
                }
            }
        }

        private void checkBoxCompletada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelTareas_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}