using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class HumanPay : Form
    {
        public HumanPay()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            if (textBox1.Text != "")
            {
                string checkeR = textBox1.Text;
                CheckError(checkeR);              
            }       
        }
        void CheckError(string needCheck)
        {
            if (!int.TryParse(needCheck, out int x))
            {
                MessageBox.Show("Неверный ввод");
            }
            else
            {
                Money.PayMoney = float.Parse(textBox1.Text);
                this.Close();
            }
        }
    }
}
