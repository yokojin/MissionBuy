
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbConnectSQL = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopSql = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConnectSQL
            // 
            this.tbConnectSQL.Location = new System.Drawing.Point(12, 3);
            this.tbConnectSQL.Name = "tbConnectSQL";
            this.tbConnectSQL.Size = new System.Drawing.Size(127, 22);
            this.tbConnectSQL.TabIndex = 0;
            this.tbConnectSQL.Text = "Подключение SQL";
            this.tbConnectSQL.UseVisualStyleBackColor = true;
            this.tbConnectSQL.Click += new System.EventHandler(this.tbConnectSQL_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(347, 121);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(127, 42);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Добавить Сотрудника";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(347, 31);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(127, 39);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Добавить покупку";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 33;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(329, 179);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Состояние подключения";
            // 
            // btnStopSql
            // 
            this.btnStopSql.Location = new System.Drawing.Point(160, 3);
            this.btnStopSql.Name = "btnStopSql";
            this.btnStopSql.Size = new System.Drawing.Size(127, 22);
            this.btnStopSql.TabIndex = 6;
            this.btnStopSql.Text = "Отключение SQL";
            this.btnStopSql.UseVisualStyleBackColor = true;
            this.btnStopSql.Click += new System.EventHandler(this.btnStopSql_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(347, 76);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(127, 39);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Платёж  Сотрудника";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Покупка делится на всех.        Каждый сотрудник вносит платёж за себя";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(347, 169);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(126, 41);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Удалить сотрудника";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 259);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnStopSql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbConnectSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbConnectSQL;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopSql;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
    }
}

