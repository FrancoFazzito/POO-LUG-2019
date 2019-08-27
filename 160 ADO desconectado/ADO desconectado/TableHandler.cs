using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ADO_desconectado
{
    public class TableHandler
    {
        private DataTable table;

        private const string COLUMN_NAME = "Name";
        private const string COLUMN_ID = "Id";
        private const string COLUMN_AGE = "Age";
        private const string TABLE_NAME = "Employee";

        private bool isCreated;
        public bool IsCreated { get => isCreated; }
        public bool ExistsRows
        {
            get
            {
                return table.Rows.Count > 0;
            }
        }
        public void CreateEmployeeTable()
        {
            table = new DataTable(TABLE_NAME);

            DataColumn idColumn = new DataColumn(COLUMN_ID, typeof(int));
            DataColumn nameColumn = new DataColumn(COLUMN_NAME, typeof(string));
            DataColumn ageColumn = new DataColumn(COLUMN_AGE, typeof(int));

            table.Columns.Add(idColumn);
            table.Columns.Add(nameColumn);
            table.Columns.Add(ageColumn);

            table.PrimaryKey = new DataColumn[] { idColumn };
            isCreated = true;
        }

        public void AddRow(int id, string name, int age)
        {
            if (!ExistId(id))
            {
                DataRow rowEmployee = table.NewRow();
                rowEmployee[0] = id;
                rowEmployee[1] = name;
                rowEmployee[2] = age;
                table.Rows.Add(rowEmployee);
            }
            else
            {
                throw new Exception("ID EXISTENTE");
            }
        }

        public bool ExistId(int id)
        {
            return table.Select().ToList().Exists(row => row.Field<int>(COLUMN_ID) == id);
        }

        public void DeleteRowIndex(int index)
        {
            table.Rows.Remove(table.Rows[index]);
        }

        public void DeleteRowLinq(int id)
        {
            DataRow removeRow = table.Select().First(row => row.Field<int>(COLUMN_ID) == id);
            table.Rows.Remove(removeRow);
        }

        public void UpdateRowIndex(int index, string name, int age)
        {
            //se puede tomar id en base al index
            DataRow updateRow = table.Rows[index];
            updateRow[1] = name;
            updateRow[2] = age;

        }

        public void UpdateRowLinq(int id, string name, int age)
        {
            DataRow updateRow = table.Select().First(row => row.Field<int>(COLUMN_ID) == id);
            updateRow[1] = name;
            updateRow[2] = age;
        }

        public DataTable GetTable()
        {
            return this.table;
        }

        public void ClearRows()
        {
            this.table.Clear();
        }

        public DataTable FindTable(string name)
        {

            List<DataRow> rowList = this.table.Select().ToList();

            List<DataRow> rowsFind = rowList.FindAll(row => row.Field<string>(COLUMN_NAME) == name);
            DataTable tableTemp = new DataTable();

            DataColumn idColumn = new DataColumn(COLUMN_ID, typeof(int));
            DataColumn nameColumn = new DataColumn(COLUMN_NAME, typeof(string));
            DataColumn ageColumn = new DataColumn(COLUMN_AGE, typeof(int));

            tableTemp.Columns.Add(idColumn);
            tableTemp.Columns.Add(nameColumn);
            tableTemp.Columns.Add(ageColumn);

            if (rowsFind.Count > 0)
            {

                foreach (DataRow row in rowsFind)
                {
                    DataRow rowEmployee = tableTemp.NewRow();
                    rowEmployee[0] = row[0];
                    rowEmployee[1] = row[1];
                    rowEmployee[2] = row[2];
                    tableTemp.Rows.Add(rowEmployee);
                }
                return tableTemp;
            }
            else
            {
                throw new Exception("NO EXISTE EL NOMBRE BUSCADO");
            }
        }
    }

}

