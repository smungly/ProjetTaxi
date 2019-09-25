namespace Projet_Gerer_Taxi
{
    partial class Chauffeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chauffeur));
            this.lbltitlechauff = new System.Windows.Forms.Label();
            this.DCMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPanC = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DCPanV = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.error5 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.DDNChau = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DDSexe = new Bunifu.Framework.UI.BunifuDropdown();
            this.TBNumPermis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TBTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TBNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TBPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TBMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSexeChauff = new System.Windows.Forms.Label();
            this.lbldaten = new System.Windows.Forms.Label();
            this.lblNumPermis = new System.Windows.Forms.Label();
            this.lblchaufmail = new System.Windows.Forms.Label();
            this.lblchauffnum = new System.Windows.Forms.Label();
            this.lblcchauffnom = new System.Windows.Forms.Label();
            this.lblchauffpr = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.DBstate2 = new System.Windows.Forms.PictureBox();
            this.DBstate1 = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PBChauff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChauff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitlechauff
            // 
            this.lbltitlechauff.AutoSize = true;
            this.lbltitlechauff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlechauff.Location = new System.Drawing.Point(59, 15);
            this.lbltitlechauff.Name = "lbltitlechauff";
            this.lbltitlechauff.Size = new System.Drawing.Size(239, 25);
            this.lbltitlechauff.TabIndex = 0;
            this.lbltitlechauff.Text = "NOUVEAU CHAUFFEUR";
            // 
            // DCMain
            // 
            this.DCMain.Fixed = true;
            this.DCMain.Horizontal = true;
            this.DCMain.TargetControl = this;
            this.DCMain.Vertical = true;
            // 
            // DCPanC
            // 
            this.DCPanC.Fixed = true;
            this.DCPanC.Horizontal = true;
            this.DCPanC.TargetControl = null;
            this.DCPanC.Vertical = true;
            // 
            // DCPanV
            // 
            this.DCPanV.Fixed = true;
            this.DCPanV.Horizontal = true;
            this.DCPanV.TargetControl = null;
            this.DCPanV.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error5);
            this.panel1.Controls.Add(this.error2);
            this.panel1.Controls.Add(this.error3);
            this.panel1.Controls.Add(this.error4);
            this.panel1.Controls.Add(this.error1);
            this.panel1.Controls.Add(this.DDNChau);
            this.panel1.Controls.Add(this.DDSexe);
            this.panel1.Controls.Add(this.TBNumPermis);
            this.panel1.Controls.Add(this.TBTel);
            this.panel1.Controls.Add(this.TBNom);
            this.panel1.Controls.Add(this.TBPrenom);
            this.panel1.Controls.Add(this.TBMail);
            this.panel1.Controls.Add(this.lblSexeChauff);
            this.panel1.Controls.Add(this.lbldaten);
            this.panel1.Controls.Add(this.lblNumPermis);
            this.panel1.Controls.Add(this.lblchaufmail);
            this.panel1.Controls.Add(this.lblchauffnum);
            this.panel1.Controls.Add(this.lblcchauffnom);
            this.panel1.Controls.Add(this.lblchauffpr);
            this.panel1.Location = new System.Drawing.Point(213, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 366);
            this.panel1.TabIndex = 29;
            // 
            // error5
            // 
            this.error5.AutoSize = true;
            this.error5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error5.ForeColor = System.Drawing.Color.Crimson;
            this.error5.Location = new System.Drawing.Point(347, 265);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(14, 15);
            this.error5.TabIndex = 69;
            this.error5.Text = "*";
            this.error5.Visible = false;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.ForeColor = System.Drawing.Color.Crimson;
            this.error2.Location = new System.Drawing.Point(346, 57);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(14, 15);
            this.error2.TabIndex = 68;
            this.error2.Text = "*";
            this.error2.Visible = false;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.Crimson;
            this.error3.Location = new System.Drawing.Point(333, 111);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(14, 15);
            this.error3.TabIndex = 67;
            this.error3.Text = "*";
            this.error3.Visible = false;
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error4.ForeColor = System.Drawing.Color.Crimson;
            this.error4.Location = new System.Drawing.Point(346, 214);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(14, 15);
            this.error4.TabIndex = 66;
            this.error4.Text = "*";
            this.error4.Visible = false;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.Crimson;
            this.error1.Location = new System.Drawing.Point(346, 6);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(14, 15);
            this.error1.TabIndex = 65;
            this.error1.Text = "*";
            this.error1.Visible = false;
            // 
            // DDNChau
            // 
            this.DDNChau.BackColor = System.Drawing.Color.Black;
            this.DDNChau.BorderRadius = 0;
            this.DDNChau.ForeColor = System.Drawing.Color.White;
            this.DDNChau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DDNChau.FormatCustom = null;
            this.DDNChau.Location = new System.Drawing.Point(189, 318);
            this.DDNChau.Margin = new System.Windows.Forms.Padding(2);
            this.DDNChau.Name = "DDNChau";
            this.DDNChau.Size = new System.Drawing.Size(171, 31);
            this.DDNChau.TabIndex = 6;
            this.DDNChau.Value = new System.DateTime(1997, 5, 2, 0, 0, 0, 0);
            // 
            // DDSexe
            // 
            this.DDSexe.BackColor = System.Drawing.Color.Transparent;
            this.DDSexe.BorderRadius = 3;
            this.DDSexe.DisabledColor = System.Drawing.Color.Gray;
            this.DDSexe.ForeColor = System.Drawing.Color.White;
            this.DDSexe.Items = new string[] {
        "Homme",
        "Femme",
        "Non-Specifié"};
            this.DDSexe.Location = new System.Drawing.Point(181, 165);
            this.DDSexe.Name = "DDSexe";
            this.DDSexe.NomalColor = System.Drawing.Color.Black;
            this.DDSexe.onHoverColor = System.Drawing.Color.Gold;
            this.DDSexe.selectedIndex = 0;
            this.DDSexe.Size = new System.Drawing.Size(163, 32);
            this.DDSexe.TabIndex = 3;
            // 
            // TBNumPermis
            // 
            this.TBNumPermis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNumPermis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBNumPermis.ForeColor = System.Drawing.Color.White;
            this.TBNumPermis.HintForeColor = System.Drawing.Color.Empty;
            this.TBNumPermis.HintText = "";
            this.TBNumPermis.isPassword = false;
            this.TBNumPermis.LineFocusedColor = System.Drawing.Color.Blue;
            this.TBNumPermis.LineIdleColor = System.Drawing.Color.Black;
            this.TBNumPermis.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.TBNumPermis.LineThickness = 3;
            this.TBNumPermis.Location = new System.Drawing.Point(181, 265);
            this.TBNumPermis.Margin = new System.Windows.Forms.Padding(4);
            this.TBNumPermis.Name = "TBNumPermis";
            this.TBNumPermis.Size = new System.Drawing.Size(163, 33);
            this.TBNumPermis.TabIndex = 5;
            this.TBNumPermis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBNumPermis.OnValueChanged += new System.EventHandler(this.TBNumPermis_OnValueChanged);
            // 
            // TBTel
            // 
            this.TBTel.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.TBTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBTel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBTel.ForeColor = System.Drawing.Color.White;
            this.TBTel.HintForeColor = System.Drawing.Color.Empty;
            this.TBTel.HintText = "+230";
            this.TBTel.isPassword = false;
            this.TBTel.LineFocusedColor = System.Drawing.Color.Blue;
            this.TBTel.LineIdleColor = System.Drawing.Color.Black;
            this.TBTel.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.TBTel.LineThickness = 3;
            this.TBTel.Location = new System.Drawing.Point(209, 111);
            this.TBTel.Margin = new System.Windows.Forms.Padding(4);
            this.TBTel.Name = "TBTel";
            this.TBTel.Size = new System.Drawing.Size(115, 33);
            this.TBTel.TabIndex = 2;
            this.TBTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBTel.OnValueChanged += new System.EventHandler(this.TBTel_OnValueChanged);
            // 
            // TBNom
            // 
            this.TBNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBNom.ForeColor = System.Drawing.Color.White;
            this.TBNom.HintForeColor = System.Drawing.Color.Empty;
            this.TBNom.HintText = "Nom De Famille";
            this.TBNom.isPassword = false;
            this.TBNom.LineFocusedColor = System.Drawing.Color.Blue;
            this.TBNom.LineIdleColor = System.Drawing.Color.Black;
            this.TBNom.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.TBNom.LineThickness = 3;
            this.TBNom.Location = new System.Drawing.Point(181, 57);
            this.TBNom.Margin = new System.Windows.Forms.Padding(4);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(163, 33);
            this.TBNom.TabIndex = 1;
            this.TBNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TBPrenom
            // 
            this.TBPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBPrenom.ForeColor = System.Drawing.Color.White;
            this.TBPrenom.HintForeColor = System.Drawing.Color.Empty;
            this.TBPrenom.HintText = "";
            this.TBPrenom.isPassword = false;
            this.TBPrenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.TBPrenom.LineIdleColor = System.Drawing.Color.Black;
            this.TBPrenom.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.TBPrenom.LineThickness = 3;
            this.TBPrenom.Location = new System.Drawing.Point(181, 6);
            this.TBPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrenom.Name = "TBPrenom";
            this.TBPrenom.Size = new System.Drawing.Size(163, 33);
            this.TBPrenom.TabIndex = 0;
            this.TBPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TBMail
            // 
            this.TBMail.BorderColorFocused = System.Drawing.Color.Blue;
            this.TBMail.BorderColorIdle = System.Drawing.Color.Black;
            this.TBMail.BorderColorMouseHover = System.Drawing.Color.Gold;
            this.TBMail.BorderThickness = 3;
            this.TBMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBMail.isPassword = false;
            this.TBMail.Location = new System.Drawing.Point(188, 214);
            this.TBMail.Margin = new System.Windows.Forms.Padding(4);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(146, 32);
            this.TBMail.TabIndex = 4;
            this.TBMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSexeChauff
            // 
            this.lblSexeChauff.AutoSize = true;
            this.lblSexeChauff.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexeChauff.Location = new System.Drawing.Point(7, 174);
            this.lblSexeChauff.Name = "lblSexeChauff";
            this.lblSexeChauff.Size = new System.Drawing.Size(54, 22);
            this.lblSexeChauff.TabIndex = 49;
            this.lblSexeChauff.Text = "SEXE :";
            // 
            // lbldaten
            // 
            this.lbldaten.AutoSize = true;
            this.lbldaten.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaten.Location = new System.Drawing.Point(7, 326);
            this.lbldaten.Name = "lbldaten";
            this.lbldaten.Size = new System.Drawing.Size(159, 22);
            this.lbldaten.TabIndex = 48;
            this.lbldaten.Text = "DATE DE NAISSANCE :";
            // 
            // lblNumPermis
            // 
            this.lblNumPermis.AutoSize = true;
            this.lblNumPermis.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPermis.Location = new System.Drawing.Point(7, 276);
            this.lblNumPermis.Name = "lblNumPermis";
            this.lblNumPermis.Size = new System.Drawing.Size(132, 22);
            this.lblNumPermis.TabIndex = 47;
            this.lblNumPermis.Text = "NUMÉRO PERMIS:";
            // 
            // lblchaufmail
            // 
            this.lblchaufmail.AutoSize = true;
            this.lblchaufmail.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchaufmail.Location = new System.Drawing.Point(9, 222);
            this.lblchaufmail.Name = "lblchaufmail";
            this.lblchaufmail.Size = new System.Drawing.Size(64, 22);
            this.lblchaufmail.TabIndex = 46;
            this.lblchaufmail.Text = "E-MAIL :";
            // 
            // lblchauffnum
            // 
            this.lblchauffnum.AutoSize = true;
            this.lblchauffnum.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchauffnum.Location = new System.Drawing.Point(10, 122);
            this.lblchauffnum.Name = "lblchauffnum";
            this.lblchauffnum.Size = new System.Drawing.Size(116, 22);
            this.lblchauffnum.TabIndex = 45;
            this.lblchauffnum.Text = "№ TÉLÉPHONE:";
            // 
            // lblcchauffnom
            // 
            this.lblcchauffnom.AutoSize = true;
            this.lblcchauffnom.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcchauffnom.Location = new System.Drawing.Point(10, 68);
            this.lblcchauffnom.Name = "lblcchauffnom";
            this.lblcchauffnom.Size = new System.Drawing.Size(51, 22);
            this.lblcchauffnom.TabIndex = 44;
            this.lblcchauffnom.Text = "NOM :";
            // 
            // lblchauffpr
            // 
            this.lblchauffpr.AutoSize = true;
            this.lblchauffpr.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchauffpr.Location = new System.Drawing.Point(12, 17);
            this.lblchauffpr.Name = "lblchauffpr";
            this.lblchauffpr.Size = new System.Drawing.Size(98, 22);
            this.lblchauffpr.TabIndex = 43;
            this.lblchauffpr.Text = "PRÉNOM(S) :";
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
            this.btnreset.TabIndex = 65;
            this.btnreset.Text = " ";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
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
            this.btnhelp.TabIndex = 64;
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
            this.btnsettings.TabIndex = 63;
            this.btnsettings.Text = " ";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // DBstate2
            // 
            this.DBstate2.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_information_1034694;
            this.DBstate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate2.Location = new System.Drawing.Point(768, 11);
            this.DBstate2.Name = "DBstate2";
            this.DBstate2.Size = new System.Drawing.Size(42, 38);
            this.DBstate2.TabIndex = 32;
            this.DBstate2.TabStop = false;
            this.DBstate2.Visible = false;
            // 
            // DBstate1
            // 
            this.DBstate1.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_security_1034724;
            this.DBstate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DBstate1.Location = new System.Drawing.Point(769, 11);
            this.DBstate1.Name = "DBstate1";
            this.DBstate1.Size = new System.Drawing.Size(42, 38);
            this.DBstate1.TabIndex = 31;
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
            this.BtnNew.TabIndex = 0;
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // PBChauff
            // 
            this.PBChauff.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_users_10_984119;
            this.PBChauff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBChauff.Location = new System.Drawing.Point(0, 0);
            this.PBChauff.Name = "PBChauff";
            this.PBChauff.Size = new System.Drawing.Size(56, 46);
            this.PBChauff.TabIndex = 1;
            this.PBChauff.TabStop = false;
            // 
            // Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.DBstate2);
            this.Controls.Add(this.DBstate1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.PBChauff);
            this.Controls.Add(this.lbltitlechauff);
            this.Name = "Chauffeur";
            this.Size = new System.Drawing.Size(825, 562);
            this.Load += new System.EventHandler(this.Chauffeur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBstate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChauff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBChauff;
        private System.Windows.Forms.Label lbltitlechauff;
        private Bunifu.Framework.UI.BunifuDragControl DCMain;
        private Bunifu.Framework.UI.BunifuDragControl DCPanC;
        private Bunifu.Framework.UI.BunifuDragControl DCPanV;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnNew;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBNumPermis;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBTel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TBPrenom;
        private Bunifu.Framework.UI.BunifuMetroTextbox TBMail;
        private System.Windows.Forms.Label lblSexeChauff;
        private System.Windows.Forms.Label lbldaten;
        private System.Windows.Forms.Label lblNumPermis;
        private System.Windows.Forms.Label lblchaufmail;
        private System.Windows.Forms.Label lblchauffnum;
        private System.Windows.Forms.Label lblcchauffnom;
        private System.Windows.Forms.Label lblchauffpr;
        private Bunifu.Framework.UI.BunifuDropdown DDSexe;
        private Bunifu.Framework.UI.BunifuDatepicker DDNChau;
        private System.Windows.Forms.PictureBox DBstate1;
        private System.Windows.Forms.PictureBox DBstate2;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Button btnreset;
    }
}
