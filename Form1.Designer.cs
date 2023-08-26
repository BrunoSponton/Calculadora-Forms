
namespace Forms_Prueba_3
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(113, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(113, 101);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // txtbA
            // 
            this.txtbA.Location = new System.Drawing.Point(137, 70);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(100, 20);
            this.txtbA.TabIndex = 2;
            this.txtbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(137, 101);
            this.txtbB.Name = "txtbB";
            this.txtbB.Size = new System.Drawing.Size(100, 20);
            this.txtbB.TabIndex = 3;
            this.txtbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(266, 70);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(360, 69);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 5;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(266, 97);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 23);
            this.btnmul.TabIndex = 6;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(360, 96);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 7;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(201, 149);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(35, 13);
            this.lblresul.TabIndex = 8;
            this.lblresul.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.Label label1;
    }
}

