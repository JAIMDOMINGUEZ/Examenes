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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcular_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moneda_lbl
            // 
            this.moneda_lbl.AutoSize = true;
            this.moneda_lbl.Location = new System.Drawing.Point(13, 19);
            this.moneda_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneda_lbl.Name = "moneda_lbl";
            this.moneda_lbl.Size = new System.Drawing.Size(46, 13);
            this.moneda_lbl.TabIndex = 0;
            this.moneda_lbl.Text = "Moneda";
            this.moneda_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // monto_lbl
            // 
            this.monto_lbl.AutoSize = true;
            this.monto_lbl.Location = new System.Drawing.Point(190, 19);
            this.monto_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monto_lbl.Name = "monto_lbl";
            this.monto_lbl.Size = new System.Drawing.Size(37, 13);
            this.monto_lbl.TabIndex = 1;
            this.monto_lbl.Text = "Monto";
            // 
            // Moneda_comboBox
            // 
            this.Moneda_comboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Moneda_comboBox.FormattingEnabled = true;
            this.Moneda_comboBox.Location = new System.Drawing.Point(16, 34);
            this.Moneda_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Moneda_comboBox.Name = "Moneda_comboBox";
            this.Moneda_comboBox.Size = new System.Drawing.Size(141, 21);
            this.Moneda_comboBox.TabIndex = 2;
            this.Moneda_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // monto_textBox
            // 
            this.monto_textBox.Location = new System.Drawing.Point(184, 34);
            this.monto_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monto_textBox.Name = "monto_textBox";
            this.monto_textBox.Size = new System.Drawing.Size(79, 20);
            this.monto_textBox.TabIndex = 3;
            this.monto_textBox.TextChanged += new System.EventHandler(this.monto_textBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(287, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversiones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // calcular_btn
            // 
            this.calcular_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcular_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calcular_btn.Location = new System.Drawing.Point(184, 69);
            this.calcular_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcular_btn.Name = "calcular_btn";
            this.calcular_btn.Size = new System.Drawing.Size(77, 23);
            this.calcular_btn.TabIndex = 5;
            this.calcular_btn.Text = "Calcular";
            this.calcular_btn.UseVisualStyleBackColor = false;
            this.calcular_btn.Click += new System.EventHandler(this.calcular_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.Controls.Add(this.calcular_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monto_textBox);
            this.Controls.Add(this.Moneda_comboBox);
            this.Controls.Add(this.monto_lbl);
            this.Controls.Add(this.moneda_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calcular_btn;
    }
}

