namespace ConversordeTemperatura3F
{
    partial class temp
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
            cbtemp = new ComboBox();
            txttemp = new TextBox();
            button1 = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // cbtemp
            // 
            cbtemp.FormattingEnabled = true;
            cbtemp.Location = new Point(45, 29);
            cbtemp.Name = "cbtemp";
            cbtemp.Size = new Size(185, 23);
            cbtemp.TabIndex = 0;
            cbtemp.SelectedIndexChanged += cbtemp_SelectedIndexChanged;
            // 
            // txttemp
            // 
            txttemp.Location = new Point(236, 29);
            txttemp.Name = "txttemp";
            txttemp.Size = new Size(143, 23);
            txttemp.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(396, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(45, 67);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 30);
            lblresultado.TabIndex = 3;
            // 
            // temp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 109);
            Controls.Add(lblresultado);
            Controls.Add(button1);
            Controls.Add(txttemp);
            Controls.Add(cbtemp);
            Name = "temp";
            Text = "Convertir Temperaturas";
            Load += temp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbtemp;
        private TextBox txttemp;
        private Button button1;
        private Label lblresultado;
    }
}