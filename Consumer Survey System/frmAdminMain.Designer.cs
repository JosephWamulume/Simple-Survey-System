namespace Consumer_Survey_System
{
    partial class frmAdminMain
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSurveys = new System.Windows.Forms.Panel();
            this.dgvSurveys = new System.Windows.Forms.DataGridView();
            this.btnEditSurvey = new System.Windows.Forms.Button();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.btnNewSurvey = new System.Windows.Forms.Button();
            this.btnSurveys = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxCategories = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxCart = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.pnlSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlSurveys);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(254, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(693, 550);
            this.pnlContainer.TabIndex = 3;
            // 
            // pnlSurveys
            // 
            this.pnlSurveys.AutoScroll = true;
            this.pnlSurveys.Controls.Add(this.dgvSurveys);
            this.pnlSurveys.Controls.Add(this.btnEditSurvey);
            this.pnlSurveys.Controls.Add(this.btnDeleteSurvey);
            this.pnlSurveys.Controls.Add(this.btnNewSurvey);
            this.pnlSurveys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSurveys.Location = new System.Drawing.Point(0, 0);
            this.pnlSurveys.Name = "pnlSurveys";
            this.pnlSurveys.Size = new System.Drawing.Size(693, 550);
            this.pnlSurveys.TabIndex = 0;
            // 
            // dgvSurveys
            // 
            this.dgvSurveys.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurveys.Location = new System.Drawing.Point(13, 51);
            this.dgvSurveys.Name = "dgvSurveys";
            this.dgvSurveys.Size = new System.Drawing.Size(666, 487);
            this.dgvSurveys.TabIndex = 16;
            // 
            // btnEditSurvey
            // 
            this.btnEditSurvey.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSurvey.Image = global::Consumer_Survey_System.Properties.Resources.icons8_edit_file_16;
            this.btnEditSurvey.Location = new System.Drawing.Point(284, 12);
            this.btnEditSurvey.Name = "btnEditSurvey";
            this.btnEditSurvey.Size = new System.Drawing.Size(122, 27);
            this.btnEditSurvey.TabIndex = 15;
            this.btnEditSurvey.Text = "Edit Survey";
            this.btnEditSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditSurvey.UseVisualStyleBackColor = true;
            this.btnEditSurvey.Click += new System.EventHandler(this.btnEditSurvey_Click);
            // 
            // btnDeleteSurvey
            // 
            this.btnDeleteSurvey.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSurvey.Image = global::Consumer_Survey_System.Properties.Resources.icons8_delete_file_16;
            this.btnDeleteSurvey.Location = new System.Drawing.Point(148, 12);
            this.btnDeleteSurvey.Name = "btnDeleteSurvey";
            this.btnDeleteSurvey.Size = new System.Drawing.Size(122, 27);
            this.btnDeleteSurvey.TabIndex = 14;
            this.btnDeleteSurvey.Text = "Delete Survey";
            this.btnDeleteSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteSurvey.UseVisualStyleBackColor = true;
            this.btnDeleteSurvey.Click += new System.EventHandler(this.btnDeleteSurvey_Click);
            // 
            // btnNewSurvey
            // 
            this.btnNewSurvey.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSurvey.Image = global::Consumer_Survey_System.Properties.Resources.icons8_add_file_16;
            this.btnNewSurvey.Location = new System.Drawing.Point(13, 12);
            this.btnNewSurvey.Name = "btnNewSurvey";
            this.btnNewSurvey.Size = new System.Drawing.Size(122, 27);
            this.btnNewSurvey.TabIndex = 13;
            this.btnNewSurvey.Text = "New Survey";
            this.btnNewSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewSurvey.UseVisualStyleBackColor = true;
            this.btnNewSurvey.Click += new System.EventHandler(this.btnNewSurvey_Click);
            // 
            // btnSurveys
            // 
            this.btnSurveys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(49)))));
            this.btnSurveys.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSurveys.FlatAppearance.BorderSize = 0;
            this.btnSurveys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurveys.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurveys.ForeColor = System.Drawing.Color.White;
            this.btnSurveys.Location = new System.Drawing.Point(0, 96);
            this.btnSurveys.Name = "btnSurveys";
            this.btnSurveys.Size = new System.Drawing.Size(254, 48);
            this.btnSurveys.TabIndex = 1;
            this.btnSurveys.Text = "Surveys";
            this.btnSurveys.UseVisualStyleBackColor = false;
            this.btnSurveys.Click += new System.EventHandler(this.btnSurveys_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnMyAccount.Location = new System.Drawing.Point(0, 144);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(254, 48);
            this.btnMyAccount.TabIndex = 2;
            this.btnMyAccount.Text = "My Account";
            this.btnMyAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 192);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Consumer_Survey_System.Properties.Resources.My_Post__3_;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 96);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pbxCategories
            // 
            this.pbxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(49)))));
            this.pbxCategories.Location = new System.Drawing.Point(35, 102);
            this.pbxCategories.Name = "pbxCategories";
            this.pbxCategories.Size = new System.Drawing.Size(36, 36);
            this.pbxCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCategories.TabIndex = 0;
            this.pbxCategories.TabStop = false;
            // 
            // pbxSearch
            // 
            this.pbxSearch.Location = new System.Drawing.Point(23, 150);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(36, 36);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 11;
            this.pbxSearch.TabStop = false;
            // 
            // pbxCart
            // 
            this.pbxCart.Location = new System.Drawing.Point(33, 198);
            this.pbxCart.Name = "pbxCart";
            this.pbxCart.Size = new System.Drawing.Size(36, 36);
            this.pbxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCart.TabIndex = 12;
            this.pbxCart.TabStop = false;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.pnlSideMenu.Controls.Add(this.pbxCart);
            this.pnlSideMenu.Controls.Add(this.pbxSearch);
            this.pnlSideMenu.Controls.Add(this.pbxCategories);
            this.pnlSideMenu.Controls.Add(this.pictureBox3);
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.btnMyAccount);
            this.pnlSideMenu.Controls.Add(this.btnSurveys);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(254, 550);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer Survey System (Admin)";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlSurveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlSurveys;
        private System.Windows.Forms.DataGridView dgvSurveys;
        private System.Windows.Forms.Button btnEditSurvey;
        private System.Windows.Forms.Button btnDeleteSurvey;
        private System.Windows.Forms.Button btnNewSurvey;
        private System.Windows.Forms.Button btnSurveys;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbxCategories;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxCart;
        private System.Windows.Forms.Panel pnlSideMenu;
    }
}