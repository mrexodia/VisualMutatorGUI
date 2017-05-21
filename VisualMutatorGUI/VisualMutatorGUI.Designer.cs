namespace VisualMutatorGUI
{
    partial class VisualMutatorGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMutants = new System.Windows.Forms.ListBox();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.richTextCode = new System.Windows.Forms.RichTextBox();
            this.linkIcon = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listBoxMutants
            // 
            this.listBoxMutants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMutants.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMutants.FormattingEnabled = true;
            this.listBoxMutants.ItemHeight = 11;
            this.listBoxMutants.Location = new System.Drawing.Point(12, 41);
            this.listBoxMutants.Name = "listBoxMutants";
            this.listBoxMutants.Size = new System.Drawing.Size(1012, 114);
            this.listBoxMutants.TabIndex = 2;
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(122, 23);
            this.buttonLoadXml.TabIndex = 0;
            this.buttonLoadXml.Text = "&Load Mutation Results";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // richTextCode
            // 
            this.richTextCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextCode.BackColor = System.Drawing.Color.White;
            this.richTextCode.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextCode.Location = new System.Drawing.Point(12, 168);
            this.richTextCode.Name = "richTextCode";
            this.richTextCode.ReadOnly = true;
            this.richTextCode.Size = new System.Drawing.Size(1012, 387);
            this.richTextCode.TabIndex = 3;
            this.richTextCode.Text = "";
            this.richTextCode.WordWrap = false;
            // 
            // linkIcon
            // 
            this.linkIcon.AutoSize = true;
            this.linkIcon.Location = new System.Drawing.Point(140, 17);
            this.linkIcon.Name = "linkIcon";
            this.linkIcon.Size = new System.Drawing.Size(77, 13);
            this.linkIcon.TabIndex = 1;
            this.linkIcon.TabStop = true;
            this.linkIcon.Text = "Icon by Icons8";
            this.linkIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIcon_LinkClicked);
            // 
            // VisualMutatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 564);
            this.Controls.Add(this.linkIcon);
            this.Controls.Add(this.richTextCode);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.listBoxMutants);
            this.Name = "VisualMutatorGUI";
            this.Text = "VisualMutatorGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMutants;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.RichTextBox richTextCode;
        private System.Windows.Forms.LinkLabel linkIcon;
    }
}

