namespace WindowsAppDemos
{
    partial class Form2
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
            this.btnPruebaException = new System.Windows.Forms.Button();
            this.btnSqlException = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaException
            // 
            this.btnPruebaException.Location = new System.Drawing.Point(497, 28);
            this.btnPruebaException.Name = "btnPruebaException";
            this.btnPruebaException.Size = new System.Drawing.Size(215, 23);
            this.btnPruebaException.TabIndex = 0;
            this.btnPruebaException.Text = "Prueba de Exception";
            this.btnPruebaException.UseVisualStyleBackColor = true;
            this.btnPruebaException.Click += new System.EventHandler(this.btnPruebaException_Click);
            // 
            // btnSqlException
            // 
            this.btnSqlException.Location = new System.Drawing.Point(493, 101);
            this.btnSqlException.Name = "btnSqlException";
            this.btnSqlException.Size = new System.Drawing.Size(218, 46);
            this.btnSqlException.TabIndex = 1;
            this.btnSqlException.Text = "Ejemplo SqlException";
            this.btnSqlException.UseVisualStyleBackColor = true;
            this.btnSqlException.Click += new System.EventHandler(this.btnSqlException_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSqlException);
            this.Controls.Add(this.btnPruebaException);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaException;
        private System.Windows.Forms.Button btnSqlException;
        private System.Windows.Forms.Button button1;
    }
}