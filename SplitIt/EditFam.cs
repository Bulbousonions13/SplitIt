using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitIt
{    
    public partial class EditFam : Form
    {
        Form Main;
        int numMembers;
        int currMembers; 
        String fileName;
        Boolean exists;


        public EditFam(Form form, String fileName, Boolean exists)
        {
            InitializeComponent();
            Main = form;
            this.MdiParent = Main;
            this.fileName = fileName;
            this.exists = exists;
            if (!exists) currMembers = 0;
            else currMembers = numMembers;
        }

        private void EditFam_Load(object sender, EventArgs e)
        {
            if (!exists)
            {
                int lineNum = 1;
                string line = "Not initiated";
                StreamReader reader = new StreamReader(fileName);
                while ((line = reader.ReadLine()) != null)
                {
                    String[] split = line.Split(':');

                    if (split[0].Equals("numMembers"))
                    {
                        numMembers = Int32.Parse(split[1]);
                    }
                    lineNum++;
                }

                reader.Close();
                Console.WriteLine(numMembers);                
            }
        }

        private void enterMemberButton_Click(object sender, EventArgs e)
        {
             if(currMembers <numMembers)
            {
                String name = enterNameTB.Text.ToString();
                String email = enterEmailTB.Text.ToString();
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(Environment.NewLine+ "member:" + name + ":" + email);
                writer.Close();
                currMembers++;

                if (currMembers == numMembers) {
                    MessageBox.Show("All Members entered! Time to enter some bills!");
                    ManageBills manageBillsForm = new ManageBills(Main,fileName);
                    manageBillsForm.Show();
                    this.Close();
                }

                enterNameTB.Text="";
                enterEmailTB.Text = "";

                enterNameLabel.Text = "Enter Member : " + (currMembers+1) + " Name : ";
                enterEmailLabel.Text = "Enter Member : " + (currMembers+1) + " Email : ";

            }
        }
    }
}
