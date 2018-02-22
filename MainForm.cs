using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ConsoleGenereteInsert;

namespace GeneratorInserts
{
    public partial class MainForm : Form
    {
        string directoryFile = "";
        string stringConnection = "";

        public MainForm()
        {
            InitializeComponent();

            string directoryStringConnection = Directory.GetCurrentDirectory() + "\\StringConnection";

            if (File.Exists(directoryStringConnection))
                using (var file = File.OpenText(directoryStringConnection))
                {
                    stringConnection = file.ReadToEnd();
                }
            else
                File.Create(directoryStringConnection).Close();

            TextBoxconnectionString.Text = stringConnection;

            directoryFile = directoryStringConnection;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                if (TableName.Text == "") { ErrorLabel.Text = "*Введите таблицу"; return; }
                stringConnection = TextBoxconnectionString.Text;
                if (stringConnection == "") { ErrorLabel.Text = "*Введите строку подключения"; return; }
                var dataBaseObject = new DataBaseClass(stringConnection);
                try { dataBaseObject.ReadTable(TableName.Text); } catch { ErrorLabel.Text = "*Ошибка подключения. Проверте данные"; return; }
                SelectForm window = new SelectForm(dataBaseObject);
                window.ShowDialog();
            }
            catch(Exception ex) { ErrorLabel.Text = ex.ToString(); return; }

            try
            {
                var fileStringConnection = File.CreateText(directoryFile);
                fileStringConnection.WriteLine(stringConnection);
                fileStringConnection.Close();
                fileStringConnection.Dispose();
            }
            catch {  }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.button2.PerformClick(); }
        }

        private void TableName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.button2.PerformClick(); }
        }
    }
}
