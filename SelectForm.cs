using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleGenereteInsert;
using System.IO;

namespace GeneratorInserts
{
    public partial class SelectForm : Form
    {
        //List<ChackBo>
        List<CheckBox> columeCheckBoxs = new List<CheckBox>();
        DataBaseClass dataBase;

        public SelectForm(DataBaseClass dataBase)
        {

            InitializeComponent();
            this.KeyPreview = true;

            this.dataBase = dataBase;
            int x = 10, y = 50;
            int size = 0;
            int newWidth = 1;
            int i = 0;
            //var sizeWindow = this.Size;
            foreach ( var colume in dataBase.table.Columns)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(x, y);
                checkBox.Name = colume.name;
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 8;
                checkBox.Text = colume.name;
                checkBox.UseVisualStyleBackColor = true;
                checkBox.Checked = true;
                //if (i == 1 || i == 3 || i == 4) checkBox.Checked = false;
                //i++;

                columeCheckBoxs.Add(checkBox);
                this.Controls.Add(checkBox);

                if (size == 15) {
                    size = 0; x += 150; y = 50;
                    newWidth++;
                }
                else { y += 25; size++; }
            }
            Width = newWidth * 150;
            if (Width < 470) Width = 470;
        }

        private void PanelCheckBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveInsert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < columeCheckBoxs.Count; i++)
            {
                var column = dataBase.table.Columns;
                dataBase.SetUseColumn(i, columeCheckBoxs[i].Checked);
            }
            var inserts = dataBase.GetInserts();

            SaveFileDialog directory = new SaveFileDialog();
            directory.Filter = "text file (*.txt)|*.txt";
            directory.FileName = "insetrs.txt";

            if (directory.ShowDialog() == DialogResult.OK)
            {
                var file = File.CreateText(directory.FileName);

                foreach (var insert in inserts)
                {
                    file.WriteLine(insert);
                }
                file.Close();
                file.Dispose();
            }
        }

        private void DeselectAll_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in columeCheckBoxs)
                checkBox.Checked = false;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in columeCheckBoxs)
                checkBox.Checked = true;
        }

        private void SelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SaveInsert.PerformClick(); }
        }
    }
}
