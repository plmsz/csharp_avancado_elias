namespace _04_3_Eventos
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
            this.btnVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(115, 107);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(151, 84);
            this.btnVideo.TabIndex = 0;
            this.btnVideo.Text = "Video Encode";
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(355, 326);
            this.Controls.Add(this.btnVideo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.EventoDeClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVideo;
    }
}

