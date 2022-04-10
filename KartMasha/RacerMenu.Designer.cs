
namespace KartMasha
{
    partial class RacerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacerMenu));
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_sponsor = new System.Windows.Forms.Button();
            this.btn_kontakts = new System.Windows.Forms.Button();
            this.p_kontakts = new System.Windows.Forms.Panel();
            this.lbl_kontakts = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_phone_num = new System.Windows.Forms.Label();
            this.lbl_email_kartskills = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.p_kontakts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_menu.Location = new System.Drawing.Point(285, 89);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(119, 23);
            this.lbl_menu.TabIndex = 112;
            this.lbl_menu.Text = "Меню гонщика";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Silver;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(594, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 29);
            this.btn_back.TabIndex = 111;
            this.btn_back.Text = "Logout";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_timer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timer.Location = new System.Drawing.Point(111, 421);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(523, 20);
            this.lbl_timer.TabIndex = 110;
            this.lbl_timer.Text = "До начала события осталось 0 лет, 0 месяцев, 0 дней, 0 часов, 0 минут, 0 секунд.";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_bottom.Enabled = false;
            this.panel_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_bottom.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_bottom.Location = new System.Drawing.Point(-28, 409);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(757, 52);
            this.panel_bottom.TabIndex = 109;
            this.panel_bottom.UseVisualStyleBackColor = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_date.Location = new System.Drawing.Point(246, 38);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(193, 20);
            this.lbl_date.TabIndex = 108;
            this.lbl_date.Text = "Москва, Россия 20 июня 2017";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_name.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(254, 7);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(175, 31);
            this.lbl_name.TabIndex = 107;
            this.lbl_name.Text = "Kart Skills 2017";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_top.Enabled = false;
            this.panel_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_top.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel_top.Location = new System.Drawing.Point(-28, -5);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(757, 78);
            this.panel_top.TabIndex = 106;
            this.panel_top.UseVisualStyleBackColor = false;
            // 
            // btn_results
            // 
            this.btn_results.BackColor = System.Drawing.Color.Silver;
            this.btn_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_results.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_results.Location = new System.Drawing.Point(380, 127);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(257, 65);
            this.btn_results.TabIndex = 115;
            this.btn_results.Text = "Мои результаты";
            this.btn_results.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Silver;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit.Location = new System.Drawing.Point(61, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(257, 65);
            this.btn_edit.TabIndex = 114;
            this.btn_edit.Text = "Редактирование профиля";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.Silver;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reg.Location = new System.Drawing.Point(61, 127);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(257, 65);
            this.btn_reg.TabIndex = 113;
            this.btn_reg.Text = "Регистрация на гонку";
            this.btn_reg.UseVisualStyleBackColor = false;
            // 
            // btn_sponsor
            // 
            this.btn_sponsor.BackColor = System.Drawing.Color.Silver;
            this.btn_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sponsor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sponsor.Location = new System.Drawing.Point(380, 212);
            this.btn_sponsor.Name = "btn_sponsor";
            this.btn_sponsor.Size = new System.Drawing.Size(257, 65);
            this.btn_sponsor.TabIndex = 116;
            this.btn_sponsor.Text = "Мой спонсор";
            this.btn_sponsor.UseVisualStyleBackColor = false;
            // 
            // btn_kontakts
            // 
            this.btn_kontakts.BackColor = System.Drawing.Color.Silver;
            this.btn_kontakts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kontakts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_kontakts.Location = new System.Drawing.Point(61, 301);
            this.btn_kontakts.Name = "btn_kontakts";
            this.btn_kontakts.Size = new System.Drawing.Size(257, 65);
            this.btn_kontakts.TabIndex = 117;
            this.btn_kontakts.Text = "Контакты";
            this.btn_kontakts.UseVisualStyleBackColor = false;
            this.btn_kontakts.Click += new System.EventHandler(this.btn_kontakts_Click);
            // 
            // p_kontakts
            // 
            this.p_kontakts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.p_kontakts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_kontakts.Controls.Add(this.lbl_close);
            this.p_kontakts.Controls.Add(this.lbl_email);
            this.p_kontakts.Controls.Add(this.lbl_email_kartskills);
            this.p_kontakts.Controls.Add(this.lbl_phone_num);
            this.p_kontakts.Controls.Add(this.lbl_phone);
            this.p_kontakts.Controls.Add(this.lbl_kontakts);
            this.p_kontakts.Location = new System.Drawing.Point(118, 127);
            this.p_kontakts.Name = "p_kontakts";
            this.p_kontakts.Size = new System.Drawing.Size(464, 239);
            this.p_kontakts.TabIndex = 129;
            this.p_kontakts.Visible = false;
            // 
            // lbl_kontakts
            // 
            this.lbl_kontakts.AutoSize = true;
            this.lbl_kontakts.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_kontakts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kontakts.Location = new System.Drawing.Point(186, 67);
            this.lbl_kontakts.Name = "lbl_kontakts";
            this.lbl_kontakts.Size = new System.Drawing.Size(79, 23);
            this.lbl_kontakts.TabIndex = 113;
            this.lbl_kontakts.Text = "Контакты";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_phone.Location = new System.Drawing.Point(128, 107);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(86, 19);
            this.lbl_phone.TabIndex = 114;
            this.lbl_phone.Text = "Телефон:";
            // 
            // lbl_phone_num
            // 
            this.lbl_phone_num.AutoSize = true;
            this.lbl_phone_num.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_phone_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_phone_num.Location = new System.Drawing.Point(220, 108);
            this.lbl_phone_num.Name = "lbl_phone_num";
            this.lbl_phone_num.Size = new System.Drawing.Size(132, 18);
            this.lbl_phone_num.TabIndex = 115;
            this.lbl_phone_num.Text = "+7 999 999 99 99";
            // 
            // lbl_email_kartskills
            // 
            this.lbl_email_kartskills.AutoSize = true;
            this.lbl_email_kartskills.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email_kartskills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email_kartskills.Location = new System.Drawing.Point(187, 141);
            this.lbl_email_kartskills.Name = "lbl_email_kartskills";
            this.lbl_email_kartskills.Size = new System.Drawing.Size(152, 18);
            this.lbl_email_kartskills.TabIndex = 116;
            this.lbl_email_kartskills.Text = "yugkug@kartskill.org";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email.Location = new System.Drawing.Point(128, 141);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 19);
            this.lbl_email.TabIndex = 117;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_close.Location = new System.Drawing.Point(437, 0);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 23);
            this.lbl_close.TabIndex = 118;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // RacerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.p_kontakts);
            this.Controls.Add(this.btn_kontakts);
            this.Controls.Add(this.btn_sponsor);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 495);
            this.MinimumSize = new System.Drawing.Size(716, 495);
            this.Name = "RacerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            this.p_kontakts.ResumeLayout(false);
            this.p_kontakts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button panel_bottom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button panel_top;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_sponsor;
        private System.Windows.Forms.Button btn_kontakts;
        private System.Windows.Forms.Panel p_kontakts;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_email_kartskills;
        private System.Windows.Forms.Label lbl_phone_num;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_kontakts;
        private System.Windows.Forms.Label lbl_close;
    }
}