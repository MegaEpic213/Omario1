using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextFileViewer
{
    public partial class MainForm : Form
    {
        private string currentDirectory;
        private string currentFile;
        private Encoding currentEncoding = Encoding.GetEncoding(1251);

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Просмотр текстовых файлов";
        }

        private void InitializeComponent()
        {
            this.labelDirectory = new Label();
            this.listBoxFiles = new ListBox();
            this.textBoxContent = new TextBox();
            this.buttonSelectDirectory = new Button();
            this.buttonExit = new Button();
            this.folderBrowserDialog = new FolderBrowserDialog();
            this.groupBoxEncoding = new GroupBox();
            this.radioButtonUnicode = new RadioButton();
            this.radioButtonWestEuropean = new RadioButton();
            this.radioButtonCyrillic = new RadioButton();
            this.groupBoxEncoding.SuspendLayout();
            this.SuspendLayout();

            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 9);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(95, 13);
            this.labelDirectory.TabIndex = 0;
            this.labelDirectory.Text = "Каталог не выбран";

            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 25);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(200, 300);
            this.listBoxFiles.Sorted = true;
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiles_SelectedIndexChanged);

            this.textBoxContent.Location = new System.Drawing.Point(218, 25);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.ScrollBars = ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(400, 300);
            this.textBoxContent.TabIndex = 2;

            this.buttonSelectDirectory.Location = new System.Drawing.Point(12, 331);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(120, 30);
            this.buttonSelectDirectory.TabIndex = 3;
            this.buttonSelectDirectory.Text = "Выбрать каталог";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.ButtonSelectDirectory_Click);

            this.buttonExit.Location = new System.Drawing.Point(498, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);

            this.folderBrowserDialog.Description = "Выберите каталог с текстовыми файлами";
            this.folderBrowserDialog.ShowNewFolderButton = false;

            this.groupBoxEncoding.Controls.Add(this.radioButtonUnicode);
            this.groupBoxEncoding.Controls.Add(this.radioButtonWestEuropean);
            this.groupBoxEncoding.Controls.Add(this.radioButtonCyrillic);
            this.groupBoxEncoding.Location = new System.Drawing.Point(218, 331);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(200, 100);
            this.groupBoxEncoding.TabIndex = 5;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Кодировка";

            this.radioButtonCyrillic.AutoSize = true;
            this.radioButtonCyrillic.Checked = true;
            this.radioButtonCyrillic.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCyrillic.Name = "radioButtonCyrillic";
            this.radioButtonCyrillic.Size = new System.Drawing.Size(68, 17);
            this.radioButtonCyrillic.TabIndex = 0;
            this.radioButtonCyrillic.TabStop = true;
            this.radioButtonCyrillic.Text = "Кириллица";
            this.radioButtonCyrillic.UseVisualStyleBackColor = true;
            this.radioButtonCyrillic.CheckedChanged += new System.EventHandler(this.Encoding_CheckedChanged);

            this.radioButtonWestEuropean.AutoSize = true;
            this.radioButtonWestEuropean.Location = new System.Drawing.Point(6, 42);
            this.radioButtonWestEuropean.Name = "radioButtonWestEuropean";
            this.radioButtonWestEuropean.Size = new System.Drawing.Size(112, 17);
            this.radioButtonWestEuropean.TabIndex = 1;
            this.radioButtonWestEuropean.Text = "Западноевропейская";
            this.radioButtonWestEuropean.UseVisualStyleBackColor = true;
            this.radioButtonWestEuropean.CheckedChanged += new System.EventHandler(this.Encoding_CheckedChanged);

            this.radioButtonUnicode.AutoSize = true;
            this.radioButtonUnicode.Location = new System.Drawing.Point(6, 65);
            this.radioButtonUnicode.Name = "radioButtonUnicode";
            this.radioButtonUnicode.Size = new System.Drawing.Size(65, 17);
            this.radioButtonUnicode.TabIndex = 2;
            this.radioButtonUnicode.Text = "Юникод";
            this.radioButtonUnicode.UseVisualStyleBackColor = true;
            this.radioButtonUnicode.CheckedChanged += new System.EventHandler(this.Encoding_CheckedChanged);

            this.ClientSize = new System.Drawing.Size(630, 440);
            this.Controls.Add(this.groupBoxEncoding);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.labelDirectory);
            this.Name = "MainForm";
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label labelDirectory;
        private ListBox listBoxFiles;
        private TextBox textBoxContent;
        private Button buttonSelectDirectory;
        private Button buttonExit;
        private FolderBrowserDialog folderBrowserDialog;
        private GroupBox groupBoxEncoding;
        private RadioButton radioButtonCyrillic;
        private RadioButton radioButtonWestEuropean;
        private RadioButton radioButtonUnicode;

        private void ButtonSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                currentDirectory = folderBrowserDialog.SelectedPath;
                labelDirectory.Text = currentDirectory;
                LoadFileList();
            }
        }

        private void LoadFileList()
        {
            listBoxFiles.Items.Clear();
            textBoxContent.Clear();

            try
            {
                string[] txtFiles = Directory.GetFiles(currentDirectory, "*.txt");
                foreach (string file in txtFiles)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файлов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                currentFile = Path.Combine(currentDirectory, listBoxFiles.SelectedItem.ToString());
                LoadFileContent();
            }
        }

        private void LoadFileContent()
        {
            try
            {
                string content = File.ReadAllText(currentFile, currentEncoding);
                textBoxContent.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContent.Clear();
            }
        }

        private void Encoding_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCyrillic.Checked)
            {
                currentEncoding = Encoding.GetEncoding(1251); 
            }
            else if (radioButtonWestEuropean.Checked)
            {
                currentEncoding = Encoding.GetEncoding(1252);
            }
            else if (radioButtonUnicode.Checked)
            {
                currentEncoding = Encoding.UTF8; 
            }

            if (!string.IsNullOrEmpty(currentFile))
            {
                LoadFileContent();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}