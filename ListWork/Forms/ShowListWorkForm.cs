using ListWork.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListWork.Forms
{
    public partial class ShowListWorkForm : Form
    {
        private readonly int _id;

        public ShowListWorkForm(int id)
        {
            InitializeComponent();
            this._id = id;
            LoadListWorkAsync(id);
        }

        private async void LoadListWorkAsync(int id)
        {
            await Task.Run(() =>
            {
                var client = new RestClient($"{Program.Url}/ListWork/getById?id={id}")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.GET);
                var response = client.Execute(request);
                if (response.Content.Length == 0)
                {
                    LoadListWorkAsync(id);
                    return;
                }
                var model = JsonConvert.DeserializeObject<ListWorkResponseModel>(response.Content);
                Invoke(new Action(() =>
                {
                    if (model == null) return;
                    titleLbl.Text = model.Title;
                    descriptionLbl.Text = model.Description;
                    deadlineLbl.Text = model.Deadline.Date.ToString(CultureInfo.InvariantCulture);
                    priorityLbl.Text = model.PriorityWork.ToString();
                    conditionLbl.Text = model.ConditionWork.ToString();
                }));
            });
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var wndwHendler = new MenageListWorkForm(this._id);
            wndwHendler.ShowDialog();
            RefreshForm();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient($"{Program.Url}/ListWork/remove?id={_id}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            client.Execute(request);
            ListWorkForm.GetInstance().RefreshItem();
            Close();
        }

        private void closelBtn_Click(object sender, EventArgs e)
        {
            ActiveForm?.Close();
        }

        private void RefreshForm()
        {
            titleLbl.Text = null;
            descriptionLbl.Text = null;
            deadlineLbl.Text = null;
            priorityLbl.Text = null;
            conditionLbl.Text = null;
            LoadListWorkAsync(_id);
        }
    }
}
