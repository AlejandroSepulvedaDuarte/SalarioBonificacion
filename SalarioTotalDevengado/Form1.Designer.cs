namespace SalarioTotalDevengado
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcularS = new System.Windows.Forms.Button();
            this.lblSalariob = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValorSF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblant = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARIO TOTAL DEVENGADO";
            // 
            // btncalcularS
            // 
            this.btncalcularS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncalcularS.Location = new System.Drawing.Point(384, 102);
            this.btncalcularS.Name = "btncalcularS";
            this.btncalcularS.Size = new System.Drawing.Size(137, 34);
            this.btncalcularS.TabIndex = 4;
            this.btncalcularS.Text = "Calcular Salario";
            this.btncalcularS.UseVisualStyleBackColor = true;
            this.btncalcularS.Click += new System.EventHandler(this.btncalcularS_Click);
            // 
            // lblSalariob
            // 
            this.lblSalariob.AutoSize = true;
            this.lblSalariob.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSalariob.Location = new System.Drawing.Point(240, 152);
            this.lblSalariob.Name = "lblSalariob";
            this.lblSalariob.Size = new System.Drawing.Size(95, 18);
            this.lblSalariob.TabIndex = 14;
            this.lblSalariob.Text = "SalarioBase";
            this.lblSalariob.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(113, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Neto A Pagar:";
            // 
            // lblValorSF
            // 
            this.lblValorSF.AutoSize = true;
            this.lblValorSF.Font = new System.Drawing.Font("Arial", 12F);
            this.lblValorSF.Location = new System.Drawing.Point(240, 261);
            this.lblValorSF.Name = "lblValorSF";
            this.lblValorSF.Size = new System.Drawing.Size(93, 18);
            this.lblValorSF.TabIndex = 22;
            this.lblValorSF.Text = "NetoApagar";
            this.lblValorSF.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Antiguedad del empleado:";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAntiguedad.Location = new System.Drawing.Point(230, 106);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(129, 26);
            this.txtAntiguedad.TabIndex = 24;
            // 
            // lblant
            // 
            this.lblant.AutoSize = true;
            this.lblant.Font = new System.Drawing.Font("Arial", 12F);
            this.lblant.Location = new System.Drawing.Point(240, 201);
            this.lblant.Name = "lblant";
            this.lblant.Size = new System.Drawing.Size(88, 18);
            this.lblant.TabIndex = 25;
            this.lblant.Text = "Antigüedad";
            this.lblant.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(14, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Bonificación Por Antigüedad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(113, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Salario Base:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(541, 102);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(137, 34);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblant);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorSF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSalariob);
            this.Controls.Add(this.btncalcularS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcularS;
        private System.Windows.Forms.Label lblSalariob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValorSF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label lblant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
    }
}

