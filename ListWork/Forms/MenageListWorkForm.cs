using ListWork.Model;
using ListWork.Model.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListWork.Forms
{
    public partial class MenageListWorkForm : Form
    {
        private readonly bool _isCreate;

        private readonly int _id;

        public MenageListWorkForm(int listWorkId = 0)
        {
            InitializeComponent();
            if (listWorkId != 0) LoadListWorkAsync(listWorkId);
            else _isCreate = true;
            _id = listWorkId;
            prioretyCB.DataSource = Enum.GetValues(typeof(Priority));
            conditionCB.DataSource = Enum.GetValues(typeof(Condition));
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
                    if (model != null)
                    {
                        titleTB.Text = model.Title;
                        descriptionRB.Text = model.Description;
                        deadlineTP.Text = model.Deadline.ToString(CultureInfo.InvariantCulture);
                    }

                    prioretyCB.DataSource = Enum.GetValues(typeof(Priority));
                    conditionCB.DataSource = Enum.GetValues(typeof(Condition));
                }));
            });
        }

        private Priority ReadPriorityCb()
        {
            Enum.TryParse(prioretyCB.SelectedValue.ToString(), out Priority selectedTypeParsing);
            return selectedTypeParsing;
        }

        private Condition ReadConditionCb()
        {
            Enum.TryParse(conditionCB.SelectedValue.ToString(), out Condition selectedTypeParsing);
            return selectedTypeParsing;
        }

        private void saveBtn_Click( object sender, EventArgs e)
        {
            if(_isCreate)
            {
                var client = new RestClient($"{Program.Url}/ListWork/create")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var priority = ReadPriorityCb();
                var condition = ReadConditionCb();
                var body = new ListWorkResponseModel
                {
                    Title = titleTB.Text,
                    Description = descriptionRB.Text,
                    PriorityWork = priority,
                    Deadline = deadlineTP.Value,
                    ConditionWork = condition
            };
                request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                client.Execute(request);
                ListWorkForm.GetInstance().RefreshItem();
                Close();
            }
            else
            {
                var client = new RestClient($"{Program.Url}/ListWork/edit")
                {
                    Timeout = -1
                };
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var priority = ReadPriorityCb();
                var condition = ReadConditionCb();
                var body = new ListWorkResponseModel
                {
                    Id = _id,
                    Title = titleTB.Text,
                    Description = descriptionRB.Text,
                    PriorityWork = priority,
                    Deadline = deadlineTP.Value,
                    ConditionWork = condition
                };
                request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                client.Execute(request);
               
                ListWorkForm.GetInstance().RefreshItem();
                Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ActiveForm?.Close();
        }
    }
}
