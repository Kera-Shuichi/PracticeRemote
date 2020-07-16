using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int value1 = 0;
                int value2 = 0;

                if(!int.TryParse(tbxValue1.Text, out value1) ||
                   !int.TryParse(tbxValue2.Text, out value2))
                {
                    MessageBox.Show("数値を入力してください。");
                    return;
                }

                if (value2 == 0)
                {
                    MessageBox.Show("0以外の数値を入力してください。");
                    return;
                }

                int result = value1 / value2;
                MessageBox.Show(result.ToString());

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                tbxValue1.Text = string.Empty;
                tbxValue2.Text = string.Empty;
            }
        }
    }
}
