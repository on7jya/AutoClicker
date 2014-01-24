namespace AutoClicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track_count = new System.Windows.Forms.TrackBar();
            this.track_time = new System.Windows.Forms.TrackBar();
            this.TabelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.track_cycle = new System.Windows.Forms.TrackBar();
            this.button_start_stop = new System.Windows.Forms.Button();
            this.label_info_count = new System.Windows.Forms.Label();
            this.label_info_time = new System.Windows.Forms.Label();
            this.label_show_time = new System.Windows.Forms.Label();
            this.label_show_count = new System.Windows.Forms.Label();
            this.track_timeout = new System.Windows.Forms.TrackBar();
            this.label_timeout = new System.Windows.Forms.Label();
            this.label_show_timeout = new System.Windows.Forms.Label();
            this.label_cycle = new System.Windows.Forms.Label();
            this.label_show_cycle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).BeginInit();
            this.TabelLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_cycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // track_count
            // 
            this.track_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_count.LargeChange = 100;
            this.track_count.Location = new System.Drawing.Point(119, 3);
            this.track_count.Maximum = 1000;
            this.track_count.Minimum = 1;
            this.track_count.Name = "track_count";
            this.track_count.Size = new System.Drawing.Size(267, 35);
            this.track_count.TabIndex = 0;
            this.track_count.TickFrequency = 100;
            this.track_count.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_count.Value = 1;
            this.track_count.Scroll += new System.EventHandler(this.track_count_Scroll);
            // 
            // track_time
            // 
            this.track_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_time.LargeChange = 100;
            this.track_time.Location = new System.Drawing.Point(119, 44);
            this.track_time.Maximum = 1000;
            this.track_time.Minimum = 1;
            this.track_time.Name = "track_time";
            this.track_time.Size = new System.Drawing.Size(267, 35);
            this.track_time.SmallChange = 10;
            this.track_time.TabIndex = 1;
            this.track_time.TickFrequency = 100;
            this.track_time.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_time.Value = 1;
            this.track_time.Scroll += new System.EventHandler(this.track_time_Scroll);
            // 
            // TabelLayoutPanel
            // 
            this.TabelLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TabelLayoutPanel.ColumnCount = 3;
            this.TabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.95017F));
            this.TabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.09966F));
            this.TabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.95017F));
            this.TabelLayoutPanel.Controls.Add(this.track_cycle, 1, 3);
            this.TabelLayoutPanel.Controls.Add(this.button_start_stop, 1, 4);
            this.TabelLayoutPanel.Controls.Add(this.track_count, 1, 0);
            this.TabelLayoutPanel.Controls.Add(this.track_time, 1, 1);
            this.TabelLayoutPanel.Controls.Add(this.label_info_count, 0, 0);
            this.TabelLayoutPanel.Controls.Add(this.label_info_time, 0, 1);
            this.TabelLayoutPanel.Controls.Add(this.label_show_time, 2, 1);
            this.TabelLayoutPanel.Controls.Add(this.label_show_count, 2, 0);
            this.TabelLayoutPanel.Controls.Add(this.track_timeout, 1, 2);
            this.TabelLayoutPanel.Controls.Add(this.label_timeout, 0, 2);
            this.TabelLayoutPanel.Controls.Add(this.label_show_timeout, 2, 2);
            this.TabelLayoutPanel.Controls.Add(this.label_cycle, 0, 3);
            this.TabelLayoutPanel.Controls.Add(this.label_show_cycle, 2, 3);
            this.TabelLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TabelLayoutPanel.Name = "TabelLayoutPanel";
            this.TabelLayoutPanel.RowCount = 5;
            this.TabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TabelLayoutPanel.Size = new System.Drawing.Size(506, 207);
            this.TabelLayoutPanel.TabIndex = 2;
            // 
            // track_cycle
            // 
            this.track_cycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.track_cycle.LargeChange = 1;
            this.track_cycle.Location = new System.Drawing.Point(199, 126);
            this.track_cycle.Maximum = 1;
            this.track_cycle.Name = "track_cycle";
            this.track_cycle.Size = new System.Drawing.Size(106, 35);
            this.track_cycle.TabIndex = 11;
            this.track_cycle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_cycle.Scroll += new System.EventHandler(this.track_cycle_Scroll);
            // 
            // button_start_stop
            // 
            this.button_start_stop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_start_stop.BackColor = System.Drawing.Color.Gainsboro;
            this.button_start_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start_stop.ForeColor = System.Drawing.Color.Black;
            this.button_start_stop.Location = new System.Drawing.Point(142, 167);
            this.button_start_stop.Name = "button_start_stop";
            this.button_start_stop.Size = new System.Drawing.Size(220, 34);
            this.button_start_stop.TabIndex = 6;
            this.button_start_stop.Text = "Start clicking!";
            this.button_start_stop.UseVisualStyleBackColor = false;
            this.button_start_stop.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_info_count
            // 
            this.label_info_count.AutoSize = true;
            this.label_info_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info_count.Location = new System.Drawing.Point(3, 0);
            this.label_info_count.Name = "label_info_count";
            this.label_info_count.Size = new System.Drawing.Size(110, 41);
            this.label_info_count.TabIndex = 2;
            this.label_info_count.Text = "Click";
            this.label_info_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_info_time
            // 
            this.label_info_time.AutoSize = true;
            this.label_info_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info_time.Location = new System.Drawing.Point(3, 41);
            this.label_info_time.Name = "label_info_time";
            this.label_info_time.Size = new System.Drawing.Size(110, 41);
            this.label_info_time.TabIndex = 3;
            this.label_info_time.Text = "Click Interval";
            this.label_info_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_time
            // 
            this.label_show_time.AutoSize = true;
            this.label_show_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_time.Location = new System.Drawing.Point(392, 41);
            this.label_show_time.Name = "label_show_time";
            this.label_show_time.Size = new System.Drawing.Size(111, 41);
            this.label_show_time.TabIndex = 5;
            this.label_show_time.Text = "-";
            this.label_show_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_count
            // 
            this.label_show_count.AutoSize = true;
            this.label_show_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_count.Location = new System.Drawing.Point(392, 0);
            this.label_show_count.Name = "label_show_count";
            this.label_show_count.Size = new System.Drawing.Size(111, 41);
            this.label_show_count.TabIndex = 4;
            this.label_show_count.Text = "-";
            this.label_show_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // track_timeout
            // 
            this.track_timeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_timeout.LargeChange = 1;
            this.track_timeout.Location = new System.Drawing.Point(119, 85);
            this.track_timeout.Maximum = 5;
            this.track_timeout.Name = "track_timeout";
            this.track_timeout.Size = new System.Drawing.Size(267, 35);
            this.track_timeout.TabIndex = 3;
            this.track_timeout.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track_timeout.Scroll += new System.EventHandler(this.track_timeout_Scroll);
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_timeout.Location = new System.Drawing.Point(3, 82);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(110, 41);
            this.label_timeout.TabIndex = 7;
            this.label_timeout.Text = "Timeout";
            this.label_timeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_timeout
            // 
            this.label_show_timeout.AutoSize = true;
            this.label_show_timeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_timeout.Location = new System.Drawing.Point(392, 82);
            this.label_show_timeout.Name = "label_show_timeout";
            this.label_show_timeout.Size = new System.Drawing.Size(111, 41);
            this.label_show_timeout.TabIndex = 8;
            this.label_show_timeout.Text = "-";
            this.label_show_timeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cycle
            // 
            this.label_cycle.AutoSize = true;
            this.label_cycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cycle.Location = new System.Drawing.Point(3, 123);
            this.label_cycle.Name = "label_cycle";
            this.label_cycle.Size = new System.Drawing.Size(110, 41);
            this.label_cycle.TabIndex = 12;
            this.label_cycle.Text = "Looping";
            this.label_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_cycle
            // 
            this.label_show_cycle.AutoSize = true;
            this.label_show_cycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_cycle.Location = new System.Drawing.Point(392, 123);
            this.label_show_cycle.Name = "label_show_cycle";
            this.label_show_cycle.Size = new System.Drawing.Size(111, 41);
            this.label_show_cycle.TabIndex = 13;
            this.label_show_cycle.Text = "-";
            this.label_show_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 750;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 206);
            this.Controls.Add(this.TabelLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).EndInit();
            this.TabelLayoutPanel.ResumeLayout(false);
            this.TabelLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_cycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_timeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar track_count;
        private System.Windows.Forms.TrackBar track_time;
        private System.Windows.Forms.TableLayoutPanel TabelLayoutPanel;
        private System.Windows.Forms.Label label_info_count;
        private System.Windows.Forms.Label label_info_time;
        private System.Windows.Forms.Label label_show_time;
        private System.Windows.Forms.Label label_show_count;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar track_timeout;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.Label label_show_timeout;
        private System.Windows.Forms.TrackBar track_cycle;
        private System.Windows.Forms.Label label_cycle;
        private System.Windows.Forms.Label label_show_cycle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_start_stop;
    }
}

