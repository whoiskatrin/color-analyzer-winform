namespace ColorAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_CountColors = new System.Windows.Forms.Button();
            this.pic_preview = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_github = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CountColors
            // 
            this.btn_CountColors.Location = new System.Drawing.Point(237, 376);
            this.btn_CountColors.Name = "btn_CountColors";
            this.btn_CountColors.Size = new System.Drawing.Size(75, 23);
            this.btn_CountColors.TabIndex = 0;
            this.btn_CountColors.Text = "Count";
            this.btn_CountColors.UseVisualStyleBackColor = true;
            this.btn_CountColors.Click += new System.EventHandler(this.btn_CountColors_Click);
            // 
            // pic_preview
            // 
            this.pic_preview.BackColor = System.Drawing.SystemColors.Control;
            this.pic_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_preview.Location = new System.Drawing.Point(12, 12);
            this.pic_preview.Name = "pic_preview";
            this.pic_preview.Size = new System.Drawing.Size(348, 358);
            this.pic_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_preview.TabIndex = 1;
            this.pic_preview.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(61, 376);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(88, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Choose Image";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_github
            // 
            this.btn_github.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_github.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_github.Location = new System.Drawing.Point(281, 414);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(90, 24);
            this.btn_github.TabIndex = 3;
            this.btn_github.Text = "Star on GitHub";
            this.btn_github.UseVisualStyleBackColor = false;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 440);
            this.Controls.Add(this.btn_github);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pic_preview);
            this.Controls.Add(this.btn_CountColors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Color Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CountColors;
        private System.Windows.Forms.PictureBox pic_preview;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_github;
    }
}

