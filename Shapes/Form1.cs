namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FnametextBox.Text) || string.IsNullOrEmpty(Lastnametextbox.Text) || string.IsNullOrEmpty(CellphonetextBox.Text))
            {
                MessageBox.Show("Please fill the blanks");
            }

            if (AdmincheckBox.Checked == true)
            {
                Admin Person1 = new Admin();
                Person1.FirstName = FnametextBox.Text;
                Person1.LastName = Lastnametextbox.Text;
                Person1.Cellphone = CellphonetextBox.Text;
                Person1.Gender = Genderdomain.Text;
                Person1.RoleName = rolenametextbox.Text;
                Person1.AccessID = AccessIDtextBox.Text;
                List<Admin> admins = new List<Admin>();
                admins.Add(Person1);

                int celladmin;
                bool correct = int.TryParse(Person1.Cellphone, out celladmin);

                if (Person1.Cellphone.StartsWith("+98"))
                {
                    Person1.Cellphone.Replace("+98", "0");
                }

            }
            else
            {
                User person1 = new User();
                person1.FirstName = FnametextBox.Text;
                person1.LastName = Lastnametextbox.Text;
                person1.Cellphone = CellphonetextBox.Text;
                person1.Gender = Genderdomain.Text;
                List<User> users = new List<User>();
                users.Add(person1);

                int celluser;
                bool number = int.TryParse(person1.Cellphone, out celluser);

                if (person1.Cellphone.StartsWith("+98"))
                {
                    person1.Cellphone.Replace("+98", "0");
                }
            }
            if (AdmincheckBox.Checked == true && (string.IsNullOrEmpty(rolenametextbox.Text) || string.IsNullOrEmpty(AccessIDtextBox.Text)))
            {
                MessageBox.Show("Please insert your role's information completely");
            }
            

        }

        private void AdmincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rolenametextbox.Enabled = AdmincheckBox.Checked;
            RoleNamelabel.Enabled = AdmincheckBox.Checked;
            AccessIDlabel.Enabled = AdmincheckBox.Checked;
            AccessIDtextBox.Enabled = AdmincheckBox.Checked;
        }


    }

}