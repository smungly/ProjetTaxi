namespace Projet_Gerer_Taxi
{
    partial class Parametres_Chauffeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametres_Chauffeur));
            this.minibutt = new System.Windows.Forms.Button();
            this.closebutt = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.DCMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // minibutt
            // 
            this.minibutt.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_down_1303877_1_;
            this.minibutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minibutt.FlatAppearance.BorderSize = 0;
            this.minibutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibutt.Location = new System.Drawing.Point(388, 3);
            this.minibutt.Name = "minibutt";
            this.minibutt.Size = new System.Drawing.Size(38, 30);
            this.minibutt.TabIndex = 54;
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
            this.closebutt.Location = new System.Drawing.Point(435, 2);
            this.closebutt.Name = "closebutt";
            this.closebutt.Size = new System.Drawing.Size(38, 30);
            this.closebutt.TabIndex = 53;
            this.closebutt.Text = " ";
            this.closebutt.UseVisualStyleBackColor = true;
            this.closebutt.Click += new System.EventHandler(this.closebutt_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Projet_Gerer_Taxi.Properties.Resources.if_database_1608662;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(160, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 31);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "CHAUFFEUR";
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView4.Location = new System.Drawing.Point(44, 89);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(382, 353);
            this.dataGridView4.TabIndex = 55;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // DCMain
            // 
            this.DCMain.Fixed = true;
            this.DCMain.Horizontal = true;
            this.DCMain.TargetControl = this;
            this.DCMain.Vertical = true;
            // 
            // Parametres_Chauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(475, 471);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.minibutt);
            this.Controls.Add(this.closebutt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parametres_Chauffeur";
            this.Text = "Parametres Chauffeur";
            this.Load += new System.EventHandler(this.Parametres_Chauffeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minibutt;
        private System.Windows.Forms.Button closebutt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Bunifu.Framework.UI.BunifuDragControl DCMain;
    }
}