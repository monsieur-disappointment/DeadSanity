using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace lab1
{
    public partial class MainWindow : Form
    {
        private bool tbchanged = false;
        private string filePath = null;

        public string _txt_list = "";

        bool needClear = false;

        public MainWindow()
        {
            InitializeComponent();
            InputTextBox.KeyPress += InputTextBox_KeyPress;
        }

        //private void StartButton_Click(object sender, EventArgs e)
        //{
        //    OutputTextBox.Text += "\n----------------------DATE------------------------\n";

        //    List<double> statesData = new List<double>(StateMachine.StatingDate(InputTextBox).Item1);
        //    List<char> lettersData = new List<char>(StateMachine.StatingDate(InputTextBox).Item2);
        //    for (int i = 0; i < statesData.Count; i++)
        //        OutputTextBox.Text += statesData[i].ToString() + " [" + lettersData[i].ToString() + "] -> ";
        //    OutputTextBox.Text += "\n\n";
        //    List<char> dataData = new List<char>(StateMachine.StatingDate(InputTextBox).Item3);
        //    for (int i = 0; i < dataData.Count; i++)
        //        OutputTextBox.Text += dataData[i];

        //    OutputTextBox.Text += "\n----------------------ACTIONS------------------------\n";

        //    List<double> statesAction = new List<double>(StateMachine.StatingAction(InputTextBox).Item1);
        //    List<char> lettersAction = new List<char>(StateMachine.StatingAction(InputTextBox).Item2);
        //    for (int i = 0; i < statesAction.Count; i++)
        //        OutputTextBox.Text += statesAction[i].ToString() + " [" + lettersAction[i].ToString() + "] -> ";
        //    OutputTextBox.Text += "\n\n";
        //    List<char> dataAction = new List<char>(StateMachine.StatingAction(InputTextBox).Item3);
        //    for (int i = 0; i < dataAction.Count; i++)
        //        OutputTextBox.Text += dataAction[i];


        //    /*List<List<string>> matches = new List<List<string>>(TextWorker.ParseFile(InputTextBox));
        //    for(int j = 0; j < matches[0].Count; j++)
        //        for (int i = 0; i < matches.Count; i++)
        //            OutputTextBox.Text += matches[i][j].ToString();*/
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            Scaner s = new Scaner(InputTextBox.Text);
            OutputTextBox.Clear();
            OutputTextBox.Text = s.Analyse();
        }

        private void FileCreateButton_Click(object sender, EventArgs e)
        {
            Process.Start("lab1.exe", "-t");
        }
        private void FileOpenButton_Click(object sender, EventArgs e)
        {
            if (tbchanged) {
                DialogResult message = MessageBox.Show("Save changes?", "Open file", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if(filePath != null) FileWorker.Save(ref InputTextBox, ref tbchanged, ref filePath);
                    else FileWorker.SaveAs(ref InputTextBox, ref tbchanged, ref filePath);
                    FileWorker.Open(ref InputTextBox, ref tbchanged, ref filePath);
                }
                else if (message == DialogResult.No) FileWorker.Open(ref InputTextBox, ref tbchanged, ref filePath);
                else return;
            }
            else FileWorker.Open(ref InputTextBox, ref tbchanged, ref filePath);
        }
        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            FileWorker.Save(ref InputTextBox, ref tbchanged, ref filePath);
        }
        private void FileSaveAsButton_Click(object sender, EventArgs e)
        {
            FileWorker.SaveAs(ref InputTextBox, ref tbchanged, ref filePath);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            tbchanged = true;
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (needClear)
            {
                _txt_list = "";
                needClear = false;
            }
            if (_txt_list.EndsWith(" ")) _txt_list = "";
            _txt_list +=  e.KeyChar;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!tbchanged) return;

            DialogResult message = MessageBox.Show("Save changes?", "Open file", MessageBoxButtons.YesNoCancel);

            switch (message)
            {
                case DialogResult.Yes:
                    if (filePath != null) FileWorker.Save(ref InputTextBox, ref tbchanged, ref filePath);
                    else FileWorker.SaveAs(ref InputTextBox, ref tbchanged, ref filePath);
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    return;
            }
            return;
        }

        private void EditCancelButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Undo();
        }

        private void EditRepeatButton_Click(object sender, EventArgs e)
        {
            InputTextBox.AppendText(_txt_list.Trim());
            needClear = true;
        }

        private void EditCutButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.SelectionLength > 0)
            {
                InputTextBox.Cut();
            }
        }

        private void EditCopyButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.SelectionLength > 0)
            {
                InputTextBox.Copy();
            }
        }

        private void EditPasteButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Paste();
            needClear = true;
        }

        private void EditDeleteButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.SelectionLength > 0)
            {
                InputTextBox.SelectedText = "";
            }
        }

        private void EditPickAllButton_Click(object sender, EventArgs e)
        {
            InputTextBox.SelectAll();
        }

        private void WorkCopyButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.SelectionLength > 0)
            {
                InputTextBox.Copy();
            }
        }

        private void WorkCutButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.SelectionLength > 0)
            {
                InputTextBox.Cut();
            }
        }

        private void WorkPasteButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Paste();
        }

        private void WorkUndoButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Undo();
            needClear = true;
        }

        private void WorkRedoButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Redo();
        }

        private void AboutProgButton_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void HelpProviderButton_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "help.htm";
            proc.Start();
        }

        private void fontBigger_Click(object sender, EventArgs e)
        {
            InputTextBox.Font = new Font("Segoe UI", InputTextBox.Font.Size + 6);
            OutputTextBox.Font = new Font("Segoe UI", OutputTextBox.Font.Size + 6);
        }

        private void fontSmaller_Click(object sender, EventArgs e)
        {
            InputTextBox.Font = new Font("Segoe UI", InputTextBox.Font.Size - 6);
            OutputTextBox.Font = new Font("Segoe UI", OutputTextBox.Font.Size - 6);
        }
    }

}
