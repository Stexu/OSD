namespace OSD
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rb_MM_Local = new System.Windows.Forms.RadioButton();
            this.rb_MM_Server = new System.Windows.Forms.RadioButton();
            this.lbl_main_header = new System.Windows.Forms.Label();
            this.clb_Software = new System.Windows.Forms.CheckedListBox();
            this.gb_Mode = new System.Windows.Forms.GroupBox();
            this.btn_load_software = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_status = new System.Windows.Forms.RichTextBox();
            this.gb_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_MM_Local
            // 
            this.rb_MM_Local.AutoSize = true;
            this.rb_MM_Local.Checked = true;
            this.rb_MM_Local.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_MM_Local.Location = new System.Drawing.Point(6, 24);
            this.rb_MM_Local.Name = "rb_MM_Local";
            this.rb_MM_Local.Size = new System.Drawing.Size(370, 22);
            this.rb_MM_Local.TabIndex = 0;
            this.rb_MM_Local.TabStop = true;
            this.rb_MM_Local.Text = "Lokal (für die Nutzung mit einem USB Stick)";
            this.rb_MM_Local.UseVisualStyleBackColor = true;
            this.rb_MM_Local.CheckedChanged += new System.EventHandler(this.rb_MM_Local_CheckedChanged);
            // 
            // rb_MM_Server
            // 
            this.rb_MM_Server.AutoSize = true;
            this.rb_MM_Server.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_MM_Server.Location = new System.Drawing.Point(6, 47);
            this.rb_MM_Server.Name = "rb_MM_Server";
            this.rb_MM_Server.Size = new System.Drawing.Size(194, 22);
            this.rb_MM_Server.TabIndex = 1;
            this.rb_MM_Server.Text = "Server (not yet done)";
            this.rb_MM_Server.UseVisualStyleBackColor = true;
            this.rb_MM_Server.CheckedChanged += new System.EventHandler(this.rb_MM_Server_CheckedChanged);
            // 
            // lbl_main_header
            // 
            this.lbl_main_header.AutoSize = true;
            this.lbl_main_header.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_main_header.Location = new System.Drawing.Point(52, 14);
            this.lbl_main_header.Name = "lbl_main_header";
            this.lbl_main_header.Size = new System.Drawing.Size(778, 41);
            this.lbl_main_header.TabIndex = 2;
            this.lbl_main_header.Text = "Open Software Deployment Client by Stexu";
            // 
            // clb_Software
            // 
            this.clb_Software.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_Software.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.clb_Software.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Software.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.clb_Software.FormattingEnabled = true;
            this.clb_Software.Location = new System.Drawing.Point(835, 90);
            this.clb_Software.Name = "clb_Software";
            this.clb_Software.Size = new System.Drawing.Size(555, 559);
            this.clb_Software.TabIndex = 3;
            // 
            // gb_Mode
            // 
            this.gb_Mode.BackColor = System.Drawing.Color.Transparent;
            this.gb_Mode.Controls.Add(this.rb_MM_Server);
            this.gb_Mode.Controls.Add(this.rb_MM_Local);
            this.gb_Mode.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.gb_Mode.Location = new System.Drawing.Point(59, 75);
            this.gb_Mode.Name = "gb_Mode";
            this.gb_Mode.Size = new System.Drawing.Size(523, 72);
            this.gb_Mode.TabIndex = 6;
            this.gb_Mode.TabStop = false;
            this.gb_Mode.Text = "Mode";
            // 
            // btn_load_software
            // 
            this.btn_load_software.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btn_load_software.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load_software.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_software.Location = new System.Drawing.Point(59, 221);
            this.btn_load_software.Name = "btn_load_software";
            this.btn_load_software.Size = new System.Drawing.Size(130, 25);
            this.btn_load_software.TabIndex = 7;
            this.btn_load_software.Text = "Load Software";
            this.btn_load_software.UseVisualStyleBackColor = false;
            this.btn_load_software.Click += new System.EventHandler(this.btn_load_software_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.BackColor = System.Drawing.Color.Transparent;
            this.lbl_path.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lbl_path.Location = new System.Drawing.Point(61, 169);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(70, 22);
            this.lbl_path.TabIndex = 8;
            this.lbl_path.Text = "Pfad: ";
            this.lbl_path.Click += new System.EventHandler(this.lbl_path_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Install Software!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_status
            // 
            this.rtb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rtb_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.rtb_status.Location = new System.Drawing.Point(61, 275);
            this.rtb_status.Name = "rtb_status";
            this.rtb_status.Size = new System.Drawing.Size(768, 281);
            this.rtb_status.TabIndex = 10;
            this.rtb_status.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1402, 686);
            this.Controls.Add(this.rtb_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_load_software);
            this.Controls.Add(this.gb_Mode);
            this.Controls.Add(this.clb_Software);
            this.Controls.Add(this.lbl_main_header);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OSD Deployment Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Mode.ResumeLayout(false);
            this.gb_Mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_MM_Local;
        private System.Windows.Forms.RadioButton rb_MM_Server;
        private System.Windows.Forms.Label lbl_main_header;
        private System.Windows.Forms.CheckedListBox clb_Software;
        private System.Windows.Forms.GroupBox gb_Mode;
        private System.Windows.Forms.Button btn_load_software;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_status;
    }
}

