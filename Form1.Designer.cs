namespace WinFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DesktopPanel = new Panel();
            dimension = new Panel();
            panel3 = new Panel();
            Title = new Label();
            dashboard = new Button();
            seller = new Button();
            tasks = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            DesktopPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DesktopPanel
            // 
            DesktopPanel.Controls.Add(dimension);
            DesktopPanel.Dock = DockStyle.Fill;
            DesktopPanel.Location = new Point(0, 0);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(1132, 675);
            DesktopPanel.TabIndex = 15;
            // 
            // dimension
            // 
            dimension.Location = new Point(267, -2);
            dimension.Name = "dimension";
            dimension.Size = new Size(865, 677);
            dimension.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrchid;
            panel3.Controls.Add(Title);
            panel3.Location = new Point(-5, -2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 134);
            panel3.TabIndex = 2;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Title.Location = new Point(63, 58);
            Title.Margin = new Padding(2, 0, 2, 0);
            Title.Name = "Title";
            Title.Size = new Size(138, 37);
            Title.TabIndex = 0;
            Title.Text = "Mars Data";
            // 
            // dashboard
            // 
            dashboard.FlatAppearance.BorderSize = 0;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            dashboard.ForeColor = Color.White;
            dashboard.Image = (Image)resources.GetObject("dashboard.Image");
            dashboard.Location = new Point(-7, 131);
            dashboard.Margin = new Padding(2);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(269, 118);
            dashboard.TabIndex = 5;
            dashboard.Text = "Event Tracking";
            dashboard.TextAlign = ContentAlignment.BottomCenter;
            dashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            dashboard.UseVisualStyleBackColor = true;
            dashboard.Click += dashboard_Click;
            // 
            // seller
            // 
            seller.FlatAppearance.BorderSize = 0;
            seller.FlatStyle = FlatStyle.Flat;
            seller.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            seller.ForeColor = Color.White;
            seller.Image = (Image)resources.GetObject("seller.Image");
            seller.Location = new Point(-5, 260);
            seller.Margin = new Padding(2);
            seller.Name = "seller";
            seller.Size = new Size(269, 118);
            seller.TabIndex = 6;
            seller.Text = "Atmosphärischer Druck";
            seller.TextAlign = ContentAlignment.BottomCenter;
            seller.TextImageRelation = TextImageRelation.ImageAboveText;
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // tasks
            // 
            tasks.FlatAppearance.BorderSize = 0;
            tasks.FlatStyle = FlatStyle.Flat;
            tasks.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            tasks.ForeColor = Color.White;
            tasks.Image = (Image)resources.GetObject("tasks.Image");
            tasks.Location = new Point(0, 382);
            tasks.Margin = new Padding(2);
            tasks.Name = "tasks";
            tasks.Size = new Size(262, 118);
            tasks.TabIndex = 7;
            tasks.Text = "Windgeschwindigkeit";
            tasks.TextAlign = ContentAlignment.BottomCenter;
            tasks.TextImageRelation = TextImageRelation.ImageAboveText;
            tasks.UseVisualStyleBackColor = true;
            tasks.Click += tasks_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrchid;
            panel4.Location = new Point(252, 131);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 125);
            panel4.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(tasks);
            panel1.Controls.Add(seller);
            panel1.Controls.Add(dashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 675);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1132, 675);
            Controls.Add(panel1);
            Controls.Add(DesktopPanel);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DesktopPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Panel DesktopPanel;
        private Panel dimension;
        private Panel panel3;
        private Label Title;
        private Button dashboard;
        private Button seller;
        private Button tasks;
        private Panel panel4;
        private Panel panel1;
    }
}