namespace Webrowser
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
            this.forwardButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.newtabButton = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcontrol2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabcontrol2.SuspendLayout();
            this.SuspendLayout();
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(37, 10);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(2);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(31, 19);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = ">>\r\n\r\n\r\n";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(484, 10);
            this.goButton.Margin = new System.Windows.Forms.Padding(2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(31, 19);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go\r\n";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // newtabButton
            // 
            this.newtabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newtabButton.Location = new System.Drawing.Point(519, 10);
            this.newtabButton.Margin = new System.Windows.Forms.Padding(2);
            this.newtabButton.Name = "newtabButton";
            this.newtabButton.Size = new System.Drawing.Size(79, 19);
            this.newtabButton.TabIndex = 3;
            this.newtabButton.Text = "New Tab\r\n";
            this.newtabButton.UseVisualStyleBackColor = true;
            this.newtabButton.Click += new System.EventHandler(this.NewtabButton_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(73, 10);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(406, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtURL_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabcontrol2);
            this.tabControl.Location = new System.Drawing.Point(13, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(585, 319);
            this.tabControl.TabIndex = 5;
            // 
            // tabcontrol2
            // 
            this.tabcontrol2.Controls.Add(this.webBrowser);
            this.tabcontrol2.Location = new System.Drawing.Point(4, 22);
            this.tabcontrol2.Name = "tabcontrol2";
            this.tabcontrol2.Padding = new System.Windows.Forms.Padding(3);
            this.tabcontrol2.Size = new System.Drawing.Size(577, 293);
            this.tabcontrol2.TabIndex = 1;
            this.tabcontrol2.Text = "tabPage2";
            this.tabcontrol2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(571, 287);
            this.webBrowser.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(2, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(31, 19);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.newtabButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.forwardButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabcontrol2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button newtabButton;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabcontrol2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button backButton;
    }
}

