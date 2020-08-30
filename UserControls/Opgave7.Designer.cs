namespace UserControls
{
    partial class UCOpgave7
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
            this.TxtFornavn = new System.Windows.Forms.TextBox();
            this.BtnAddToLinkedList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveNode = new System.Windows.Forms.Button();
            this.BtnFindNode = new System.Windows.Forms.Button();
            this.BtnClearNode = new System.Windows.Forms.Button();
            this.BtnInsertBefore = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtEfternavn = new System.Windows.Forms.TextBox();
            this.BtnInsertAfter = new System.Windows.Forms.Button();
            this.lblFirstNode = new System.Windows.Forms.Label();
            this.lblLastNode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNameGenerator = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMiddleNode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Insert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(332, 64);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(353, 342);
            this.ListBoxOutput.TabIndex = 5;
            this.ListBoxOutput.TabStop = false;
            this.ListBoxOutput.DoubleClick += new System.EventHandler(this.ListBoxOutput_DoubleClick);
            // 
            // TxtFornavn
            // 
            this.TxtFornavn.Location = new System.Drawing.Point(81, 19);
            this.TxtFornavn.MaxLength = 25;
            this.TxtFornavn.Name = "TxtFornavn";
            this.TxtFornavn.Size = new System.Drawing.Size(200, 20);
            this.TxtFornavn.TabIndex = 0;
            // 
            // BtnAddToLinkedList
            // 
            this.BtnAddToLinkedList.Location = new System.Drawing.Point(171, 97);
            this.BtnAddToLinkedList.Name = "BtnAddToLinkedList";
            this.BtnAddToLinkedList.Size = new System.Drawing.Size(110, 23);
            this.BtnAddToLinkedList.TabIndex = 3;
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
            this.label1.Text = "Opgave 7";
            // 
            // BtnRemoveNode
            // 
            this.BtnRemoveNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnRemoveNode.Location = new System.Drawing.Point(152, 19);
            this.BtnRemoveNode.Name = "BtnRemoveNode";
            this.BtnRemoveNode.Size = new System.Drawing.Size(129, 23);
            this.BtnRemoveNode.TabIndex = 7;
            this.BtnRemoveNode.Text = "Remove Node By Email";
            this.BtnRemoveNode.UseVisualStyleBackColor = false;
            this.BtnRemoveNode.Click += new System.EventHandler(this.BtnRemoveNode_Click);
            // 
            // BtnFindNode
            // 
            this.BtnFindNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.BtnFindNode.Location = new System.Drawing.Point(6, 19);
            this.BtnFindNode.Name = "BtnFindNode";
            this.BtnFindNode.Size = new System.Drawing.Size(129, 23);
            this.BtnFindNode.TabIndex = 6;
            this.BtnFindNode.Text = "Find Node By Email";
            this.BtnFindNode.UseVisualStyleBackColor = false;
            this.BtnFindNode.Click += new System.EventHandler(this.BtnFindNode_Click);
            // 
            // BtnClearNode
            // 
            this.BtnClearNode.Location = new System.Drawing.Point(608, 415);
            this.BtnClearNode.Name = "BtnClearNode";
            this.BtnClearNode.Size = new System.Drawing.Size(77, 23);
            this.BtnClearNode.TabIndex = 10;
            this.BtnClearNode.Text = "Clear All";
            this.BtnClearNode.UseVisualStyleBackColor = true;
            this.BtnClearNode.Click += new System.EventHandler(this.BtnClearNode_Click);
            // 
            // BtnInsertBefore
            // 
            this.BtnInsertBefore.Location = new System.Drawing.Point(111, 139);
            this.BtnInsertBefore.Name = "BtnInsertBefore";
            this.BtnInsertBefore.Size = new System.Drawing.Size(82, 23);
            this.BtnInsertBefore.TabIndex = 4;
            this.BtnInsertBefore.Text = "Insert Before";
            this.BtnInsertBefore.UseVisualStyleBackColor = true;
            this.BtnInsertBefore.Click += new System.EventHandler(this.BtnInsertBefore_Click);
            // 
            // Insert
            // 
            this.Insert.Controls.Add(this.label4);
            this.Insert.Controls.Add(this.label3);
            this.Insert.Controls.Add(this.label2);
            this.Insert.Controls.Add(this.TxtEmail);
            this.Insert.Controls.Add(this.TxtEfternavn);
            this.Insert.Controls.Add(this.BtnInsertAfter);
            this.Insert.Controls.Add(this.TxtFornavn);
            this.Insert.Controls.Add(this.BtnAddToLinkedList);
            this.Insert.Controls.Add(this.BtnInsertBefore);
            this.Insert.Location = new System.Drawing.Point(14, 58);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(287, 168);
            this.Insert.TabIndex = 1;
            this.Insert.TabStop = false;
            this.Insert.Text = "Insert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Efternavn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fornavn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(81, 71);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(200, 20);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtEfternavn
            // 
            this.TxtEfternavn.Location = new System.Drawing.Point(81, 45);
            this.TxtEfternavn.MaxLength = 25;
            this.TxtEfternavn.Name = "TxtEfternavn";
            this.TxtEfternavn.Size = new System.Drawing.Size(200, 20);
            this.TxtEfternavn.TabIndex = 1;
            // 
            // BtnInsertAfter
            // 
            this.BtnInsertAfter.Location = new System.Drawing.Point(199, 139);
            this.BtnInsertAfter.Name = "BtnInsertAfter";
            this.BtnInsertAfter.Size = new System.Drawing.Size(82, 23);
            this.BtnInsertAfter.TabIndex = 5;
            this.BtnInsertAfter.Text = "Insert After";
            this.BtnInsertAfter.UseVisualStyleBackColor = true;
            this.BtnInsertAfter.Click += new System.EventHandler(this.BtnInsertAfter_Click);
            // 
            // lblFirstNode
            // 
            this.lblFirstNode.AutoSize = true;
            this.lblFirstNode.Location = new System.Drawing.Point(6, 16);
            this.lblFirstNode.Name = "lblFirstNode";
            this.lblFirstNode.Size = new System.Drawing.Size(58, 13);
            this.lblFirstNode.TabIndex = 14;
            this.lblFirstNode.Text = "First Node:";
            // 
            // lblLastNode
            // 
            this.lblLastNode.AutoSize = true;
            this.lblLastNode.Location = new System.Drawing.Point(6, 33);
            this.lblLastNode.Name = "lblLastNode";
            this.lblLastNode.Size = new System.Drawing.Size(59, 13);
            this.lblLastNode.TabIndex = 15;
            this.lblLastNode.Text = "Last Node:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFirstNode);
            this.groupBox1.Controls.Add(this.lblLastNode);
            this.groupBox1.Location = new System.Drawing.Point(3, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFindNode);
            this.groupBox2.Controls.Add(this.BtnRemoveNode);
            this.groupBox2.Location = new System.Drawing.Point(14, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // BtnNameGenerator
            // 
            this.BtnNameGenerator.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNameGenerator.Location = new System.Drawing.Point(60, 29);
            this.BtnNameGenerator.Name = "BtnNameGenerator";
            this.BtnNameGenerator.Size = new System.Drawing.Size(116, 23);
            this.BtnNameGenerator.TabIndex = 0;
            this.BtnNameGenerator.Text = "Navne Generator";
            this.BtnNameGenerator.UseVisualStyleBackColor = false;
            this.BtnNameGenerator.Click += new System.EventHandler(this.BtnNameGenerator_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLength);
            this.groupBox3.Controls.Add(this.lblMiddleNode);
            this.groupBox3.Location = new System.Drawing.Point(3, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 59);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(6, 16);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 14;
            this.lblLength.Text = "Length:";
            // 
            // lblMiddleNode
            // 
            this.lblMiddleNode.AutoSize = true;
            this.lblMiddleNode.Location = new System.Drawing.Point(6, 33);
            this.lblMiddleNode.Name = "lblMiddleNode";
            this.lblMiddleNode.Size = new System.Drawing.Size(70, 13);
            this.lblMiddleNode.TabIndex = 15;
            this.lblMiddleNode.Text = "Middle Node:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(360, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Info: dobbeltklik på listen for at udtrække mail til tekst boksen";
            // 
            // UCOpgave7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnNameGenerator);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClearNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxOutput);
            this.Name = "UCOpgave7";
            this.Size = new System.Drawing.Size(726, 494);
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.TextBox TxtFornavn;
        private System.Windows.Forms.Button BtnAddToLinkedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemoveNode;
        private System.Windows.Forms.Button BtnFindNode;
        private System.Windows.Forms.Button BtnClearNode;
        private System.Windows.Forms.Button BtnInsertBefore;
        private System.Windows.Forms.GroupBox Insert;
        private System.Windows.Forms.Button BtnInsertAfter;
        private System.Windows.Forms.Label lblFirstNode;
        private System.Windows.Forms.Label lblLastNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtEfternavn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnNameGenerator;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblMiddleNode;
        private System.Windows.Forms.Label label5;
    }
}
