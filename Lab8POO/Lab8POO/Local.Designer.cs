namespace Lab8POO
{
    partial class Local
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
            this.components = new System.ComponentModel.Container();
            this.NombreLocal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.ComboBox();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreLocal
            // 
            this.NombreLocal.AutoSize = true;
            this.NombreLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLocal.Location = new System.Drawing.Point(8, 11);
            this.NombreLocal.Name = "NombreLocal";
            this.NombreLocal.Size = new System.Drawing.Size(90, 29);
            this.NombreLocal.TabIndex = 1;
            this.NombreLocal.Text = "Local: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Local";
            // 
            // Nombres
            // 
            this.Nombres.FormattingEnabled = true;
            this.Nombres.Location = new System.Drawing.Point(172, 86);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(274, 21);
            this.Nombres.TabIndex = 3;
            // 
            // ShowInfo
            // 
            this.ShowInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInfo.Location = new System.Drawing.Point(176, 130);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(109, 36);
            this.ShowInfo.TabIndex = 4;
            this.ShowInfo.Text = "Mostrar Info";
            this.ShowInfo.UseVisualStyleBackColor = false;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(10, 19);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 16);
            this.Info.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Location = new System.Drawing.Point(36, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 164);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(557, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreLocal);
            this.Name = "Local";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locales";
            this.Load += new System.EventHandler(this.Local_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Nombres;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Info;
    }
}