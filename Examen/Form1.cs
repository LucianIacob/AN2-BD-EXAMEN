using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOrase.Items.Clear();
            
            connection.Open();
            command = new System.Data.SqlClient.SqlCommand("select distinct oras from participanti", connection);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbOrase.Items.Add(reader[0]);
            }
            connection.Close();
            dataAdapter.Fill(dataSet, "participanti");
            
        }

        private void cmbOrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshParticipanti();
        }

        private void refreshParticipanti()
        {
            lstParticipanti.Items.Clear();
            for (int i = 0; i < dataSet.Tables["participanti"].Rows.Count; i++)
            {
                if (dataSet.Tables["participanti"].Rows[i]["oras"].ToString() == cmbOrase.Items[cmbOrase.SelectedIndex].ToString())
                {
                    string line = dataSet.Tables["participanti"].Rows[i]["nume"] + ", distanta: " + dataSet.Tables["participanti"].Rows[i]["distanta"] + " km";
                    lstParticipanti.Items.Add(line);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new System.Data.SqlClient.SqlCommand("update participanti set distanta=distanta+200 where distanta<100 AND (dataIntoarcerii>'2015-03-30 00:00:00.000' or dataIntoarcerii<'2015-03-01 00:00:00.000')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            for (int i = 0; i < dataSet.Tables["participanti"].Rows.Count; i++)
            {
                string luna = dataSet.Tables["participanti"].Rows[i]["dataIntoarcerii"].ToString().Split('/')[0];
                if (Int32.Parse(dataSet.Tables["participanti"].Rows[i]["distanta"].ToString()) < Int32.Parse("100"))
                {
                    if (luna != "3")
                    {
                        dataSet.Tables["participanti"].Rows[i]["distanta"] = Int32.Parse(dataSet.Tables["participanti"].Rows[i]["distanta"].ToString()) + 200;
                    }
                }
            }
            refreshParticipanti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["participanti"].Columns.Contains("Buget"))
            {
                MessageBox.Show("Coloana exista deja!");
            }
            else
            {
                MessageBox.Show("Coloana va fi adaugata!");
                connection.Open();
                command = new SqlCommand("ALTER TABLE participanti ADD Buget int not null constraint name default 1", connection);
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                command = new SqlCommand("update participanti set Buget=distanta*100 where Buget=1", connection);
                command.ExecuteNonQuery();
                connection.Close();


                dataSet.Tables["participanti"].Columns.Add("Buget", typeof(Int32));
                dataAdapter.Fill(dataSet, "participanti");
            }
        }
    }
}
