using System;
using System.Windows.Forms;
using LinkedListsOpgave1;
namespace UserControls
{
    public partial class UCOpgave1 : UserControl
    {
        CustomLinkedList addNode = new CustomLinkedList();
        public UCOpgave1()
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
                MessageBox.Show($"{ex.Message.ToString()}","Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int i = 0;
            CustomLinkedListNode current = addNode.Head;
            ListBoxOutput.Items.Clear();
            while (current != null)
            {
                ListBoxOutput.Items.Add($"{++i}. node->data( {current.Data} )");
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

    }
}
