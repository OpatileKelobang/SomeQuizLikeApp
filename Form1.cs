using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SomeQuizLikeApp
{
    public partial class Form1 : Form
    {
        private const int MAX = 6;
        //private String[] country = { "Japan", "South Africa", "United States", "Germany", "Australia", "Italy"};
        string fileName = @"Files\\countries.txt";
        private string[] country = File.ReadLines(@"Files\\countries.txt").ToArray();
        private int score = 0;


        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            // Debug Write to array from File
            Console.WriteLine(country[0]);
            #region WriteToFile
            /*using (StreamWriter Writer = File.AppendText("Files\\countries.txt"))
            {

                for (int x = 0; x < country.Length; x++)
                {
                    string countryName = country[x];
                    Writer.WriteLine(countryName);
                }
                Writer.Close();
            }*/
            #endregion WriteToFile
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "Images\\" + country[count] + ".ico";
            pictureBoxFlag.Image = Image.FromFile(filename);
            btnNextFlag.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String answer = comboBoxCountrySelect.SelectedItem.ToString();
            String correctAnswer = country[count];
            if(answer.Equals(correctAnswer))
            {
                lblAnswerField.Text = "CORRECT";
                score++;
            }
            else
            {
                lblAnswerField.Text = "SORRY, INCORRECT.";
            }
            if(count == (MAX - 1))
            {
                btnSubmit.Enabled = false;
                lblAnswerField.Text += "\nDone";
                String message = "You got " + score + " out of 6 correct";
                MessageBox.Show(message, "Score");
            }
            else
            {
                btnSubmit.Enabled = true;
                btnNextFlag.Enabled = true;
            }
        }

        private void btnNextFlag_Click(object sender, EventArgs e)
        {
            count++;
            String filename = "Images\\" + country[count] + ".ico";
            pictureBoxFlag.Image = Image.FromFile(filename);
            btnNextFlag.Enabled = false;
            btnSubmit.Enabled = true;
            lblAnswerField.Text = "";
        }
    }
}
