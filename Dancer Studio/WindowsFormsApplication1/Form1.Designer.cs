namespace WindowsFormsApplication1
{
    partial class dancerInformation
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
            this.lblNumOfDancers = new System.Windows.Forms.Label();
            this.txtNumOfDancers = new System.Windows.Forms.TextBox();
            this.lblDancerName = new System.Windows.Forms.Label();
            this.txtDancerName = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblIdNum = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtIdNum = new System.Windows.Forms.TextBox();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.lblMomHos = new System.Windows.Forms.Label();
            this.lblMomCountry = new System.Windows.Forms.Label();
            this.lblMomYear = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMomHos = new System.Windows.Forms.TextBox();
            this.txtMomCountry = new System.Windows.Forms.TextBox();
            this.txtMomYear = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPerNum = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPerNum = new System.Windows.Forms.Label();
            this.btnNumOfDancers = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNumOfDancers
            // 
            this.lblNumOfDancers.AutoSize = true;
            this.lblNumOfDancers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfDancers.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfDancers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumOfDancers.Location = new System.Drawing.Point(35, 387);
            this.lblNumOfDancers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfDancers.Name = "lblNumOfDancers";
            this.lblNumOfDancers.Size = new System.Drawing.Size(218, 30);
            this.lblNumOfDancers.TabIndex = 0;
            this.lblNumOfDancers.Text = "Number Of Dancers";
            // 
            // txtNumOfDancers
            // 
            this.txtNumOfDancers.BackColor = System.Drawing.Color.Linen;
            this.txtNumOfDancers.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfDancers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumOfDancers.Location = new System.Drawing.Point(40, 433);
            this.txtNumOfDancers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumOfDancers.Name = "txtNumOfDancers";
            this.txtNumOfDancers.Size = new System.Drawing.Size(121, 28);
            this.txtNumOfDancers.TabIndex = 1;
            this.txtNumOfDancers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumOfDancers_KeyDown);
            this.txtNumOfDancers.Leave += new System.EventHandler(this.txtNumOfDancers_Leave);
            // 
            // lblDancerName
            // 
            this.lblDancerName.AutoSize = true;
            this.lblDancerName.BackColor = System.Drawing.Color.Transparent;
            this.lblDancerName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDancerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDancerName.Location = new System.Drawing.Point(36, 88);
            this.lblDancerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDancerName.Name = "lblDancerName";
            this.lblDancerName.Size = new System.Drawing.Size(121, 21);
            this.lblDancerName.TabIndex = 2;
            this.lblDancerName.Text = "Dancer\'s Name";
            // 
            // txtDancerName
            // 
            this.txtDancerName.BackColor = System.Drawing.Color.Linen;
            this.txtDancerName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDancerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDancerName.Location = new System.Drawing.Point(445, 85);
            this.txtDancerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDancerName.Name = "txtDancerName";
            this.txtDancerName.Size = new System.Drawing.Size(148, 28);
            this.txtDancerName.TabIndex = 3;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetails.Location = new System.Drawing.Point(13, 9);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(233, 27);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Enter Dancer\'s Details:";
            // 
            // lblIdNum
            // 
            this.lblIdNum.AutoSize = true;
            this.lblIdNum.BackColor = System.Drawing.Color.Transparent;
            this.lblIdNum.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdNum.Location = new System.Drawing.Point(36, 126);
            this.lblIdNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNum.Name = "lblIdNum";
            this.lblIdNum.Size = new System.Drawing.Size(92, 21);
            this.lblIdNum.TabIndex = 5;
            this.lblIdNum.Text = "ID Number";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.BackColor = System.Drawing.Color.Transparent;
            this.lblHospitalName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHospitalName.Location = new System.Drawing.Point(36, 162);
            this.lblHospitalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(115, 21);
            this.lblHospitalName.TabIndex = 6;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCountry.Location = new System.Drawing.Point(36, 208);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(108, 21);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Birth Country";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(36, 240);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(86, 21);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Birth Year";
            // 
            // txtIdNum
            // 
            this.txtIdNum.BackColor = System.Drawing.Color.Linen;
            this.txtIdNum.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdNum.Location = new System.Drawing.Point(445, 123);
            this.txtIdNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Size = new System.Drawing.Size(148, 28);
            this.txtIdNum.TabIndex = 9;
            // 
            // txtHospital
            // 
            this.txtHospital.BackColor = System.Drawing.Color.Linen;
            this.txtHospital.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospital.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHospital.Location = new System.Drawing.Point(445, 162);
            this.txtHospital.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(148, 28);
            this.txtHospital.TabIndex = 10;
            // 
            // lblMomHos
            // 
            this.lblMomHos.AutoSize = true;
            this.lblMomHos.BackColor = System.Drawing.Color.Transparent;
            this.lblMomHos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMomHos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMomHos.Location = new System.Drawing.Point(33, 359);
            this.lblMomHos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMomHos.Name = "lblMomHos";
            this.lblMomHos.Size = new System.Drawing.Size(188, 21);
            this.lblMomHos.TabIndex = 11;
            this.lblMomHos.Text = "Mother\'s Hospital Name";
            // 
            // lblMomCountry
            // 
            this.lblMomCountry.AutoSize = true;
            this.lblMomCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblMomCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMomCountry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMomCountry.Location = new System.Drawing.Point(36, 396);
            this.lblMomCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMomCountry.Name = "lblMomCountry";
            this.lblMomCountry.Size = new System.Drawing.Size(181, 21);
            this.lblMomCountry.TabIndex = 12;
            this.lblMomCountry.Text = "Mother\'s Birth Country";
            // 
            // lblMomYear
            // 
            this.lblMomYear.AutoSize = true;
            this.lblMomYear.BackColor = System.Drawing.Color.Transparent;
            this.lblMomYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMomYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMomYear.Location = new System.Drawing.Point(36, 436);
            this.lblMomYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMomYear.Name = "lblMomYear";
            this.lblMomYear.Size = new System.Drawing.Size(157, 21);
            this.lblMomYear.TabIndex = 13;
            this.lblMomYear.Text = "Mother\'s Birth year";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.Linen;
            this.txtCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCountry.Location = new System.Drawing.Point(445, 199);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(148, 28);
            this.txtCountry.TabIndex = 14;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Linen;
            this.txtYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYear.Location = new System.Drawing.Point(445, 237);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(148, 28);
            this.txtYear.TabIndex = 15;
            // 
            // txtMomHos
            // 
            this.txtMomHos.BackColor = System.Drawing.Color.Linen;
            this.txtMomHos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMomHos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMomHos.Location = new System.Drawing.Point(445, 356);
            this.txtMomHos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMomHos.Name = "txtMomHos";
            this.txtMomHos.Size = new System.Drawing.Size(148, 28);
            this.txtMomHos.TabIndex = 16;
            // 
            // txtMomCountry
            // 
            this.txtMomCountry.BackColor = System.Drawing.Color.Linen;
            this.txtMomCountry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMomCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMomCountry.Location = new System.Drawing.Point(445, 393);
            this.txtMomCountry.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMomCountry.Name = "txtMomCountry";
            this.txtMomCountry.Size = new System.Drawing.Size(148, 28);
            this.txtMomCountry.TabIndex = 17;
            // 
            // txtMomYear
            // 
            this.txtMomYear.BackColor = System.Drawing.Color.Linen;
            this.txtMomYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMomYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMomYear.Location = new System.Drawing.Point(445, 433);
            this.txtMomYear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMomYear.Name = "txtMomYear";
            this.txtMomYear.Size = new System.Drawing.Size(148, 28);
            this.txtMomYear.TabIndex = 18;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Linen;
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOk.Location = new System.Drawing.Point(445, 474);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(148, 28);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPerNum
            // 
            this.txtPerNum.BackColor = System.Drawing.Color.Linen;
            this.txtPerNum.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPerNum.Location = new System.Drawing.Point(445, 315);
            this.txtPerNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPerNum.Name = "txtPerNum";
            this.txtPerNum.Size = new System.Drawing.Size(148, 28);
            this.txtPerNum.TabIndex = 21;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Linen;
            this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(445, 506);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(148, 28);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show Details";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtShow
            // 
            this.txtShow.BackColor = System.Drawing.Color.Linen;
            this.txtShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(613, 0);
            this.txtShow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(553, 571);
            this.txtShow.TabIndex = 23;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(36, 279);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 21);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Dance Type";
            // 
            // lblPerNum
            // 
            this.lblPerNum.AutoSize = true;
            this.lblPerNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPerNum.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerNum.Location = new System.Drawing.Point(36, 318);
            this.lblPerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerNum.Name = "lblPerNum";
            this.lblPerNum.Size = new System.Drawing.Size(178, 21);
            this.lblPerNum.TabIndex = 25;
            this.lblPerNum.Text = "Monthly Performances ";
            // 
            // btnNumOfDancers
            // 
            this.btnNumOfDancers.BackColor = System.Drawing.Color.Linen;
            this.btnNumOfDancers.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumOfDancers.Location = new System.Drawing.Point(216, 433);
            this.btnNumOfDancers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNumOfDancers.Name = "btnNumOfDancers";
            this.btnNumOfDancers.Size = new System.Drawing.Size(37, 28);
            this.btnNumOfDancers.TabIndex = 26;
            this.btnNumOfDancers.Text = ">>";
            this.btnNumOfDancers.UseVisualStyleBackColor = false;
            this.btnNumOfDancers.Click += new System.EventHandler(this.btnNumOfDancers_Click);
            // 
            // cboxType
            // 
            this.cboxType.BackColor = System.Drawing.Color.Linen;
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Ballet",
            "Breakdance",
            "Debka",
            "Flamenco",
            "Salsa",
            "Tango",
            "Waltz"});
            this.cboxType.Location = new System.Drawing.Point(445, 281);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(148, 23);
            this.cboxType.TabIndex = 30;
            // 
            // dancerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1162, 570);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.btnNumOfDancers);
            this.Controls.Add(this.lblPerNum);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPerNum);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMomYear);
            this.Controls.Add(this.txtMomCountry);
            this.Controls.Add(this.txtMomHos);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblMomYear);
            this.Controls.Add(this.lblMomCountry);
            this.Controls.Add(this.lblMomHos);
            this.Controls.Add(this.txtHospital);
            this.Controls.Add(this.txtIdNum);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.lblIdNum);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDancerName);
            this.Controls.Add(this.lblDancerName);
            this.Controls.Add(this.txtNumOfDancers);
            this.Controls.Add(this.lblNumOfDancers);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "dancerInformation";
            this.Text = "Dancers Information System";
            this.Load += new System.EventHandler(this.dancerInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfDancers;
        private System.Windows.Forms.TextBox txtNumOfDancers;
        private System.Windows.Forms.Label lblDancerName;
        private System.Windows.Forms.TextBox txtDancerName;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblIdNum;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtIdNum;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblMomHos;
        private System.Windows.Forms.Label lblMomCountry;
        private System.Windows.Forms.Label lblMomYear;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPerNum;
        private System.Windows.Forms.TextBox txtMomHos;
        private System.Windows.Forms.TextBox txtMomCountry;
        private System.Windows.Forms.TextBox txtMomYear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPerNum;
        private System.Windows.Forms.Button btnNumOfDancers;
        private System.Windows.Forms.ComboBox cboxType;
    }
}

