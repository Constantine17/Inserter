using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleGenereteInsert
{
    public class DataBaseClass
    {
        string stringConnection = @"";
        const string formatDate = "dd-MM-yyyy HH:mm:ss";

        public struct Column
        {
            public string name;
            public Type type;
            public string typeInDataBase;
            public bool use;
        }
        public struct Cell
        {
            public string columnName;
            public Type type;
            public object value;
        }

        public struct Table
        {
            public String TableName;
            public List<Column> Columns;
            public List<List<Cell>> Values;
        }

        public Table table;

        public void SetUseColumn(int number, bool use) {
            // изменения значемого типа
            List<Column> list = table.Columns;
            Column structure = list[number];
            structure.use = use;
            list[number] = structure;
        }

        /// <summary>
        /// Создает экземпляр класса с подключением к базе данных
        /// </summary>
        /// <param name="stringConnection"></param>
        public DataBaseClass(string stringConnection)
        {
            this.stringConnection = stringConnection;
            // CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }

        /// <summary>
        /// Читает данные таблицы
        /// </summary>
        /// <param name="TableName"></param>
        public void ReadTable(string TableName)
        {
            Table table = new Table();

            string sqlreqvest = "Select * From [" + TableName + "]";
            using (var Connection = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(sqlreqvest, Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int columCount = reader.FieldCount;
                List<Column> columNames = new List<Column>();
                for (int i = 0; i < columCount; i++)
                {
                    Column column = new Column();
                    column.name = reader.GetName(i);
                    column.type = reader.GetFieldType(i);
                    column.typeInDataBase = reader.GetDataTypeName(i);
                    column.use = true;
                    columNames.Add(column);
                }

                List<List<Cell>> TableValues = new List<List<Cell>>();
                while (reader.Read())
                {
                    List<Cell> Line = new List<Cell>();
                    for (int i = 0; i < columCount; i++)
                    {
                        Cell cell = new Cell();

                        cell.columnName = columNames[i].name;
                        cell.type = columNames[i].type;
                        cell.value = reader[columNames[i].name];
                        Line.Add(cell);
                    }
                    TableValues.Add(Line);
                }

                table.TableName = TableName;
                table.Columns = columNames;
                table.Values = TableValues;
                this.table = table;
            }
        }

        /// <summary>
        /// Возращает лист инсертов
        /// </summary>
        /// <param name="Имя таблицы"></param>
        /// <param name="Сохранять уникальные индификаторы"></param>
        /// <returns></returns>
        public List<string> GetInserts()
        {
            Table table = this.table;
            List<string> Inserts = new List<string>();

            string Begin = "Insert into [" + table.TableName + "] ";
            foreach (var line in table.Values)
            {
                string nameColumns = "";
                string values = "";

                for(int i = 0; i<line.Count;i++)
                {
                    var column = line[i];
                    if (!table.Columns[i].use) continue;
                    try
                    {
                        string value = "";
                        // если значимый
                        if (column.type == typeof(int) || column.type == typeof(double) || column.type == typeof(decimal) || column.type == typeof(float)
                            || column.type == typeof(bool) || column.type == typeof(byte) || column.type == typeof(long) || column.type == typeof(Int16))
                        {
                            object objectValue = Convert.ChangeType(column.value, column.type);
                            value = Convert.ToString(objectValue, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                        }
                        //если строка
                        else
                        {
                            if (column.type == typeof(DateTime))
                                value = "N'" + ((DateTime)column.value).ToString(formatDate) + "'";
                            else
                                value = "'" + column.value + "'";
                        }
                        nameColumns += "["+column.columnName + "], ";
                        values += value + ", ";
                    }
                    catch { }
                }
                if (nameColumns != "" || values != "")
                {
                    nameColumns = nameColumns.Substring(0, nameColumns.Length - 2);
                    values = values.Substring(0, values.Length - 2);
                    string Insert = Begin + "(" + nameColumns + ") values (" + values + ")";
                    Inserts.Add(Insert);
                }

            }

            return Inserts;
        }
    }
}
