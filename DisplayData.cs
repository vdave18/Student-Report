using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Up_Project
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void DisplayData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                this.studentsTableAdapter.FillByQuiz80(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                this.studentsTableAdapter.FillByQuiz50(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                this.studentsTableAdapter.FillByQuizbtwn6070(this.studentsDataSet.Students);
            }

            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                this.studentsTableAdapter.FillByLab80(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                this.studentsTableAdapter.FillByLab50(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                this.studentsTableAdapter.FillByLabbtwn6070(this.studentsDataSet.Students);
            }


            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                this.studentsTableAdapter.FillByLec80(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                this.studentsTableAdapter.FillByLec50(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                this.studentsTableAdapter.FillByLecbtwn6070(this.studentsDataSet.Students);
            }

            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                this.studentsTableAdapter.FillByResearch80(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
            {
                this.studentsTableAdapter.FillByResearch50(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
            {
                this.studentsTableAdapter.FillByResearchbtwn6070(this.studentsDataSet.Students);
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                this.studentsTableAdapter.FillByFinal80(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
            {
                this.studentsTableAdapter.FillByFinal50(this.studentsDataSet.Students);
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
            {
                this.studentsTableAdapter.FillByFinalbtwn6070(this.studentsDataSet.Students);
            }
        }
    }
}
