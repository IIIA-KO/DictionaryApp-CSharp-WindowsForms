namespace Dictionaries
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DictionariesComboBox = new System.Windows.Forms.ComboBox();
            this.WordLabel = new System.Windows.Forms.Label();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.TranslationTextBox = new System.Windows.Forms.TextBox();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(192, 17);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Find Translation In Dictionary";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(12, 70);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(343, 29);
            this.TypeLabel.TabIndex = 15;
            this.TypeLabel.Text = "Choose the name of dictionary:";
            // 
            // DictionariesComboBox
            // 
            this.DictionariesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DictionariesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionariesComboBox.FormattingEnabled = true;
            this.DictionariesComboBox.Location = new System.Drawing.Point(16, 111);
            this.DictionariesComboBox.Name = "DictionariesComboBox";
            this.DictionariesComboBox.Size = new System.Drawing.Size(405, 37);
            this.DictionariesComboBox.TabIndex = 14;
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(448, 70);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(140, 29);
            this.WordLabel.TabIndex = 17;
            this.WordLabel.Text = "Enter Word:";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextBox.Location = new System.Drawing.Point(453, 113);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WordTextBox.Size = new System.Drawing.Size(425, 35);
            this.WordTextBox.TabIndex = 16;
            // 
            // TranslationTextBox
            // 
            this.TranslationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationTextBox.Location = new System.Drawing.Point(16, 224);
            this.TranslationTextBox.Multiline = true;
            this.TranslationTextBox.Name = "TranslationTextBox";
            this.TranslationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TranslationTextBox.Size = new System.Drawing.Size(862, 171);
            this.TranslationTextBox.TabIndex = 18;
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.AutoSize = true;
            this.TranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationLabel.Location = new System.Drawing.Point(12, 192);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(213, 29);
            this.TranslationLabel.TabIndex = 19;
            this.TranslationLabel.Text = "Translation Result:";
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(342, 454);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(177, 39);
            this.FindButton.TabIndex = 20;
            this.FindButton.Text = "Translate";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.FindButton);
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
            this.Name = "FindForm";
            this.Text = "Find Translation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox DictionariesComboBox;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.TextBox TranslationTextBox;
        private System.Windows.Forms.Label TranslationLabel;
        private System.Windows.Forms.Button FindButton;
    }
}