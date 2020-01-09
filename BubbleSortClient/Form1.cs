using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSortClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region UI Event Handlers
        private void button1_Click(object sender, EventArgs e)
        {
            RestClass rClient = new RestClass();
            if (numberList.Text == "")
            {
                responseBox.Text = "brak argumentów";
            }
            else
            {
                string url = "https://localhost:44350/api/Numbers/" + numberList.Text;
                rClient.endPoint = url;
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest();
                responseBox.Text = strResponse;
            }
           
        }
        #endregion
    }
}
