namespace Dictionaries
{
    partial class AddWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWordForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.DictionariesComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.WordLabel = new System.Windows.Forms.Label();
            this.TranslationTextBox = new System.Windows.Forms.TextBox();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(172, 17);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Add A Word To Dictionary";
            // 
            // DictionariesComboBox
            // 
            this.DictionariesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DictionariesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionariesComboBox.FormattingEnabled = true;
            this.DictionariesComboBox.Location = new System.Drawing.Point(15, 83);
            this.DictionariesComboBox.Name = "DictionariesComboBox";
            this.DictionariesComboBox.Size = new System.Drawing.Size(405, 37);
            this.DictionariesComboBox.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(10, 54);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(313, 26);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Choose the name of dictionary:";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextBox.Location = new System.Drawing.Point(458, 85);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WordTextBox.Size = new System.Drawing.Size(425, 35);
            this.WordTextBox.TabIndex = 7;
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(453, 54);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(128, 26);
            this.WordLabel.TabIndex = 8;
            this.WordLabel.Text = "Enter Word:";
            // 
            // TranslationTextBox
            // 
            this.TranslationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationTextBox.Location = new System.Drawing.Point(458, 191);
            this.TranslationTextBox.Name = "TranslationTextBox";
            this.TranslationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TranslationTextBox.Size = new System.Drawing.Size(425, 35);
            this.TranslationTextBox.TabIndex = 9;
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.AutoSize = true;
            this.TranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationLabel.Location = new System.Drawing.Point(453, 162);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(182, 26);
            this.TranslationLabel.TabIndex = 10;
            this.TranslationLabel.Text = "Enter Translation:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(458, 454);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(177, 39);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add word";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TranslationLabel);
            this.Controls.Add(this.TranslationTextBox);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DictionariesComboBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Add a Word To Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox DictionariesComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox TranslationTextBox;
        private System.Windows.Forms.Label TranslationLabel;
        private System.Windows.Forms.Button AddButton;
    }
}