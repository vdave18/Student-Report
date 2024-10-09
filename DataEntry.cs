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
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
          

            foreach (DataGridViewRow row in studentsDataGridView.Rows)
            {

                //Console.WriteLine($"Parameter Name: {parameter.ParameterName}, Value: {parameter.Value}");
                if (row.IsNewRow) continue; // Skip the new row placeholder

                // Access marks by column index
                int quizMarks = Convert.ToInt32(row.Cells[3].Value);  // Quiz Marks is the 4th column
                int labTestMarks = Convert.ToInt32(row.Cells[4].Value);  // Lab Test Marks is the 5th column
                int lectureTestMarks = Convert.ToInt32(row.Cells[5].Value); // Lecture Test Marks is the 6th column
                int researchProjectMarks = Convert.ToInt32(row.Cells[6].Value); // Research Project Marks is the 7th column
                int finalProjectMarks = Convert.ToInt32(row.Cells[7].Value); // Final Project Marks is the 8th column

                // Calculate the average as an integer
                int average = (quizMarks + labTestMarks + lectureTestMarks + researchProjectMarks + finalProjectMarks) / 5;

                // Update the Average column in the DataGridView (Assuming Average is the 9th column)
                row.Cells[8].Value = average;


            }

            // Update the database with the changes made in the DataGridView
            //this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void Average_Click(object sender, EventArgs e)
        {
            //this.studentsTableAdapter.FillByAverage(this.studentsDataSet.Students);
            double overallAverage = CalculateOverallAverage();

            MessageBox.Show($"The average of the Average column is: {overallAverage:F2}");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private double CalculateOverallAverage()
        {
            // Check if there are any rows in the DataGridView
            if (studentsDataGridView.Rows.Count == 0)
            {
                return 0; // No data available
            }

            // Sum of all averages
            double sum = 0;
            int count = 0;

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in studentsDataGridView.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                // Get the average value from the 9th column (assuming index 8)
                if (row.Cells[8].Value != null && int.TryParse(row.Cells[8].Value.ToString(), out int average))
                {
                    sum += average;
                    count++;
                }
            }

            // Return the average of averages
            return count > 0 ? sum / count : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double standardDeviation = CalculateStandardDeviation();
            // Format the result to 2 decimal places
            string formattedStandardDeviation = standardDeviation.ToString("F2");
            MessageBox.Show($"The standard deviation of the Average column is: {formattedStandardDeviation}");
        }
        private double CalculateStandardDeviation()
        {
            List<double> averages = new List<double>();

            foreach (DataGridViewRow row in studentsDataGridView.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                if (row.Cells[8].Value != null && int.TryParse(row.Cells[8].Value.ToString(), out int average))
                {
                    averages.Add(average);
                }
            }

            int count = averages.Count;
            if (count <= 1) return 0;

            double mean = averages.Average();
            double variance = averages.Sum(x => Math.Pow(x - mean, 2)) / (count - 1);

            return Math.Sqrt(variance);
        }
    }
}
