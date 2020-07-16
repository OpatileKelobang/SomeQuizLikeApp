using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private String[] country = { "Japan", "South Africa", "United States", "Germany", "Australia", "Italy"};

        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String filename = "Images\\" + country[count] + ".ico";
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
            }
            else
            {
                lblAnswerField.Text = "SORRY, INCORRECT.";
            }
            if(count == (MAX - 1))
            {
                btnSubmit.Enabled = false;
                lblAnswerField.Text += "Done";
            }
            else
            {
                btnSubmit.Enabled = true;
                btnNextFlag.Enabled = true;
            }
        }
    }
}
