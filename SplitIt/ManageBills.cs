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
    public partial class ManageBills : Form
    {
        String fileName;
        int numMembers;
        String[] members;
        String[] emails;
        Form Main;

        public ManageBills( Form parent, String fileName)
        {
            InitializeComponent();
            Main = parent;
            this.MdiParent = Main;
            this.fileName = fileName;
        }

        private void ManageBills_Load(object sender, EventArgs e)
        {
            getMemberInfo();
            foreach(String s in members) { 
                memberList.Items.Add(s);
            }
        }

        private void getMemberInfo() {
            
            string line = "Not initiated";
            int memIndex = 0;            
            StreamReader reader = new StreamReader(fileName);
            while ((line = reader.ReadLine()) != null)
            {
                String[] split = line.Split(':');

                if (split[0].Equals("numMembers"))
                {
                    numMembers = Int32.Parse(split[1]);
                    members = new string[numMembers];
                    emails = new string[numMembers];
                }
                else if (split[0].Equals("member"))
                {
                    members[memIndex] = split[1];
                    emails[memIndex] = split[2];
                    memIndex++;
                }
                
            }
            MessageBox.Show(String.Join(":", members) + String.Join(":", emails));
            reader.Close();
        }

       
    }
}
