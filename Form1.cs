using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public class Character
        {
            public string name;
            public int tally;
            public string image;
            public Character(string newname, int newtally, string newimage)
            {
                this.name = newname;
                this.tally = newtally;
                this.image = newimage;
            }
            public int getTally()
            {
                return this.tally;
            }
            public string getImage()
            {
                return this.image;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "DeltaX Hacks Submission (Sept. 2020)";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonTakeTest_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int elsa = 0, anna = 0, olaf = 0, kristoff = 0, maximum = elsa;
            Character elsa = new Character("Elsa", 0, "elsa.jpg");
            Character anna = new Character("Anna", 0, "anna.jpg");
            Character olaf = new Character("Olaf", 0, "olaf.jpg");
            Character kristoff = new Character("Kristoff", 0, "Kristoff.jpg");
            Character highest = new Character("", 0, "");
            int CheckedCount = 0;

            // Question 1
            if (radioButtonQ1O1.Checked)
            {
                elsa.tally++;
                radioButtonQ1O1.Font = new Font(radioButtonQ1O1.Font, FontStyle.Bold);
                CheckedCount++;
            }

            if (radioButtonQ1O2.Checked)
            {
                anna.tally++;
                radioButtonQ1O2.Font = new Font(radioButtonQ1O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ1O3.Checked)
            {
                olaf.tally++;
                radioButtonQ1O3.Font = new Font(radioButtonQ1O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ1O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ1O4.Font = new Font(radioButtonQ1O4.Font, FontStyle.Bold);
                CheckedCount++;
            } 

            // Question 2
            if (radioButtonQ2O1.Checked)
            {
                elsa.tally++;
                radioButtonQ2O1.Font = new Font(radioButtonQ2O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ2O2.Checked)
            {
                anna.tally++;
                radioButtonQ2O2.Font = new Font(radioButtonQ2O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ2O3.Checked)
            {
                olaf.tally++;
                radioButtonQ2O3.Font = new Font(radioButtonQ2O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ2O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ2O4.Font = new Font(radioButtonQ2O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 3
            if (radioButtonQ3O1.Checked)
            {
                elsa.tally++;
                radioButtonQ3O1.Font = new Font(radioButtonQ3O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ3O2.Checked)
            {
                anna.tally++;
                radioButtonQ3O2.Font = new Font(radioButtonQ3O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ3O3.Checked)
            {
                olaf.tally++;
                radioButtonQ3O3.Font = new Font(radioButtonQ3O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ3O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ3O4.Font = new Font(radioButtonQ3O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 4
            if (radioButtonQ4O1.Checked)
            {
                elsa.tally++;
                radioButtonQ4O1.Font = new Font(radioButtonQ4O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ4O2.Checked)
            {
                anna.tally++;
                radioButtonQ4O2.Font = new Font(radioButtonQ4O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ4O3.Checked)
            {
                olaf.tally++;
                radioButtonQ4O3.Font = new Font(radioButtonQ4O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ4O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ4O4.Font = new Font(radioButtonQ4O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 5
            if (radioButtonQ5O1.Checked)
            {
                elsa.tally++;
                radioButtonQ5O1.Font = new Font(radioButtonQ5O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ5O2.Checked)
            {
                anna.tally++;
                radioButtonQ5O2.Font = new Font(radioButtonQ5O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ5O3.Checked)
            {
                olaf.tally++;
                radioButtonQ5O3.Font = new Font(radioButtonQ5O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ5O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ5O4.Font = new Font(radioButtonQ5O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 6
            if (radioButtonQ6O1.Checked)
            {
                elsa.tally++;
                radioButtonQ6O1.Font = new Font(radioButtonQ6O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ6O2.Checked)
            {
                anna.tally++;
                radioButtonQ6O2.Font = new Font(radioButtonQ6O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ6O3.Checked)
            {
                olaf.tally++;
                radioButtonQ6O3.Font = new Font(radioButtonQ6O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ6O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ6O4.Font = new Font(radioButtonQ6O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 7
            if (radioButtonQ7O1.Checked)
            {
                elsa.tally++;
                radioButtonQ7O1.Font = new Font(radioButtonQ7O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ7O2.Checked)
            {
                anna.tally++;
                radioButtonQ7O2.Font = new Font(radioButtonQ7O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ7O3.Checked)
            {
                olaf.tally++;
                radioButtonQ7O3.Font = new Font(radioButtonQ7O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ7O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ7O4.Font = new Font(radioButtonQ7O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 8
            if (radioButtonQ8O1.Checked)
            {
                elsa.tally++;
                radioButtonQ8O1.Font = new Font(radioButtonQ8O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ8O2.Checked)
            {
                anna.tally++;
                radioButtonQ8O2.Font = new Font(radioButtonQ8O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ8O3.Checked)
            {
                olaf.tally++;
                radioButtonQ8O3.Font = new Font(radioButtonQ8O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ8O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ8O4.Font = new Font(radioButtonQ8O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 9
            if (radioButtonQ9O1.Checked)
            {
                elsa.tally++;
                radioButtonQ9O1.Font = new Font(radioButtonQ9O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ9O2.Checked)
            {
                anna.tally++;
                radioButtonQ9O2.Font = new Font(radioButtonQ9O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ9O3.Checked)
            {
                olaf.tally++;
                radioButtonQ9O3.Font = new Font(radioButtonQ9O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ9O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ9O4.Font = new Font(radioButtonQ9O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            //Question 10
            if (radioButtonQ10O1.Checked)
            {
                elsa.tally++;
                radioButtonQ10O1.Font = new Font(radioButtonQ10O1.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ10O2.Checked)
            {
                anna.tally++;
                radioButtonQ10O2.Font = new Font(radioButtonQ10O2.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ10O3.Checked)
            {
                olaf.tally++;
                radioButtonQ10O3.Font = new Font(radioButtonQ10O3.Font, FontStyle.Bold);
                CheckedCount++;
            }
            if (radioButtonQ10O4.Checked)
            {
                kristoff.tally++;
                radioButtonQ10O4.Font = new Font(radioButtonQ10O4.Font, FontStyle.Bold);
                CheckedCount++;
            }

            // Result
            if (CheckedCount >= 10)
            {
                highest = elsa;
                if (anna.getTally() > highest.getTally())
                    highest = anna;
                if (olaf.getTally() > highest.getTally())
                    highest = olaf;
                if (kristoff.getTally() > highest.getTally())
                    highest = kristoff;

                textBoxResult.Text = "You are " + highest.name.ToString();
                // MessageBox.Show("You are " + highest.name.ToString());
                chartResults.Series.Clear();
                chartResults.Series.Add("Results");
                chartResults.Series["Results"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                if (elsa.getTally() >= 1)
                    chartResults.Series["Results"].Points.AddXY("Elsa", elsa.getTally());
                if (anna.getTally() >= 1)
                    chartResults.Series["Results"].Points.AddXY("Anna", anna.getTally());
                if (olaf.getTally() >= 1)
                    chartResults.Series["Results"].Points.AddXY("Olaf", olaf.getTally());
                if (kristoff.getTally() >= 1)
                    chartResults.Series["Results"].Points.AddXY("Kristoff", kristoff.getTally());

                pictureBoxResult.Load(highest.getImage());
            }

            if (CheckedCount < 10)
            {
                MessageBox.Show("You did not finish the test!");
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            pictureBoxResult.Image = null;

            chartResults.Series.Clear();

            radioButtonQ1O1.Checked = false;
            radioButtonQ1O2.Checked = false;
            radioButtonQ1O3.Checked = false;
            radioButtonQ1O4.Checked = false;
            radioButtonQ2O1.Checked = false;
            radioButtonQ2O2.Checked = false;
            radioButtonQ2O3.Checked = false;
            radioButtonQ2O4.Checked = false;
            radioButtonQ3O1.Checked = false;
            radioButtonQ3O2.Checked = false;
            radioButtonQ3O3.Checked = false;
            radioButtonQ3O4.Checked = false;
            radioButtonQ4O1.Checked = false;
            radioButtonQ4O2.Checked = false;
            radioButtonQ4O3.Checked = false;
            radioButtonQ4O4.Checked = false;
            radioButtonQ5O1.Checked = false;
            radioButtonQ5O2.Checked = false;
            radioButtonQ5O3.Checked = false;
            radioButtonQ5O4.Checked = false;
            radioButtonQ6O1.Checked = false;
            radioButtonQ6O2.Checked = false;
            radioButtonQ6O3.Checked = false;
            radioButtonQ6O4.Checked = false;
            radioButtonQ7O1.Checked = false;
            radioButtonQ7O2.Checked = false;
            radioButtonQ7O3.Checked = false;
            radioButtonQ7O4.Checked = false;
            radioButtonQ8O1.Checked = false;
            radioButtonQ8O2.Checked = false;
            radioButtonQ8O3.Checked = false;
            radioButtonQ8O4.Checked = false;
            radioButtonQ9O1.Checked = false;
            radioButtonQ9O2.Checked = false;
            radioButtonQ9O3.Checked = false;
            radioButtonQ9O4.Checked = false;
            radioButtonQ10O1.Checked = false;
            radioButtonQ10O2.Checked = false;
            radioButtonQ10O3.Checked = false;
            radioButtonQ10O4.Checked = false;

            radioButtonQ1O1.Font = new Font(radioButtonQ1O1.Font, FontStyle.Regular);
            radioButtonQ1O2.Font = new Font(radioButtonQ1O2.Font, FontStyle.Regular);
            radioButtonQ1O3.Font = new Font(radioButtonQ1O3.Font, FontStyle.Regular);
            radioButtonQ1O4.Font = new Font(radioButtonQ1O4.Font, FontStyle.Regular);
            radioButtonQ2O1.Font = new Font(radioButtonQ2O1.Font, FontStyle.Regular);
            radioButtonQ2O2.Font = new Font(radioButtonQ2O2.Font, FontStyle.Regular);
            radioButtonQ2O3.Font = new Font(radioButtonQ2O3.Font, FontStyle.Regular);
            radioButtonQ2O4.Font = new Font(radioButtonQ2O4.Font, FontStyle.Regular);
            radioButtonQ3O1.Font = new Font(radioButtonQ3O1.Font, FontStyle.Regular);
            radioButtonQ3O2.Font = new Font(radioButtonQ3O2.Font, FontStyle.Regular);
            radioButtonQ3O3.Font = new Font(radioButtonQ3O3.Font, FontStyle.Regular);
            radioButtonQ3O4.Font = new Font(radioButtonQ3O4.Font, FontStyle.Regular);
            radioButtonQ4O1.Font = new Font(radioButtonQ4O1.Font, FontStyle.Regular);
            radioButtonQ4O2.Font = new Font(radioButtonQ4O2.Font, FontStyle.Regular);
            radioButtonQ4O3.Font = new Font(radioButtonQ4O3.Font, FontStyle.Regular);
            radioButtonQ4O4.Font = new Font(radioButtonQ4O4.Font, FontStyle.Regular);
            radioButtonQ5O1.Font = new Font(radioButtonQ5O1.Font, FontStyle.Regular);
            radioButtonQ5O2.Font = new Font(radioButtonQ5O2.Font, FontStyle.Regular);
            radioButtonQ5O3.Font = new Font(radioButtonQ5O3.Font, FontStyle.Regular);
            radioButtonQ5O4.Font = new Font(radioButtonQ5O4.Font, FontStyle.Regular);
            radioButtonQ6O1.Font = new Font(radioButtonQ6O1.Font, FontStyle.Regular);
            radioButtonQ6O2.Font = new Font(radioButtonQ6O2.Font, FontStyle.Regular);
            radioButtonQ6O3.Font = new Font(radioButtonQ6O3.Font, FontStyle.Regular);
            radioButtonQ6O4.Font = new Font(radioButtonQ6O4.Font, FontStyle.Regular);
            radioButtonQ7O1.Font = new Font(radioButtonQ7O1.Font, FontStyle.Regular);
            radioButtonQ7O2.Font = new Font(radioButtonQ7O2.Font, FontStyle.Regular);
            radioButtonQ7O3.Font = new Font(radioButtonQ7O3.Font, FontStyle.Regular);
            radioButtonQ7O4.Font = new Font(radioButtonQ7O4.Font, FontStyle.Regular);
            radioButtonQ8O1.Font = new Font(radioButtonQ8O1.Font, FontStyle.Regular);
            radioButtonQ8O2.Font = new Font(radioButtonQ8O2.Font, FontStyle.Regular);
            radioButtonQ8O3.Font = new Font(radioButtonQ8O3.Font, FontStyle.Regular);
            radioButtonQ8O4.Font = new Font(radioButtonQ8O4.Font, FontStyle.Regular);
            radioButtonQ9O1.Font = new Font(radioButtonQ9O1.Font, FontStyle.Regular);
            radioButtonQ9O2.Font = new Font(radioButtonQ9O2.Font, FontStyle.Regular);
            radioButtonQ9O3.Font = new Font(radioButtonQ9O3.Font, FontStyle.Regular);
            radioButtonQ9O4.Font = new Font(radioButtonQ9O4.Font, FontStyle.Regular);
            radioButtonQ10O1.Font = new Font(radioButtonQ10O1.Font, FontStyle.Regular);
            radioButtonQ10O2.Font = new Font(radioButtonQ10O2.Font, FontStyle.Regular);
            radioButtonQ10O3.Font = new Font(radioButtonQ10O3.Font, FontStyle.Regular);
            radioButtonQ10O4.Font = new Font(radioButtonQ10O4.Font, FontStyle.Regular);
        }
    }
}
