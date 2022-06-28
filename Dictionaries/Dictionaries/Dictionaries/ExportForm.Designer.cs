namespace Dictionaries
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.WordLabel = new System.Windows.Forms.Label();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DictionariesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 17);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Export Translation";
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.Location = new System.Drawing.Point(347, 454);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(177, 39);
            this.ExportButton.TabIndex = 23;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(446, 130);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(140, 29);
            this.WordLabel.TabIndex = 27;
            this.WordLabel.Text = "Enter Word:";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextBox.Location = new System.Drawing.Point(451, 173);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WordTextBox.Size = new System.Drawing.Size(425, 35);
            this.WordTextBox.TabIndex = 26;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(10, 130);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(343, 29);
            this.TypeLabel.TabIndex = 25;
            this.TypeLabel.Text = "Choose the name of dictionary:";
            // 
            // DictionariesComboBox
            // 
            this.DictionariesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DictionariesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionariesComboBox.FormattingEnabled = true;
            this.DictionariesComboBox.Location = new System.Drawing.Point(14, 171);
            this.DictionariesComboBox.Name = "DictionariesComboBox";
            this.DictionariesComboBox.Size = new System.Drawing.Size(405, 37);
            this.DictionariesComboBox.TabIndex = 24;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DictionariesComboBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.Text = "Export Translation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox DictionariesComboBox;
    }
}