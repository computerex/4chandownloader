using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace googledownloader
{
    public partial class Form1 : Form
    {
        public WebClient web;
        public string hookfile;
        public int pos;
        public Form1()
        {
            web = new WebClient();
            web.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);
            InitializeComponent();
        }

        void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        public string getFileName(string str)
        {
            int pos = str.LastIndexOf("/");
            if (pos == -1)
                pos = str.LastIndexOf("\\");
            if (pos == -1) return str;
            return str.Substring(pos + 1);
        }
        // TODO - replace this shitty heuristic method with 
        // a regex
        String getnextfile(String file, ref int cpos)
        {
            String lookfor = "/src/";
            int lklen = lookfor.Length;
            int inx = file.IndexOf(lookfor, cpos);
            if (inx == -1) return "";
            int start = file.Substring(0, inx).LastIndexOf("//");
            int end = file.IndexOf("\"", inx);
            cpos = end+1;
            return "http://"+file.Substring(start+2, end-start-2);
        }
        void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            String file = getnextfile(hookfile, ref pos);
            if (file == "")
            {
                btndownload.Enabled = true;
                return;
            }
            while (!downloadfile(file))
            {
                file = getnextfile(hookfile, ref pos);
                if (file == "") break;
            }
            downloadfile(file);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private bool downloadfile(String url)
        {
            if (url.Length <= 0) return false;
            string shortname = getFileName(url);
            string filename = txtsavedir.Text + "\\" + shortname;
            if (File.Exists(filename))
            {
                //listBox1.Items.Add("skipping " + shortname);
                return false;
            }
            web.DownloadFileAsync(new Uri(url), filename);
            listBox1.Items.Add("downloading " + shortname);
            return true;
        }
        private void btndownload_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtsavedir.Text))
            {
                MessageBox.Show("Please make sure you select an appropriate directory to save the files");
                return;
            }
           if (File.Exists("hook.htm"))
                File.Delete("hook.htm");
            Process hookdownloader = Process.Start("wget.exe", txtthreadurl.Text);
            hookdownloader.WaitForExit();
            StreamReader input;
            try
            {
                input = new StreamReader("hook.htm");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
                return;
            }
            hookfile = input.ReadToEnd();
            input.Close();
            File.Delete("hook.htm");
            pos = 0;
            string link = getnextfile(hookfile, ref pos);
            if (link == "")
            {
                MessageBox.Show("No files to download on the specified thread");
                return;
            }
            while (!downloadfile(link))
            {
                link = getnextfile(hookfile, ref pos);
                if (link == "") break; 
            }
            btndownload.Enabled = !downloadfile(link);
            /*StreamWriter sw = new StreamWriter("debug.txt", false);
            while (link != "")
            {
                sw.WriteLine(link);
                link = getnextfile(hookfile, ref pos);
            }
            sw.Close(); */
        }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtsavedir.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
