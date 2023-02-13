namespace WinShu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.listButton = new System.Windows.Forms.Button();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "WinShu";
            this.menuPanel.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel menuPanel;
        private Panel panelSubMenu;
        private Button listButton;
        private Button newTaskButton;
        private Button buttonMenu;
        private Panel panelLogo;
    }
}