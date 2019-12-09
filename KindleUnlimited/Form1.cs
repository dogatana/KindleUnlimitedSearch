using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KindleUnlimited
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var url = ComposeSearchUrl(textSearch.Text);
            if (string.IsNullOrEmpty(url))
                return;

            UpdateMessage(url);
            System.Diagnostics.Process.Start(url);
        }
        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            var url = ComposeSearchUrl(textSearch.Text);
            if (string.IsNullOrEmpty(url))
                return;

            UpdateMessage(url);
            Clipboard.SetText(url);
        }

        private string ComposeSearchUrl(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            const string head = "https://www.amazon.co.jp/s/ref=sr_nr_p_n_feature_nineteen_0?rh=n:2250738051,k:";
            const string tail = ",p_n_feature_nineteen_browse-bin:3169286051";
            var encoded_text = System.Web.HttpUtility.UrlEncode(text);
            return head + encoded_text + tail;
        }

        private void UpdateMessage(string text)
        {
            textBoxMessage.AppendText(text + Environment.NewLine + Environment.NewLine);
        }
    }

}
