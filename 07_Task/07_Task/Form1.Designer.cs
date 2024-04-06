namespace _07_Task
{
    partial class Form1
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
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(117, 245);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(191, 39);
            this.btnBaixar.TabIndex = 0;
            this.btnBaixar.Text = "Fazer Download";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(117, 51);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(191, 188);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(145, 25);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(163, 20);
            this.txtSite.TabIndex = 3;
            this.txtSite.TextChanged += new System.EventHandler(this.txtSite_TextChanged);
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(114, 25);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(25, 13);
            this.labelSite.TabIndex = 4;
            this.labelSite.Text = "Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 296);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBaixar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label labelSite;
    }
}

