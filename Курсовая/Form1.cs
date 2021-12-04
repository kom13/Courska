using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        private string FilePath = @"C:\";

        private ListView Active;

        private bool IsMove = false;

        private string[] SelectedFiles = new string[200];

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

                string[] size = new string[] { "bytes", "KB", "MB" };

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
                    if (fileInfo.Extension == ".txt")
                    {
                        ListViewItem item = ListFiles.Items.Add(fileInfo.Name, 4);

                        item.Tag = fileInfo.FullName;

                        item.SubItems.Add(fileInfo.LastWriteTime.ToString());

                        item.SubItems.Add(fileInfo.Extension + "");

                        if (fileInfo.Length <= 1024)
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length, 2)} байт");
                        }
                        else if (fileInfo.Length <= (1024 * 1024))
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length / 1024, 2)} КБ");
                        }
                        else
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length / (1024 * 1024), 2)} МБ");
                        }
                    }
                    else
                    {
                        ListViewItem item = ListFiles.Items.Add(fileInfo.Name);

                        item.Tag = fileInfo.FullName;

                        item.SubItems.Add(fileInfo.LastWriteTime.ToString());

                        item.SubItems.Add(fileInfo.Extension + "");

                        if (fileInfo.Length <= 1024)
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length, 2)} байт");
                        }
                        else if (fileInfo.Length <= (1024 * 1024))
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length / 1024, 2)} КБ");
                        }
                        else
                        {
                            item.SubItems.Add($"{Math.Round((float)fileInfo.Length / (1024 * 1024), 2)} МБ");
                        }
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

        //вывод дисков
        public void DiskLists()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            ListDisk.Items.Clear();

            foreach (var item in allDrives)
            {
                ListDisk.Items.Add(item);
            }
        }

        //Ввод с клавиатуры после нажатия enter
        private void FilePathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //ввод нового адреса
            if (e.KeyCode == Keys.Enter)
            {
                FilePath = FilePathTextBox.Text;

                if (FilePath == "")
                {
                    return;
                }
                else if (!Directory.Exists(FilePath))
                {
                    return;
                }

                ShowFileList(FilePath);
            }
        }

        //открытие файла/папки
        private void ListFiles_ItemActivate(object sender, EventArgs e)
        {
            FilePath = ListFiles.SelectedItems[0].Tag.ToString();

            try
            {
                //Если выбрана папка
                if (Directory.Exists(FilePath))
                {
                    //Открыть папку
                    ShowFileList(FilePath);
                }
                //Если выбранный файл
                else
                {
                    //открыть файл
                    Process.Start(FilePath);
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

            DiskLists();
        }

        //Вывод файлов по диску
        private void ListDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilePath = Convert.ToString((sender as ComboBox).SelectedItem);

            FilePathTextBox.Text = FilePath;

            ShowFileList(FilePath);
        }

        //вызвать меню правой клавишей мыши
        private void ListFiles_MouseClick(object sender, MouseEventArgs e)
        {
            Active = ListFiles;

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        //создать папку
        private void папкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 1;
                string path = Path.Combine(FilePath, "новая папка");
                string newFolderPath = path;

                while (Directory.Exists(newFolderPath))
                {
                    newFolderPath = path + "(" + num + ")";
                    num++;
                }

                Directory.CreateDirectory(newFolderPath);

                ListViewItem item = ListFiles.Items.Add("новая папка" + (num == 1 ? "" : "(" + (num - 1) + ")"), 0);

                //Реальный путь
                item.Tag = newFolderPath;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //создать файл txt
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = 1;
            string newFile = "новый файл";
            string path = Path.Combine(FilePath, newFile);
            string newFilePath = path;

            while (File.Exists(newFilePath + ".txt"))
            {
                newFilePath = path + "(" + num + ")";

                num++;
            }

            File.Create(newFilePath + ".txt");

            ListViewItem item = ListFiles.Items.Add("новый файл" + (num == 1 ? ("") : ("(" + (num - 1) + ")")), 4);

            //Реальный путь
            item.Tag = newFilePath;
        }

        //обновить список
        private void Reflesh_Click(object sender, EventArgs e)
        {
            FilePath = FilePathTextBox.Text;

            ShowFileList(FilePath);

            DiskLists();
        }

        //удалить
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in ListFiles.SelectedItems)
                {
                    string path = item.Tag.ToString();

                    //если это файл
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    //если это папка
                    else if (Directory.Exists(path))
                    {
                        Directory.Delete(path);
                    }

                    ListFiles.Items.Remove(item);
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //недопустимые значения в имени
        private bool IsValidFileName(string fileName)
        {
            bool isValid = true;

            //недопустимые символы
            string errChar = "\\/:*?\"<>|";

            for (int i = 0; i < errChar.Length; i++)
            {
                if (fileName.Contains(errChar[i].ToString()))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        //переименовать файл/папку
        private void Rename_Click(object sender, EventArgs e)
        {
            if (ListFiles.SelectedItems.Count > 0)
            {
                //По сути, имитируйте редактирование метки, чтобы вызвать событие LabelEdit через код.
                ListFiles.SelectedItems[0].BeginEdit();
            }
        }

        //скопировать файл/папку
        private void Copy_Click(object sender, EventArgs e)
        {
            if (ListFiles.SelectedItems.Count > 0)
            {
                int i = 0;

                foreach (ListViewItem item in ListFiles.SelectedItems)
                {
                    SelectedFiles[i++] = item.Tag.ToString();
                }
            }
        }

        private void CopyAndPasteDirectory(DirectoryInfo files, DirectoryInfo destDirInfo)
        {
            //Создать целевую папку
            if (!Directory.Exists(destDirInfo.FullName))
            {
                Directory.CreateDirectory(destDirInfo.FullName);
            }
            //Скопируйте файл и вставьте его в папку назначения
            foreach (FileInfo fileInfo in files.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destDirInfo.FullName, fileInfo.Name));
            }

            //Рекурсивно скопируйте и вставьте подпапки в целевую папку
            foreach (DirectoryInfo dir in files.GetDirectories())
            {
                DirectoryInfo destSubDirInfo = destDirInfo.CreateSubdirectory(dir.Name);

                CopyAndPasteDirectory(dir, destSubDirInfo);
            }
        }

        private void ListFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FilePath = Convert.ToString((sender as ComboBox).SelectedItem);
            ListFiles.DoDragDrop(FilePath + "\\" + ListFiles.FocusedItem.Text, DragDropEffects.Copy);
        }

        //копирование файлов/папок
        private void CopyFileOrFolder_Click(object sender, EventArgs e)
        {
            if (ListFiles.SelectedItems.Count > 0)
            {
                int i = 0;

                foreach (ListViewItem item in ListFiles.SelectedItems)
                {
                    SelectedFiles[i++] = item.Tag.ToString();
                }

                IsMove = false;
            }
        }

        //вставить файл/папку
        private void Insert_Click(object sender, EventArgs e)
        {
            if (SelectedFiles[0] == null)
            {
                return;
            }
            else
            {
                for (int i = 0; SelectedFiles[i] != null; i++)
                {
                    //Если это файл
                    if (File.Exists(SelectedFiles[i]))
                    {
                        //«Переместить в» или «Копировать в» исполняемого файла
                        MoveOrCopyToFile(SelectedFiles[i]);
                    }
                    //Если это папка
                    else if (Directory.Exists(SelectedFiles[i]))
                    {
                        //Выполните папку «переместить в» или «скопировать в»
                        MoveOrCopyToFolder(SelectedFiles[i]);
                    }
                }

                FilePath = FilePathTextBox.Text;

                ShowFileList(FilePath);

                SelectedFiles = new string[200];
            }
        }

        private void MoveOrCopyToFile(string sourcePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                //Получить путь к месту назначения
                string path = Path.Combine(FilePathTextBox.Text, fileInfo.Name);

                //Если целевой путь совпадает с исходным,
                //никакие операции не выполняются.
                if (path == sourcePath)
                {
                    return;
                }

                //(в настоящее время выполняется операция «вырезать + вставить»)
                else if (IsMove)
                {
                    fileInfo.MoveTo(path);
                }
                //Вставьте файл в целевой путь
                //(в настоящее время выполняется операция «копировать + вставить»)
                else
                {
                    fileInfo.CopyTo(path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MoveOrCopyToFolder(string sourcePath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(sourcePath);

                //Получить путь к месту перемещения
                string path = Path.Combine(FilePathTextBox.Text, dirInfo.Name);

                //Если целевой путь совпадает с исходным, операции не выполняются.
                if (path == sourcePath)
                {
                    return;
                }

                //вырезать + вставить
                if (IsMove)
                {
                    //Рекурсивно скопируйте и вставьте папку (включая все файлы в папке)
                    CopyAndPasteDirectory(dirInfo, new DirectoryInfo(path));

                    //Удалить исходную папку
                    Directory.Delete(sourcePath);

                }
                //копировать + вставить
                else
                {
                    //вставка всех файлов, с данными внутри
                    CopyAndPasteDirectory(dirInfo, new DirectoryInfo(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Вырезать файл/папку
        private void CutFileOrFolder_Click_1(object sender, EventArgs e)
        {
            if (ListFiles.SelectedItems.Count > 0)
            {
                int i = 0;

                foreach (ListViewItem item in ListFiles.SelectedItems)
                {
                    SelectedFiles[i++] = item.Tag.ToString();
                }

                IsMove = true;
            }
        }

        private void ListFiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newName = e.Label;

            //Выбранный элемент
            ListViewItem selectedItem = ListFiles.SelectedItems[0];

            //Если имя пустое
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Имя файла не может быть пустым!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Когда отображается, восстановить исходную метку
                e.CancelEdit = true;
            }
            //Этикетка не изменилась
            else if (newName == null)
            {
                return;
            }
            //Ярлык изменился, но в итоге остался прежним
            else if (newName == selectedItem.Text)
            {
                return;
            }
            //Имя файла недействительно
            else if (!IsValidFileName(newName))
            {
                MessageBox.Show("Имя файла не может содержать ни один из следующих символов:\r\n" + "\t\\/:*?\"<>|", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Когда отображается, восстановить исходную метку
                e.CancelEdit = true;
            }
            else
            {
                //Если это папка
                if (Directory.Exists(selectedItem.Tag.ToString()))
                {
                    //Если в текущем пути есть папка с таким же именем
                    if (Directory.Exists(Path.Combine(FilePath, newName)))
                    {
                        MessageBox.Show("В текущем пути есть папка с таким же именем！", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Когда отображается, восстановить исходную метку
                        e.CancelEdit = true;
                    }
                }
            }
        }
    }
}