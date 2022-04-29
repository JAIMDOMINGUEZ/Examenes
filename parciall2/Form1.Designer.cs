namespace parciall2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.moneda_lbl = new System.Windows.Forms.Label();
            this.monto_lbl = new System.Windows.Forms.Label();
            this.Moneda_comboBox = new System.Windows.Forms.ComboBox();
            this.monto_textBox = new System.Windows.Forms.TextBox();
            this.calcular_btn = new System.Windows.Forms.Button();
            this.Conversiones_grp = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // moneda_lbl
            // 
            this.moneda_lbl.AutoSize = true;
            this.moneda_lbl.Location = new System.Drawing.Point(20, 29);
            this.moneda_lbl.Name = "moneda_lbl";
            this.moneda_lbl.Size = new System.Drawing.Size(67, 20);
            this.moneda_lbl.TabIndex = 0;
            this.moneda_lbl.Text = "Moneda";
            this.moneda_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // monto_lbl
            // 
            this.monto_lbl.AutoSize = true;
            this.monto_lbl.Location = new System.Drawing.Point(285, 29);
            this.monto_lbl.Name = "monto_lbl";
            this.monto_lbl.Size = new System.Drawing.Size(54, 20);
            this.monto_lbl.TabIndex = 1;
            this.monto_lbl.Text = "Monto";
            // 
            // Moneda_comboBox
            // 
            this.Moneda_comboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Moneda_comboBox.FormattingEnabled = true;
            this.Moneda_comboBox.Location = new System.Drawing.Point(24, 52);
            this.Moneda_comboBox.Name = "Moneda_comboBox";
            this.Moneda_comboBox.Size = new System.Drawing.Size(210, 28);
            this.Moneda_comboBox.TabIndex = 2;
            this.Moneda_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // monto_textBox
            // 
            this.monto_textBox.Location = new System.Drawing.Point(276, 52);
            this.monto_textBox.Name = "monto_textBox";
            this.monto_textBox.Size = new System.Drawing.Size(116, 26);
            this.monto_textBox.TabIndex = 3;
            this.monto_textBox.TextChanged += new System.EventHandler(this.monto_textBox_TextChanged);
            // 
            // calcular_btn
            // 
            this.calcular_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcular_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calcular_btn.Location = new System.Drawing.Point(276, 106);
            this.calcular_btn.Name = "calcular_btn";
            this.calcular_btn.Size = new System.Drawing.Size(116, 35);
            this.calcular_btn.TabIndex = 5;
            this.calcular_btn.Text = "Calcular";
            this.calcular_btn.UseVisualStyleBackColor = false;
            this.calcular_btn.Click += new System.EventHandler(this.calcular_btn_Click);
            // 
            // Conversiones_grp
            // 
            this.Conversiones_grp.Location = new System.Drawing.Point(24, 169);
            this.Conversiones_grp.Name = "Conversiones_grp";
            this.Conversiones_grp.Size = new System.Drawing.Size(426, 240);
            this.Conversiones_grp.TabIndex = 6;
            this.Conversiones_grp.TabStop = false;
            this.Conversiones_grp.Text = "Conversiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(478, 445);
            this.Controls.Add(this.Conversiones_grp);
            this.Controls.Add(this.calcular_btn);
            this.Controls.Add(this.monto_textBox);
            this.Controls.Add(this.Moneda_comboBox);
            this.Controls.Add(this.monto_lbl);
            this.Controls.Add(this.moneda_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneda_lbl;
        private System.Windows.Forms.Label monto_lbl;
        private System.Windows.Forms.ComboBox Moneda_comboBox;
        private System.Windows.Forms.TextBox monto_textBox;
        private System.Windows.Forms.Button calcular_btn;
        private System.Windows.Forms.GroupBox Conversiones_grp;
    }
}

