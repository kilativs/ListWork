using ListWork.Forms.UserControls;
using ListWork.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListWork.Forms
{
    public partial class ListWorkForm : Form
    {
        private static ListWorkForm _instance;

        private ListWorkForm()
        {
            InitializeComponent();
        }

        public static ListWorkForm GetInstance()
        {
            return _instance ??= new ListWorkForm();
        }

        private async void ListWorkForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var client = new RestClient($"{Program.Url}/ListWork")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);
                if (response.Content.Length == 0) ListWorkForm_Load(null, null);
                var model = JsonConvert.DeserializeObject<List<ListWorkResponseModel>>(response.Content);
                if (model == null) return;
                foreach (var item in model)
                {
                    Invoke(new Action(() =>
                    {
                        var newListWorkItem = new ListWorkItem(item.Id, item.Title, item.Description,
                            item.PriorityWork.ToString(), item.ConditionWork.ToString(),
                            item.Deadline.ToString(CultureInfo.InvariantCulture));
                        flowLayoutPanel1.Controls.Add(newListWorkItem);
                    }));
                }
            });
        }

        private void createListWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wndwHendler = new MenageListWorkForm();
            wndwHendler.ShowDialog();
        }

        public void RefreshItem()
        {
            flowLayoutPanel1.Controls.Clear();
            ListWorkForm_Load(null, null);
        }
    }
}
