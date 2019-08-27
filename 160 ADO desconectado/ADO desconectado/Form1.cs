using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_desconectado
{
    public partial class Form1 : Form
    {
        private TableHandler tableHandler;
        public Form1()
        {
            InitializeComponent();
            tableHandler = new TableHandler();
            tableHandler.CreateEmployeeTable();
            checkBox1.Checked = tableHandler.IsCreated;
            RefreshGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToIntValue(ID_TXT);
                int age = Convert.ToIntValue(AGE_TXT);
                string name = Convert.ToStringValue(NAME_TXT);
                tableHandler.AddRow(id, name, age);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToIntValue(ID_TXT);
                int age = Convert.ToIntValue(AGE_TXT);
                string name = Convert.ToStringValue(NAME_TXT);
                tableHandler.UpdateRowLinq(id, name, age);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToIntValue(ID_TXT);
                tableHandler.DeleteRowLinq(id);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshGrid()
        {
            DGV_TABLE.DataSource = null;
            DGV_TABLE.DataSource = tableHandler.GetTable();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (tableHandler.ExistsRows)
            {
                int index = DGV_TABLE.CurrentRow.Index;
                tableHandler.DeleteRowIndex(index);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableHandler.ExistsRows)
                {
                    int index = DGV_TABLE.CurrentRow.Index;
                    int age = Convert.ToIntValue(AGE_TXT);
                    string name = Convert.ToStringValue(NAME_TXT);
                    tableHandler.UpdateRowIndex(index, name, age);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tableHandler.ClearRows();
            RefreshGrid();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToStringValue(NAME_FIND_TXT);
                DGV_TABLE.DataSource = null;
                DGV_TABLE.DataSource = tableHandler.FindTable(name);
            }
            catch (Exception ex)
            {
                DGV_TABLE.DataSource = null;
                DGV_TABLE.DataSource = tableHandler.GetTable();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                tableHandler.AddRow(1, "franco", 19);
                tableHandler.AddRow(2, "katia", 19);
                tableHandler.AddRow(3, "pato", 20);
                tableHandler.AddRow(4, "flor", 20);
                tableHandler.AddRow(5, "tomas", 20);
                tableHandler.AddRow(6, "franco", 21);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
