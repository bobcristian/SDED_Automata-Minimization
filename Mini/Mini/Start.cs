using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(colTextBox.Text))
            {
                int outvalue;
                if (int.TryParse(colTextBox.Text,out outvalue))
                {
                    Tabel tab = new Tabel(System.Convert.ToInt16(colTextBox.Text));
                    tab.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The input must be a NUMBER!");
                }
            }
            else
            {
                MessageBox.Show("Set the number of columns!");
            }
        }

        private void Start_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Minimiz.exe");
        }

        private void colTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode==Keys.Return)
            {
                NextButton.PerformClick();
            }
        }
    }
}
