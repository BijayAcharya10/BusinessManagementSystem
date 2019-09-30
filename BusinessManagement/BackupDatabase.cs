using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagement
{
    public partial class BackupDatabase : Form
    {
        public BackupDatabase()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;

            }
        }
       
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-OQ80NQL\\BIJAY; Integrated Security=true; Initial Catalog=BusinessManagementDB");
            string databse = con.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter by Browsing Database Backup Location....!");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + databse + "] TO DISK='" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();

                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Database Backup has been Successefully Created..!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\n" + ex);

            }
        }
    }
}
