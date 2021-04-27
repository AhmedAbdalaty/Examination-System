using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Exam
{
    public partial class frmLoginandRegister : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataSet DS;
        Color select_color = Color.FromArgb(49, 46, 46);
        frmInstructor insPage = new frmInstructor();
        frmdeptregst frmdeptregst1 = new frmdeptregst();
        frmstuds frmstudss = new frmstuds();

        public frmLoginandRegister()
        {
            InitializeComponent();
        }

        private void frmLoginandRegister_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial Catalog ='Examination System SD_41';Integrated Security=True";
            loginpanel.BringToFront();
            loginbutt.BackColor = Color.Black;
            Registerbut.BackColor = select_color;
            loginpanelsmall.BackColor = Color.PeachPuff;
            registerpanelsmall.BackColor = select_color;
        }
        private void loginbutt_Click(object sender, EventArgs e)
        {
            loginpanel.BringToFront();
            loginbutt.BackColor = Color.Black;
            Registerbut.BackColor = select_color;
            loginpanelsmall.BackColor = Color.PeachPuff;
            registerpanelsmall.BackColor = select_color;
        }

        private void Registerbut_Click(object sender, EventArgs e)
        {
            registerpanel.BringToFront();
            Registerbut.BackColor = Color.Black;
            loginbutt.BackColor = select_color;
            registerpanelsmall.BackColor = Color.PeachPuff;
            loginpanelsmall.BackColor = select_color;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkInputSignUp())
            {
                cmd = new SqlCommand("StudentSignUp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@stPassword", txtPassword.Text);
                cmd.Parameters.Add("@stEmail", txtEmail.Text);
                cmd.Parameters.Add("@stZipCode", int.Parse(txtZipCode.Text));
                cmd.Parameters.Add("@stStreet", txtStreet.Text);
                cmd.Parameters.Add("@stLName", txtLastName.Text);
                cmd.Parameters.Add("@stCity", txtCity.Text);
                cmd.Parameters.Add("@stFName", txtFirstName.Text);
                Da = new SqlDataAdapter(cmd);
                DS = new DataSet();
                Da.Fill(DS);
                SqlCommandBuilder SCB = new SqlCommandBuilder(Da);
                MessageBox.Show("Data Inserted");
                this.Hide();
                //frmdeptregst1.mail= this.txtLoginEmail.Text;
                frmdeptregst1.ShowDialog();
                this.Visible = true;
            }
        }
        private bool checkInputSignUp()
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Invalid First Name", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Invalid Last Name", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtZipCode.Text))
            {
                MessageBox.Show("Invalid Zipcode", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();
                return false;
            }
            else
            {
                for (int i = 0; i < txtZipCode.Text.Length; i++)
                {
                    if (!char.IsNumber(txtZipCode.Text[i]))
                    {
                        MessageBox.Show("Invalid Zipcode", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtZipCode.Focus();
                        return false;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Invalid City Name", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Invalid Street Name", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else
            {
                Regex mRegxExpression;
                if (txtEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                    {
                        MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                        return false;
                    }
                }
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Invalid Password", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            if (txtPassword.Text != txtConfirmpassword.Text)
            {
                MessageBox.Show("Password not identical", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            cmd = new SqlCommand("select UserEmail from Users", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                if (txtEmail.Text == Dr["UserEmail"].ToString())
                {
                    conn.Close();
                    MessageBox.Show("User Email is already in the system", "MojoCRM",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            conn.Close();
            return true;
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkInputLogIn())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand("StudentLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@stEmail", txtLoginEmail.Text);
                cmd.Parameters.Add("@stPassword", int.Parse(txtLoginPassword.Text));
                SqlCommand SqlEmailCheck = new SqlCommand("select count(*) from Users where UserType='I' and UserEmail= @email", conn);
                SqlEmailCheck.Parameters.AddWithValue("@email", txtLoginEmail.Text);
                if (int.TryParse(cmd.ExecuteScalar()?.ToString() ?? "0", out int N))
                {
                    if ((N == 1))
                    {
                        if ((int)SqlEmailCheck.ExecuteScalar() == 1)
                        {
                            conn.Close();
                            this.Hide();
                            insPage.mail = this.txtLoginEmail.Text;
                            insPage.ShowDialog();
                            this.Visible = true;
                            return;
                        }
                        else
                        {
                            if ((int)SqlEmailCheck.ExecuteScalar() == 0)
                            {
                                conn.Close();
                                this.Hide();
                                frmstudss.mail = this.txtLoginEmail.Text;
                                frmstudss.ShowDialog();
                                this.Visible = true;
                                return;
                            }
                        }
                    }
                    else if (N == 0) MessageBox.Show("Invalid Credentials", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        //SqlDataReader Dr = SqlEmailCheck.ExecuteReader();
        //while (Dr.Read())
        //{
        //    if (txtLoginEmail.Text == Dr["UserEmail"].ToString())//this means that this is an instructor
        //    {
        //        conn.Close();
        //        this.Hide();
        //        insPage.mail = this.txtLoginEmail.Text;
        //        insPage.ShowDialog();
        //        this.Visible = true;
        //        return;
        //    }
        //}
        private bool checkInputLogIn()
        {
            if (String.IsNullOrEmpty(txtLoginEmail.Text))
            {
                MessageBox.Show("Invalid Email format", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginEmail.Focus();
                return false;
            }
            else
            {
                Regex mRegxExpression;
                if (txtLoginEmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtLoginEmail.Text.Trim()))
                    {
                        MessageBox.Show("Invalid Email format", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLoginEmail.Focus();
                        return false;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Invalid Password", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginPassword.Focus();
                return false;
            }
            else
            {
                for (int i = 0; i < txtLoginPassword.Text.Length; i++)
                {
                    if (!char.IsNumber(txtLoginPassword.Text[i]))
                    {
                        MessageBox.Show("Invalid Credentials", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLoginPassword.Focus();
                        return false;
                    }
                }
            }
            return true;
        }


    }
}

