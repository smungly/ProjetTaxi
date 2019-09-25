namespace Projet_Gerer_Taxi
{
    partial class Taxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taxi));
            this.panelgauche = new System.Windows.Forms.Panel();
            this.btnreserv = new System.Windows.Forms.Button();
            this.pan5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnclient = new System.Windows.Forms.Button();
            this.pan6 = new System.Windows.Forms.FlowLayoutPanel();
            this.pan3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnvoiture = new System.Windows.Forms.Button();
            this.pan2 = new System.Windows.Forms.FlowLayoutPanel();
            this.logooff = new System.Windows.Forms.PictureBox();
            this.btnchauffeur = new System.Windows.Forms.Button();
            this.acceuil = new System.Windows.Forms.Button();
            this.pan4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pan1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panhaut = new System.Windows.Forms.Panel();
            this.btngetout = new System.Windows.Forms.Button();
            this.minibutt = new System.Windows.Forms.Button();
            this.closebutt = new System.Windows.Forms.Button();
            this.MainPan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.DCMainPan = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPanHaut = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPanGauche = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPan6 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPic1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPic2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelgauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logooff)).BeginInit();
            this.panhaut.SuspendLayout();
            this.MainPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelgauche
            // 
            this.panelgauche.BackColor = System.Drawing.Color.Ivory;
            this.panelgauche.Controls.Add(this.btnreserv);
            this.panelgauche.Controls.Add(this.pan5);
            this.panelgauche.Controls.Add(this.btnclient);
            this.panelgauche.Controls.Add(this.pan6);
            this.panelgauche.Controls.Add(this.pan3);
            this.panelgauche.Controls.Add(this.btnvoiture);
            this.panelgauche.Controls.Add(this.pan2);
            this.panelgauche.Controls.Add(this.logooff);
            this.panelgauche.Controls.Add(this.btnchauffeur);
            this.panelgauche.Controls.Add(this.acceuil);
            this.panelgauche.Controls.Add(this.pan4);
            this.panelgauche.Controls.Add(this.pan1);
            this.panelgauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelgauche.Location = new System.Drawing.Point(0, 0);
            this.panelgauche.Name = "panelgauche";
            this.panelgauche.Size = new System.Drawing.Size(149, 598);
            this.panelgauche.TabIndex = 0;
            this.panelgauche.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgauche_Paint);
            // 
            // btnreserv
            // 
            this.btnreserv.BackColor = System.Drawing.Color.Gold;
            this.btnreserv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnreserv.FlatAppearance.BorderSize = 0;
            this.btnreserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreserv.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreserv.ForeColor = System.Drawing.Color.Snow;
            this.btnreserv.Location = new System.Drawing.Point(15, 398);
            this.btnreserv.Name = "btnreserv";
            this.btnreserv.Size = new System.Drawing.Size(134, 55);
            this.btnreserv.TabIndex = 5;
            this.btnreserv.Text = "RÉSERVATION";
            this.btnreserv.UseVisualStyleBackColor = false;
            this.btnreserv.Click += new System.EventHandler(this.btninfores_Click);
            // 
            // pan5
            // 
            this.pan5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pan5.Location = new System.Drawing.Point(0, 398);
            this.pan5.Name = "pan5";
            this.pan5.Size = new System.Drawing.Size(15, 55);
            this.pan5.TabIndex = 5;
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.Gold;
            this.btnclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.Snow;
            this.btnclient.Location = new System.Drawing.Point(15, 343);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(134, 55);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "CLIENT";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnreserv_Click);
            // 
            // pan6
            // 
            this.pan6.BackColor = System.Drawing.SystemColors.Desktop;
            this.pan6.Location = new System.Drawing.Point(0, 451);
            this.pan6.Name = "pan6";
            this.pan6.Size = new System.Drawing.Size(149, 147);
            this.pan6.TabIndex = 6;
            // 
            // pan3
            // 
            this.pan3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pan3.Location = new System.Drawing.Point(0, 288);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(15, 55);
            this.pan3.TabIndex = 4;
            // 
            // btnvoiture
            // 
            this.btnvoiture.BackColor = System.Drawing.Color.Gold;
            this.btnvoiture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnvoiture.FlatAppearance.BorderSize = 0;
            this.btnvoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoiture.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoiture.ForeColor = System.Drawing.Color.Snow;
            this.btnvoiture.Location = new System.Drawing.Point(15, 288);
            this.btnvoiture.Name = "btnvoiture";
            this.btnvoiture.Size = new System.Drawing.Size(134, 55);
            this.btnvoiture.TabIndex = 7;
            this.btnvoiture.Text = "VOITURE";
            this.btnvoiture.UseVisualStyleBackColor = false;
            this.btnvoiture.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.Black;
            this.pan2.Location = new System.Drawing.Point(0, 233);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(15, 55);
            this.pan2.TabIndex = 4;
            // 
            // logooff
            // 
            this.logooff.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_aiga_taxi_134116_1_;
            this.logooff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logooff.Location = new System.Drawing.Point(12, 36);
            this.logooff.Name = "logooff";
            this.logooff.Size = new System.Drawing.Size(131, 123);
            this.logooff.TabIndex = 2;
            this.logooff.TabStop = false;
            // 
            // btnchauffeur
            // 
            this.btnchauffeur.BackColor = System.Drawing.Color.Gold;
            this.btnchauffeur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnchauffeur.FlatAppearance.BorderSize = 0;
            this.btnchauffeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchauffeur.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchauffeur.ForeColor = System.Drawing.Color.Snow;
            this.btnchauffeur.Location = new System.Drawing.Point(15, 233);
            this.btnchauffeur.Name = "btnchauffeur";
            this.btnchauffeur.Size = new System.Drawing.Size(134, 55);
            this.btnchauffeur.TabIndex = 3;
            this.btnchauffeur.Text = "CHAUFFEUR";
            this.btnchauffeur.UseVisualStyleBackColor = false;
            this.btnchauffeur.Click += new System.EventHandler(this.btnchauffeur_Click);
            // 
            // acceuil
            // 
            this.acceuil.BackColor = System.Drawing.Color.Gold;
            this.acceuil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceuil.FlatAppearance.BorderSize = 0;
            this.acceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceuil.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceuil.ForeColor = System.Drawing.Color.Snow;
            this.acceuil.Location = new System.Drawing.Point(15, 178);
            this.acceuil.Name = "acceuil";
            this.acceuil.Size = new System.Drawing.Size(134, 55);
            this.acceuil.TabIndex = 2;
            this.acceuil.Text = "ACCEUIL";
            this.acceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.acceuil.UseVisualStyleBackColor = false;
            this.acceuil.Click += new System.EventHandler(this.acceuil_Click);
            // 
            // pan4
            // 
            this.pan4.BackColor = System.Drawing.Color.Black;
            this.pan4.Location = new System.Drawing.Point(0, 343);
            this.pan4.Name = "pan4";
            this.pan4.Size = new System.Drawing.Size(15, 55);
            this.pan4.TabIndex = 3;
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pan1.Location = new System.Drawing.Point(0, 178);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(15, 55);
            this.pan1.TabIndex = 2;
            // 
            // panhaut
            // 
            this.panhaut.BackColor = System.Drawing.SystemColors.Control;
            this.panhaut.Controls.Add(this.btngetout);
            this.panhaut.Controls.Add(this.minibutt);
            this.panhaut.Controls.Add(this.closebutt);
            this.panhaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.panhaut.Location = new System.Drawing.Point(149, 0);
            this.panhaut.Name = "panhaut";
            this.panhaut.Size = new System.Drawing.Size(824, 30);
            this.panhaut.TabIndex = 1;
            // 
            // btngetout
            // 
            this.btngetout.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_icons_exit2_1564506;
            this.btngetout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngetout.FlatAppearance.BorderSize = 0;
            this.btngetout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngetout.Location = new System.Drawing.Point(0, 0);
            this.btngetout.Name = "btngetout";
            this.btngetout.Size = new System.Drawing.Size(38, 30);
            this.btngetout.TabIndex = 2;
            this.btngetout.Text = " ";
            this.btngetout.UseVisualStyleBackColor = true;
            this.btngetout.Click += new System.EventHandler(this.btngetout_Click);
            // 
            // minibutt
            // 
            this.minibutt.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_down_1303877_1_;
            this.minibutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minibutt.FlatAppearance.BorderSize = 0;
            this.minibutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibutt.Location = new System.Drawing.Point(741, 0);
            this.minibutt.Name = "minibutt";
            this.minibutt.Size = new System.Drawing.Size(38, 30);
            this.minibutt.TabIndex = 1;
            this.minibutt.Text = " ";
            this.minibutt.UseVisualStyleBackColor = true;
            this.minibutt.Click += new System.EventHandler(this.minibutt_Click);
            // 
            // closebutt
            // 
            this.closebutt.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_close_309090_2_;
            this.closebutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutt.FlatAppearance.BorderSize = 0;
            this.closebutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutt.Location = new System.Drawing.Point(785, 0);
            this.closebutt.Name = "closebutt";
            this.closebutt.Size = new System.Drawing.Size(38, 30);
            this.closebutt.TabIndex = 0;
            this.closebutt.Text = " ";
            this.closebutt.UseVisualStyleBackColor = true;
            this.closebutt.Click += new System.EventHandler(this.closebutt_Click);
            // 
            // MainPan
            // 
            this.MainPan.Controls.Add(this.label1);
            this.MainPan.Controls.Add(this.picture2);
            this.MainPan.ForeColor = System.Drawing.Color.Black;
            this.MainPan.Location = new System.Drawing.Point(149, 36);
            this.MainPan.Name = "MainPan";
            this.MainPan.Size = new System.Drawing.Size(825, 562);
            this.MainPan.TabIndex = 2;
            this.MainPan.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPan_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENUE";
            // 
            // picture2
            // 
            this.picture2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_flash_2995002;
            this.picture2.Location = new System.Drawing.Point(354, 180);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(128, 127);
            this.picture2.TabIndex = 2;
            this.picture2.TabStop = false;
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // DCMainPan
            // 
            this.DCMainPan.Fixed = true;
            this.DCMainPan.Horizontal = true;
            this.DCMainPan.TargetControl = this.MainPan;
            this.DCMainPan.Vertical = true;
            // 
            // DCPanHaut
            // 
            this.DCPanHaut.Fixed = true;
            this.DCPanHaut.Horizontal = true;
            this.DCPanHaut.TargetControl = this.panhaut;
            this.DCPanHaut.Vertical = true;
            // 
            // DCPanGauche
            // 
            this.DCPanGauche.Fixed = true;
            this.DCPanGauche.Horizontal = true;
            this.DCPanGauche.TargetControl = this.panelgauche;
            this.DCPanGauche.Vertical = true;
            // 
            // DCPan6
            // 
            this.DCPan6.Fixed = true;
            this.DCPan6.Horizontal = true;
            this.DCPan6.TargetControl = this.pan6;
            this.DCPan6.Vertical = true;
            // 
            // DCPic1
            // 
            this.DCPic1.Fixed = true;
            this.DCPic1.Horizontal = true;
            this.DCPic1.TargetControl = this.logooff;
            this.DCPic1.Vertical = true;
            // 
            // DCPic2
            // 
            this.DCPic2.Fixed = true;
            this.DCPic2.Horizontal = true;
            this.DCPic2.TargetControl = this.picture2;
            this.DCPic2.Vertical = true;
            // 
            // Taxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 598);
            this.Controls.Add(this.MainPan);
            this.Controls.Add(this.panhaut);
            this.Controls.Add(this.panelgauche);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Taxi";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION TAXI";
            this.Load += new System.EventHandler(this.Taxi_Load);
            this.panelgauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logooff)).EndInit();
            this.panhaut.ResumeLayout(false);
            this.MainPan.ResumeLayout(false);
            this.MainPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelgauche;
        private System.Windows.Forms.Panel panhaut;
        private System.Windows.Forms.Button closebutt;
        private System.Windows.Forms.Button minibutt;
        private System.Windows.Forms.PictureBox logooff;
        private System.Windows.Forms.Button btnreserv;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnchauffeur;
        private System.Windows.Forms.Button acceuil;
        private System.Windows.Forms.FlowLayoutPanel pan1;
        private System.Windows.Forms.FlowLayoutPanel pan2;
        private System.Windows.Forms.FlowLayoutPanel pan3;
        private System.Windows.Forms.FlowLayoutPanel pan4;
        private System.Windows.Forms.Panel MainPan;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.FlowLayoutPanel pan6;
        private System.Windows.Forms.FlowLayoutPanel pan5;
        private System.Windows.Forms.Button btnvoiture;
        private Bunifu.Framework.UI.BunifuDragControl DCMainPan;
        private Bunifu.Framework.UI.BunifuDragControl DCPanHaut;
        private Bunifu.Framework.UI.BunifuDragControl DCPanGauche;
        private Bunifu.Framework.UI.BunifuDragControl DCPan6;
        private Bunifu.Framework.UI.BunifuDragControl DCPic1;
        private Bunifu.Framework.UI.BunifuDragControl DCPic2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngetout;
    }
}

