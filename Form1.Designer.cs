namespace SensorsRS485
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            panel5 = new Panel();
            id2_temperatureLabel = new Label();
            panel4 = new Panel();
            id2_humidityLabel = new Label();
            panel3 = new Panel();
            id1_conductivityLabel = new Label();
            panel2 = new Panel();
            id1_temperatureLabel = new Label();
            panel1 = new Panel();
            id1_humidityLabel = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            panel7 = new Panel();
            id3_humidityLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(0, 423);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1327, 325);
            textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel6, 2, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1327, 423);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(887, 214);
            panel6.Name = "panel6";
            panel6.Size = new Size(437, 206);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(id2_temperatureLabel);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(445, 214);
            panel5.Name = "panel5";
            panel5.Size = new Size(436, 206);
            panel5.TabIndex = 4;
            // 
            // id2_temperatureLabel
            // 
            id2_temperatureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id2_temperatureLabel.AutoSize = true;
            id2_temperatureLabel.BackColor = Color.Transparent;
            id2_temperatureLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id2_temperatureLabel.ForeColor = SystemColors.ButtonHighlight;
            id2_temperatureLabel.Location = new Point(86, 40);
            id2_temperatureLabel.Name = "id2_temperatureLabel";
            id2_temperatureLabel.Size = new Size(267, 112);
            id2_temperatureLabel.TabIndex = 2;
            id2_temperatureLabel.Text = "-00ºC";
            id2_temperatureLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(id2_humidityLabel);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 214);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 206);
            panel4.TabIndex = 3;
            // 
            // id2_humidityLabel
            // 
            id2_humidityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id2_humidityLabel.AutoSize = true;
            id2_humidityLabel.BackColor = Color.Transparent;
            id2_humidityLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id2_humidityLabel.ForeColor = SystemColors.ButtonHighlight;
            id2_humidityLabel.Location = new Point(86, 40);
            id2_humidityLabel.Name = "id2_humidityLabel";
            id2_humidityLabel.Size = new Size(264, 112);
            id2_humidityLabel.TabIndex = 1;
            id2_humidityLabel.Text = "000%";
            id2_humidityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(id1_conductivityLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(887, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 205);
            panel3.TabIndex = 2;
            // 
            // id1_conductivityLabel
            // 
            id1_conductivityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id1_conductivityLabel.AutoSize = true;
            id1_conductivityLabel.BackColor = Color.Transparent;
            id1_conductivityLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id1_conductivityLabel.ForeColor = SystemColors.ButtonHighlight;
            id1_conductivityLabel.Location = new Point(63, 46);
            id1_conductivityLabel.Name = "id1_conductivityLabel";
            id1_conductivityLabel.Size = new Size(327, 112);
            id1_conductivityLabel.TabIndex = 1;
            id1_conductivityLabel.Text = "0000us";
            id1_conductivityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(id1_temperatureLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(445, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 205);
            panel2.TabIndex = 1;
            // 
            // id1_temperatureLabel
            // 
            id1_temperatureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id1_temperatureLabel.AutoSize = true;
            id1_temperatureLabel.BackColor = Color.Transparent;
            id1_temperatureLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id1_temperatureLabel.ForeColor = SystemColors.ButtonHighlight;
            id1_temperatureLabel.Location = new Point(85, 46);
            id1_temperatureLabel.Name = "id1_temperatureLabel";
            id1_temperatureLabel.Size = new Size(267, 112);
            id1_temperatureLabel.TabIndex = 1;
            id1_temperatureLabel.Text = "-00ºC";
            id1_temperatureLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(id1_humidityLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 205);
            panel1.TabIndex = 0;
            // 
            // id1_humidityLabel
            // 
            id1_humidityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id1_humidityLabel.AutoSize = true;
            id1_humidityLabel.BackColor = Color.Transparent;
            id1_humidityLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id1_humidityLabel.ForeColor = SystemColors.ButtonHighlight;
            id1_humidityLabel.Location = new Point(87, 51);
            id1_humidityLabel.Name = "id1_humidityLabel";
            id1_humidityLabel.Size = new Size(264, 112);
            id1_humidityLabel.TabIndex = 0;
            id1_humidityLabel.Text = "000%";
            id1_humidityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 30000;
            timer2.Tick += timer2_Tick;
            // 
            // panel7
            // 
            panel7.Controls.Add(id3_humidityLabel);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(437, 206);
            panel7.TabIndex = 4;
            // 
            // id3_humidityLabel
            // 
            id3_humidityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            id3_humidityLabel.AutoSize = true;
            id3_humidityLabel.BackColor = Color.Transparent;
            id3_humidityLabel.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            id3_humidityLabel.ForeColor = SystemColors.ButtonHighlight;
            id3_humidityLabel.Location = new Point(86, 40);
            id3_humidityLabel.Name = "id3_humidityLabel";
            id3_humidityLabel.Size = new Size(264, 112);
            id3_humidityLabel.TabIndex = 1;
            id3_humidityLabel.Text = "000%";
            id3_humidityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1327, 748);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label id1_humidityLabel;
        private Label id1_temperatureLabel;
        private Label id2_temperatureLabel;
        private Label id2_humidityLabel;
        private Label id1_conductivityLabel;
        private System.Windows.Forms.Timer timer2;
        private Panel panel7;
        private Label id3_humidityLabel;
    }
}
