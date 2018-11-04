using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitIt
{
    public partial class CreateFam : Form
    {
        private String famName;
        private int numMembers;
        private Form Main;

        public CreateFam( Form form)
        {
            InitializeComponent();
            this.MdiParent = form;
            Main = form;
        }

        private void create_Click(object sender, EventArgs e)
        {
            famName = textBox1.Text.ToString();
            numMembers = Int32.Parse(textBox2.Text.ToString());
            String fileName = famName + "_BillFile.txt";
            Console.WriteLine("Family Name : " + famName);
            if (!File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.Write(famName + Environment.NewLine + numMembers);
                writer.Close();
                MessageBox.Show(famName + " Family file succesfully created!");
                EditFam editFamForm = new EditFam(Main);
                editFamForm.Show();
                this.Close();
            }
            else {
                MessageBox.Show("This Family file already exists!");
            }
            
        }
    }
}
