namespace PROYECTO_MAESTRO
{
    partial class Form3
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
            this.btnRegresarM = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJugar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresarM
            // 
            this.btnRegresarM.Location = new System.Drawing.Point(676, 393);
            this.btnRegresarM.Name = "btnRegresarM";
            this.btnRegresarM.Size = new System.Drawing.Size(112, 45);
            this.btnRegresarM.TabIndex = 0;
            this.btnRegresarM.Text = "Menú";
            this.btnRegresarM.UseVisualStyleBackColor = true;
            this.btnRegresarM.UseWaitCursor = true;
            this.btnRegresarM.Click += new System.EventHandler(this.btnRegresarM_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuntaje.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntaje.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPuntaje.Location = new System.Drawing.Point(198, 161);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(261, 59);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "PUNTAJE";
            this.lblPuntaje.UseWaitCursor = true;
            this.lblPuntaje.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 48);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEST YOUR KNOWLEDGE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(735, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 49);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(558, 393);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(112, 45);
            this.btnJugar.TabIndex = 15;
            this.btnJugar.Text = "Volver a jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.UseWaitCursor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_MAESTRO.Properties.Resources.Iconos__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnRegresarM);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarM;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJugar;
    }
}