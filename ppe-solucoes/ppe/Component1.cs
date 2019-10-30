using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
            
        }

        public void panel1_Paint() {


        }

        public void teste()
        {
            panel1.Show();
        }

       

        public void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

           

        }

        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }
}
