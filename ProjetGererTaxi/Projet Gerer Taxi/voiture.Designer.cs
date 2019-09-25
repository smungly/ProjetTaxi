namespace Projet_Gerer_Taxi
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lblInfo = new System.Windows.Forms.Label();
            this.DCPanC = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCLbl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DClblReserv = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DClblch = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.error4 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.DDExp = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSpecs = new System.Windows.Forms.RichTextBox();
            this.DDStatut = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblvoiturespecs = new System.Windows.Forms.Label();
            this.lblvoitureensuage = new System.Windows.Forms.Label();
            this.TBNC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblvoiturens = new System.Windows.Forms.Label();
            this.TBModele = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblvoituremod = new System.Windows.Forms.Label();
            this.TBMatricule = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblvoituremat = new System.Windows.Forms.Label();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.DBstate2 = new System.Windows.Forms.PictureBox();
            this.DBstate1 = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbreserv = new System.Windows.Forms.PictureBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreserv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(62, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(97, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "VOITURE";
            // 
            // DCPanC
            // 
            this.DCPanC.Fixed = true;
            this.DCPanC.Horizontal = true;
            this.DCPanC.TargetControl = this;
            this.DCPanC.Vertical = true;
            // 
            // DCLbl1
            // 
            this.DCLbl1.Fixed = true;
            this.DCLbl1.Horizontal = true;
            this.DCLbl1.TargetControl = this.lblInfo;
            this.DCLbl1.Vertical = true;
            // 
            // DClblReserv
            // 
            this.DClblReserv.Fixed = true;
            this.DClblReserv.Horizontal = true;
            this.DClblReserv.TargetControl = null;
            this.DClblReserv.Vertical = true;
            // 
            // DClblch
            // 
            this.DClblch.Fixed = true;
            this.DClblch.Horizontal = true;
            this.DClblch.TargetControl = null;
            this.DClblch.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error4);
            this.panel1.Controls.Add(this.error3);
            this.panel1.Controls.Add(this.error1);
            this.panel1.Controls.Add(this.DDExp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBSpecs);
            this.panel1.Controls.Add(this.DDStatut);
            this.panel1.Controls.Add(this.lblvoiturespecs);
            this.panel1.Controls.Add(this.lblvoitureensuage);
            this.panel1.Controls.Add(this.TBNC);
            this.panel1.Controls.Add(this.lblvoiturens);
            this.panel1.Controls.Add(this.TBModele);
            this.panel1.Controls.Add(this.lblvoituremod);
            this.panel1.Controls.Add(this.TBMatricule);
            this.panel1.Controls.Add(this.lblvoituremat);
            this.panel1.Location = new System.Drawing.Point(213, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 330);
            this.panel1.TabIndex = 0;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error4.ForeColor = System.Drawing.Color.Crimson;
            this.error4.Location = new System.Drawing.Point(296, 160);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(14, 15);
            this.error4.TabIndex = 70;
            this.error4.Text = "*";
            this.error4.Visible = false;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.Crimson;
            this.error3.Location = new System.Drawing.Point(350, 107);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(14, 15);
            this.error3.TabIndex = 68;
            this.error3.Text = "*";
            this.error3.Visible = false;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.Crimson;
            this.error1.Location = new System.Drawing.Point(354, 9);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(14, 15);
            this.error1.TabIndex = 67;
            this.error1.Text = "*";
            this.error1.Visible = false;
            // 
            // DDExp
            // 
            this.DDExp.BackColor = System.Drawing.Color.SeaShell;
            this.DDExp.BorderRadius = 0;
            this.DDExp.ForeColor = System.Drawing.Color.Black;
            this.DDExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DDExp.FormatCustom = null;
            this.DDExp.Location = new System.Drawing.Point(200, 61);
            this.DDExp.Name = "DDExp";
            this.DDExp.Size = new System.Drawing.Size(164, 31);
            this.DDExp.TabIndex = 1;
            this.DDExp.Value = new System.DateTime(2018, 5, 1, 13, 31, 18, 511);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "DATE EXP. ASSURANCE :";
            // 
            // TBSpecs
            // 
            this.TBSpecs.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TBSpecs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBSpecs.ForeColor = System.Drawing.Color.Black;
            this.TBSpecs.Location = new System.Drawing.Point(152, 211);
            this.TBSpecs.Name = "TBSpecs";
            this.TBSpecs.Size = new System.Drawing.Size(194, 48);
            this.TBSpecs.TabIndex = 4;
            this.TBSpecs.Text = "";
            // 
            // DDStatut
            // 
            this.DDStatut.BackColor = System.Drawing.Color.Transparent;
            this.DDStatut.BorderRadius = 3;
            this.DDStatut.DisabledColor = System.Drawing.Color.Gray;
            this.DDStatut.ForeColor = System.Drawing.Color.Black;
            this.DDStatut.Items = new string[] {
        "OUI",
        "NON"};
            this.DDStatut.Location = new System.Drawing.Point(221, 278);
            this.DDStatut.Name = "DDStatut";
            this.DDStatut.NomalColor = System.Drawing.Color.AntiqueWhite;
            this.DDStatut.onHoverColor = System.Drawing.Color.Indigo;
            this.DDStatut.selectedIndex = 0;
            this.DDStatut.Size = new System.Drawing.Size(125, 31);
            this.DDStatut.TabIndex = 5;
            // 
            // lblvoiturespecs
            // 
            this.lblvoiturespecs.AutoSize = true;
            this.lblvoiturespecs.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoiturespecs.Location = new System.Drawing.Point(8, 224);
            this.lblvoiturespecs.Name = "lblvoiturespecs";
            this.lblvoiturespecs.Size = new System.Drawing.Size(130, 22);
            this.lblvoiturespecs.TabIndex = 42;
            this.lblvoiturespecs.Text = "SPÉCIFICATIONS :";
            // 
            // lblvoitureensuage
            // 
            this.lblvoitureensuage.AutoSize = true;
            this.lblvoitureensuage.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoitureensuage.Location = new System.Drawing.Point(11, 284);
            this.lblvoitureensuage.Name = "lblvoitureensuage";
            this.lblvoitureensuage.Size = new System.Drawing.Size(89, 22);
            this.lblvoitureensuage.TabIndex = 36;
            this.lblvoitureensuage.Text = "EN USAGE :";
            // 
            // TBNC
            // 
            this.TBNC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBNC.HintForeColor = System.Drawing.Color.Empty;
            this.TBNC.HintText = "";
            this.TBNC.isPassword = false;
            this.TBNC.LineFocusedColor = System.Drawing.Color.Indigo;
            this.TBNC.LineIdleColor = System.Drawing.Color.AntiqueWhite;
            this.TBNC.LineMouseHoverColor = System.Drawing.Color.Indigo;
            this.TBNC.LineThickness = 5;
            this.TBNC.Location = new System.Drawing.Point(254, 160);
            this.TBNC.Margin = new System.Windows.Forms.Padding(4);
            this.TBNC.Name = "TBNC";
            this.TBNC.Size = new System.Drawing.Size(35, 30);
            this.TBNC.TabIndex = 3;
            this.TBNC.Text = "4";
            this.TBNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblvoiturens
            // 
            this.lblvoiturens.AutoSize = true;
            this.lblvoiturens.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoiturens.Location = new System.Drawing.Point(11, 168);
            this.lblvoiturens.Name = "lblvoiturens";
            this.lblvoiturens.Size = new System.Drawing.Size(133, 22);
            this.lblvoiturens.TabIndex = 35;
            this.lblvoiturens.Text = "NOMBRE SIEGES :";
            // 
            // TBModele
            // 
            this.TBModele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBModele.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBModele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBModele.HintForeColor = System.Drawing.Color.Empty;
            this.TBModele.HintText = "";
            this.TBModele.isPassword = false;
            this.TBModele.LineFocusedColor = System.Drawing.Color.Indigo;
            this.TBModele.LineIdleColor = System.Drawing.Color.AntiqueWhite;
            this.TBModele.LineMouseHoverColor = System.Drawing.Color.Indigo;
            this.TBModele.LineThickness = 5;
            this.TBModele.Location = new System.Drawing.Point(201, 107);
            this.TBModele.Margin = new System.Windows.Forms.Padding(4);
            this.TBModele.Name = "TBModele";
            this.TBModele.Size = new System.Drawing.Size(146, 29);
            this.TBModele.TabIndex = 2;
            this.TBModele.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblvoituremod
            // 
            this.lblvoituremod.AutoSize = true;
            this.lblvoituremod.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoituremod.Location = new System.Drawing.Point(11, 114);
            this.lblvoituremod.Name = "lblvoituremod";
            this.lblvoituremod.Size = new System.Drawing.Size(77, 22);
            this.lblvoituremod.TabIndex = 31;
            this.lblvoituremod.Text = "MODELE :";
            // 
            // TBMatricule
            // 
            this.TBMatricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMatricule.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBMatricule.HintForeColor = System.Drawing.Color.Empty;
            this.TBMatricule.HintText = "";
            this.TBMatricule.isPassword = false;
            this.TBMatricule.LineFocusedColor = System.Drawing.Color.Indigo;
            this.TBMatricule.LineIdleColor = System.Drawing.Color.AntiqueWhite;
            this.TBMatricule.LineMouseHoverColor = System.Drawing.Color.Indigo;
            this.TBMatricule.LineThickness = 5;
            this.TBMatricule.Location = new System.Drawing.Point(197, 13);
            this.TBMatricule.Margin = new System.Windows.Forms.Padding(4);
            this.TBMatricule.Name = "TBMatricule";
            this.TBMatricule.Size = new System.Drawing.Size(160, 29);
            this.TBMatricule.TabIndex = 0;
            this.TBMatricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblvoituremat
            // 
            this.lblvoituremat.AutoSize = true;
            this.lblvoituremat.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoituremat.Location = new System.Drawing.Point(12, 20);
            this.lblvoituremat.Name = "lblvoituremat";
            this.lblvoituremat.Size = new System.Drawing.Size(116, 22);
            this.lblvoituremat.TabIndex = 29;
            this.lblvoituremat.Text = "№ MATRICULE :";
            // 
            // btnhelp
            // 
            this.btnhelp.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_help_172477;
            this.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Location = new System.Drawing.Point(771, 99);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(38, 30);
            this.btnhelp.TabIndex = 62;
            this.btnhelp.Text = " ";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_Streamline_75_185095;
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Location = new System.Drawing.Point(769, 58);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(42, 37);
            this.btnsettings.TabIndex = 61;
            this.btnsettings.Text = " ";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // DBstate2
            // 
            this.DBstate2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_information_1034691;
            this.DBstate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate2.Location = new System.Drawing.Point(769, 11);
            this.DBstate2.Name = "DBstate2";
            this.DBstate2.Size = new System.Drawing.Size(42, 38);
            this.DBstate2.TabIndex = 60;
            this.DBstate2.TabStop = false;
            this.DBstate2.Visible = false;
            // 
            // DBstate1
            // 
            this.DBstate1.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_security_1034721;
            this.DBstate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate1.Location = new System.Drawing.Point(769, 11);
            this.DBstate1.Name = "DBstate1";
            this.DBstate1.Size = new System.Drawing.Size(42, 38);
            this.DBstate1.TabIndex = 59;
            this.DBstate1.TabStop = false;
            this.DBstate1.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.ActiveBorderThickness = 1;
            this.BtnAdd.ActiveCornerRadius = 20;
            this.BtnAdd.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.BtnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAdd.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.ButtonText = "SAVEGARDER";
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.IdleBorderThickness = 1;
            this.BtnAdd.IdleCornerRadius = 20;
            this.BtnAdd.IdleFillColor = System.Drawing.Color.Black;
            this.BtnAdd.IdleForecolor = System.Drawing.Color.Honeydew;
            this.BtnAdd.IdleLineColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(397, 498);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(163, 37);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ActiveBorderThickness = 1;
            this.BtnNew.ActiveCornerRadius = 20;
            this.BtnNew.ActiveFillColor = System.Drawing.Color.PowderBlue;
            this.BtnNew.ActiveForecolor = System.Drawing.Color.White;
            this.BtnNew.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.BtnNew.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.ButtonText = "NOUVEAU";
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.IdleBorderThickness = 1;
            this.BtnNew.IdleCornerRadius = 20;
            this.BtnNew.IdleFillColor = System.Drawing.Color.Black;
            this.BtnNew.IdleForecolor = System.Drawing.Color.Honeydew;
            this.BtnNew.IdleLineColor = System.Drawing.Color.Black;
            this.BtnNew.Location = new System.Drawing.Point(213, 498);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(163, 37);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // pbreserv
            // 
            this.pbreserv.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_tesla_roadster_car_space_music_vehicle_transport_29442501;
            this.pbreserv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbreserv.Location = new System.Drawing.Point(0, 1);
            this.pbreserv.Name = "pbreserv";
            this.pbreserv.Size = new System.Drawing.Size(56, 57);
            this.pbreserv.TabIndex = 1;
            this.pbreserv.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_063_Undo_183192;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(771, 521);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(38, 30);
            this.btnreset.TabIndex = 67;
            this.btnreset.Text = " ";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.DBstate2);
            this.Controls.Add(this.DBstate1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.pbreserv);
            this.Controls.Add(this.lblInfo);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(825, 562);
            this.Load += new System.EventHandler(this.INFORES_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbreserv;
        private System.Windows.Forms.Label lblInfo;
        private Bunifu.Framework.UI.BunifuDragControl DCPanC;
        private Bunifu.Framework.UI.BunifuDragControl DCLbl1;
        private Bunifu.Framework.UI.BunifuDragControl DClblReserv;
        private Bunifu.Framework.UI.BunifuDragControl DClblch;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnNew;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown DDStatut;
        private System.Windows.Forms.Label lblvoiturespecs;
        private System.Windows.Forms.Label lblvoitureensuage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBNC;
        private System.Windows.Forms.Label lblvoiturens;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBModele;
        private System.Windows.Forms.Label lblvoituremod;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBMatricule;
        private System.Windows.Forms.Label lblvoituremat;
        private System.Windows.Forms.RichTextBox TBSpecs;
        private Bunifu.Framework.UI.BunifuDatepicker DDExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DBstate2;
        private System.Windows.Forms.PictureBox DBstate1;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error1;
    }
}
