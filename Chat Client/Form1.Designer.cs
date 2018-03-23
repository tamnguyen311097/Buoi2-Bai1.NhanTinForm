namespace Chat_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.listBox1Client = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageClient = new System.Windows.Forms.TextBox();
            this.btnSendClient = new System.Windows.Forms.Button();
            this.btnFilesClient = new System.Windows.Forms.Button();
            this.btnMusicsClient = new System.Windows.Forms.Button();
            this.btnImagesClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(121, 20);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(211, 22);
            this.txtServerIP.TabIndex = 1;
            // 
            // listBox1Client
            // 
            this.listBox1Client.FormattingEnabled = true;
            this.listBox1Client.ItemHeight = 16;
            this.listBox1Client.Location = new System.Drawing.Point(40, 70);
            this.listBox1Client.Name = "listBox1Client";
            this.listBox1Client.Size = new System.Drawing.Size(504, 196);
            this.listBox1Client.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // txtMessageClient
            // 
            this.txtMessageClient.Location = new System.Drawing.Point(40, 321);
            this.txtMessageClient.Multiline = true;
            this.txtMessageClient.Name = "txtMessageClient";
            this.txtMessageClient.Size = new System.Drawing.Size(512, 97);
            this.txtMessageClient.TabIndex = 4;
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(578, 321);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(125, 97);
            this.btnSendClient.TabIndex = 5;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // btnFilesClient
            // 
            this.btnFilesClient.Location = new System.Drawing.Point(592, 81);
            this.btnFilesClient.Name = "btnFilesClient";
            this.btnFilesClient.Size = new System.Drawing.Size(82, 35);
            this.btnFilesClient.TabIndex = 6;
            this.btnFilesClient.Text = "Files";
            this.btnFilesClient.UseVisualStyleBackColor = true;
            // 
            // btnMusicsClient
            // 
            this.btnMusicsClient.Location = new System.Drawing.Point(592, 136);
            this.btnMusicsClient.Name = "btnMusicsClient";
            this.btnMusicsClient.Size = new System.Drawing.Size(82, 35);
            this.btnMusicsClient.TabIndex = 7;
            this.btnMusicsClient.Text = "Musics";
            this.btnMusicsClient.UseVisualStyleBackColor = true;
            // 
            // btnImagesClient
            // 
            this.btnImagesClient.Location = new System.Drawing.Point(592, 191);
            this.btnImagesClient.Name = "btnImagesClient";
            this.btnImagesClient.Size = new System.Drawing.Size(82, 35);
            this.btnImagesClient.TabIndex = 8;
            this.btnImagesClient.Text = "Images";
            this.btnImagesClient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 435);
            this.Controls.Add(this.btnImagesClient);
            this.Controls.Add(this.btnMusicsClient);
            this.Controls.Add(this.btnFilesClient);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.txtMessageClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1Client);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.ListBox listBox1Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessageClient;
        private System.Windows.Forms.Button btnSendClient;
        private System.Windows.Forms.Button btnFilesClient;
        private System.Windows.Forms.Button btnMusicsClient;
        private System.Windows.Forms.Button btnImagesClient;
    }
}

