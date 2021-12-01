using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        private string FilePath = @"C:\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFileList(FilePath);

            DiskLists();
        }

        //вывод файлов
        public void ShowFileList(string FilePath)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(FilePath);
                DirectoryInfo[] dirs = directoryInfo.GetDirectories();
                FileInfo[] files = directoryInfo.GetFiles();

                //Очистить ListFiles
                ListFiles.Items.Clear();

                string[] sizeletters = new string[] { "bytes", "KB", "MB", "GB"};

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

                    if (fileInfo.Length < (1000 * 1000))
                    {
                        item.SubItems.Add($"{fileInfo.Length / 1000} KB");
                    }
                    else if (fileInfo.Length < (1000 * 1000 * 1000))
                    {
                        item.SubItems.Add($"{fileInfo.Length / (1000 * 1000)} MB");
                    }
                    else
                    {
                        item.SubItems.Add($"{fileInfo.Length / (1000 * 1000 * 1000)} GB");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Обновите адресную строку
            FilePathTextBox.Text = FilePath;
        }

        //вывод дисков в бокс
        public void DiskLists()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in allDrives)
            {
                ListDisk.Items.Add(item.Name);
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

        //открытие файла/папки
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

        //обновить данные
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FilePath = FilePathTextBox.Text;
            ShowFileList(FilePath);
        }

        //Вывод файлов по диску
        private void ListDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Convert.ToString((sender as ComboBox).SelectedItem);

            FilePathTextBox.Text = path;

            ShowFileList(path);
        }
    }
}
