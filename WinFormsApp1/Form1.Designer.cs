namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFile1 = new Label();
            textBoxFile1 = new TextBox();
            buttonBrowseFile1 = new Button();
            labelFile2 = new Label();
            textBoxFile2 = new TextBox();
            buttonBrowseFile2 = new Button();
            buttonSubmit = new Button();
            buttonExit = new Button();
            listBoxTopWords1 = new ListBox();
            listBoxTopWords2 = new ListBox();
            openFileDialog = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // labelFile1
            // 
            labelFile1.AutoSize = true;
            labelFile1.Location = new Point(12, 15);
            labelFile1.Name = "labelFile1";
            labelFile1.Size = new Size(71, 15);
            labelFile1.TabIndex = 0;
            labelFile1.Text = "Select File 1:";
            // 
            // textBoxFile1
            // 
            textBoxFile1.Location = new Point(100, 12);
            textBoxFile1.Name = "textBoxFile1";
            textBoxFile1.ReadOnly = true;
            textBoxFile1.Size = new Size(520, 23);
            textBoxFile1.TabIndex = 1;
            // 
            // buttonBrowseFile1
            // 
            buttonBrowseFile1.Location = new Point(630, 11);
            buttonBrowseFile1.Name = "buttonBrowseFile1";
            buttonBrowseFile1.Size = new Size(75, 25);
            buttonBrowseFile1.TabIndex = 2;
            buttonBrowseFile1.Text = "Browse...";
            buttonBrowseFile1.UseVisualStyleBackColor = true;
            buttonBrowseFile1.Click += ButtonBrowseFile1_Click;
            // 
            // labelFile2
            // 
            labelFile2.AutoSize = true;
            labelFile2.Location = new Point(12, 50);
            labelFile2.Name = "labelFile2";
            labelFile2.Size = new Size(71, 15);
            labelFile2.TabIndex = 3;
            labelFile2.Text = "Select File 2:";
            // 
            // textBoxFile2
            // 
            textBoxFile2.Location = new Point(100, 47);
            textBoxFile2.Name = "textBoxFile2";
            textBoxFile2.ReadOnly = true;
            textBoxFile2.Size = new Size(520, 23);
            textBoxFile2.TabIndex = 4;
            // 
            // buttonBrowseFile2
            // 
            buttonBrowseFile2.Location = new Point(630, 46);
            buttonBrowseFile2.Name = "buttonBrowseFile2";
            buttonBrowseFile2.Size = new Size(75, 25);
            buttonBrowseFile2.TabIndex = 5;
            buttonBrowseFile2.Text = "Browse...";
            buttonBrowseFile2.UseVisualStyleBackColor = true;
            buttonBrowseFile2.Click += ButtonBrowseFile2_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(100, 85);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 30);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += ButtonSubmit_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(220, 85);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 30);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // listBoxTopWords1
            // 
            listBoxTopWords1.FormattingEnabled = true;
            listBoxTopWords1.Location = new Point(12, 130);
            listBoxTopWords1.Name = "listBoxTopWords1";
            listBoxTopWords1.Size = new Size(370, 274);
            listBoxTopWords1.TabIndex = 8;
            // 
            // listBoxTopWords2
            // 
            listBoxTopWords2.FormattingEnabled = true;
            listBoxTopWords2.Location = new Point(418, 130);
            listBoxTopWords2.Name = "listBoxTopWords2";
            listBoxTopWords2.Size = new Size(370, 274);
            listBoxTopWords2.TabIndex = 9;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTopWords2);
            Controls.Add(listBoxTopWords1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonBrowseFile2);
            Controls.Add(textBoxFile2);
            Controls.Add(labelFile2);
            Controls.Add(buttonBrowseFile1);
            Controls.Add(textBoxFile1);
            Controls.Add(labelFile1);
            Name = "Form1";
            Text = "Top Words from Two Books";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.Button buttonBrowseFile1;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Button buttonBrowseFile2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxTopWords1;
        private System.Windows.Forms.ListBox listBoxTopWords2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
    }
}
