
﻿namespace E_CommerceSystem
{
    partial class Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            this.verify_btn = new Guna.UI2.WinForms.Guna2Button();
            this.user_code = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.error_username = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.user_gmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.resend_code = new Guna.UI2.WinForms.Guna2Button();
            this.verification_countdown = new System.Windows.Forms.Timer(this.components);
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_countdown = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.hiddenPicBoxRef = new System.Windows.Forms.PictureBox();
            this.VerificationPallette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hiddenPicBoxRef)).BeginInit();
            this.SuspendLayout();
            // 
            // verify_btn
            // 
            this.verify_btn.Animated = true;
            this.verify_btn.BorderRadius = 5;
            this.verify_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verify_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verify_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verify_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verify_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.verify_btn.Font = new System.Drawing.Font("League Spartan Thin", 15.75F, System.Drawing.FontStyle.Bold);
            this.verify_btn.ForeColor = System.Drawing.Color.White;
            this.verify_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.verify_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.verify_btn.Location = new System.Drawing.Point(367, 324);
            this.verify_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.verify_btn.Size = new System.Drawing.Size(384, 69);
            this.verify_btn.TabIndex = 13;
            this.verify_btn.Text = "VERIFY";
            this.verify_btn.Tile = true;
            this.verify_btn.Click += new System.EventHandler(this.verify_Click);
            // 
            // user_code
            // 
            this.user_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_code.Location = new System.Drawing.Point(486, 178);
            this.user_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_code.MaxLength = 6;
            this.user_code.Name = "user_code";
            this.user_code.Size = new System.Drawing.Size(129, 43);
            this.user_code.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.user_code.StateCommon.Border.Rounding = 5;
            this.user_code.StateCommon.Border.Width = 1;
            this.user_code.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.user_code.StateCommon.Content.Font = new System.Drawing.Font("Manrope Light", 9.75F);
            this.user_code.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.user_code.TabIndex = 14;
            this.user_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(299, 96);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(520, 28);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Your verification code is sent to your phone number";
            // 
            // error_username
            // 
            this.error_username.Location = new System.Drawing.Point(489, 231);
            this.error_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.error_username.Name = "error_username";
            this.error_username.Size = new System.Drawing.Size(122, 25);
            this.error_username.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.error_username.StateCommon.ShortText.Font = new System.Drawing.Font("Nexa Light", 8.249999F);
            this.error_username.TabIndex = 16;
            this.error_username.Values.Text = "Required field";
            // 
            // user_gmail
            // 
            this.user_gmail.Location = new System.Drawing.Point(457, 134);
            this.user_gmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_gmail.Name = "user_gmail";
            this.user_gmail.Size = new System.Drawing.Size(201, 34);
            this.user_gmail.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.user_gmail.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.user_gmail.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_gmail.TabIndex = 17;
            this.user_gmail.Values.Text = "09xxxxxx461";
            // 
            // resend_code
            // 
            this.resend_code.Animated = true;
            this.resend_code.BorderRadius = 5;
            this.resend_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resend_code.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resend_code.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resend_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resend_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resend_code.FillColor = System.Drawing.Color.White;
            this.resend_code.Font = new System.Drawing.Font("League Spartan Thin", 15.75F, System.Drawing.FontStyle.Bold);
            this.resend_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.resend_code.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.resend_code.HoverState.ForeColor = System.Drawing.Color.White;
            this.resend_code.Location = new System.Drawing.Point(367, 403);
            this.resend_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resend_code.Name = "resend_code";
            this.resend_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resend_code.Size = new System.Drawing.Size(384, 69);
            this.resend_code.TabIndex = 18;
            this.resend_code.Text = "RESEND CODE";
            this.resend_code.Tile = true;
            this.resend_code.Click += new System.EventHandler(this.resend_code_Click);
            // 
            // verification_countdown
            // 
            this.verification_countdown.Interval = 1000;
            this.verification_countdown.Tick += new System.EventHandler(this.verification_countdown_Tick);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(405, 272);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(237, 28);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin Light", 12F);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "The code will expire in:";
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.Location = new System.Drawing.Point(633, 272);
            this.lbl_countdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(52, 28);
            this.lbl_countdown.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.lbl_countdown.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countdown.TabIndex = 20;
            this.lbl_countdown.Values.Text = "60s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("League Spartan Thin", 39.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label1.Location = new System.Drawing.Point(82, -18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1033, 119);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENTER VERIFICATION CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hiddenPicBoxRef
            // 
            this.hiddenPicBoxRef.Location = new System.Drawing.Point(914, 311);
            this.hiddenPicBoxRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hiddenPicBoxRef.Name = "hiddenPicBoxRef";
            this.hiddenPicBoxRef.Size = new System.Drawing.Size(224, 152);
            this.hiddenPicBoxRef.TabIndex = 22;
            this.hiddenPicBoxRef.TabStop = false;
            // 
            // VerificationPallette
            // 
            this.VerificationPallette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("VerificationPallette.ButtonSpecs.FormClose.Image")));
            this.VerificationPallette.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("VerificationPallette.ButtonSpecs.FormMax.Image")));
            this.VerificationPallette.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("VerificationPallette.ButtonSpecs.FormMin.Image")));
            this.VerificationPallette.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VerificationPallette.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VerificationPallette.FormStyles.FormCommon.StateCommon.Border.Width = 0;
            this.VerificationPallette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.VerificationPallette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.VerificationPallette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VerificationPallette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("League Spartan Thin Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.VerificationPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1155, 497);
            this.Controls.Add(this.hiddenPicBoxRef);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_countdown);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.resend_code);
            this.Controls.Add(this.user_gmail);
            this.Controls.Add(this.error_username);
            this.Controls.Add(this.user_code);
            this.Controls.Add(this.verify_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Verification";
            this.Palette = this.VerificationPallette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WANIFY";
            this.TextExtra = "Verification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verification_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verification_FormClosed);
            this.Load += new System.EventHandler(this.Verification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hiddenPicBoxRef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button verify_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox user_code;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel error_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel user_gmail;
        private Guna.UI2.WinForms.Guna2Button resend_code;
        private System.Windows.Forms.Timer verification_countdown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_countdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hiddenPicBoxRef;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette VerificationPallette;
    }
}