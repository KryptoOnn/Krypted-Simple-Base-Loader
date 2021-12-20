namespace Krypted_Loader__SIMPLE_
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.LogExit = new Guna.UI2.WinForms.Guna2Button();
            this.CopyConsole = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(-1, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(406, 52);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageSize = new System.Drawing.Size(15, 15);
            this.MinimizeButton.Location = new System.Drawing.Point(305, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.MinimizeButton.PressedState.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(53, 38);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageSize = new System.Drawing.Size(15, 15);
            this.ExitButton.Location = new System.Drawing.Point(353, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.ExitButton.PressedState.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(53, 38);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Krypted Sol.";
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.InfoBox.ForeColor = System.Drawing.Color.Gray;
            this.InfoBox.Location = new System.Drawing.Point(12, 60);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(379, 267);
            this.InfoBox.TabIndex = 7;
            this.InfoBox.Text = "\n------------------------------------------CONSOLE - INFO BOX--------------------" +
    "-------------------------";
            // 
            // LogExit
            // 
            this.LogExit.BorderThickness = 1;
            this.LogExit.CheckedState.Parent = this.LogExit;
            this.LogExit.CustomImages.Parent = this.LogExit;
            this.LogExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogExit.ForeColor = System.Drawing.Color.White;
            this.LogExit.HoverState.Parent = this.LogExit;
            this.LogExit.Location = new System.Drawing.Point(12, 327);
            this.LogExit.Name = "LogExit";
            this.LogExit.ShadowDecoration.Parent = this.LogExit;
            this.LogExit.Size = new System.Drawing.Size(379, 43);
            this.LogExit.TabIndex = 8;
            this.LogExit.Text = "Exit";
            this.LogExit.Click += new System.EventHandler(this.LogExit_Click);
            // 
            // CopyConsole
            // 
            this.CopyConsole.BorderThickness = 1;
            this.CopyConsole.CheckedState.Parent = this.CopyConsole;
            this.CopyConsole.CustomImages.Parent = this.CopyConsole;
            this.CopyConsole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CopyConsole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyConsole.ForeColor = System.Drawing.Color.White;
            this.CopyConsole.HoverState.Parent = this.CopyConsole;
            this.CopyConsole.Location = new System.Drawing.Point(12, 372);
            this.CopyConsole.Name = "CopyConsole";
            this.CopyConsole.ShadowDecoration.Parent = this.CopyConsole;
            this.CopyConsole.Size = new System.Drawing.Size(379, 43);
            this.CopyConsole.TabIndex = 9;
            this.CopyConsole.Text = "Copy Log";
            this.CopyConsole.Click += new System.EventHandler(this.CopyConsole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "v0.3 ";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CopyConsole);
            this.Controls.Add(this.LogExit);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypted";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizeButton;
        private Guna.UI2.WinForms.Guna2ImageButton ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InfoBox;
        private Guna.UI2.WinForms.Guna2Button LogExit;
        private Guna.UI2.WinForms.Guna2Button CopyConsole;
        private System.Windows.Forms.Label label2;
    }
}