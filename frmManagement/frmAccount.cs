using BussinessObject2;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class frmAccount : Form
    {

        IAccountRepository repository = new AccountRepository();
        public frmAccount()
        {
            InitializeComponent();
        }

        public void LoadRoleList()
        {
            try
            {
                var roleList = repository.GetRoles().ToArray();
                // cbbCategory.DataSource = categoryList;
                cbbRole.DataSource = new BindingSource()
                {
                    DataSource = roleList,
                };
                cbbRole.DisplayMember = "Rolename";
                cbbRole.ValueMember = "Roleid";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of roles");
            }
        }


        public void LoadAccountList()
        {
            try
            {
                var accountList = repository.GetAccounts();
                BindingSource source = new BindingSource();
                source.DataSource = accountList;


            

                txtAccountID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cbbRole.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtAccountID.DataBindings.Add("Text", source, "aid");
                txtName.DataBindings.Add("Text", source, "username");
                txtPassword.DataBindings.Add("Text", source, "password");
                
                txtStatus.DataBindings.Add("Text", source, "status");
           //     cbbRole.DataBindings.Add("Text", source, "Role.roleid");

                dgvAccount.DataSource = null;
                dgvAccount.DataSource = source;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Account");
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadRoleList();
            LoadAccountList(); ;
        }

        private void ClearText()
        {



           

            txtAccountID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtStatus.Text = "";
            cbbRole.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;
                // Clear DataBinding



           

                txtAccountID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                cbbRole.DataBindings.Clear();
                dgvAccount.ClearSelection();

                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadAccountList(); 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtAccountID.Enabled = false;
            if (txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!", "Account Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Account
                {
                 
                   // Aid = int.Parse(txtAccountID.Text),
                    Username = txtName.Text,
                    Password= txtPassword.Text,
                    Role = int.Parse(cbbRole.SelectedValue.ToString()),
                    
                    Status = bool.Parse(txtStatus.Text)



                };
                repository.SaveAccount(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;

               LoadAccountList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
        

                Aid = int.Parse(txtAccountID.Text),
                Username= txtName.Text,
                Password= txtPassword.Text,
                Status= Boolean.Parse(txtStatus.Text),
             //  Role = int.Parse(cbbRole.SelectedValue.ToString()),



            };

            repository.UpdateAccount(account);
            LoadAccountList();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this record?", "Account Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var p = new Account
                    {
                        Aid = int.Parse(txtAccountID.Text),
                    };
                    repository.DeleteAccount(p);
                    LoadAccountList();
                }
            }
        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          

            int Index = dgvAccount.CurrentCell.RowIndex;
            Account account = repository.GetAccountByIndex(Index);
            txtAccountID.Text=account.Aid.ToString();
            txtName.Text=account.Username.ToString();
            txtPassword.Text=account.Password.ToString();
            txtStatus.Text=account.Status.ToString();
            cbbRole.Text = account.Role.ToString();


        }
    }
}
