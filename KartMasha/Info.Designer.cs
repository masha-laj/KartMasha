
namespace KartMasha
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.btn_kartskills = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_charity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kartskills
            // 
            this.btn_kartskills.BackColor = System.Drawing.Color.Silver;
            this.btn_kartskills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kartskills.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_kartskills.Location = new System.Drawing.Point(58, 144);
            this.btn_kartskills.Name = "btn_kartskills";
            this.btn_kartskills.Size = new System.Drawing.Size(257, 65);
            this.btn_kartskills.TabIndex = 65;
            this.btn_kartskills.Text = "Kart Skills 2017";
            this.btn_kartskills.UseVisualStyleBackColor = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(260, 98);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(191, 23);
            this.lbl_info.TabIndex = 43;
            this.lbl_info.Text = "Подробная информация";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Silver;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(32, 19);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 29);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "Назад";
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
            this.lbl_timer.TabIndex = 40;
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
            this.panel_bottom.TabIndex = 39;
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
            this.lbl_date.TabIndex = 38;
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
            this.lbl_name.TabIndex = 37;
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
            this.panel_top.TabIndex = 36;
            this.panel_top.UseVisualStyleBackColor = false;
            // 
            // btn_results
            // 
            this.btn_results.BackColor = System.Drawing.Color.Silver;
            this.btn_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_results.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_results.Location = new System.Drawing.Point(58, 229);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(257, 65);
            this.btn_results.TabIndex = 66;
            this.btn_results.Text = "Предыдущие результаты";
            this.btn_results.UseVisualStyleBackColor = false;
            // 
            // btn_charity
            // 
            this.btn_charity.BackColor = System.Drawing.Color.Silver;
            this.btn_charity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_charity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_charity.Location = new System.Drawing.Point(377, 144);
            this.btn_charity.Name = "btn_charity";
            this.btn_charity.Size = new System.Drawing.Size(257, 65);
            this.btn_charity.TabIndex = 67;
            this.btn_charity.Text = "Список благотворительных организаций";
            this.btn_charity.UseVisualStyleBackColor = false;
            this.btn_charity.Click += new System.EventHandler(this.btn_charity_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.btn_charity);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.btn_kartskills);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 495);
            this.MinimumSize = new System.Drawing.Size(716, 495);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kartskills;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button panel_bottom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button panel_top;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_charity;
    }
}