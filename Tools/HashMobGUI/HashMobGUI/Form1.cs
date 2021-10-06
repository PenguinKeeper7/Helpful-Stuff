using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using RestSharp;
using System.Threading;

namespace HashMobGUI
{
    public partial class frmMain : Form
    {
        int foundCount = 0;
        int hashesRead = 0;
        StreamWriter sw;
        dynamic userInfo;
        int api_balance = 0;

        public frmMain()
        {
            InitializeComponent();
            chkAppendOutput.Checked = Properties.Settings.Default.appendOutput;
            chkAlgoHashPass.Checked = Properties.Settings.Default.algoHashPass;
            
            if (Regex.Match(Properties.Settings.Default.APIKEY, @"^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$").Success)
                txtAPIKey.Text = Properties.Settings.Default.APIKEY;
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtAPIKey.Text, @"^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$").Success)
            {
                if (txtAPIKey.Text != "")
                    MessageBox.Show("Your API Key is invalid. It should look like this: 6ee28c21-7872-4b43-84ed-744999d1a3d3.\n" +
                        "You can get it from hashmob.net/user/info", "API Key Error", MessageBoxButtons.OK);
                lblUserInfo.Text = "";
            }
            else
            {
                string responseText;
                txtAPIKey.ForeColor = Color.Black;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://hashmob.net/api/v1/user");
                    request.Method = "POST";
                    request.Headers.Add("api-key", txtAPIKey.Text);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII))
                    {
                        responseText = reader.ReadToEnd();
                    }
                    userInfo = JObject.Parse(responseText);
                    Int32.TryParse((userInfo.api_balance).ToString(), out api_balance);
                    lblUserInfo.Text = "Username:" + userInfo.display_name + "\n" + "Balance:" + api_balance;
                    Properties.Settings.Default.APIKEY = txtAPIKey.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured. Please ensure your API Key is correct and wait a few minutes to try again", "Server error", MessageBoxButtons.OK);
                }

            }
        }

        private void btnFindHashfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            txtHashlistLocation.Text = OpenFileDialog.FileName;
        }

        private void btnOutputHashlist_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            txtOutputLocation.Text = SaveFileDialog.FileName;
        }

        private void txtAPIKey_MouseDown(object sender, MouseEventArgs e)
        {
            txtAPIKey.ForeColor = Color.Black;
            txtAPIKey.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foundCount = 0;
            hashesRead = 0;
            sw = new StreamWriter(txtOutputLocation.Text, chkAppendOutput.Checked, Encoding.UTF8);
            string[] hashes = File.ReadLines(txtHashlistLocation.Text).ToArray();
            int hashfileLength = hashes.Length;


            string[] buffer;
            int chunkSize = 1000;

            bool paid = (!lblUserInfo.Text.Contains("balance:0")) && !(lblUserInfo.Text == "");

            for (int i = 0; i < hashfileLength; i += chunkSize){
                buffer = new string[chunkSize];
                try {
                    Array.Copy(hashes, i, buffer, 0, chunkSize);
                    //I know this is inefficient - I have no clue why it's the only thing that works lol
                    foreach (var buf in buffer) {
                        hashesRead++;
                    }
                    paid = (!lblUserInfo.Text.Contains("balance:0")) && !(lblUserInfo.Text == "");
                    queryHashmob(buffer);
                    lblFileInfo.Text = "Hashes: " + hashfileLength + "\nSearched: " + hashesRead.ToString() + "\nFound:" + foundCount.ToString();
                    //api_balance = api_balance - foundCount;
                    if (paid) {
                        lblETA.Text = "Estimated Time: " + ((hashfileLength / chunkSize) * 5/60).ToString() + "minutes";
                        lblUserInfo.Text = "Username:" + userInfo.display_name + "\n" + "Balance:" + (api_balance - foundCount).ToString();
                        WaitNSeconds(5);
                    }else {
                        lblETA.Text = "Estimated Time: " + (((hashfileLength-hashesRead) / chunkSize) * 720/60).ToString() + "minutes";
                        WaitNSeconds(720); 
                    }
                }
                catch (Exception){}
            }

            int remainder = hashfileLength % chunkSize;
            buffer = new string[remainder];
            Array.Copy(hashes, hashesRead, buffer, 0, remainder);
            queryHashmob(buffer);

            hashesRead += remainder;
            lblFileInfo.Text = "Length: " + hashfileLength + "\nSearched: " + hashesRead.ToString() + "\nFound:" + foundCount.ToString();
            if (paid){
                //api_balance = api_balance - remainder;
                lblUserInfo.Text = "Username:" + userInfo.display_name + "\n" + "Balance:" + (api_balance - foundCount);
            }
            sw.Close();
        }

        private void queryHashmob(string[] hashes) {
            string URL;
            
            if (lblUserInfo.Text.Contains("Balance:0") || lblUserInfo.Text == "")
                URL = "https://hashmob.net/api/v1/search";
            else
                URL = "https://hashmob.net/api/v1/search/paid";
            //Console.WriteLine(URL);
            var client = new RestClient(URL);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            
            request.AddHeader("api-key", txtAPIKey.Text);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            foreach (string hash in hashes){
                request.AddParameter("hashes[]", hash);
            }
            foreach (var x in request.Parameters.ToArray())
                Console.WriteLine(x.ToString());
            IRestResponse response = client.Execute(request);
            string founds = response.Content;
            //Console.WriteLine(founds);
            founds = Regex.Replace(founds, ".*\"found\":\\[", "");
            founds = Regex.Replace(founds, "}]}$", "}");
            string[] foundsJSON = founds.Split(new string[] { "},{" }, StringSplitOptions.None);
            
            string algo = "";
            string separator = txtSeparator.Text;
            dynamic foundJSON;
            
            foreach (string found in foundsJSON) {
                string foundtemp = found;
                if (foundtemp[0] != '{')
                    foundtemp = "{" + foundtemp;
                if (foundtemp.Last() != '}')
                    foundtemp = foundtemp + "}";
                //Console.WriteLine(foundtemp);
                foundJSON = JObject.Parse(foundtemp);
                if (chkAlgoHashPass.Checked)
                    algo = foundJSON.algorithm + " ";
                if(foundJSON.salt == null)
                    sw.WriteLine(algo + foundJSON.hash + separator + foundJSON.plain);
                else
                    sw.WriteLine(algo + foundJSON.hash + separator + foundJSON.salt + separator + foundJSON.plain);
                foundCount++;
            }
            

        }
        private void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void linkAPIKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            //Broken link, due to it 404-ing. linkAPIKEY is disabled until it's fixed
            System.Diagnostics.Process.Start("https://hashmob.net/research/api");
        }
        private void chkAlgoHashPass_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.algoHashPass = chkAlgoHashPass.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkAppendOutput_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.appendOutput = chkAppendOutput.Checked;
            Properties.Settings.Default.Save();
        }

        private void lblForgetAPIKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAPIKey.Text = "";
            Properties.Settings.Default.APIKEY = "";
            Properties.Settings.Default.Save();
        }
    }
}