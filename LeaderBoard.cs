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
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();
            loadData();
        }

        private async void loadData()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.carspotter.ca");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine("K");
                var result = await client.GetAsync("/index.php/highscores?transform=1");
                Console.WriteLine("Await");
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine(result.StatusCode);
                    string responseString = await result.Content.ReadAsStringAsync();
                    dynamic response = JsonConvert.DeserializeObject(responseString);
                    foreach (dynamic yeh in response.highscores) {
                        Console.WriteLine(yeh.name);
                        Console.WriteLine(yeh.score);
                        LeaderData.Rows.Add(Convert.ToString(yeh.name), Convert.ToInt32(yeh.score));
                    }
                    //Console.WriteLine(response);
                }
                else
                {
                    Console.WriteLine(result.StatusCode);
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Leaderboard_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
