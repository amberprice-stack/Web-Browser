using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(txtURL.Text);
        }

        WebBrowser webTab = null;
        private void NewtabButton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            txtURL.Text = "https://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void TxtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(txtURL.Text);
                }
            }
        }
    }
}
