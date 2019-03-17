using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vtdi_Gatelog
{
    
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }


        private void btSubmit_Click(object sender, EventArgs e)
        {
           

            var ctx = new GateInDatabaseEntities();

            var username = txtUserName.Text;
            var password = txtPassword.Text;
            


            if (username == "")
            {
                String txtusername = String.Empty;
                MessageBox.Show("The username fields are empty kindly enter the following information required");
             }

               else if (password == "")
            {
                MessageBox.Show("The password fields are empty kindly enter the following information required");
            }

            else              {
                var userCount = ctx.Users.Count(q => q.Username == username && q.Password == password);



                if (userCount != 1)
                {
                    MessageBox.Show("Invalid creditials");
                }
                else
                {
                    this.Close();
                    //btLogin.Show();
                    MessageBox.Show("Welcome ");
                }
            }



            User usern = new User();
            //MessageBox.Show();
            var showid = usern.Id;
            Select  where ID is 1
            MessageBox.Show("Hello: " +showid);
                   }
    
           

            

          






                
                //Previous coding 

                /*  if (txtUserName.Text == admin && txtPassword.Text == admin)
                {
                    MessageBox.Show(" Loggin SUCCESSFULL !!! \r \nOne Moment for Application to Load");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Invalid password entered, try again or contact admin");
                    txtPassword.Clear();
                }

                */
           
        

        private void btReset_Click(object sender, EventArgs e)
        {
            
            

            txtPassword.Clear();
            txtUserName.ClearUndo();
        }

        

        private void btReset_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to reset the information ");
        }
    }
}
