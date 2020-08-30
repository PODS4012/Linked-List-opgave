using System;
using System.Windows.Forms;
using LinkedListsOpgave7;
using System.Text.RegularExpressions;

namespace UserControls
{
    public partial class UCOpgave7 : UserControl
    {
        CustomLinkedList aNode = new CustomLinkedList();
        string[] userFirstName = { "Paul", "Kris", "Martin", "Espen", "Sonja", "Lise", "Emilie", "Maria", "Stefanie", "Thorben", "Ulrik", "Robert", "Jon" };
        string[] userLastName = { "Hansen", "Petersen", "Jackson", "Mortensen", "Peterson", "Christensen", "Thomson", "Møller" };
        public UCOpgave7()
        {
            InitializeComponent();
        }

        private void BtnAddToLinkedList_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtFornavn.Text, TxtFornavn);
                CheckTxtBox(TxtEfternavn.Text, TxtEfternavn);
                CheckTxtBox(TxtEmail.Text, TxtEmail);
                aNode.Add(TxtFornavn.Text, TxtEfternavn.Text, TxtEmail.Text);
                ClearInputFields();
                RefreshListbox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}","Indtastnings fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFornavn.SelectAll();
                TxtFornavn.Focus();
            }
        }
        private void RefreshListbox()
        {
            CustomLinkedListNode current = aNode.Head;
            ListBoxOutput.Items.Clear();
            while (current != null)
            {
                ListBoxOutput.Items.Add($"{current.Data.Email} | {current.Data.FirstName} {current.Data.LastName}");
                current = current.Next;
            }
            try
            {
                lblFirstNode.Text = $"Første Node: {aNode.First.Data.Email.ToString()}";
                lblLastNode.Text = $"Sidste Node: {aNode.Last.Data.Email.ToString()}";
                lblLength.Text = $"Length: {aNode.Length.ToString()}";
                lblMiddleNode.Text = $"Middle Node: {aNode.Middle.Data.Email.ToString()}";
            }
            catch(NullReferenceException)
            {
                lblFirstNode.Text = $"Første Node: Empty";
                lblLastNode.Text = $"Sidste Node: Empty";
                lblLength.Text = $"Length: 0";
                lblMiddleNode.Text = $"Middle Node: Empty";
            }
        }

        private void BtnRemoveNode_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtEmail.Text, TxtEmail);
                aNode.Remove(TxtEmail.Text);
                RefreshListbox();
                ClearInputFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Indtastnings fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.SelectAll();
                TxtEmail.Focus();
            }
        }

        private void BtnFindNode_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTxtBox(TxtEmail.Text, TxtEmail);
                string email = TxtEmail.Text;
                RefreshListbox();
                TxtEmail.Focus();
                string nodeLocated = aNode.Find(email).Data.Email.ToString();
                int index = ListBoxOutput.FindString($"{nodeLocated}");
                ListBoxOutput.SetSelected(index, true);
                MessageBox.Show($"Bruger med email: [{nodeLocated}] er blevet fundet!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.Message.ToString()}", "Indtastnings fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Brugeren med email: {TxtEmail.Text} findes ikke", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmail.SelectAll();
                TxtEmail.Focus();
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
                MessageBox.Show("Vælg en node fra liste boksen.");
            }
            else
            {
                try
                {
                    CheckTxtBox(TxtFornavn.Text, TxtFornavn);
                    CheckTxtBox(TxtEfternavn.Text, TxtEfternavn);
                    CheckTxtBox(TxtEmail.Text, TxtEmail);
                    string firstName = TxtFornavn.Text;
                    string lastName = TxtEfternavn.Text;
                    string email = TxtEmail.Text;
                    CustomLinkedListNode selNode = aNode.Find(CleanListValue(ListBoxOutput));
                    bool insertOk = aNode.InsertBefore(firstName, lastName, email, selNode);
                    if(insertOk)
                    {
                        RefreshListbox();
                        ClearInputFields();
                        MessageBox.Show($"Brugeren: [{email}], er blevet tilføjet før den første fundet node, med email:  [{selNode.Data.Email}] ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RefreshListbox();
                        TxtFornavn.SelectAll();
                        TxtFornavn.Focus();
                        MessageBox.Show($"Kan ikke finde bruger med email: [{email}]", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Indtastnings fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtFornavn.SelectAll();
                    TxtFornavn.Focus();
                }
            }
        }
        private void BtnInsertAfter_Click(object sender, EventArgs e)
        {
            if (ListBoxOutput.SelectedItem == null)
            {
                MessageBox.Show("Vælg en node fra liste boksen.");
            }
            else
            {
                try
                {
                    CheckTxtBox(TxtFornavn.Text, TxtFornavn);
                    CheckTxtBox(TxtEfternavn.Text, TxtEfternavn);
                    CheckTxtBox(TxtEmail.Text, TxtEmail);
                    string firstName = TxtFornavn.Text;
                    string lastName = TxtEfternavn.Text;
                    string email = TxtEmail.Text;
                    CustomLinkedListNode selNode = aNode.Find(CleanListValue(ListBoxOutput));
                    bool insertOk = aNode.InsertAfter(firstName, lastName, email, selNode);
                    if (insertOk)
                    {
                        RefreshListbox();
                        ClearInputFields();
                        MessageBox.Show($"Brugeren: [{email}], er blevet tilføjet efter den første fundet node, med email:  [{selNode.Data.Email}] ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RefreshListbox();
                        TxtFornavn.SelectAll();
                        TxtFornavn.Focus();
                        MessageBox.Show($"Kan ikke finde bruger med email: [{email}]", "Prøv igen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Indtastnings fejl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message.ToString()}", "Kritisk fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtFornavn.SelectAll();
                    TxtFornavn.Focus();
                }
            }
        }
        private string CleanListValue(ListBox lbo)
        {
            string text = lbo.GetItemText(lbo.SelectedItem);
            string result = Regex.Match(text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").ToString();
            return result;
        }
        private void ClearInputFields()
        {
            TxtFornavn.Text = null;
            TxtEfternavn.Text = null;
            TxtEmail.Text = null;
            TxtFornavn.Focus();
        }
        private void CheckTxtBox(string txt, TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(txt))
            {
                tb.Focus();
                throw new FormatException($"{tb.Name.Substring(3,tb.Name.Length - 3)} feltet må ikke være tom.");
            }
            else if (!Regex.IsMatch(txt, @"^(\s+)?\w+.{1}(\s+)?$") && tb.Name != "TxtEmail")
            {
                tb.SelectAll();
                tb.Focus();
                throw new FormatException($"{tb.Name.Substring(3, tb.Name.Length - 3)} feltet må kun indholde et ord.");
            }
            else if (tb.Name == "TxtEmail")
            {
                try
                {
                    var email = new System.Net.Mail.MailAddress(txt);
                }
                catch
                {
                    tb.SelectAll();
                    tb.Focus();
                    throw new FormatException($"{txt} er ikke valid email addresse.");
                }
            }
        }
        private void BtnNameGenerator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TxtFornavn.Text = userFirstName[rnd.Next(0, userFirstName.Length)];
            TxtEfternavn.Text = userLastName[rnd.Next(0, userLastName.Length)];
            TxtEmail.Text = $"{TxtFornavn.Text}.{TxtEfternavn.Text}@mail.dk";
        }
        private void ListBoxOutput_DoubleClick(object sender, EventArgs e)
        {
            TxtEmail.Text = CleanListValue(ListBoxOutput);
        }
    }
}
