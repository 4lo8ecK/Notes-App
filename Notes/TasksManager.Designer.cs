namespace TaskSaver
{
    partial class TasksManager
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
            CurDateLbl = new Label();
            TextBoxCorn = new Panel();
            TaskTextBox = new TextBox();
            TasksLbl = new Label();
            newTaskBtn = new Button();
            tasksContasiner = new FlowLayoutPanel();
            MainPanel.SuspendLayout();
            TextBoxCorn.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(CurDateLbl);
            MainPanel.Controls.Add(TextBoxCorn);
            MainPanel.Controls.Add(TasksLbl);
            MainPanel.Controls.Add(newTaskBtn);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(650, 125);
            MainPanel.TabIndex = 1;
            // 
            // CurDateLbl
            // 
            CurDateLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CurDateLbl.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CurDateLbl.ForeColor = SystemColors.GrayText;
            CurDateLbl.Location = new Point(418, 25);
            CurDateLbl.Name = "CurDateLbl";
            CurDateLbl.Size = new Size(214, 31);
            CurDateLbl.TabIndex = 9;
            CurDateLbl.Text = "21 февраль 2025";
            CurDateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxCorn
            // 
            TextBoxCorn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxCorn.BackColor = SystemColors.Control;
            TextBoxCorn.Controls.Add(TaskTextBox);
            TextBoxCorn.Location = new Point(141, 67);
            TextBoxCorn.Name = "TextBoxCorn";
            TextBoxCorn.Size = new Size(493, 40);
            TextBoxCorn.TabIndex = 7;
            // 
            // TaskTextBox
            // 
            TaskTextBox.BackColor = SystemColors.Control;
            TaskTextBox.BorderStyle = BorderStyle.None;
            TaskTextBox.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskTextBox.Location = new Point(18, 8);
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(425, 25);
            TaskTextBox.TabIndex = 8;
            TaskTextBox.Text = "Введите текст";
            TaskTextBox.Enter += TaskTextBox_Click;
            TaskTextBox.KeyDown += TaskTextBox_KeyDown;
            TaskTextBox.Leave += TaskTextBox_Leave;
            // 
            // TasksLbl
            // 
            TasksLbl.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksLbl.ImageAlign = ContentAlignment.TopCenter;
            TasksLbl.Location = new Point(19, 25);
            TasksLbl.Name = "TasksLbl";
            TasksLbl.Size = new Size(230, 41);
            TasksLbl.TabIndex = 5;
            TasksLbl.Text = "Заметки";
            // 
            // newTaskBtn
            // 
            newTaskBtn.BackColor = Color.FromArgb(35, 75, 230);
            newTaskBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            newTaskBtn.FlatAppearance.BorderSize = 0;
            newTaskBtn.FlatStyle = FlatStyle.Flat;
            newTaskBtn.Font = new Font("Segoe UI Variable Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newTaskBtn.ForeColor = SystemColors.ControlLightLight;
            newTaskBtn.ImageAlign = ContentAlignment.TopCenter;
            newTaskBtn.Location = new Point(20, 67);
            newTaskBtn.Name = "newTaskBtn";
            newTaskBtn.Size = new Size(115, 41);
            newTaskBtn.TabIndex = 4;
            newTaskBtn.Text = "+ Добавить";
            newTaskBtn.UseVisualStyleBackColor = false;
            newTaskBtn.Click += NewTaskBtn;
            // 
            // tasksContasiner
            // 
            tasksContasiner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tasksContasiner.AutoScroll = true;
            tasksContasiner.BackColor = Color.Transparent;
            tasksContasiner.Location = new Point(0, 141);
            tasksContasiner.Name = "tasksContasiner";
            tasksContasiner.Size = new Size(650, 359);
            tasksContasiner.TabIndex = 2;
            tasksContasiner.SizeChanged += TasksManager_SizeChanged;
            // 
            // TasksManager
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            Controls.Add(tasksContasiner);
            Controls.Add(MainPanel);
            Name = "TasksManager";
            Size = new Size(650, 500);
            Resize += TasksManager_SizeChanged;
            MainPanel.ResumeLayout(false);
            TextBoxCorn.ResumeLayout(false);
            TextBoxCorn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label TasksLbl;
        private Button newTaskBtn;
        private FlowLayoutPanel tasksContasiner;
        private Panel TextBoxCorn;
        private TextBox TaskTextBox;
        private Label CurDateLbl;
    }
}
