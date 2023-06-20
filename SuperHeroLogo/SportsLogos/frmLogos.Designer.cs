namespace SportsLogos
{
    partial class frmLogos
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
            this.lblCItyName = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.cboCityName = new System.Windows.Forms.ComboBox();
            this.cboTeamName = new System.Windows.Forms.ComboBox();
            this.chkShowStatistics = new System.Windows.Forms.CheckBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCItyName
            // 
            this.lblCItyName.BackColor = System.Drawing.Color.Cyan;
            this.lblCItyName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCItyName.Location = new System.Drawing.Point(142, 44);
            this.lblCItyName.Name = "lblCItyName";
            this.lblCItyName.Size = new System.Drawing.Size(210, 41);
            this.lblCItyName.TabIndex = 5;
            this.lblCItyName.Text = "City Name:";
            this.lblCItyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamName
            // 
            this.lblTeamName.BackColor = System.Drawing.Color.Cyan;
            this.lblTeamName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(395, 44);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(210, 41);
            this.lblTeamName.TabIndex = 6;
            this.lblTeamName.Text = "Team Name:";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCityName
            // 
            this.cboCityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCityName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCityName.FormattingEnabled = true;
            this.cboCityName.Location = new System.Drawing.Point(145, 104);
            this.cboCityName.Name = "cboCityName";
            this.cboCityName.Size = new System.Drawing.Size(207, 45);
            this.cboCityName.TabIndex = 0;
            this.cboCityName.SelectedIndexChanged += new System.EventHandler(this.cboCityName_SelectedIndexChanged);
            // 
            // cboTeamName
            // 
            this.cboTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeamName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTeamName.FormattingEnabled = true;
            this.cboTeamName.Location = new System.Drawing.Point(398, 104);
            this.cboTeamName.Name = "cboTeamName";
            this.cboTeamName.Size = new System.Drawing.Size(207, 45);
            this.cboTeamName.TabIndex = 4;
            this.cboTeamName.SelectedIndexChanged += new System.EventHandler(this.cboTeamName_SelectedIndexChanged);
            // 
            // chkShowStatistics
            // 
            this.chkShowStatistics.AutoSize = true;
            this.chkShowStatistics.BackColor = System.Drawing.Color.Cyan;
            this.chkShowStatistics.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowStatistics.Location = new System.Drawing.Point(402, 171);
            this.chkShowStatistics.Name = "chkShowStatistics";
            this.chkShowStatistics.Size = new System.Drawing.Size(232, 41);
            this.chkShowStatistics.TabIndex = 3;
            this.chkShowStatistics.Text = "Show Statistics";
            this.chkShowStatistics.UseVisualStyleBackColor = false;
            this.chkShowStatistics.CheckedChanged += new System.EventHandler(this.chkShowStatistics_CheckedChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(145, 171);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(207, 245);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(398, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(202, 67);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(398, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.chkShowStatistics);
            this.Controls.Add(this.cboTeamName);
            this.Controls.Add(this.cboCityName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCItyName);
            this.Name = "frmLogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Logo App";
            this.Load += new System.EventHandler(this.frmLogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCItyName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cboCityName;
        private System.Windows.Forms.ComboBox cboTeamName;
        private System.Windows.Forms.CheckBox chkShowStatistics;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

