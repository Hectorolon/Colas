namespace Colas
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(93, 58);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciclos que estuvo vacia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Procesos que se \r\nantendieron correctamente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Procesos pendientes";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(152, 104);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(62, 20);
            this.txtCV.TabIndex = 4;
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(152, 142);
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(62, 20);
            this.txtPA.TabIndex = 5;
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(152, 181);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(62, 20);
            this.txtPP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciclos pendientes";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(152, 215);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(62, 20);
            this.txtCP.TabIndex = 8;
            this.txtCP.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtPA);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCP;
    }
}

