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
            TasksLbl = new Label();
            panel1 = new Panel();
            ColorSchemePanel = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            panel4 = new Panel();
            accentColChngBtn = new Button();
            label2 = new Label();
            panel3 = new Panel();
            ChngThemeBtn = new Button();
            label1 = new Label();
            MainPanel.SuspendLayout();
            panel1.SuspendLayout();
            ColorSchemePanel.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(TasksLbl);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(650, 67);
            MainPanel.TabIndex = 2;
            // 
            // TasksLbl
            // 
            TasksLbl.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksLbl.ImageAlign = ContentAlignment.TopCenter;
            TasksLbl.Location = new Point(19, 2);
            TasksLbl.Name = "TasksLbl";
            TasksLbl.Size = new Size(258, 62);
            TasksLbl.TabIndex = 5;
            TasksLbl.Text = "Настройки";
            TasksLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
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
            ColorSchemePanel.Controls.Add(label3);
            ColorSchemePanel.Controls.Add(panel2);
            ColorSchemePanel.Controls.Add(panel4);
            ColorSchemePanel.Controls.Add(panel3);
            ColorSchemePanel.Location = new Point(3, 23);
            ColorSchemePanel.Name = "ColorSchemePanel";
            ColorSchemePanel.Size = new Size(607, 228);
            ColorSchemePanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(21, 10);
            label3.Name = "label3";
            label3.Size = new Size(216, 26);
            label3.TabIndex = 9;
            label3.Text = "Цветовое оформление";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(18, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 50);
            panel2.TabIndex = 8;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.Yellow;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(525, 17);
            button5.Name = "button5";
            button5.Size = new Size(18, 18);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = false;
            button5.Click += yellow_clck;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(500, 17);
            button4.Name = "button4";
            button4.Size = new Size(18, 18);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = false;
            button4.Click += orang_clck;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(475, 17);
            button3.Name = "button3";
            button3.Size = new Size(18, 18);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += red_clck;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(450, 17);
            button2.Name = "button2";
            button2.Size = new Size(18, 18);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += green_clck;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(424, 17);
            button1.Name = "button1";
            button1.Size = new Size(18, 18);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += blue_clck;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label4.Location = new Point(24, 3);
            label4.Name = "label4";
            label4.Size = new Size(322, 46);
            label4.TabIndex = 0;
            label4.Text = "Выбрать акцентный цвет";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(accentColChngBtn);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(18, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(570, 50);
            panel4.TabIndex = 8;
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
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label2.Location = new Point(24, 3);
            label2.Name = "label2";
            label2.Size = new Size(349, 46);
            label2.TabIndex = 0;
            label2.Text = "Включить акцентный цвет";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ChngThemeBtn);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(18, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 50);
            panel3.TabIndex = 8;
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
            ChngThemeBtn.Click += ChngThemeBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display Semib", 16F);
            label1.Location = new Point(24, 3);
            label1.Name = "label1";
            label1.Size = new Size(349, 46);
            label1.TabIndex = 0;
            label1.Text = "Тема приложения";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(MainPanel);
            Name = "Settings";
            Size = new Size(650, 657);
            Resize += Settings_SizeChanged;
            MainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ColorSchemePanel.ResumeLayout(false);
            ColorSchemePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label TasksLbl;
        private Panel panel1;
        private Label label1;
        private Panel ColorSchemePanel;
        private Button ChngThemeBtn;
        private Button accentColChngBtn;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
