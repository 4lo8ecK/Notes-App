namespace TaskSaver
{
    partial class ControlBox
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
            ControlBoxPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            Maximize_btn = new Button();
            CurDateLbl = new Label();
            Minimize_btn = new Button();
            Close_btn = new Button();
            ControlBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlBoxPanel
            // 
            ControlBoxPanel.BackColor = Color.White;
            ControlBoxPanel.Controls.Add(label1);
            ControlBoxPanel.Controls.Add(panel1);
            ControlBoxPanel.Controls.Add(Maximize_btn);
            ControlBoxPanel.Controls.Add(CurDateLbl);
            ControlBoxPanel.Controls.Add(Minimize_btn);
            ControlBoxPanel.Controls.Add(Close_btn);
            ControlBoxPanel.Dock = DockStyle.Fill;
            ControlBoxPanel.Location = new Point(0, 0);
            ControlBoxPanel.Name = "ControlBoxPanel";
            ControlBoxPanel.Size = new Size(640, 45);
            ControlBoxPanel.TabIndex = 3;
            ControlBoxPanel.MouseDown += MsDown;
            ControlBoxPanel.MouseMove += MsMove;
            ControlBoxPanel.MouseUp += MsUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(213, 6);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 8;
            label1.Text = "21 февраль 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += MsDown;
            label1.MouseMove += MsMove;
            label1.MouseUp += MsUp;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            //panel1.BackgroundImage = Properties.Resources.main_icon;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(1128, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(35, 35);
            panel1.TabIndex = 1;
            // 
            // Maximize_btn
            // 
            Maximize_btn.BackColor = Color.Transparent;
            Maximize_btn.BackgroundImage = Properties.Resources.min_def;
            Maximize_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Maximize_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Maximize_btn.FlatAppearance.BorderSize = 0;
            Maximize_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Maximize_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Maximize_btn.FlatStyle = FlatStyle.Flat;
            Maximize_btn.Location = new Point(66, 15);
            Maximize_btn.Name = "Maximize_btn";
            Maximize_btn.Size = new Size(20, 20);
            Maximize_btn.TabIndex = 0;
            Maximize_btn.UseVisualStyleBackColor = false;
            Maximize_btn.Click += MaxMinBtn_Click;
            Maximize_btn.MouseLeave += Maximize_btn_MouseLeave;
            Maximize_btn.MouseMove += Maximize_btn_MouseMove;
            // 
            // CurDateLbl
            // 
            CurDateLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CurDateLbl.Font = new Font("Segoe UI Variable Text", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurDateLbl.ForeColor = SystemColors.ControlDark;
            CurDateLbl.Location = new Point(908, 10);
            CurDateLbl.Name = "CurDateLbl";
            CurDateLbl.Size = new Size(214, 31);
            CurDateLbl.TabIndex = 6;
            CurDateLbl.Text = "21 февраль 2025";
            CurDateLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Minimize_btn
            // 
            Minimize_btn.BackColor = Color.Transparent;
            Minimize_btn.BackgroundImage = Properties.Resources.hide_def;
            Minimize_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Minimize_btn.FlatAppearance.BorderSize = 0;
            Minimize_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Minimize_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Minimize_btn.FlatStyle = FlatStyle.Flat;
            Minimize_btn.Location = new Point(42, 15);
            Minimize_btn.Name = "Minimize_btn";
            Minimize_btn.Size = new Size(20, 20);
            Minimize_btn.TabIndex = 0;
            Minimize_btn.UseVisualStyleBackColor = false;
            Minimize_btn.Click += Minimize_btn_Click;
            Minimize_btn.MouseLeave += Minimize_btn_MouseLeave;
            Minimize_btn.MouseMove += Minimize_btn_MouseMove;
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Transparent;
            Close_btn.BackgroundImage = Properties.Resources.close_def;
            Close_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Close_btn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Close_btn.FlatAppearance.BorderSize = 0;
            Close_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Close_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Close_btn.FlatStyle = FlatStyle.Flat;
            Close_btn.Location = new Point(18, 15);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(20, 20);
            Close_btn.TabIndex = 0;
            Close_btn.UseVisualStyleBackColor = false;
            Close_btn.Click += Close_btn_Click;
            Close_btn.MouseLeave += Close_btn_MouseLeave;
            Close_btn.MouseMove += Close_btn_MouseMove;
            // 
            // ControlBox
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(ControlBoxPanel);
            Name = "ControlBox";
            Size = new Size(640, 45);
            ControlBoxPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ControlBoxPanel;
        private Panel panel1;
        private Button Maximize_btn;
        private Label CurDateLbl;
        private Button Minimize_btn;
        private Button Close_btn;
        private Label label1;
    }
}
