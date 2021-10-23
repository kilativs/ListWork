using System.Windows.Forms;

namespace ListWork.Forms.UserControls
{
    public partial class ListWorkItem : UserControl
    {
        private int Id { get; set; }

        public ListWorkItem(int id, string title, string description, string priority, string condition, string deadline)
        {
            InitializeComponent();
            titleLbl.Text = title;
            if (description.Length > 40)
            {
                description = description[..40];
                description += "...";
                descriptionLbl.Text = description;
            }
            else descriptionLbl.Text = description;

            descriptionLbl.Text = description;
            priorityLbl.Text = priority;
            conditionalLbl.Text = condition;
            deadlineLbl.Text = deadline;
            Id = id;
        }

        private void ListWorkItem_MouseClick(object sender, MouseEventArgs e)
        {
            var wndwHendler = new ShowListWorkForm(Id);
            wndwHendler.ShowDialog();
        }
    }
}
