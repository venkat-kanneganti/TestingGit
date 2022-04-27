using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharectors()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\practice\\Advance CHash\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                //it will sleep for five seconds
                Thread.Sleep(5000);
            }
            return count;
        }
        

        private void btnprocessfile(object sender, EventArgs e)
        {
            lblCount.Text = "Processing File Please Wait...";
            int count = CountCharectors();
            lblCount.Text = count.ToString() + "charectors in file";

        }

      
    }
}
