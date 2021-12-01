
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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListDisk = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FilePathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ListDisks = new System.Windows.Forms.ComboBox();
            imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
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
            // 
            // ListFiles
            // 
            this.ListFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namr,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListFiles.HideSelection = false;
            this.ListFiles.Location = new System.Drawing.Point(217, 80);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(571, 358);
            this.ListFiles.SmallImageList = imageList;
            this.ListFiles.TabIndex = 0;
            this.ListFiles.UseCompatibleStateImageBehavior = false;
            this.ListFiles.View = System.Windows.Forms.View.Details;
            this.ListFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Файл";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "размер";
            this.columnHeader4.Width = 69;
            // 
            // ListDisk
            // 
            this.ListDisk.Location = new System.Drawing.Point(12, 80);
            this.ListDisk.Name = "ListDisk";
            this.ListDisk.Size = new System.Drawing.Size(199, 358);
            this.ListDisk.TabIndex = 1;
            this.ListDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListDisk_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilePathTextBox,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(217, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(500, 27);
            this.FilePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilePathTextBox_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ListDisks
            // 
            this.ListDisks.FormattingEnabled = true;
            this.ListDisks.Location = new System.Drawing.Point(12, 29);
            this.ListDisks.Name = "ListDisks";
            this.ListDisks.Size = new System.Drawing.Size(88, 24);
            this.ListDisks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListDisks);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListDisk);
            this.Controls.Add(this.ListFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListFiles;
        private System.Windows.Forms.TreeView ListDisk;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox FilePathTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ColumnHeader namr;
        private System.Windows.Forms.ComboBox ListDisks;
    }
}

