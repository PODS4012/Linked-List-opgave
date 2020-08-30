using System;
using System.Windows.Forms;
using LinkedListsOpgave3;
using System.Text.RegularExpressions;

namespace UserControls
{
    public partial class UCOpgave3 : UserControl
    {
        CustomLinkedList aNode = new CustomLinkedList();
        public UCOpgave3()
        {
            InitializeComponent();
        }

        private void BtnAddToLinkedList_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtInputData.Text);
                aNode.Add(Int32.Parse(TxtInputData.Text));
                RefreshListbox();
                TxtInputData.Text = null;
                TxtInputData.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }

        }
        private void RefreshListbox()
        {
            CustomLinkedListNode current = aNode.Head;
            ListBoxOutput.Items.Clear();
            while (current != null)
            {
                ListBoxOutput.Items.Add($"[{current.Data}]");
                current = current.Next;
            }
        }
        private void CheckTxtBox(string txt)
        {
            if (string.IsNullOrWhiteSpace(txt))
            {
                throw new FormatException($"Input feltet må ikke være tom.");
            }
        }
        private void BtnRemoveNode_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtInputData.Text);
                aNode.Remove(Int32.Parse(TxtInputData.Text));
                RefreshListbox();
                TxtInputData.Text = null;
                TxtInputData.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"{ex.Message}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }
        }

        private void BtnFindNode_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtInputData.Text);
                int data = Int32.Parse(TxtInputData.Text);
                RefreshListbox();
                string nodeLocated = aNode.Find(data).Data.ToString();
                int index = ListBoxOutput.FindString($"[{nodeLocated}");
                TxtInputData.Text = null;
                TxtInputData.Focus();
                ListBoxOutput.SetSelected(index, true);
                MessageBox.Show($"Found Data Node [{nodeLocated}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Node med nr. {TxtInputData.Text} findes ikke", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtInputData.SelectAll();
                TxtInputData.Focus();
            }
        }

        private void BtnClearNode_Click(object sender, EventArgs e)
        {
            aNode.Clear();
            RefreshListbox();
        }

        private void BtnInsertBefore_Click(object sender, EventArgs e)
        {
            if(ListBoxOutput.SelectedItem == null)
            {
                MessageBox.Show("Select Node from list box.");
            }
            else
            {
                try
                {
                    CheckTxtBox(TxtInputData.Text);
                    int data = Int32.Parse(TxtInputData.Text);
                    CustomLinkedListNode selNode = aNode.Find(Int32.Parse(CleanListValue(ListBoxOutput)));
                    bool yup = aNode.InsertBefore(data, selNode);
                    RefreshListbox();
                    TxtInputData.Text = null;
                    TxtInputData.Focus();
                    MessageBox.Show($"Data [{data}], has been successfully added before first node with no. [{selNode.Data}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtInputData.SelectAll();
                    TxtInputData.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtInputData.SelectAll();
                    TxtInputData.Focus();
                }
            }
        }
        private void BtnInsertAfter_Click(object sender, EventArgs e)
        {
            if (ListBoxOutput.SelectedItem == null)
            {
                MessageBox.Show("Select item from list box.");
            }
            else
            {
                try
                {
                    CheckTxtBox(TxtInputData.Text);
                    int data = Int32.Parse(TxtInputData.Text);
                    CustomLinkedListNode selNode = aNode.Find(Int32.Parse(CleanListValue(ListBoxOutput)));
                    bool yup = aNode.InsertAfter(data, selNode);
                    RefreshListbox();
                    TxtInputData.Text = null;
                    TxtInputData.Focus();
                    MessageBox.Show($"Data [{data}], has been successfully added after first node with no. [{selNode.Data}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtInputData.SelectAll();
                    TxtInputData.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtInputData.SelectAll();
                    TxtInputData.Focus();
                }
            }
        }

        private string CleanListValue(ListBox lbo)
        {
            Regex pattern = new Regex(@"[\[\]]");
            string text = lbo.GetItemText(lbo.SelectedItem);
            text = pattern.Replace(text, "");
            return text;
        }
    }
}
