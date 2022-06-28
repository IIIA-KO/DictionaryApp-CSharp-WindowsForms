namespace Dictionaries
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateDictionaryButton = new System.Windows.Forms.Button();
            this.EditTranslationButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportDictButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteTranslationButton = new System.Windows.Forms.Button();
            this.DeleteWordButton = new System.Windows.Forms.Button();
            this.AddTranslationButton = new System.Windows.Forms.Button();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.EditWordButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDictionaryButton
            // 
            this.CreateDictionaryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateDictionaryButton.FlatAppearance.BorderSize = 3;
            this.CreateDictionaryButton.Location = new System.Drawing.Point(12, 107);
            this.CreateDictionaryButton.Name = "CreateDictionaryButton";
            this.CreateDictionaryButton.Size = new System.Drawing.Size(240, 30);
            this.CreateDictionaryButton.TabIndex = 0;
            this.CreateDictionaryButton.Text = "Create Dictionary";
            this.CreateDictionaryButton.UseVisualStyleBackColor = false;
            this.CreateDictionaryButton.Click += new System.EventHandler(this.CreateDictionaryButton_Click);
            // 
            // EditTranslationButton
            // 
            this.EditTranslationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.EditTranslationButton.FlatAppearance.BorderSize = 3;
            this.EditTranslationButton.Location = new System.Drawing.Point(12, 323);
            this.EditTranslationButton.Name = "EditTranslationButton";
            this.EditTranslationButton.Size = new System.Drawing.Size(240, 30);
            this.EditTranslationButton.TabIndex = 2;
            this.EditTranslationButton.Text = "Edit Translation In Dictionary";
            this.EditTranslationButton.UseVisualStyleBackColor = false;
            this.EditTranslationButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FindButton.FlatAppearance.BorderSize = 3;
            this.FindButton.Location = new System.Drawing.Point(12, 359);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(240, 30);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Find Translation In Dictionary";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExportButton.FlatAppearance.BorderSize = 3;
            this.ExportButton.Location = new System.Drawing.Point(12, 395);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(240, 30);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "Export Translation";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Olivers Barney", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExportDictButton);
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.DeleteTranslationButton);
            this.panel1.Controls.Add(this.DeleteWordButton);
            this.panel1.Controls.Add(this.AddTranslationButton);
            this.panel1.Controls.Add(this.AddWordButton);
            this.panel1.Controls.Add(this.EditWordButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EditTranslationButton);
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.CreateDictionaryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 511);
            this.panel1.TabIndex = 8;
            // 
            // ExportDictButton
            // 
            this.ExportDictButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExportDictButton.FlatAppearance.BorderSize = 3;
            this.ExportDictButton.Location = new System.Drawing.Point(12, 431);
            this.ExportDictButton.Name = "ExportDictButton";
            this.ExportDictButton.Size = new System.Drawing.Size(240, 30);
            this.ExportDictButton.TabIndex = 14;
            this.ExportDictButton.Text = "Export Dictionary";
            this.ExportDictButton.UseVisualStyleBackColor = false;
            this.ExportDictButton.Click += new System.EventHandler(this.ExportDictButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Gainsboro;
            this.LoadButton.FlatAppearance.BorderSize = 3;
            this.LoadButton.Location = new System.Drawing.Point(12, 71);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(240, 30);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Load Dictionary";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteTranslationButton
            // 
            this.DeleteTranslationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteTranslationButton.FlatAppearance.BorderSize = 3;
            this.DeleteTranslationButton.Location = new System.Drawing.Point(12, 251);
            this.DeleteTranslationButton.Name = "DeleteTranslationButton";
            this.DeleteTranslationButton.Size = new System.Drawing.Size(240, 30);
            this.DeleteTranslationButton.TabIndex = 12;
            this.DeleteTranslationButton.Text = "Delete Translation From Dictionary";
            this.DeleteTranslationButton.UseVisualStyleBackColor = false;
            // 
            // DeleteWordButton
            // 
            this.DeleteWordButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DeleteWordButton.FlatAppearance.BorderSize = 3;
            this.DeleteWordButton.Location = new System.Drawing.Point(12, 215);
            this.DeleteWordButton.Name = "DeleteWordButton";
            this.DeleteWordButton.Size = new System.Drawing.Size(240, 30);
            this.DeleteWordButton.TabIndex = 11;
            this.DeleteWordButton.Text = "Delete Word From Dictionary";
            this.DeleteWordButton.UseVisualStyleBackColor = false;
            // 
            // AddTranslationButton
            // 
            this.AddTranslationButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddTranslationButton.FlatAppearance.BorderSize = 3;
            this.AddTranslationButton.Location = new System.Drawing.Point(12, 179);
            this.AddTranslationButton.Name = "AddTranslationButton";
            this.AddTranslationButton.Size = new System.Drawing.Size(240, 30);
            this.AddTranslationButton.TabIndex = 10;
            this.AddTranslationButton.Text = "Add Translation To Dictionary";
            this.AddTranslationButton.UseVisualStyleBackColor = false;
            this.AddTranslationButton.Click += new System.EventHandler(this.AddTranslationButton_Click);
            // 
            // AddWordButton
            // 
            this.AddWordButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddWordButton.FlatAppearance.BorderSize = 3;
            this.AddWordButton.Location = new System.Drawing.Point(12, 143);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(240, 30);
            this.AddWordButton.TabIndex = 9;
            this.AddWordButton.Text = "Add Word To Dictionary";
            this.AddWordButton.UseVisualStyleBackColor = false;
            this.AddWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // EditWordButton
            // 
            this.EditWordButton.BackColor = System.Drawing.Color.Gainsboro;
            this.EditWordButton.FlatAppearance.BorderSize = 3;
            this.EditWordButton.Location = new System.Drawing.Point(12, 287);
            this.EditWordButton.Name = "EditWordButton";
            this.EditWordButton.Size = new System.Drawing.Size(240, 30);
            this.EditWordButton.TabIndex = 8;
            this.EditWordButton.Text = "Edit Word In Dictioanry";
            this.EditWordButton.UseVisualStyleBackColor = false;
            this.EditWordButton.Click += new System.EventHandler(this.EditWordButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionaries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateDictionaryButton;
        private System.Windows.Forms.Button EditTranslationButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditWordButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button AddTranslationButton;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button DeleteTranslationButton;
        private System.Windows.Forms.Button DeleteWordButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ExportDictButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

