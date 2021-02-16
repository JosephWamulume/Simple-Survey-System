namespace Consumer_Survey_System
{
    partial class frmConsumerMain
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pbxCart = new System.Windows.Forms.PictureBox();
            this.pbxCategories = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnAnswerSurvey = new System.Windows.Forms.Button();
            this.dgvSurveys = new System.Windows.Forms.DataGridView();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(42)))));
            this.pnlSideMenu.Controls.Add(this.pbxCart);
            this.pnlSideMenu.Controls.Add(this.pbxCategories);
            this.pnlSideMenu.Controls.Add(this.pictureBox3);
            this.pnlSideMenu.Controls.Add(this.btnCart);
            this.pnlSideMenu.Controls.Add(this.btnCategories);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(254, 550);
            this.pnlSideMenu.TabIndex = 2;
            // 
            // pbxCart
            // 
            this.pbxCart.Location = new System.Drawing.Point(33, 152);
            this.pbxCart.Name = "pbxCart";
            this.pbxCart.Size = new System.Drawing.Size(36, 36);
            this.pbxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCart.TabIndex = 12;
            this.pbxCart.TabStop = false;
            // 
            // pbxCategories
            // 
            this.pbxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(49)))));
            this.pbxCategories.Location = new System.Drawing.Point(35, 102);
            this.pbxCategories.Name = "pbxCategories";
            this.pbxCategories.Size = new System.Drawing.Size(36, 36);
            this.pbxCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCategories.TabIndex = 0;
            this.pbxCategories.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Consumer_Survey_System.Properties.Resources.Cosumer_Survey_System__5_;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 96);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.Black;
            this.btnCart.Location = new System.Drawing.Point(0, 146);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(254, 48);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Logout";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(49)))));
            this.btnCategories.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(0, 96);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(254, 48);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Surveys";
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnAnswerSurvey);
            this.pnlContainer.Controls.Add(this.dgvSurveys);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(254, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(693, 550);
            this.pnlContainer.TabIndex = 3;
            // 
            // btnAnswerSurvey
            // 
            this.btnAnswerSurvey.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerSurvey.Image = global::Consumer_Survey_System.Properties.Resources.icons8_ball_point_pen_16;
            this.btnAnswerSurvey.Location = new System.Drawing.Point(15, 12);
            this.btnAnswerSurvey.Name = "btnAnswerSurvey";
            this.btnAnswerSurvey.Size = new System.Drawing.Size(149, 27);
            this.btnAnswerSurvey.TabIndex = 8;
            this.btnAnswerSurvey.Text = "Answer Survey";
            this.btnAnswerSurvey.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnswerSurvey.UseVisualStyleBackColor = true;
            this.btnAnswerSurvey.Click += new System.EventHandler(this.btnAnswerSurvey_Click);
            // 
            // dgvSurveys
            // 
            this.dgvSurveys.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurveys.Location = new System.Drawing.Point(15, 53);
            this.dgvSurveys.Name = "dgvSurveys";
            this.dgvSurveys.Size = new System.Drawing.Size(666, 485);
            this.dgvSurveys.TabIndex = 7;
            // 
            // frmConsumerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "frmConsumerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer Survey System";
            this.Load += new System.EventHandler(this.frmConsumerMain_Load);
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurveys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.PictureBox pbxCart;
        private System.Windows.Forms.PictureBox pbxCategories;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnAnswerSurvey;
        private System.Windows.Forms.DataGridView dgvSurveys;
    }
}