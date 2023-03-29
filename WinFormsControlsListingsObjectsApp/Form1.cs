namespace WinFormsControlsListingsObjectsApp
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        public Form1()
        {
            employees = new List<Employee>()
            {
                new(){ Id = 11, Name = "Joe", Age = 34, IsMarried = true },
                new(){ Id = 19, Name = "Joe", Age = 34, IsMarried = true },

                new(){ Id = 12, Name = "Bob", Age = 22, IsMarried = false },
                new(){ Id = 13, Name = "Tim", Age = 41, IsMarried = true },
                new(){ Id = 14, Name = "Sam", Age = 19, IsMarried = false },
                new(){ Id = 15, Name = "Leo", Age = 28, IsMarried = true },
            };
            InitializeComponent();

            lstBoxEmploees.DataSource = employees;
            lstBoxEmploees.DisplayMember = "Name";
            lstBoxEmploees.ValueMember = "Id";
        }

        private void lstBoxEmploees_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lstBoxEmploees.SelectedValue.ToString());
        }
    }
}