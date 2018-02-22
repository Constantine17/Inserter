namespace GeneratorInserts
{
    partial class SelectForm
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
            this.SelectAll = new System.Windows.Forms.Button();
            this.DeselectAll = new System.Windows.Forms.Button();
            this.SaveInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(210, 12);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(112, 23);
            this.SelectAll.TabIndex = 0;
            this.SelectAll.Text = "Выделить все";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // DeselectAll
            // 
            this.DeselectAll.Location = new System.Drawing.Point(328, 12);
            this.DeselectAll.Name = "DeselectAll";
            this.DeselectAll.Size = new System.Drawing.Size(112, 23);
            this.DeselectAll.TabIndex = 1;
            this.DeselectAll.Text = "Снять выделения";
            this.DeselectAll.UseVisualStyleBackColor = true;
            this.DeselectAll.Click += new System.EventHandler(this.DeselectAll_Click);
            // 
            // SaveInsert
            // 
            this.SaveInsert.Location = new System.Drawing.Point(12, 12);
            this.SaveInsert.Name = "SaveInsert";
            this.SaveInsert.Size = new System.Drawing.Size(155, 23);
            this.SaveInsert.TabIndex = 2;
            this.SaveInsert.Text = "Сохранить инсерты в файл";
            this.SaveInsert.UseVisualStyleBackColor = true;
            this.SaveInsert.Click += new System.EventHandler(this.SaveInsert_Click);
            this.SaveInsert.Enter += new System.EventHandler(this.SaveInsert_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 456);
            this.Controls.Add(this.SaveInsert);
            this.Controls.Add(this.DeselectAll);
            this.Controls.Add(this.SelectAll);
            this.Name = "SelectForm";
            this.Text = "Выбор колонок";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button DeselectAll;
        private System.Windows.Forms.Button SaveInsert;
    }
}