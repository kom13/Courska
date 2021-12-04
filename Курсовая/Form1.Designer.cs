
namespace Курсовая
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ImageList imageList;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListFiles = new System.Windows.Forms.ListView();
            this.namr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FilePathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ListDisk = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.CutFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Reflesh = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            imageList.Images.SetKeyName(0, "icons8-папка-50.icon");
            imageList.Images.SetKeyName(1, "reload_update_refresh_icon_143703.png");
            imageList.Images.SetKeyName(2, "Generica_25576.png");
            imageList.Images.SetKeyName(3, "-forward_90600.png");
            imageList.Images.SetKeyName(4, "txt_5583.png");
            // 
            // ListFiles
            // 
            this.ListFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namr,
            this.columnHeader2,
            this.FileType,
            this.columnHeader4});
            this.ListFiles.HideSelection = false;
            this.ListFiles.Location = new System.Drawing.Point(3, 58);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(867, 444);
            this.ListFiles.SmallImageList = imageList;
            this.ListFiles.TabIndex = 0;
            this.ListFiles.UseCompatibleStateImageBehavior = false;
            this.ListFiles.View = System.Windows.Forms.View.Details;
            this.ListFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListFiles_AfterLabelEdit);
            this.ListFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
            this.ListFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListFiles_ItemDrag);
            this.ListFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListFiles_MouseClick);
            // 
            // namr
            // 
            this.namr.Text = "Имя";
            this.namr.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Дата изменения";
            this.columnHeader2.Width = 136;
            // 
            // FileType
            // 
            this.FileType.Text = "Тип файла";
            this.FileType.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "размер";
            this.columnHeader4.Width = 136;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.FilePathTextBox,
            this.toolStripButton3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(64, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(740, 27);
            this.FilePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilePathTextBox_KeyDown);
            // 
            // ListDisk
            // 
            this.ListDisk.FormattingEnabled = true;
            this.ListDisk.Location = new System.Drawing.Point(3, 25);
            this.ListDisk.Name = "ListDisk";
            this.ListDisk.Size = new System.Drawing.Size(58, 24);
            this.ListDisk.TabIndex = 4;
            this.ListDisk.SelectedIndexChanged += new System.EventHandler(this.ListDisk_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileOrFolder,
            this.Delete,
            this.CutFileOrFolder,
            this.Insert,
            this.Rename,
            this.CopyFileOrFolder,
            this.Reflesh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 172);
            // 
            // CreateFileOrFolder
            // 
            this.CreateFileOrFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.CreateFileOrFolder.Name = "CreateFileOrFolder";
            this.CreateFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CreateFileOrFolder.Text = "Создать";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.папкуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.файлToolStripMenuItem.Text = "Текстовый документ";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 24);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CutFileOrFolder
            // 
            this.CutFileOrFolder.Name = "CutFileOrFolder";
            this.CutFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CutFileOrFolder.Text = "Вырезать";
            this.CutFileOrFolder.Click += new System.EventHandler(this.CutFileOrFolder_Click_1);
            // 
            // Insert
            // 
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(190, 24);
            this.Insert.Text = "Вставить";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Rename
            // 
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(190, 24);
            this.Rename.Text = "Переименовать";
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // CopyFileOrFolder
            // 
            this.CopyFileOrFolder.Name = "CopyFileOrFolder";
            this.CopyFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CopyFileOrFolder.Text = "Копировать";
            this.CopyFileOrFolder.Click += new System.EventHandler(this.CopyFileOrFolder_Click);
            // 
            // Reflesh
            // 
            this.Reflesh.Name = "Reflesh";
            this.Reflesh.Size = new System.Drawing.Size(190, 24);
            this.Reflesh.Text = "Обновить";
            this.Reflesh.Click += new System.EventHandler(this.Reflesh_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(29, 24);
            this.BackButton.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.ListDisk);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListFiles;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox FilePathTextBox;
        public System.Windows.Forms.ColumnHeader namr;
        private System.Windows.Forms.ComboBox ListDisk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem CutFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem Rename;
        private System.Windows.Forms.ToolStripMenuItem CopyFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem Reflesh;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

