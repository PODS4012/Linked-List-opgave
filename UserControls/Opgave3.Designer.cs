namespace UserControls
{
    partial class UCOpgave3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.TxtInputData = new System.Windows.Forms.TextBox();
            this.BtnAddToLinkedList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveNode = new System.Windows.Forms.Button();
            this.BtnFindNode = new System.Windows.Forms.Button();
            this.BtnClearNode = new System.Windows.Forms.Button();
            this.BtnInsertBefore = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.GroupBox();
            this.BtnInsertAfter = new System.Windows.Forms.Button();
            this.Insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(203, 58);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(189, 251);
            this.ListBoxOutput.TabIndex = 5;
            this.ListBoxOutput.TabStop = false;
            // 
            // TxtInputData
            // 
            this.TxtInputData.Location = new System.Drawing.Point(6, 19);
            this.TxtInputData.MaxLength = 10;
            this.TxtInputData.Name = "TxtInputData";
            this.TxtInputData.Size = new System.Drawing.Size(170, 20);
            this.TxtInputData.TabIndex = 1;
            // 
            // BtnAddToLinkedList
            // 
            this.BtnAddToLinkedList.Location = new System.Drawing.Point(66, 49);
            this.BtnAddToLinkedList.Name = "BtnAddToLinkedList";
            this.BtnAddToLinkedList.Size = new System.Drawing.Size(110, 23);
            this.BtnAddToLinkedList.TabIndex = 2;
            this.BtnAddToLinkedList.Text = "Add to linked list";
            this.BtnAddToLinkedList.UseVisualStyleBackColor = true;
            this.BtnAddToLinkedList.Click += new System.EventHandler(this.BtnAddToLinkedList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(235, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opgave 3";
            // 
            // BtnRemoveNode
            // 
            this.BtnRemoveNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnRemoveNode.Location = new System.Drawing.Point(47, 200);
            this.BtnRemoveNode.Name = "BtnRemoveNode";
            this.BtnRemoveNode.Size = new System.Drawing.Size(110, 23);
            this.BtnRemoveNode.TabIndex = 6;
            this.BtnRemoveNode.Text = "Remove Node";
            this.BtnRemoveNode.UseVisualStyleBackColor = false;
            this.BtnRemoveNode.Click += new System.EventHandler(this.BtnRemoveNode_Click);
            // 
            // BtnFindNode
            // 
            this.BtnFindNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.BtnFindNode.Location = new System.Drawing.Point(47, 171);
            this.BtnFindNode.Name = "BtnFindNode";
            this.BtnFindNode.Size = new System.Drawing.Size(110, 23);
            this.BtnFindNode.TabIndex = 5;
            this.BtnFindNode.Text = "Find Node";
            this.BtnFindNode.UseVisualStyleBackColor = false;
            this.BtnFindNode.Click += new System.EventHandler(this.BtnFindNode_Click);
            // 
            // BtnClearNode
            // 
            this.BtnClearNode.Location = new System.Drawing.Point(315, 315);
            this.BtnClearNode.Name = "BtnClearNode";
            this.BtnClearNode.Size = new System.Drawing.Size(77, 23);
            this.BtnClearNode.TabIndex = 7;
            this.BtnClearNode.Text = "Clear All";
            this.BtnClearNode.UseVisualStyleBackColor = true;
            this.BtnClearNode.Click += new System.EventHandler(this.BtnClearNode_Click);
            // 
            // BtnInsertBefore
            // 
            this.BtnInsertBefore.Location = new System.Drawing.Point(6, 78);
            this.BtnInsertBefore.Name = "BtnInsertBefore";
            this.BtnInsertBefore.Size = new System.Drawing.Size(82, 23);
            this.BtnInsertBefore.TabIndex = 3;
            this.BtnInsertBefore.Text = "Insert Before";
            this.BtnInsertBefore.UseVisualStyleBackColor = true;
            this.BtnInsertBefore.Click += new System.EventHandler(this.BtnInsertBefore_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.BtnInsertAfter);
            this.Insert.Controls.Add(this.TxtInputData);
            this.Insert.Controls.Add(this.BtnAddToLinkedList);
            this.Insert.Controls.Add(this.BtnInsertBefore);
            this.Insert.Location = new System.Drawing.Point(14, 58);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(183, 107);
            this.Insert.TabIndex = 0;
            this.Insert.TabStop = false;
            this.Insert.Text = "Insert";
            // 
            // BtnInsertAfter
            // 
            this.BtnInsertAfter.Location = new System.Drawing.Point(94, 78);
            this.BtnInsertAfter.Name = "BtnInsertAfter";
            this.BtnInsertAfter.Size = new System.Drawing.Size(82, 23);
            this.BtnInsertAfter.TabIndex = 4;
            this.BtnInsertAfter.Text = "Insert After";
            this.BtnInsertAfter.UseVisualStyleBackColor = true;
            this.BtnInsertAfter.Click += new System.EventHandler(this.BtnInsertAfter_Click);
            // 
            // UCOpgave3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.BtnClearNode);
            this.Controls.Add(this.BtnFindNode);
            this.Controls.Add(this.BtnRemoveNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxOutput);
            this.Name = "UCOpgave3";
            this.Size = new System.Drawing.Size(597, 434);
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.TextBox TxtInputData;
        private System.Windows.Forms.Button BtnAddToLinkedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemoveNode;
        private System.Windows.Forms.Button BtnFindNode;
        private System.Windows.Forms.Button BtnClearNode;
        private System.Windows.Forms.Button BtnInsertBefore;
        private System.Windows.Forms.GroupBox Insert;
        private System.Windows.Forms.Button BtnInsertAfter;
    }
}
