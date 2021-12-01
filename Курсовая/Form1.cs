using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        private string FilePath = @"C:\";
        private bool isInitializeTvwDirectory = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFileList(FilePath);

            OutputDiskAndPath();
        }

        public void ShowFileList(string FilePath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(FilePath);
                DirectoryInfo[] dirs = directoryInfo.GetDirectories();
                FileInfo[] files = directoryInfo.GetFiles();

                //Очистить ListFiles
                ListFiles.Items.Clear();

                //Список всех папок
                foreach (DirectoryInfo dirInfo in dirs)
                {
                    ListViewItem item = ListFiles.Items.Add(dirInfo.Name, 2);
                    item.Tag = dirInfo.FullName;
                    item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                    item.SubItems.Add("папка");
                    item.SubItems.Add("");
                }

                //Список всех файлов
                foreach (FileInfo fileInfo in files)
                {
                    ListViewItem item = ListFiles.Items.Add(fileInfo.Name);
                    item.Tag = fileInfo.FullName;
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                    item.SubItems.Add(fileInfo.Extension + "");
                    item.SubItems.Add("");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Обновите адресную строку
            FilePathTextBox.Text = FilePath;
        }

        private void OutputDiskAndPath()
        {
            DriveInfo[] driveInformation = DriveInfo.GetDrives();

            foreach (DriveInfo info in driveInformation)
            {
                TreeNode driveNode;

                switch (info.DriveType)
                {
                    //жесткий диск
                    case DriveType.Fixed:

                        //имя диска
                        driveNode = ListDisk.Nodes.Add("Локальный диск (" + info.Name.Split('\\')[0] + ")");

                        //путь
                        driveNode.Tag = info.Name;

                        break;

                    //съемный диск
                    case DriveType.Removable:

                        //имя диска
                        driveNode = ListDisk.Nodes.Add("Отображаемое имя (" + info.Name.Split('\\')[0] + ")");

                        //путь
                        driveNode.Tag = info.Name;

                        break;
                }
            }
        }

        private void FilePathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //ввод нового адреса
            if (e.KeyCode == Keys.Enter)
            {
                string newPath = FilePathTextBox.Text;

                if (newPath == "")
                {
                    return;
                }
                else if (!Directory.Exists(newPath))
                {
                    return;
                }

                ShowFileList(newPath);
            }
        }

        private void ListDisk_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isInitializeTvwDirectory)
            {
                FilePath = @"C:\";
                FilePathTextBox.Text = FilePath;

                //Список "недавно открывавшихся" файлов отображается в правой форме.
                ShowFileList(FilePath);

                isInitializeTvwDirectory = false;
            }
            else
            {
                ShowFileList(e.Node.Tag.ToString());
            }
        }

        private void ListFiles_ItemActivate(object sender, EventArgs e)
        {
            string path = ListFiles.SelectedItems[0].Tag.ToString();

            try
            {
                //Если выбрана папка
                if (Directory.Exists(path))
                {
                    //Открыть папку
                    ShowFileList(path);
                }
                //Если выбранный файл
                else
                {
                    //открыть файл
                    Process.Start(path);
                }
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowFileList(FilePath);
        }
    }
}
