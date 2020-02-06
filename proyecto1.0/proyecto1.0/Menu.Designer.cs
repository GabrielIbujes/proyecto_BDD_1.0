namespace proyecto1._0
{
    partial class Menu
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btn102A = new System.Windows.Forms.Button();
            this.btn104 = new System.Windows.Forms.Button();
            this.btn106 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(122, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(359, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Servicio de Rentas Internas del Ecuador";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn102A
            // 
            this.btn102A.Location = new System.Drawing.Point(61, 103);
            this.btn102A.Name = "btn102A";
            this.btn102A.Size = new System.Drawing.Size(125, 23);
            this.btn102A.TabIndex = 1;
            this.btn102A.Text = "FORMULARIO 102A";
            this.btn102A.UseVisualStyleBackColor = true;
            // 
            // btn104
            // 
            this.btn104.Location = new System.Drawing.Point(228, 103);
            this.btn104.Name = "btn104";
            this.btn104.Size = new System.Drawing.Size(132, 23);
            this.btn104.TabIndex = 2;
            this.btn104.Text = "FORMULARIO 104";
            this.btn104.UseVisualStyleBackColor = true;
            this.btn104.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn106
            // 
            this.btn106.Location = new System.Drawing.Point(397, 103);
            this.btn106.Name = "btn106";
            this.btn106.Size = new System.Drawing.Size(125, 23);
            this.btn106.TabIndex = 3;
            this.btn106.Text = "FOMRULARIO 106";
            this.btn106.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(30, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 241);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn106);
            this.Controls.Add(this.btn104);
            this.Controls.Add(this.btn102A);
            this.Controls.Add(this.lblUser);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btn102A;
        private System.Windows.Forms.Button btn104;
        private System.Windows.Forms.Button btn106;
        private System.Windows.Forms.Button btnSalir;
    }
}