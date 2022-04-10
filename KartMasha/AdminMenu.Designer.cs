
namespace KartMasha
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btn_volunteers = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_charity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volunteers
            // 
            this.btn_volunteers.BackColor = System.Drawing.Color.Silver;
            this.btn_volunteers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volunteers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_volunteers.Location = new System.Drawing.Point(376, 159);
            this.btn_volunteers.Name = "btn_volunteers";
            this.btn_volunteers.Size = new System.Drawing.Size(257, 65);
            this.btn_volunteers.TabIndex = 136;
            this.btn_volunteers.Text = "Волонтеры";
            this.btn_volunteers.UseVisualStyleBackColor = false;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Silver;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_users.Location = new System.Drawing.Point(57, 159);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(257, 65);
            this.btn_users.TabIndex = 135;
            this.btn_users.Text = "Пользователи";
            this.btn_users.UseVisualStyleBackColor = false;
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_menu.Location = new System.Drawing.Point(256, 113);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(180, 23);
            this.lbl_menu.TabIndex = 134;
            this.lbl_menu.Text = "Меню администратора";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Silver;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(594, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 29);
            this.btn_back.TabIndex = 133;
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
            this.lbl_timer.TabIndex = 132;
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
            this.panel_bottom.TabIndex = 131;
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
            this.lbl_date.TabIndex = 130;
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
            this.lbl_name.TabIndex = 129;
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
            this.panel_top.TabIndex = 128;
            this.panel_top.UseVisualStyleBackColor = false;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Silver;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_inventory.Location = new System.Drawing.Point(377, 249);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(257, 65);
            this.btn_inventory.TabIndex = 138;
            this.btn_inventory.Text = "Инвентарь";
            this.btn_inventory.UseVisualStyleBackColor = false;
            // 
            // btn_charity
            // 
            this.btn_charity.BackColor = System.Drawing.Color.Silver;
            this.btn_charity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_charity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_charity.Location = new System.Drawing.Point(58, 249);
            this.btn_charity.Name = "btn_charity";
            this.btn_charity.Size = new System.Drawing.Size(257, 65);
            this.btn_charity.TabIndex = 137;
            this.btn_charity.Text = "Благотворительные организации";
            this.btn_charity.UseVisualStyleBackColor = false;
            this.btn_charity.Click += new System.EventHandler(this.btn_charity_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_charity);
            this.Controls.Add(this.btn_volunteers);
            this.Controls.Add(this.btn_users);
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
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volunteers;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button panel_bottom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button panel_top;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_charity;
    }
}