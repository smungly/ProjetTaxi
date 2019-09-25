namespace Projet_Gerer_Taxi
{
    partial class Help4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.closebutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_icons_exit2_15645061;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(151, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(119, 19);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(134, 15);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "ENTRER EN MODE LOGIN";
            // 
            // closebutt
            // 
            this.closebutt.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_close_309090;
            this.closebutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutt.FlatAppearance.BorderSize = 0;
            this.closebutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutt.Location = new System.Drawing.Point(331, 2);
            this.closebutt.Name = "closebutt";
            this.closebutt.Size = new System.Drawing.Size(38, 30);
            this.closebutt.TabIndex = 5;
            this.closebutt.Text = " ";
            this.closebutt.UseVisualStyleBackColor = true;
            this.closebutt.Click += new System.EventHandler(this.closebutt_Click);
            // 
            // Help4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(371, 86);
            this.Controls.Add(this.closebutt);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help4";
            this.Opacity = 0.97D;
            this.Text = "HELP";
            this.Load += new System.EventHandler(this.Help4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button closebutt;
    }
}