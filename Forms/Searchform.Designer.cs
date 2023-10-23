namespace WinFormsApp5.Forms
{
    partial class Searchform
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            date = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            cat = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            desc = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(624, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 44);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 120, 138);
            label1.Location = new Point(34, 75);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 1;
            label1.Text = "Search Date";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-2, 195);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(908, 511);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkOrchid;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { date, toolStripTextBox1, cat, toolStripTextBox2, desc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(903, 31);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // date
            // 
            date.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = SystemColors.ActiveCaptionText;
            date.Name = "date";
            date.Size = new Size(85, 27);
            date.Text = "Daten";
            date.Click += date_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = Color.DarkOrchid;
            toolStripTextBox1.BorderStyle = BorderStyle.None;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // cat
            // 
            cat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cat.ForeColor = SystemColors.ActiveCaptionText;
            cat.Name = "cat";
            cat.Size = new Size(118, 27);
            cat.Text = "Kategorie";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.BackColor = Color.DarkOrchid;
            toolStripTextBox2.BorderStyle = BorderStyle.None;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            // 
            // desc
            // 
            desc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            desc.ForeColor = SystemColors.ActiveCaptionText;
            desc.Name = "desc";
            desc.Size = new Size(154, 27);
            desc.Text = "Beschreibung";
            // 
            // Searchform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(903, 703);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlLight;
            Name = "Searchform";
            Text = "Searchform";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem date;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem cat;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripMenuItem desc;
    }
}