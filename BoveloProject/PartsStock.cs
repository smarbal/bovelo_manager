﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public partial class PartsStock : Form
    {
        string searchCriteria = "reference";
        string partInfo = "";
        List<string> clientParams = new List<string>();
        public PartsStock()
        {
            InitializeComponent();
            DataTable parts = GetData(String.Format("Select * from parts_catalog"));
            dataGridView1.DataSource = parts;

            DataTable bikes = GetData(String.Format("Select * from bike_models_view"));
            dataGridView2.DataSource = bikes;
            this.dataGridView2.Columns[0].Width = 35;
            this.dataGridView2.Columns[1].Width = 150;
            this.dataGridView2.Columns[2].Width = 55;

            string[]  searchCriterions = new string[] { "reference", "name" };
            comboBox1.Items.AddRange(searchCriterions);
        }

        private static DataTable GetData(string sqlCommand)
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
            

            MySqlCommand command = new MySqlCommand(sqlCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newModel = new NewModel();
            newModel.Location = this.Location;
            newModel.StartPosition = FormStartPosition.Manual;
            newModel.FormClosing += delegate {this.Show(); };
            newModel.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    partInfo+=(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += "  ";                  
                    column++;
                }
                label2.Text = partInfo;
            }
            catch{
                label2.Text = "";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From part_stock_view where {0} like '{1}%'", searchCriteria, textBox1.Text));
            datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.SelectedItem.ToString();
        }

        private void dataGridView2CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView2.ColumnCount)
                {
                    partInfo += (dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView2.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += "  ";
                    column++;
                }
                label6.Text = partInfo;
            }
            catch
            {
                label6.Text = "";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From bike_models_view where {0} like '{1}%'", searchCriteria, textBox2.Text));
            datas.Columns.RemoveAt(0);
            dataGridView2.DataSource = datas;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox2.SelectedItem.ToString();
        }
    }
}
