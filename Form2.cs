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
    public partial class Form2 : Form
    {       
        public Form2()
        {           
            InitializeComponent();          
        }        
        private void button1_Click_1(object sender, EventArgs e)
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
                Money.MoneyText = float.Parse(textBox1.Text);
                this.Close();
            }
        }
    }
}
