namespace lab1
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохдатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRepeatButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPasteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPickAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.класификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализаицияОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpProviderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateButton = new System.Windows.Forms.Button();
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.FileSaveButton = new System.Windows.Forms.Button();
            this.WorkUndoButton = new System.Windows.Forms.Button();
            this.WorkRedoButton = new System.Windows.Forms.Button();
            this.WorkCopyButton = new System.Windows.Forms.Button();
            this.WorkCutButton = new System.Windows.Forms.Button();
            this.WorkPasteButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.fontBigger = new System.Windows.Forms.Button();
            this.fontSmaller = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохдатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохдатьToolStripMenuItem
            // 
            this.сохдатьToolStripMenuItem.Name = "сохдатьToolStripMenuItem";
            this.сохдатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохдатьToolStripMenuItem.Text = "Создать";
            this.сохдатьToolStripMenuItem.Click += new System.EventHandler(this.FileCreateButton_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAsButton_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCancelButton,
            this.EditRepeatButton,
            this.EditCutButton,
            this.EditCopyButton,
            this.EditPasteButton,
            this.EditDeleteButton,
            this.EditPickAllButton});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(148, 22);
            this.EditCancelButton.Text = "Отменить";
            this.EditCancelButton.Click += new System.EventHandler(this.EditCancelButton_Click);
            // 
            // EditRepeatButton
            // 
            this.EditRepeatButton.Name = "EditRepeatButton";
            this.EditRepeatButton.Size = new System.Drawing.Size(148, 22);
            this.EditRepeatButton.Text = "Повторить";
            this.EditRepeatButton.Click += new System.EventHandler(this.EditRepeatButton_Click);
            // 
            // EditCutButton
            // 
            this.EditCutButton.Name = "EditCutButton";
            this.EditCutButton.Size = new System.Drawing.Size(148, 22);
            this.EditCutButton.Text = "Вырезать";
            this.EditCutButton.Click += new System.EventHandler(this.EditCutButton_Click);
            // 
            // EditCopyButton
            // 
            this.EditCopyButton.Name = "EditCopyButton";
            this.EditCopyButton.Size = new System.Drawing.Size(148, 22);
            this.EditCopyButton.Text = "Копировать";
            this.EditCopyButton.Click += new System.EventHandler(this.EditCopyButton_Click);
            // 
            // EditPasteButton
            // 
            this.EditPasteButton.Name = "EditPasteButton";
            this.EditPasteButton.Size = new System.Drawing.Size(148, 22);
            this.EditPasteButton.Text = "Вставить";
            this.EditPasteButton.Click += new System.EventHandler(this.EditPasteButton_Click);
            // 
            // EditDeleteButton
            // 
            this.EditDeleteButton.Name = "EditDeleteButton";
            this.EditDeleteButton.Size = new System.Drawing.Size(148, 22);
            this.EditDeleteButton.Text = "Удалить";
            this.EditDeleteButton.Click += new System.EventHandler(this.EditDeleteButton_Click);
            // 
            // EditPickAllButton
            // 
            this.EditPickAllButton.Name = "EditPickAllButton";
            this.EditPickAllButton.Size = new System.Drawing.Size(148, 22);
            this.EditPickAllButton.Text = "Выделить всё";
            this.EditPickAllButton.Click += new System.EventHandler(this.EditPickAllButton_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.класификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализаицияОшибокToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // постановкаToolStripMenuItem
            // 
            this.постановкаToolStripMenuItem.Name = "постановкаToolStripMenuItem";
            this.постановкаToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.постановкаToolStripMenuItem.Text = "Постановка задачи";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            // 
            // класификацияГрамматикиToolStripMenuItem
            // 
            this.класификацияГрамматикиToolStripMenuItem.Name = "класификацияГрамматикиToolStripMenuItem";
            this.класификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.класификацияГрамматикиToolStripMenuItem.Text = "Класификация грамматики";
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            // 
            // диагностикаИНейтрализаицияОшибокToolStripMenuItem
            // 
            this.диагностикаИНейтрализаицияОшибокToolStripMenuItem.Name = "диагностикаИНейтрализаицияОшибокToolStripMenuItem";
            this.диагностикаИНейтрализаицияОшибокToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.диагностикаИНейтрализаицияОшибокToolStripMenuItem.Text = "Диагностика и нейтрализаиция ошибок";
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpProviderButton,
            this.AboutProgButton});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // HelpProviderButton
            // 
            this.HelpProviderButton.Name = "HelpProviderButton";
            this.HelpProviderButton.Size = new System.Drawing.Size(156, 22);
            this.HelpProviderButton.Text = "Вызов справки";
            this.HelpProviderButton.Click += new System.EventHandler(this.HelpProviderButton_Click);
            // 
            // AboutProgButton
            // 
            this.AboutProgButton.Name = "AboutProgButton";
            this.AboutProgButton.Size = new System.Drawing.Size(156, 22);
            this.AboutProgButton.Text = "О программе";
            this.AboutProgButton.Click += new System.EventHandler(this.AboutProgButton_Click);
            // 
            // FileCreateButton
            // 
            this.FileCreateButton.Image = ((System.Drawing.Image)(resources.GetObject("FileCreateButton.Image")));
            this.FileCreateButton.Location = new System.Drawing.Point(12, 27);
            this.FileCreateButton.Name = "FileCreateButton";
            this.FileCreateButton.Size = new System.Drawing.Size(45, 47);
            this.FileCreateButton.TabIndex = 1;
            this.FileCreateButton.UseVisualStyleBackColor = true;
            this.FileCreateButton.Click += new System.EventHandler(this.FileCreateButton_Click);
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FileOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("FileOpenButton.Image")));
            this.FileOpenButton.Location = new System.Drawing.Point(63, 27);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(45, 47);
            this.FileOpenButton.TabIndex = 2;
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("FileSaveButton.Image")));
            this.FileSaveButton.Location = new System.Drawing.Point(114, 27);
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(45, 47);
            this.FileSaveButton.TabIndex = 3;
            this.FileSaveButton.UseVisualStyleBackColor = true;
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // WorkUndoButton
            // 
            this.WorkUndoButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkUndoButton.Image")));
            this.WorkUndoButton.Location = new System.Drawing.Point(222, 27);
            this.WorkUndoButton.Name = "WorkUndoButton";
            this.WorkUndoButton.Size = new System.Drawing.Size(45, 47);
            this.WorkUndoButton.TabIndex = 4;
            this.WorkUndoButton.UseVisualStyleBackColor = true;
            this.WorkUndoButton.Click += new System.EventHandler(this.WorkUndoButton_Click);
            // 
            // WorkRedoButton
            // 
            this.WorkRedoButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkRedoButton.Image")));
            this.WorkRedoButton.Location = new System.Drawing.Point(268, 27);
            this.WorkRedoButton.Name = "WorkRedoButton";
            this.WorkRedoButton.Size = new System.Drawing.Size(45, 47);
            this.WorkRedoButton.TabIndex = 5;
            this.WorkRedoButton.UseVisualStyleBackColor = true;
            this.WorkRedoButton.Click += new System.EventHandler(this.WorkRedoButton_Click);
            // 
            // WorkCopyButton
            // 
            this.WorkCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkCopyButton.Image")));
            this.WorkCopyButton.Location = new System.Drawing.Point(314, 27);
            this.WorkCopyButton.Name = "WorkCopyButton";
            this.WorkCopyButton.Size = new System.Drawing.Size(45, 47);
            this.WorkCopyButton.TabIndex = 6;
            this.WorkCopyButton.UseVisualStyleBackColor = true;
            this.WorkCopyButton.Click += new System.EventHandler(this.WorkCopyButton_Click);
            // 
            // WorkCutButton
            // 
            this.WorkCutButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkCutButton.Image")));
            this.WorkCutButton.Location = new System.Drawing.Point(360, 27);
            this.WorkCutButton.Name = "WorkCutButton";
            this.WorkCutButton.Size = new System.Drawing.Size(45, 47);
            this.WorkCutButton.TabIndex = 7;
            this.WorkCutButton.UseVisualStyleBackColor = true;
            this.WorkCutButton.Click += new System.EventHandler(this.WorkCutButton_Click);
            // 
            // WorkPasteButton
            // 
            this.WorkPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("WorkPasteButton.Image")));
            this.WorkPasteButton.Location = new System.Drawing.Point(406, 27);
            this.WorkPasteButton.Name = "WorkPasteButton";
            this.WorkPasteButton.Size = new System.Drawing.Size(45, 47);
            this.WorkPasteButton.TabIndex = 8;
            this.WorkPasteButton.UseVisualStyleBackColor = true;
            this.WorkPasteButton.Click += new System.EventHandler(this.WorkPasteButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(502, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(89, 42);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.InputTextBox);
            this.InputPanel.Location = new System.Drawing.Point(12, 108);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(776, 330);
            this.InputPanel.TabIndex = 10;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(776, 330);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.Controls.Add(this.OutputTextBox);
            this.OutputPanel.Location = new System.Drawing.Point(12, 444);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(779, 190);
            this.OutputPanel.TabIndex = 11;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(779, 190);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = "";
            // 
            // HelpProvider
            // 
            this.HelpProvider.HelpNamespace = "help.htm";
            // 
            // fontBigger
            // 
            this.fontBigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontBigger.Location = new System.Drawing.Point(634, 27);
            this.fontBigger.Name = "fontBigger";
            this.fontBigger.Size = new System.Drawing.Size(49, 42);
            this.fontBigger.TabIndex = 12;
            this.fontBigger.Text = "A+";
            this.fontBigger.UseVisualStyleBackColor = true;
            this.fontBigger.Click += new System.EventHandler(this.fontBigger_Click);
            // 
            // fontSmaller
            // 
            this.fontSmaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontSmaller.Location = new System.Drawing.Point(689, 27);
            this.fontSmaller.Name = "fontSmaller";
            this.fontSmaller.Size = new System.Drawing.Size(48, 42);
            this.fontSmaller.TabIndex = 13;
            this.fontSmaller.Text = "A-";
            this.fontSmaller.UseVisualStyleBackColor = true;
            this.fontSmaller.Click += new System.EventHandler(this.fontSmaller_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.fontSmaller);
            this.Controls.Add(this.fontBigger);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WorkPasteButton);
            this.Controls.Add(this.WorkCutButton);
            this.Controls.Add(this.WorkCopyButton);
            this.Controls.Add(this.WorkRedoButton);
            this.Controls.Add(this.WorkUndoButton);
            this.Controls.Add(this.FileSaveButton);
            this.Controls.Add(this.FileOpenButton);
            this.Controls.Add(this.FileCreateButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Compiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохдатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCancelButton;
        private System.Windows.Forms.ToolStripMenuItem EditRepeatButton;
        private System.Windows.Forms.ToolStripMenuItem EditCutButton;
        private System.Windows.Forms.ToolStripMenuItem EditCopyButton;
        private System.Windows.Forms.ToolStripMenuItem EditPasteButton;
        private System.Windows.Forms.ToolStripMenuItem EditDeleteButton;
        private System.Windows.Forms.ToolStripMenuItem EditPickAllButton;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem класификацияГрамматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИНейтрализаицияОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpProviderButton;
        private System.Windows.Forms.ToolStripMenuItem AboutProgButton;
        private System.Windows.Forms.Button FileCreateButton;
        private System.Windows.Forms.Button FileOpenButton;
        private System.Windows.Forms.Button FileSaveButton;
        private System.Windows.Forms.Button WorkUndoButton;
        private System.Windows.Forms.Button WorkRedoButton;
        private System.Windows.Forms.Button WorkCopyButton;
        private System.Windows.Forms.Button WorkCutButton;
        private System.Windows.Forms.Button WorkPasteButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.Button fontBigger;
        private System.Windows.Forms.Button fontSmaller;
    }
}

