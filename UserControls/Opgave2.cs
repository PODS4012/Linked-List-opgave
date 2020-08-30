using System;
using System.Windows.Forms;
using LinkedListsOpgave2;
namespace UserControls
{
    public partial class UCOpgave2 : UserControl
    {
        CustomLinkedList addNode = new CustomLinkedList();
        public UCOpgave2()
        {
            InitializeComponent();
        }

        private void BtnAddToLinkedList_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtInputData.Text);
                addNode.Add(Int32.Parse(TxtInputData.Text));
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
            CustomLinkedListNode current = addNode.Head;
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
                addNode.Remove(Int32.Parse(TxtInputData.Text));
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
                string nodeLocated = addNode.Find(data).Data.ToString();
                int index = ListBoxOutput.FindString($"[{nodeLocated}");
                TxtInputData.Text = null;
                TxtInputData.Focus();
                ListBoxOutput.SetSelected(index, true);
                MessageBox.Show($"Found Data Node [{nodeLocated}]","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
