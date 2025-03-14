namespace TaskSaver
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            Sidebar = new Panel();
            SettingsBtn = new Button();
            NotesBtn = new Button();
            MenuBtn = new Button();
            ToolsPanel = new Panel();
            Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = SystemColors.InactiveBorder;
            Sidebar.Controls.Add(SettingsBtn);
            Sidebar.Controls.Add(NotesBtn);
            Sidebar.Controls.Add(MenuBtn);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Font = new Font("Microsoft Sans Serif", 8.25F);
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(42, 561);
            Sidebar.TabIndex = 0;
            Sidebar.Leave += Sidebar_Leave;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SettingsBtn.BackColor = Color.Transparent;
            SettingsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            SettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SettingsBtn.Image = Properties.Resources.settings_32;
            SettingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.Location = new Point(0, 527);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(250, 32);
            SettingsBtn.TabIndex = 0;
            SettingsBtn.Text = "Настройки";
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += Settings_click;
            // 
            // NotesBtn
            // 
            NotesBtn.BackColor = Color.Transparent;
            NotesBtn.BackgroundImageLayout = ImageLayout.Zoom;
            NotesBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            NotesBtn.FlatAppearance.BorderSize = 0;
            NotesBtn.FlatStyle = FlatStyle.Flat;
            NotesBtn.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NotesBtn.Image = Properties.Resources.main_icon_32;
            NotesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            NotesBtn.Location = new Point(0, 58);
            NotesBtn.Name = "NotesBtn";
            NotesBtn.Size = new Size(250, 32);
            NotesBtn.TabIndex = 0;
            NotesBtn.Text = "Заметки";
            NotesBtn.UseVisualStyleBackColor = false;
            NotesBtn.Click += Notes_click;
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.Transparent;
            MenuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            MenuBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            MenuBtn.FlatAppearance.BorderSize = 0;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.Font = new Font("Segoe UI Variable Small", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuBtn.Image = Properties.Resources.menu_32;
            MenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MenuBtn.Location = new Point(0, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(250, 45);
            MenuBtn.TabIndex = 0;
            MenuBtn.Text = "Меню";
            MenuBtn.UseVisualStyleBackColor = false;
            MenuBtn.Click += SideBar_click;
            // 
            // ToolsPanel
            // 
            ToolsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToolsPanel.Location = new Point(75, 5);
            ToolsPanel.Name = "ToolsPanel";
            ToolsPanel.Size = new Size(800, 540);
            ToolsPanel.TabIndex = 3;
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(884, 561);
            Controls.Add(Sidebar);
            Controls.Add(ToolsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(750, 500);
            Name = "MainWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заметки";
            Resize += Form1_SizeChanged;
            Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Sidebar;
        private Panel ToolsPanel;
        private Button MenuBtn;
        private Button NotesBtn;
        private Button SettingsBtn;
    }
}
