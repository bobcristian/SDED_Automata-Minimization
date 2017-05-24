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
    public partial class Tabel : Form
    {
        public void UpdateDataGrid(int col)
        {
            //Columns
            char ev = 'a';
            StatesView.ColumnCount = col;
            for(int i=0;i<col;i++)
            {
                StatesView.Columns[i].Name = ev.ToString();
                ev++;
            }
        }

        public Tabel(int col)
        {
            InitializeComponent();
            UpdateDataGrid(col);
            GenTableButton.Enabled = false;
            NewTableButton.Enabled = false;
            EchivClassesButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int rows = StatesView.RowCount-1;
            int columns = StatesView.ColumnCount;

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("mat.txt", false))
                {
                    file.Write(rows);
                    file.Write(" ");
                    file.WriteLine(columns);

                    for (int i = 0; i < StatesView.RowCount - 1; i++)
                    {
                        for (int j = 0; j < StatesView.ColumnCount; j++)
                        {
                            if (StatesView.Rows[i].Cells[j].Value != null)
                            {
                                file.Write(System.Convert.ToInt16(StatesView.Rows[i].Cells[j].Value.ToString()));
                                file.Write(" ");
                            }
                            else
                            {
                                throw new Exception("Do not leave a blank cell");
                            }
                        }
                        file.WriteLine("");
                    }
                    file.Close();
                }

                System.Diagnostics.Process.Start("Minimiz.exe");
                GenTableButton.Enabled = true;
                NewTableButton.Enabled = true;
                EchivClassesButton.Enabled = true;
                MessageBox.Show("Successful minimization!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StatesView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void Tabel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GenTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("Tabel_Minimizat.txt"))
                {
                    String line = sr.ReadToEnd();
                    TableMin.Text = line;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Minimiz.exe");
        }

        private void EchivClassesButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("Clase_Echivalente.txt"))
                {
                    String line = sr.ReadToEnd();
                    TableMin.Text = line;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("Tabel_Nou.txt"))
                {
                    String line = sr.ReadToEnd();
                    TableMin.Text = line;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
