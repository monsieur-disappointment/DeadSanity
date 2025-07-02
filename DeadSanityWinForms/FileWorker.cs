using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public class FileWorker
    {
        public static void Open(ref RichTextBox textBox, ref bool tbchanged, ref string path)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open";
            openDialog.Filter = "Текстовые файлы (*.txt) | *.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                textBox.Text = sr.ReadToEnd();
                sr.Close();
                tbchanged = false;
                path = openDialog.FileName;
            }
        }
        public static void Save(ref RichTextBox textBox, ref bool tbchanged, ref string path)
        {
            if (path != null)
            {
                if (path != "")
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.Write(textBox.Text);
                    sw.Close();
                    tbchanged = false;
                }
                else
                {
                    FileWorker.SaveAs(ref textBox, ref tbchanged, ref path);
                }
                
            }
            else
            {
                FileWorker.SaveAs(ref textBox, ref tbchanged, ref path);
            }
        }
        public static void SaveAs(ref RichTextBox textBox, ref bool tbchanged, ref string path)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save ass...";
            if (path != null) saveDialog.FileName = path;
            else saveDialog.FileName = "Новый файл";
            saveDialog.Filter = "Текстовые файлы (*.txt) | *.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(textBox.Text);
                sw.Close();
                tbchanged = false;
                path = saveDialog.FileName;
            }
            else
            {
                tbchanged = true;
                return;
            }
        }
    }
}
