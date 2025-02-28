namespace TaskSaver.Notes
{
    partial class Settings
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new Panel();
            SaveCancelPanel = new Panel();
            CancelBtn = new Button();
            SaveBtn = new Button();
            TasksLbl = new Label();
            panel1 = new Panel();
            ColorSchemePanel = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            accentColChngBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            SettingIco = new Panel();
            ChngThemeBtn = new Button();
            colorDialog1 = new ColorDialog();
            MainPanel.SuspendLayout();
            SaveCancelPanel.SuspendLayout();
            panel1.SuspendLayout();
            ColorSchemePanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(SaveCancelPanel);
            MainPanel.Controls.Add(TasksLbl);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(650, 67);
            MainPanel.TabIndex = 2;
            // 
            // SaveCancelPanel
            // 
            SaveCancelPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveCancelPanel.Controls.Add(CancelBtn);
            SaveCancelPanel.Controls.Add(SaveBtn);
            SaveCancelPanel.Location = new Point(335, 12);
            SaveCancelPanel.Name = "SaveCancelPanel";
            SaveCancelPanel.Size = new Size(305, 40);
            SaveCancelPanel.TabIndex = 2;
            SaveCancelPanel.Visible = false;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.Menu;
            CancelBtn.Dock = DockStyle.Left;
            CancelBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            CancelBtn.ImageAlign = ContentAlignment.TopCenter;
            CancelBtn.Location = new Point(0, 0);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 40);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(35, 75, 230);
            SaveBtn.Dock = DockStyle.Right;
            SaveBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveBtn.ForeColor = SystemColors.ControlLightLight;
            SaveBtn.ImageAlign = ContentAlignment.TopCenter;
            SaveBtn.Location = new Point(155, 0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 40);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // TasksLbl
            // 
            TasksLbl.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksLbl.ImageAlign = ContentAlignment.TopCenter;
            TasksLbl.Location = new Point(19, 3);
            TasksLbl.Name = "TasksLbl";
            TasksLbl.Size = new Size(258, 63);
            TasksLbl.TabIndex = 5;
            TasksLbl.Text = "Настройки";
            TasksLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(ColorSchemePanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 590);
            panel1.TabIndex = 3;
            // 
            // ColorSchemePanel
            // 
            ColorSchemePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ColorSchemePanel.BackColor = SystemColors.Control;
            ColorSchemePanel.Controls.Add(panel4);
            ColorSchemePanel.Controls.Add(panel3);
            ColorSchemePanel.Location = new Point(3, 23);
            ColorSchemePanel.Name = "ColorSchemePanel";
            ColorSchemePanel.Size = new Size(607, 224);
            ColorSchemePanel.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(accentColChngBtn);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(18, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(570, 50);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(42, 42);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label2.Location = new Point(50, 3);
            label2.Name = "label2";
            label2.Size = new Size(349, 46);
            label2.TabIndex = 0;
            label2.Text = "Акцентный цвет";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accentColChngBtn
            // 
            accentColChngBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            accentColChngBtn.BackColor = Color.FromArgb(35, 75, 230);
            accentColChngBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            accentColChngBtn.FlatAppearance.BorderSize = 0;
            accentColChngBtn.FlatStyle = FlatStyle.Flat;
            accentColChngBtn.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            accentColChngBtn.ForeColor = SystemColors.ControlLightLight;
            accentColChngBtn.ImageAlign = ContentAlignment.TopCenter;
            accentColChngBtn.Location = new Point(410, 7);
            accentColChngBtn.Name = "accentColChngBtn";
            accentColChngBtn.Size = new Size(150, 36);
            accentColChngBtn.TabIndex = 7;
            accentColChngBtn.Text = "Изменить";
            accentColChngBtn.UseVisualStyleBackColor = false;
            accentColChngBtn.Click += accentColChngBtn_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ChngThemeBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(SettingIco);
            panel3.Location = new Point(18, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 50);
            panel3.TabIndex = 8;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label1.Location = new Point(50, 3);
            label1.Name = "label1";
            label1.Size = new Size(349, 46);
            label1.TabIndex = 0;
            label1.Text = "Тема приложения";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SettingIco
            // 
            SettingIco.Location = new Point(3, 4);
            SettingIco.Name = "SettingIco";
            SettingIco.Size = new Size(42, 42);
            SettingIco.TabIndex = 1;
            // 
            // ChngThemeBtn
            // 
            ChngThemeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChngThemeBtn.BackColor = Color.FromArgb(35, 75, 230);
            ChngThemeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ChngThemeBtn.FlatAppearance.BorderSize = 0;
            ChngThemeBtn.FlatStyle = FlatStyle.Flat;
            ChngThemeBtn.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChngThemeBtn.ForeColor = SystemColors.ControlLightLight;
            ChngThemeBtn.ImageAlign = ContentAlignment.TopCenter;
            ChngThemeBtn.Location = new Point(410, 7);
            ChngThemeBtn.Name = "ChngThemeBtn";
            ChngThemeBtn.Size = new Size(150, 36);
            ChngThemeBtn.TabIndex = 7;
            ChngThemeBtn.Text = "Изменить";
            ChngThemeBtn.UseVisualStyleBackColor = false;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = Color.White;
            colorDialog1.FullOpen = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(MainPanel);
            Name = "Settings";
            Size = new Size(650, 657);
            Resize += Settings_SizeChanged;
            MainPanel.ResumeLayout(false);
            SaveCancelPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ColorSchemePanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label TasksLbl;
        private Button SaveBtn;
        private Button CancelBtn;
        private Panel panel1;
        private Label label1;
        private Panel ColorSchemePanel;
        private Panel SettingIco;
        private Panel SaveCancelPanel;
        private Button ChngThemeBtn;
        private Button accentColChngBtn;
        private Label label2;
        private ColorDialog colorDialog1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
