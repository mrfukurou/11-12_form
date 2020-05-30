using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rezultat_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Nn1.Text);
                int m = Convert.ToInt32(Mm1.Text);
                mas ms = new mas(n, m);
                ms.random_array();
                ms.Output(table);
                if (ms)
                {
                    ms.Scalar = Convert.ToInt32(sclr.Text);
                    ms.Output(table);
                    MessageBox.Show("Матрица квадратная", Convert.ToString(true));
                }
                else { MessageBox.Show("Матрица не квадратная", Convert.ToString(false)); }

                summ_cl.Text = ms.summ(Convert.ToInt32(clm.Text)).ToString();
                ms++.Output(inc);
                ms--.Output(dec);
                nol.Text = Convert.ToString(ms.yong);

                mas ms1 = new mas(n, m);
                ms1.random_array();
                ms1.Output(table2);
                ms1 = ms1 + ms;
                ms1.Output(summa);

                int[,] mas = new int[2, 2];
                ms1 = (mas)mas;
                ms1.random_array();
                ms1.Output(preob);

                int i = Convert.ToInt32(Ii.Text);
                int j = Convert.ToInt32(Jj.Text);
                indx.Text = Convert.ToString(ms[i, j]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nn1.Clear();
            Mm1.Clear();
            Ii.Clear();
            Jj.Clear();
            sclr.Clear();
            clm.Clear();
            summ_cl.Clear();
            nol.Clear();
            indx.Clear();
            table.Columns.Clear();
            table2.Columns.Clear();
            inc.Columns.Clear();
            dec.Columns.Clear();
            preob.Columns.Clear();
            summa.Columns.Clear();
        }
    }
}
