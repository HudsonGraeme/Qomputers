using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Security;
using System.Configuration;

namespace ICS3U1_Culminating
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = "0";
            countUp(Globals.points, scoreLabel);
            sendDataToServer();
        }
        Timer labelTransition = new Timer();

        private async void sendDataToServer()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.carspotter.ca");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var Reqcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("name", Globals.username),
                new KeyValuePair<string, string>("score", Globals.points.ToString())
                });
                Console.WriteLine("K");
                var result = await client.PostAsync("/index.php/highscores", Reqcontent);
                Console.WriteLine("Await");
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine(result.StatusCode);
                    string responseString = await result.Content.ReadAsStringAsync();
                    dynamic response = JsonConvert.DeserializeObject(responseString);
                    //Console.WriteLine(Convert.ToString(response));
                }
                else
                {
                    Console.WriteLine(result.StatusCode);
                }
            }
        }


        private void countUp(int score, Label Labl)
        {
            Timer tmr = new Timer();
            tmr.Interval = 10;
            tmr.Enabled = true;
            tmr.Start();
            tmr.Tick += new EventHandler(timerTick);

            void timerTick(object sender, EventArgs e)
            {
                if(int.Parse(Labl.Text) < score)
                {
                    Labl.Text = (int.Parse(Labl.Text) + 10).ToString();
                } else
                {
                    tmr.Enabled = false;
                    tmr.Stop();
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Landing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Expand(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            LeaderBoard leaderboard = new LeaderBoard();
            leaderboard.Show();
            this.Hide();
        }
    }
}
