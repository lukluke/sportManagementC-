using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sendEmail : MetroFramework.Forms.MetroForm
    {
        public sendEmail()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage(); // Email Object
            try // Its a good practice to write your code in a try catch block 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Connection Object
               
                message.From = new MailAddress(txtreciever.Text); // Sender Email
                message.To.Add(txtreciever.Text); // Reciever emailid
                message.Body = txtbody.Text; // Body of the email
                message.Subject = txtsubject.Text; // Subject of the email
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Enabling secured Connection
                if (txtattachment.Text != null)
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text)); //Adding attachment
                }
                client.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpass.Text); // Setting Credential of gmail account
                Cursor.Current = Cursors.WaitCursor;
                client.Send(message); //Sending Email
                MessageBox.Show("Email Sent! ;)");
                Cursor.Current = Cursors.Default;
                message = null; // Free the memory
            }
            catch (Exception ex) // Catching if any error occurs
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnattach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtattachment.Text = openFileDialog1.FileName.ToString();
            }
        }
    }
}
