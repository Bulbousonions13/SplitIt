using System;
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
        public EditFam(Form form)
        {
            InitializeComponent();
            Main = form;
            this.MdiParent = Main;
        }

        private void EditFam_Load(object sender, EventArgs e)
        {

        }
    }
}
