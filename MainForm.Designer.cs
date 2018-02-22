namespace GeneratorInserts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableName = new System.Windows.Forms.TextBox();
            this.TextBoxconnectionString = new System.Windows.Forms.TextBox();
            this.TextTable = new System.Windows.Forms.Label();
            this.LabelConnectionString = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(83, 41);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(153, 20);
            this.TableName.TabIndex = 0;
            this.TableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TableName_KeyDown);
            // 
            // TextBoxconnectionString
            // 
            this.TextBoxconnectionString.Location = new System.Drawing.Point(12, 97);
            this.TextBoxconnectionString.Name = "TextBoxconnectionString";
            this.TextBoxconnectionString.Size = new System.Drawing.Size(224, 20);
            this.TextBoxconnectionString.TabIndex = 1;
            // 
            // TextTable
            // 
            this.TextTable.AutoSize = true;
            this.TextTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTable.Location = new System.Drawing.Point(12, 41);
            this.TextTable.Name = "TextTable";
            this.TextTable.Size = new System.Drawing.Size(68, 16);
            this.TextTable.TabIndex = 2;
            this.TextTable.Text = "Таблица:";
            // 
            // LabelConnectionString
            // 
            this.LabelConnectionString.AutoSize = true;
            this.LabelConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelConnectionString.Location = new System.Drawing.Point(9, 78);
            this.LabelConnectionString.Name = "LabelConnectionString";
            this.LabelConnectionString.Size = new System.Drawing.Size(149, 16);
            this.LabelConnectionString.TabIndex = 3;
            this.LabelConnectionString.Text = "Строка подключения:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 9);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Генерация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 188);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.LabelConnectionString);
            this.Controls.Add(this.TextTable);
            this.Controls.Add(this.TextBoxconnectionString);
            this.Controls.Add(this.TableName);
            this.Name = "MainForm";
            this.Text = "Inserter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.TextBox TextBoxconnectionString;
        private System.Windows.Forms.Label TextTable;
        private System.Windows.Forms.Label LabelConnectionString;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button button2;
    }
}

