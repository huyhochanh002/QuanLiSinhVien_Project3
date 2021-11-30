
namespace QuanLiSinhVien_Project3
{
    partial class GiaoDienChinh
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
            this.pn_left = new System.Windows.Forms.Panel();
            this.pn_leftcon1 = new System.Windows.Forms.Panel();
            this.menu_left = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuanLySV = new System.Windows.Forms.Button();
            this.btnQuanLyDienSV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pn_center = new System.Windows.Forms.Panel();
            this.tabcontrol_center = new DevComponents.DotNetBar.TabControl();
            this.timedate = new System.Windows.Forms.Timer(this.components);
            this.pn_top = new System.Windows.Forms.Panel();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_left.SuspendLayout();
            this.menu_left.SuspendLayout();
            this.pn_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_center)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_left
            // 
            this.pn_left.AutoSize = true;
            this.pn_left.BackColor = System.Drawing.Color.White;
            this.pn_left.Controls.Add(this.pn_leftcon1);
            this.pn_left.Controls.Add(this.menu_left);
            this.pn_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left.Location = new System.Drawing.Point(0, 0);
            this.pn_left.Margin = new System.Windows.Forms.Padding(4);
            this.pn_left.Name = "pn_left";
            this.pn_left.Size = new System.Drawing.Size(400, 886);
            this.pn_left.TabIndex = 0;
            this.pn_left.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_left_Paint);
            // 
            // pn_leftcon1
            // 
            this.pn_leftcon1.BackgroundImage = global::QuanLiSinhVien_Project3.Properties.Resources.anhmenuprj31;
            this.pn_leftcon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_leftcon1.Enabled = false;
            this.pn_leftcon1.Location = new System.Drawing.Point(0, 0);
            this.pn_leftcon1.Margin = new System.Windows.Forms.Padding(0);
            this.pn_leftcon1.Name = "pn_leftcon1";
            this.pn_leftcon1.Size = new System.Drawing.Size(400, 309);
            this.pn_leftcon1.TabIndex = 3;
            // 
            // menu_left
            // 
            this.menu_left.Controls.Add(this.btnQuanLySV);
            this.menu_left.Controls.Add(this.btnQuanLyDienSV);
            this.menu_left.Controls.Add(this.button3);
            this.menu_left.Controls.Add(this.button4);
            this.menu_left.Controls.Add(this.button5);
            this.menu_left.Controls.Add(this.button6);
            this.menu_left.Location = new System.Drawing.Point(0, 313);
            this.menu_left.Margin = new System.Windows.Forms.Padding(0);
            this.menu_left.Name = "menu_left";
            this.menu_left.Size = new System.Drawing.Size(400, 385);
            this.menu_left.TabIndex = 2;
            // 
            // btnQuanLySV
            // 
            this.btnQuanLySV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLySV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuanLySV.FlatAppearance.BorderSize = 0;
            this.btnQuanLySV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanLySV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySV.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLySV.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnQuanLySV.Name = "btnQuanLySV";
            this.btnQuanLySV.Size = new System.Drawing.Size(400, 62);
            this.btnQuanLySV.TabIndex = 0;
            this.btnQuanLySV.Text = "Quản lý sinh viên";
            this.btnQuanLySV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLySV.UseVisualStyleBackColor = false;
            this.btnQuanLySV.Click += new System.EventHandler(this.btnQuanLySV_Click);
            // 
            // btnQuanLyDienSV
            // 
            this.btnQuanLyDienSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuanLyDienSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuanLyDienSV.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDienSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanLyDienSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDienSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDienSV.Location = new System.Drawing.Point(0, 64);
            this.btnQuanLyDienSV.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnQuanLyDienSV.Name = "btnQuanLyDienSV";
            this.btnQuanLyDienSV.Size = new System.Drawing.Size(400, 62);
            this.btnQuanLyDienSV.TabIndex = 1;
            this.btnQuanLyDienSV.Text = "Quản lý điểm sinh viên";
            this.btnQuanLyDienSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyDienSV.UseVisualStyleBackColor = false;
            this.btnQuanLyDienSV.Click += new System.EventHandler(this.btnQuanLyDienSV_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 128);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 192);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 256);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 320);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(400, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // pn_center
            // 
            this.pn_center.Controls.Add(this.tabcontrol_center);
            this.pn_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_center.Location = new System.Drawing.Point(400, 54);
            this.pn_center.Margin = new System.Windows.Forms.Padding(4);
            this.pn_center.Name = "pn_center";
            this.pn_center.Size = new System.Drawing.Size(1307, 832);
            this.pn_center.TabIndex = 2;
            // 
            // tabcontrol_center
            // 
            this.tabcontrol_center.CanReorderTabs = true;
            this.tabcontrol_center.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabcontrol_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_center.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabcontrol_center.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol_center.Margin = new System.Windows.Forms.Padding(4);
            this.tabcontrol_center.Name = "tabcontrol_center";
            this.tabcontrol_center.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabcontrol_center.SelectedTabIndex = 0;
            this.tabcontrol_center.Size = new System.Drawing.Size(1307, 832);
            this.tabcontrol_center.TabIndex = 0;
            this.tabcontrol_center.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabcontrol_center.Text = "tabControl1";
            this.tabcontrol_center.Click += new System.EventHandler(this.tabcontrol_center_Click);
            // 
            // timedate
            // 
            this.timedate.Interval = 1000;
            this.timedate.Tick += new System.EventHandler(this.timedate_Tick);
            // 
            // pn_top
            // 
            this.pn_top.BackgroundImage = global::QuanLiSinhVien_Project3.Properties.Resources.panner_top_2;
            this.pn_top.Controls.Add(this.lb_thoigian);
            this.pn_top.Controls.Add(this.btn_exit);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(400, 0);
            this.pn_top.Margin = new System.Windows.Forms.Padding(4);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1307, 54);
            this.pn_top.TabIndex = 1;
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.BackColor = System.Drawing.Color.White;
            this.lb_thoigian.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_thoigian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_thoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoigian.ForeColor = System.Drawing.Color.Black;
            this.lb_thoigian.Location = new System.Drawing.Point(969, 0);
            this.lb_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(193, 54);
            this.lb_thoigian.TabIndex = 1;
            this.lb_thoigian.Text = "Time";
            this.lb_thoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_thoigian.Click += new System.EventHandler(this.lb_thoigian_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_exit.Image = global::QuanLiSinhVien_Project3.Properties.Resources.exit22;
            this.btn_exit.Location = new System.Drawing.Point(1162, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 54);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.pn_center);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GiaoDienChinh_Load);
            this.pn_left.ResumeLayout(false);
            this.menu_left.ResumeLayout(false);
            this.pn_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_center)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.FlowLayoutPanel menu_left;
        private System.Windows.Forms.Button btnQuanLySV;
        private System.Windows.Forms.Panel pn_leftcon1;
        private System.Windows.Forms.Button btnQuanLyDienSV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pn_center;
        private DevComponents.DotNetBar.TabControl tabcontrol_center;
        private System.Windows.Forms.Label lb_thoigian;
        private System.Windows.Forms.Timer timedate;
        private System.Windows.Forms.Button btn_exit;
    }
}

