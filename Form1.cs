using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS3U1_Culminating
{
    public partial class InitialView : Form
    {
        public InitialView()
        {
            InitializeComponent();
        }
        Timer labelTransition = new Timer();
        private void InitializeTimer()
        {
            labelTransition.Interval = 1000;
            labelTransition.Enabled = true;
            labelTransition.Tick += new EventHandler(labelTransition_Tick);
            labelTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection hind = new PrivateFontCollection();
            hind.AddFontFile(Application.StartupPath + "\\resources\\" + "Hind-Light.ttf");
            MainLabel.Font = new Font(hind.Families[0], 40);
            InitializeTimer();
        }

        private TextBox UsernameEntry = new TextBox();
        private void InitializeUsernameField()
        {

        }
        private void labelTransition_Tick(object sender, EventArgs e)
        {
            if(UsernameEntry.Width == 0)
            {
                InitializeUsernameField();
            }
            if(MainLabel.Location.Y >= -10)
            {
                MainLabel.Location = new Point(MainLabel.Location.X, MainLabel.Location.Y - 1);
                Console.WriteLine(MainLabel.Location);
            } else
            {
                labelTransition.Stop();
            }
            if(labelTransition.Interval == 1000)
            {
                labelTransition.Interval = 10;
            }
        }



    }
}
