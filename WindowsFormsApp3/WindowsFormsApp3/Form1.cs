using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Globalization;
using System.Data.Common;
using System.Linq.Expressions;

namespace WindowsFormsApp3
{
  
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;  Initial Catalog=Buying_cookies; Integrated Security=SSPI");     
        Form2 frm2;
        string nameHuman;
        string lastNameHuman;
        public Form1()
        {            
            InitializeComponent();
            btnsOf();


        }   
        
        void btnsOf()
        {
            btnPay.Enabled = false;
            btnBuy.Enabled = false;
            btnStopSql.Enabled = false;
            btnAddUser.Enabled = false;
            BtnDelete.Enabled = false;
        }

        void btnsOn()
        {
            tbConnectSQL.Enabled = false;
            btnStopSql.Enabled = true;
            btnBuy.Enabled = true;
            btnAddUser.Enabled = true;
            BtnDelete.Enabled = true;

        }
        //Обработка кнопок
       private async void  tbConnectSQL_Click(object sender, EventArgs e)
        {
          await ConnSQl(conn);       
        }
        private async void btnStopSql_Click(object sender, EventArgs e)
        {
            await DisSql(conn);
            btnsOf();
            dataGridView1.Columns.Clear();
        }       
        //Для присоединения
        void ConnectoR(SqlConnection conn)
        {          
            try
            {                
               conn.OpenAsync();
                label1.Text = "Подключение";
               Thread.Sleep(3000);
                if (conn != null)
                {
                    label1.Text = "Подключено успешно";
                }
               ShowateDBsql(conn);
               btnsOn();
               this.Invoke((MethodInvoker)delegate{dataGridView1.ScrollBars = ScrollBars.Vertical;});               
            }
            catch
            {
                if (conn == null)
                    label1.Text = "connect faild";
            }
        }             
        void DissconnectSql(SqlConnection conn)
        {                                    
            if (conn.State == ConnectionState.Open) {
                conn.Close();
                if (conn != null)
                    //  label1.Text = "connect success";
                    tbConnectSQL.Enabled = true;
                label1.Text = "Отсоединено";
            }
                                    
        }               
        async Task ConnSQl(SqlConnection conn)
        {
           await Task.Run(() => ConnectoR(conn));         
        }    
        async Task DisSql(SqlConnection conn)
        {
          await Task.Run(() => DissconnectSql(conn));
        }     
        void ShowateDBsql(SqlConnection conn)
        {           
            string sql = "select* from About_Duty";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);       
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;         
        }
        //Вызов формы для покупки
        private void btnBuy_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.ShowDialog();
            string sqlExpressin = "SELECT COUNT(*) FROM dbo.About_Duty";
            SqlCommand command = new SqlCommand(sqlExpressin, conn);
            object count = command.ExecuteScalar();          
            float sumMoney= Money.MoneyText/Convert.ToInt32(count);
            float res = ((float)((float)sumMoney - (int)(sumMoney))*100);
                               
            string sql = ($"UPDATE dbo.About_Duty SET Duty = Duty + {Math.Round(sumMoney)}.{Convert.ToInt32(res)}");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);             
            DataSet ds = new DataSet();
            adapter.Fill(ds);
          
            string sql1 = "select* from About_Duty";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds2 = new DataSet();
            da.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddHuman hD = new FormAddHuman();
            hD.ShowDialog();
            string Name = Human.FirstName.ToString();
            string LastName = Human.LastName.ToString();
            string sqlQuery = $"INSERT INTO dbo.About_Duty VALUES (N'{(Name)}', N'{LastName}', 0);";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            string sql1 = "select* from About_Duty";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds2 = new DataSet();
            da.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }

           
        private void button1_Click(object sender, EventArgs e)
        {
            if (Money.MoneyText != 0)
            {
                MessageBox.Show($"{ Money.MoneyText}");
            }         
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            HumanPay hP = new HumanPay();
            hP.ShowDialog();
            float MoneyPay = Money.PayMoney;
            string sql = ($"UPDATE  dbo.About_Duty SET Duty = Duty - {Math.Round(MoneyPay)}" +
                $" WHERE FirstNameUser=N'{nameHuman}' AND LastNameUser=N'{lastNameHuman}'"); 
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            string sql1 = "select* from About_Duty";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds2 = new DataSet();
            da.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 1; i < dataGridView1.ColumnCount - 1; i++)
            {
                sb.Append(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value + " ");
                if (i == 1)
                {
                    nameHuman = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value);
                }
                if (i == 2)
                {
                   lastNameHuman = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value);
                }
            }
            if (sb.ToString() != "")
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }
            //MessageBox.Show(sb.ToString());      
            //MessageBox.Show($"{nameHuman}");
            //MessageBox.Show($"{lastNameHuman}");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string sql = ($"DELETE FROM dbo.About_Duty WHERE FirstNameUser=N'{nameHuman}' AND LastNameUser=N'{lastNameHuman}'");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            string sql1 = "select* from About_Duty";
            SqlDataAdapter da = new SqlDataAdapter(sql1, conn);
            DataSet ds2 = new DataSet();
            da.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }
    }
}
