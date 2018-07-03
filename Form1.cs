using SQLDataAccessDemo.DAL;
using SQLDataAccessDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataAccessDemo
{
    public partial class Dashboard : Form
    {
        private List<Person> people = new List<Person>();
        // private DataTable people = new DataTable();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess dal = new DataAccess();
            people = dal.Getpeople(txtLastname.Text);
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataAccess dal = new DataAccess();
            dal.InsertPerson(txtFirstName.Text, txtLastName2.Text, txtEmail.Text, txtPhoneNumber.Text);
        }
    }
}