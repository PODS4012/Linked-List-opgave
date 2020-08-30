namespace UserControls
{
    partial class UCOpgave1
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
            this.SuspendLayout();
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(130, 60);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(189, 199);
            this.ListBoxOutput.TabIndex = 5;
            this.ListBoxOutput.TabStop = false;
            // 
            // TxtInputData
            // 
            this.TxtInputData.Location = new System.Drawing.Point(14, 60);
            this.TxtInputData.MaxLength = 10;
            this.TxtInputData.Name = "TxtInputData";
            this.TxtInputData.Size = new System.Drawing.Size(110, 20);
            this.TxtInputData.TabIndex = 0;
            // 
            // BtnAddToLinkedList
            // 
            this.BtnAddToLinkedList.Location = new System.Drawing.Point(14, 86);
            this.BtnAddToLinkedList.Name = "BtnAddToLinkedList";
            this.BtnAddToLinkedList.Size = new System.Drawing.Size(110, 23);
            this.BtnAddToLinkedList.TabIndex = 1;
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
            this.label1.Text = "Opgave 1";
            // 
            // UCOpgave1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.TxtInputData);
            this.Controls.Add(this.BtnAddToLinkedList);
            this.Name = "UCOpgave1";
            this.Size = new System.Drawing.Size(597, 434);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.TextBox TxtInputData;
        private System.Windows.Forms.Button BtnAddToLinkedList;
        private System.Windows.Forms.Label label1;
    }
}
