namespace ConversordeTemperatura3F
{
    partial class masa
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
            cmbMaxUnits = new ComboBox();
            txtmasa = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbMaxUnits
            // 
            cmbMaxUnits.FormattingEnabled = true;
            cmbMaxUnits.Location = new Point(48, 36);
            cmbMaxUnits.Name = "cmbMaxUnits";
            cmbMaxUnits.Size = new Size(177, 23);
            cmbMaxUnits.TabIndex = 0;
            // 
            // txtmasa
            // 
            txtmasa.Location = new Point(241, 36);
            txtmasa.Name = "txtmasa";
            txtmasa.Size = new Size(188, 23);
            txtmasa.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(435, 36);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 2;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // masa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 79);
            Controls.Add(button1);
            Controls.Add(txtmasa);
            Controls.Add(cmbMaxUnits);
            Name = "masa";
            Text = "masa";
            Load += masa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaxUnits;
        private TextBox txtmasa;
        private Button button1;
    }
}