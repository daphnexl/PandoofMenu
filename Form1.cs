using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandoofMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ButtonList = new List<Button>();
            ButtonList.Add(button1);
            ButtonList.Add(button2);
            ButtonList.Add(button3);
            ButtonList.Add(button4);
            ButtonList.Add(button5);
            ButtonList.Add(button6);

            userControlList = new List<UserControl>();
            userControlList.Add(userControl12);
            userControlList.Add(userControl21);
            userControlList.Add(userControl31);
            userControlList.Add(userControl41);
            userControlList.Add(userControl51);
            userControlList.Add(userControl61);

            userControlList[0].BringToFront();
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button btn = (Button)sender;
                SidePanel.Height = btn.Height;
                SidePanel.Top = btn.Top;

                int index = Convert.ToInt32(btn.Name.Substring(btn.Name.Length - 1));
                userControlList[index-1].Show();
                userControlList[index-1].BringToFront();
            }
        }
    }
}
