namespace WinShu
{
    partial class MainForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.listButton = new System.Windows.Forms.Button();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.labelOff = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.taskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuPanel.Controls.Add(this.panelSubMenu);
            this.menuPanel.Controls.Add(this.buttonMenu);
            this.menuPanel.Controls.Add(this.panelLogo);
            this.menuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 561);
            this.menuPanel.TabIndex = 4;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.Gray;
            this.panelSubMenu.Controls.Add(this.listButton);
            this.panelSubMenu.Controls.Add(this.newTaskButton);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 125);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(200, 90);
            this.panelSubMenu.TabIndex = 4;
            this.panelSubMenu.Visible = false;
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listButton.FlatAppearance.BorderSize = 0;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Location = new System.Drawing.Point(0, 45);
            this.listButton.Name = "listButton";
            this.listButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.listButton.Size = new System.Drawing.Size(200, 45);
            this.listButton.TabIndex = 1;
            this.listButton.Text = "List";
            this.listButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // newTaskButton
            // 
            this.newTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTaskButton.FlatAppearance.BorderSize = 0;
            this.newTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTaskButton.ForeColor = System.Drawing.Color.White;
            this.newTaskButton.Location = new System.Drawing.Point(0, 0);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.newTaskButton.Size = new System.Drawing.Size(200, 45);
            this.newTaskButton.TabIndex = 0;
            this.newTaskButton.Text = "Task";
            this.newTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTaskButton.UseVisualStyleBackColor = false;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(0, 80);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMenu.Size = new System.Drawing.Size(200, 45);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 2;
            // 
            // taskPanel
            // 
            this.taskPanel.AutoScroll = true;
            this.taskPanel.Controls.Add(this.labelOff);
            this.taskPanel.Controls.Add(this.button1);
            this.taskPanel.Controls.Add(this.dateTimePicker);
            this.taskPanel.Controls.Add(this.taskLabel);
            this.taskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskPanel.Location = new System.Drawing.Point(200, 0);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(734, 561);
            this.taskPanel.TabIndex = 5;
            // 
            // labelOff
            // 
            this.labelOff.AutoSize = true;
            this.labelOff.Location = new System.Drawing.Point(152, 185);
            this.labelOff.Name = "labelOff";
            this.labelOff.Size = new System.Drawing.Size(84, 15);
            this.labelOff.TabIndex = 3;
            this.labelOff.Text = "Wylaczy sie za:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Shut it ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(299, 134);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(101, 23);
            this.dateTimePicker.TabIndex = 1;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskLabel.Location = new System.Drawing.Point(224, 26);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(176, 37);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Add new task";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.Text = "WinShu";
            this.menuPanel.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.taskPanel.ResumeLayout(false);
            this.taskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel menuPanel;
        private Panel panelSubMenu;
        private Button listButton;
        private Button newTaskButton;
        private Button buttonMenu;
        private Panel panelLogo;
        private Panel taskPanel;
        private Label taskLabel;
        private DateTimePicker dateTimePicker;
        private Label labelOff;
        private Button button1;
    }
}