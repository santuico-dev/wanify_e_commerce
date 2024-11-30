namespace E_CommerceSystem
{
    partial class ProductReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductReturnForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeNumber = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMainConcern = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAction = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccDetails = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdditional = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.proofPictureBox = new System.Windows.Forms.PictureBox();
            this.signUpPallette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proofPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Manrope ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proof:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Manrope SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(24, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Main Concern:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Manrope ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.lblProduct.Location = new System.Drawing.Point(23, 9);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(159, 22);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Defective Product:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Manrope ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(224, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "CLICK THE BOX";
            // 
            // btnChangeNumber
            // 
            this.btnChangeNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeNumber.Location = new System.Drawing.Point(439, 563);
            this.btnChangeNumber.Name = "btnChangeNumber";
            this.btnChangeNumber.Size = new System.Drawing.Size(87, 27);
            this.btnChangeNumber.TabIndex = 18;
            this.btnChangeNumber.Text = "Change";
            this.btnChangeNumber.UseVisualStyleBackColor = false;
            this.btnChangeNumber.Click += new System.EventHandler(this.btnChangeNumber_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Manrope SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label7.Location = new System.Drawing.Point(24, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Requirements in uploading a photo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label8.Location = new System.Drawing.Point(23, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "1. The first image box is a photo of the product showing your main concern";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label9.Location = new System.Drawing.Point(23, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "2. Picture is clear and not blurry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Manrope", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(20, 598);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "*Make sure the gcash account is verified*";
            // 
            // cmbMainConcern
            // 
            this.cmbMainConcern.BackColor = System.Drawing.Color.Transparent;
            this.cmbMainConcern.BorderRadius = 5;
            this.cmbMainConcern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMainConcern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainConcern.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMainConcern.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMainConcern.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMainConcern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMainConcern.ItemHeight = 30;
            this.cmbMainConcern.Location = new System.Drawing.Point(23, 362);
            this.cmbMainConcern.Name = "cmbMainConcern";
            this.cmbMainConcern.Size = new System.Drawing.Size(507, 36);
            this.cmbMainConcern.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Manrope SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label10.Location = new System.Drawing.Point(23, 411);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Action:";
            // 
            // cmbAction
            // 
            this.cmbAction.BackColor = System.Drawing.Color.Transparent;
            this.cmbAction.BorderRadius = 5;
            this.cmbAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAction.ItemHeight = 30;
            this.cmbAction.Location = new System.Drawing.Point(23, 432);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(507, 36);
            this.cmbAction.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Manrope SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(20, 538);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Phone Number:";
            // 
            // cmbAccDetails
            // 
            this.cmbAccDetails.BackColor = System.Drawing.Color.Transparent;
            this.cmbAccDetails.BorderRadius = 5;
            this.cmbAccDetails.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAccDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccDetails.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAccDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAccDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAccDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAccDetails.ItemHeight = 30;
            this.cmbAccDetails.Location = new System.Drawing.Point(23, 489);
            this.cmbAccDetails.Name = "cmbAccDetails";
            this.cmbAccDetails.Size = new System.Drawing.Size(507, 36);
            this.cmbAccDetails.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Manrope SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.label11.Location = new System.Drawing.Point(20, 632);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Additional Info (Optional)";
            // 
            // txtAdditional
            // 
            this.txtAdditional.Location = new System.Drawing.Point(23, 653);
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(507, 86);
            this.txtAdditional.TabIndex = 32;
            this.txtAdditional.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Animated = true;
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.btnSubmit.Font = new System.Drawing.Font("Manrope ExtraBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(130, 757);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(265, 40);
            this.btnSubmit.TabIndex = 77;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnSubmit.Tile = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderRadius = 5;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(23, 559);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(507, 36);
            this.txtPhoneNumber.TabIndex = 30;
            // 
            // proofPictureBox
            // 
            this.proofPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.proofPictureBox.Location = new System.Drawing.Point(175, 71);
            this.proofPictureBox.Name = "proofPictureBox";
            this.proofPictureBox.Size = new System.Drawing.Size(202, 185);
            this.proofPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proofPictureBox.TabIndex = 5;
            this.proofPictureBox.TabStop = false;
            this.proofPictureBox.Click += new System.EventHandler(this.proofPictureBox_Click);
            // 
            // signUpPallette
            // 
            this.signUpPallette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("signUpPallette.ButtonSpecs.FormClose.Image")));
            this.signUpPallette.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("signUpPallette.ButtonSpecs.FormMax.Image")));
            this.signUpPallette.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("signUpPallette.ButtonSpecs.FormMin.Image")));
            this.signUpPallette.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signUpPallette.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signUpPallette.FormStyles.FormCommon.StateCommon.Border.Width = 0;
            this.signUpPallette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.signUpPallette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.signUpPallette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signUpPallette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(191)))));
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.signUpPallette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ProductReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(547, 820);
            this.Controls.Add(this.btnChangeNumber);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAdditional);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cmbAccDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAction);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMainConcern);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proofPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductReturnForm";
            this.Palette = this.signUpPallette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "WANIFY";
            this.Load += new System.EventHandler(this.ProductReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proofPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox proofPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMainConcern;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAction;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAccDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtAdditional;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette signUpPallette;
    }
}