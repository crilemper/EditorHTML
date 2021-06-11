namespace Editor
{
    partial class Reemplazar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reemplazar));
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPalabraBuscar = new System.Windows.Forms.TextBox();
            this.textBoxPalabraReemplazar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(82, 124);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(175, 30);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "OK";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reemplazar:";
            // 
            // textBoxPalabraBuscar
            // 
            this.textBoxPalabraBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPalabraBuscar.Location = new System.Drawing.Point(149, 28);
            this.textBoxPalabraBuscar.Name = "textBoxPalabraBuscar";
            this.textBoxPalabraBuscar.Size = new System.Drawing.Size(150, 16);
            this.textBoxPalabraBuscar.TabIndex = 0;
            this.textBoxPalabraBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPalabraReemplazar
            // 
            this.textBoxPalabraReemplazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPalabraReemplazar.Location = new System.Drawing.Point(149, 86);
            this.textBoxPalabraReemplazar.Name = "textBoxPalabraReemplazar";
            this.textBoxPalabraReemplazar.Size = new System.Drawing.Size(150, 16);
            this.textBoxPalabraReemplazar.TabIndex = 1;
            this.textBoxPalabraReemplazar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Reemplazar
            // 
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(350, 166);
            this.Controls.Add(this.textBoxPalabraReemplazar);
            this.Controls.Add(this.textBoxPalabraBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAceptar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reemplazar";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REEMPLAZAR";
            this.Load += new System.EventHandler(this.Form3Reemplazar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPalabraBuscar;
        private System.Windows.Forms.TextBox textBoxPalabraReemplazar;
    }
}