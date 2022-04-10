
namespace KartMasha
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel_top = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_reg_racer = new System.Windows.Forms.Label();
            this.lbl_reg_sponsor = new System.Windows.Forms.Label();
            this.lbl_information = new System.Windows.Forms.Label();
            this.lbl_authorization = new System.Windows.Forms.Label();
            this.pb_authorization = new System.Windows.Forms.PictureBox();
            this.pb_information = new System.Windows.Forms.PictureBox();
            this.pb_reg_sponsor = new System.Windows.Forms.PictureBox();
            this.pb_reg_racer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_authorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reg_sponsor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reg_racer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_top.Enabled = false;
            this.panel_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_top.Location = new System.Drawing.Point(-25, -3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(757, 78);
            this.panel_top.TabIndex = 0;
            this.panel_top.UseVisualStyleBackColor = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_bottom.Enabled = false;
            this.panel_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_bottom.Location = new System.Drawing.Point(-43, 415);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(757, 52);
            this.panel_bottom.TabIndex = 1;
            this.panel_bottom.UseVisualStyleBackColor = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_name.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(257, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(175, 31);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Kart Skills 2017";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_date.Location = new System.Drawing.Point(249, 40);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(193, 20);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Москва, Россия 20 июня 2017";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_timer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timer.Location = new System.Drawing.Point(96, 427);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(523, 20);
            this.lbl_timer.TabIndex = 4;
            this.lbl_timer.Text = "До начала события осталось 0 лет, 0 месяцев, 0 дней, 0 часов, 0 минут, 0 секунд.";
            // 
            // lbl_reg_racer
            // 
            this.lbl_reg_racer.AutoSize = true;
            this.lbl_reg_racer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_reg_racer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_reg_racer.Location = new System.Drawing.Point(53, 281);
            this.lbl_reg_racer.Name = "lbl_reg_racer";
            this.lbl_reg_racer.Size = new System.Drawing.Size(142, 20);
            this.lbl_reg_racer.TabIndex = 9;
            this.lbl_reg_racer.Text = "Регистрация гонщика";
            this.lbl_reg_racer.Click += new System.EventHandler(this.lbl_reg_racer_Click);
            // 
            // lbl_reg_sponsor
            // 
            this.lbl_reg_sponsor.AutoSize = true;
            this.lbl_reg_sponsor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_reg_sponsor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_reg_sponsor.Location = new System.Drawing.Point(201, 281);
            this.lbl_reg_sponsor.Name = "lbl_reg_sponsor";
            this.lbl_reg_sponsor.Size = new System.Drawing.Size(150, 20);
            this.lbl_reg_sponsor.TabIndex = 10;
            this.lbl_reg_sponsor.Text = "Регистрация спонсора";
            this.lbl_reg_sponsor.Click += new System.EventHandler(this.lbl_reg_sponsor_Click);
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_information.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_information.Location = new System.Drawing.Point(385, 281);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(75, 20);
            this.lbl_information.TabIndex = 11;
            this.lbl_information.Text = "О событии";
            this.lbl_information.Click += new System.EventHandler(this.lbl_information_Click);
            // 
            // lbl_authorization
            // 
            this.lbl_authorization.AutoSize = true;
            this.lbl_authorization.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_authorization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_authorization.Location = new System.Drawing.Point(525, 281);
            this.lbl_authorization.Name = "lbl_authorization";
            this.lbl_authorization.Size = new System.Drawing.Size(106, 20);
            this.lbl_authorization.TabIndex = 12;
            this.lbl_authorization.Text = "Вход в систему";
            this.lbl_authorization.Click += new System.EventHandler(this.lbl_authorization_Click);
            // 
            // pb_authorization
            // 
            this.pb_authorization.BackgroundImage = global::KartMasha.Properties.Resources.Klyuch;
            this.pb_authorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_authorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_authorization.Location = new System.Drawing.Point(529, 167);
            this.pb_authorization.Name = "pb_authorization";
            this.pb_authorization.Size = new System.Drawing.Size(108, 111);
            this.pb_authorization.TabIndex = 8;
            this.pb_authorization.TabStop = false;
            this.pb_authorization.Click += new System.EventHandler(this.pb_authorization_Click);
            // 
            // pb_information
            // 
            this.pb_information.BackgroundImage = global::KartMasha.Properties.Resources.Informatsia;
            this.pb_information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_information.Location = new System.Drawing.Point(372, 167);
            this.pb_information.Name = "pb_information";
            this.pb_information.Size = new System.Drawing.Size(108, 111);
            this.pb_information.TabIndex = 7;
            this.pb_information.TabStop = false;
            this.pb_information.Click += new System.EventHandler(this.pb_information_Click);
            // 
            // pb_reg_sponsor
            // 
            this.pb_reg_sponsor.BackgroundImage = global::KartMasha.Properties.Resources.Dengi;
            this.pb_reg_sponsor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_reg_sponsor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_reg_sponsor.Location = new System.Drawing.Point(219, 167);
            this.pb_reg_sponsor.Name = "pb_reg_sponsor";
            this.pb_reg_sponsor.Size = new System.Drawing.Size(108, 111);
            this.pb_reg_sponsor.TabIndex = 6;
            this.pb_reg_sponsor.TabStop = false;
            this.pb_reg_sponsor.Click += new System.EventHandler(this.pb_reg_sponsor_Click);
            // 
            // pb_reg_racer
            // 
            this.pb_reg_racer.BackgroundImage = global::KartMasha.Properties.Resources.Shlem;
            this.pb_reg_racer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_reg_racer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_reg_racer.Location = new System.Drawing.Point(67, 167);
            this.pb_reg_racer.Name = "pb_reg_racer";
            this.pb_reg_racer.Size = new System.Drawing.Size(108, 111);
            this.pb_reg_racer.TabIndex = 5;
            this.pb_reg_racer.TabStop = false;
            this.pb_reg_racer.Click += new System.EventHandler(this.pb_reg_racer_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.lbl_authorization);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.lbl_reg_sponsor);
            this.Controls.Add(this.lbl_reg_racer);
            this.Controls.Add(this.pb_authorization);
            this.Controls.Add(this.pb_information);
            this.Controls.Add(this.pb_reg_sponsor);
            this.Controls.Add(this.pb_reg_racer);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 495);
            this.MinimumSize = new System.Drawing.Size(716, 495);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            ((System.ComponentModel.ISupportInitialize)(this.pb_authorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reg_sponsor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reg_racer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button panel_top;
        private System.Windows.Forms.Button panel_bottom;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.PictureBox pb_reg_racer;
        private System.Windows.Forms.PictureBox pb_reg_sponsor;
        private System.Windows.Forms.PictureBox pb_information;
        private System.Windows.Forms.PictureBox pb_authorization;
        private System.Windows.Forms.Label lbl_reg_racer;
        private System.Windows.Forms.Label lbl_reg_sponsor;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Label lbl_authorization;
    }
}

