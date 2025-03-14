namespace TaskSaver
{
    partial class TaskPanel
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
            TaskNameLbl = new Label();
            Panel_Icon = new Panel();
            delBtn = new Button();
            SuspendLayout();
            // 
            // TaskNameLbl
            // 
            TaskNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TaskNameLbl.AutoEllipsis = true;
            TaskNameLbl.BackColor = Color.Transparent;
            TaskNameLbl.Font = new Font("Segoe UI Variable Small Semibol", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskNameLbl.ImageAlign = ContentAlignment.MiddleLeft;
            TaskNameLbl.Location = new Point(45, 8);
            TaskNameLbl.Name = "TaskNameLbl";
            TaskNameLbl.Size = new Size(522, 35);
            TaskNameLbl.TabIndex = 0;
            TaskNameLbl.Text = "TaskName";
            TaskNameLbl.TextAlign = ContentAlignment.MiddleLeft;
            TaskNameLbl.UseCompatibleTextRendering = true;
            TaskNameLbl.Click += TaskNameLbl_Click;
            // 
            // Panel_Icon
            // 
            Panel_Icon.BackgroundImage = Properties.Resources.text_edit_icon;
            Panel_Icon.BackgroundImageLayout = ImageLayout.Zoom;
            Panel_Icon.Location = new Point(7, 6);
            Panel_Icon.Name = "Panel_Icon";
            Panel_Icon.Size = new Size(35, 35);
            Panel_Icon.TabIndex = 1;
            Panel_Icon.Visible = false;
            // 
            // delBtn
            // 
            delBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            delBtn.BackgroundImage = Properties.Resources.delete_task_icon;
            delBtn.BackgroundImageLayout = ImageLayout.Zoom;
            delBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            delBtn.FlatAppearance.BorderSize = 0;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Location = new Point(570, 8);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(35, 35);
            delBtn.TabIndex = 2;
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += button1_Click;
            // 
            // TaskPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(delBtn);
            Controls.Add(Panel_Icon);
            Controls.Add(TaskNameLbl);
            Name = "TaskPanel";
            Size = new Size(620, 50);
            ResumeLayout(false);
        }

        #endregion

        private Label TaskNameLbl;
        private Panel Panel_Icon;
        private Button delBtn;
    }
}
