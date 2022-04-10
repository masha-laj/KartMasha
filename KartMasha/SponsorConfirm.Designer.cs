
namespace KartMasha
{
    partial class SponsorConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SponsorConfirm));
            this.lbl_racer = new System.Windows.Forms.Label();
            this.lbl_thank = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Button();
            this.lbl_sum_num = new System.Windows.Forms.Label();
            this.lbl_dollar = new System.Windows.Forms.Label();
            this.lbl_fund = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_racer
            // 
            this.lbl_racer.AutoSize = true;
            this.lbl_racer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_racer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_racer.Location = new System.Drawing.Point(252, 143);
            this.lbl_racer.Name = "lbl_racer";
            this.lbl_racer.Size = new System.Drawing.Size(190, 25);
            this.lbl_racer.TabIndex = 44;
            this.lbl_racer.Text = "Гонщик (0) из Country";
            // 
            // lbl_thank
            // 
            this.lbl_thank.AutoSize = true;
            this.lbl_thank.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_thank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_thank.Location = new System.Drawing.Point(208, 99);
            this.lbl_thank.Name = "lbl_thank";
            this.lbl_thank.Size = new System.Drawing.Size(276, 23);
            this.lbl_thank.TabIndex = 42;
            this.lbl_thank.Text = "Спасибо за спонсорскую поддержку!";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Silver;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(300, 337);
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
            // lbl_sum_num
            // 
            this.lbl_sum_num.AutoSize = true;
            this.lbl_sum_num.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sum_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sum_num.Location = new System.Drawing.Point(334, 233);
            this.lbl_sum_num.Name = "lbl_sum_num";
            this.lbl_sum_num.Size = new System.Drawing.Size(61, 75);
            this.lbl_sum_num.TabIndex = 70;
            this.lbl_sum_num.Text = "0";
            // 
            // lbl_dollar
            // 
            this.lbl_dollar.AutoSize = true;
            this.lbl_dollar.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_dollar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dollar.Location = new System.Drawing.Point(291, 233);
            this.lbl_dollar.Name = "lbl_dollar";
            this.lbl_dollar.Size = new System.Drawing.Size(61, 75);
            this.lbl_dollar.TabIndex = 69;
            this.lbl_dollar.Text = "$";
            // 
            // lbl_fund
            // 
            this.lbl_fund.AutoSize = true;
            this.lbl_fund.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.lbl_fund.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fund.Location = new System.Drawing.Point(308, 188);
            this.lbl_fund.Name = "lbl_fund";
            this.lbl_fund.Size = new System.Drawing.Size(70, 25);
            this.lbl_fund.TabIndex = 67;
            this.lbl_fund.Text = "Фонд 0";
            // 
            // SponsorConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.lbl_sum_num);
            this.Controls.Add(this.lbl_dollar);
            this.Controls.Add(this.lbl_fund);
            this.Controls.Add(this.lbl_racer);
            this.Controls.Add(this.lbl_thank);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 495);
            this.MinimumSize = new System.Drawing.Size(716, 495);
            this.Name = "SponsorConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_racer;
        private System.Windows.Forms.Label lbl_thank;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button panel_bottom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button panel_top;
        private System.Windows.Forms.Label lbl_sum_num;
        private System.Windows.Forms.Label lbl_dollar;
        private System.Windows.Forms.Label lbl_fund;
    }
}