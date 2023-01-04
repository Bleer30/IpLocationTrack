using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpLocationTrack
{
    public partial class frmIpLocationTrack : Form
    {
        public frmIpLocationTrack()
        {
            InitializeComponent();
        }

        private void btnLoadLocationDetails_Click(object sender, EventArgs e)
        {
            listIPLocation.Items.Clear();
            if (txtIPAddress.Text.Equals(""))
            {
                var client = new RestClient("https://www.ipapi.co/json");
                var request = new RestRequest()
                {
                    Method = Method.Get
                };
                var response = client.Execute(request);
                var strJsonData = response.Content;

                var dictionary = JsonConvert.DeserializeObject<IDictionary<string, string>>(strJsonData);

                foreach (string key in dictionary.Keys)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = key;
                    listViewItem.SubItems.Add(dictionary[key]);

                    listIPLocation.Items.Add(listViewItem);
                }
            }
            else
            {
                var client = new RestClient($"https://www.ipapi.co/{txtIPAddress.Text}/json");
                var request = new RestRequest()
                {
                    Method = Method.Get
                };
                var response = client.Execute(request);
                var strJsonData = response.Content;

                var dictionary = JsonConvert.DeserializeObject<IDictionary<string, string>>(strJsonData);
                foreach (string key in dictionary.Keys)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = key;
                    listViewItem.SubItems.Add(dictionary[key]);

                    listIPLocation.Items.Add(listViewItem);
                }
            }
        }
    }
}
