namespace Projet_Gerer_Taxi
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.tmrblink = new System.Windows.Forms.Timer(this.components);
            this.DCMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPic1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENUE";
            // 
            // picture2
            // 
            this.picture2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_flash_2995002;
            this.picture2.Location = new System.Drawing.Point(354, 180);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(128, 127);
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            // 
            // tmrblink
            // 
            this.tmrblink.Tick += new System.EventHandler(this.tmrblink_Tick);
            // 
            // DCMain
            // 
            this.DCMain.Fixed = true;
            this.DCMain.Horizontal = true;
            this.DCMain.TargetControl = this;
            this.DCMain.Vertical = true;
            // 
            // DCPic1
            // 
            this.DCPic1.Fixed = true;
            this.DCPic1.Horizontal = true;
            this.DCPic1.TargetControl = this.picture2;
            this.DCPic1.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(811, 537);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Timer tmrblink;
        private Bunifu.Framework.UI.BunifuDragControl DCMain;
        private Bunifu.Framework.UI.BunifuDragControl DCPic1;
    }
}
