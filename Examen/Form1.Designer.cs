namespace Examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connection = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.command = new System.Data.SqlClient.SqlCommand();
            this.dataSet = new System.Data.DataSet();
            this.cmbOrase = new System.Windows.Forms.ComboBox();
            this.lstParticipanti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.ConnectionString = "Data Source=(localdb)\\v11.0;Initial Catalog=master;Integrated Security=True";
            this.connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        participanti.*\r\nFROM            participanti";
            this.sqlSelectCommand1.Connection = this.connection;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.connection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@nume", System.Data.SqlDbType.VarChar, 0, "nume"),
            new System.Data.SqlClient.SqlParameter("@dataPlecarii", System.Data.SqlDbType.DateTime, 0, "dataPlecarii"),
            new System.Data.SqlClient.SqlParameter("@dataIntoarcerii", System.Data.SqlDbType.DateTime, 0, "dataIntoarcerii"),
            new System.Data.SqlClient.SqlParameter("@oras", System.Data.SqlDbType.VarChar, 0, "oras"),
            new System.Data.SqlClient.SqlParameter("@distanta", System.Data.SqlDbType.Int, 0, "distanta")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.connection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@nume", System.Data.SqlDbType.VarChar, 0, "nume"),
            new System.Data.SqlClient.SqlParameter("@dataPlecarii", System.Data.SqlDbType.DateTime, 0, "dataPlecarii"),
            new System.Data.SqlClient.SqlParameter("@dataIntoarcerii", System.Data.SqlDbType.DateTime, 0, "dataIntoarcerii"),
            new System.Data.SqlClient.SqlParameter("@oras", System.Data.SqlDbType.VarChar, 0, "oras"),
            new System.Data.SqlClient.SqlParameter("@distanta", System.Data.SqlDbType.Int, 0, "distanta"),
            new System.Data.SqlClient.SqlParameter("@Original_nume", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nume", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dataPlecarii", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataPlecarii", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dataPlecarii", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataPlecarii", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dataIntoarcerii", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataIntoarcerii", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dataIntoarcerii", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataIntoarcerii", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_oras", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "oras", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_oras", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "oras", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_distanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "distanta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_distanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "distanta", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.connection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_nume", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nume", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dataPlecarii", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataPlecarii", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dataPlecarii", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataPlecarii", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dataIntoarcerii", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataIntoarcerii", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dataIntoarcerii", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataIntoarcerii", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_oras", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "oras", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_oras", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "oras", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_distanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "distanta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_distanta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "distanta", System.Data.DataRowVersion.Original, null)});
            // 
            // dataAdapter
            // 
            this.dataAdapter.DeleteCommand = this.sqlDeleteCommand1;
            this.dataAdapter.InsertCommand = this.sqlInsertCommand1;
            this.dataAdapter.SelectCommand = this.sqlSelectCommand1;
            this.dataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "participanti", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("nume", "nume"),
                        new System.Data.Common.DataColumnMapping("dataPlecarii", "dataPlecarii"),
                        new System.Data.Common.DataColumnMapping("dataIntoarcerii", "dataIntoarcerii"),
                        new System.Data.Common.DataColumnMapping("oras", "oras"),
                        new System.Data.Common.DataColumnMapping("distanta", "distanta")})});
            this.dataAdapter.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // command
            // 
            this.command.Connection = this.connection;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // cmbOrase
            // 
            this.cmbOrase.FormattingEnabled = true;
            this.cmbOrase.Location = new System.Drawing.Point(31, 30);
            this.cmbOrase.Name = "cmbOrase";
            this.cmbOrase.Size = new System.Drawing.Size(172, 21);
            this.cmbOrase.TabIndex = 0;
            this.cmbOrase.SelectedIndexChanged += new System.EventHandler(this.cmbOrase_SelectedIndexChanged);
            // 
            // lstParticipanti
            // 
            this.lstParticipanti.FormattingEnabled = true;
            this.lstParticipanti.Location = new System.Drawing.Point(31, 66);
            this.lstParticipanti.Name = "lstParticipanti";
            this.lstParticipanti.Size = new System.Drawing.Size(172, 108);
            this.lstParticipanti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectati orasul:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adauga 200 km la persoanele care \r\nparcurg mai putin de 100 km \r\nsi nu se intorc " +
    "in luna martie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Verifica coloana buget";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstParticipanti);
            this.Controls.Add(this.cmbOrase);
            this.Name = "Form1";
            this.Text = "ZIUA IZABELLEI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        private System.Data.SqlClient.SqlCommand command;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.ComboBox cmbOrase;
        private System.Windows.Forms.ListBox lstParticipanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

