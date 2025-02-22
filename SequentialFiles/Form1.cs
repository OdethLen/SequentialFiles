using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SequentialFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Hero hero = new Hero();
            hero.Name = txtName.Text;
            hero.Alias = txtAlias.Text;
            hero.Gender = txtGender.Text;
            hero.Age = txtAge.Text;
            hero.Quirk = txtQuirk.Text;


            if (dgvData.Rows.Count==1) 
            {
                MessageBox.Show("There's no data to export.","No data");
                return;
            }

            String fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files |*.txt";
            saveFileDialog.Title = "Save a Text File";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = saveFileDialog.FileName;
            if (fileName != null)
            {
                StreamWriter sw = new StreamWriter(fileName);

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    // No exportar la fila vacía (de ser el caso)
                    if (row.IsNewRow) continue;

                    // Crear un array con los valores de las celdas de la fila
                    var values = row.Cells.OfType<DataGridViewCell>()
                                          .Select(cell => cell.Value?.ToString() ?? string.Empty)
                                          .ToArray();

                    sw.WriteLine(string.Join(",", values));
                }

                sw.Flush();
                sw.Close();
                //sw.Write(hero.Name);
                //sw.Write(hero.Alias);
                //sw.Write(hero.Gender);
                //sw.Write(hero.Age);
                //sw.Write(hero.Quirk);
                //sw.Flush();
                //sw.Close();

                MessageBox.Show("txt file sucefully saved");

            }


        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {


            if (txtName.Text == "")
            {
                MessageBox.Show("Enter data in name.");
                return;
            }

            if (txtAlias.Text == "")
            {
                MessageBox.Show("Enter data in alias.");
                return;
            }

            if (txtGender.Text == "")
            {
                MessageBox.Show("Enter data in gender.");
                return;
            }

            if (txtAge.Text == "")
            {
                MessageBox.Show("Enter data in age.");
                return;
            }

            if (txtQuirk.Text == "")
            {
                MessageBox.Show("Enter data in quirk.");
                return;
            }

            dgvData.Rows.Add(txtName.Text, txtAlias.Text, txtGender.Text, txtAge.Text, txtQuirk.Text);

            txtName.Clear();
            txtAlias.Clear();
            txtGender.Clear();
            txtAge.Clear();
            txtQuirk.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files |*.txt";
            openFileDialog.Title = "Open txt file";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;
            string[] lines = File.ReadAllLines(filePath);
            dgvData.Rows.Clear();

            foreach (string line in lines)
            {
                // Dividir cada línea por la coma (CSV)
                string[] values = line.Split(',');

                // Agregar los valores a una nueva fila del DataGridView
                dgvData.Rows.Add(values);
            }

            MessageBox.Show("Data loaded successfully into DataGridView.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count>0)
            {
                // Asegurarse de que no intentamos eliminar la fila nueva vacía
                if (!dgvData.Rows[dgvData.SelectedRows[0].Index].IsNewRow)
                {
                    // Eliminar la fila seleccionada
                    dgvData.Rows.RemoveAt(dgvData.SelectedRows[0].Index);
                    MessageBox.Show("Selected row deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Cannot delete the new empty row.");
                }
            }

            else
            {
                MessageBox.Show("No row selected to delete.");
            }
        }




        }
    }

