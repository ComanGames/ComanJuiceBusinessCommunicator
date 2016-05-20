namespace BotDataSetter
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFirstMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rendomMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.treeViewReanomMessages = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFirstMessage
            // 
            this.textBoxFirstMessage.Location = new System.Drawing.Point(92, 12);
            this.textBoxFirstMessage.Name = "textBoxFirstMessage";
            this.textBoxFirstMessage.Size = new System.Drawing.Size(370, 20);
            this.textBoxFirstMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rendom Message";
            // 
            // rendomMessageTextBox
            // 
            this.rendomMessageTextBox.Location = new System.Drawing.Point(15, 59);
            this.rendomMessageTextBox.Name = "rendomMessageTextBox";
            this.rendomMessageTextBox.Size = new System.Drawing.Size(321, 175);
            this.rendomMessageTextBox.TabIndex = 6;
            this.rendomMessageTextBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "AddText";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // treeViewReanomMessages
            // 
            this.treeViewReanomMessages.Location = new System.Drawing.Point(341, 59);
            this.treeViewReanomMessages.Name = "treeViewReanomMessages";
            this.treeViewReanomMessages.Size = new System.Drawing.Size(121, 222);
            this.treeViewReanomMessages.TabIndex = 8;
            this.treeViewReanomMessages.DoubleClick += TreeViewDoubleClick;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 352);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.treeViewReanomMessages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rendomMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstMessage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFirstMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rendomMessageTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeViewReanomMessages;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

