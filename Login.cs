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
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;


namespace ICS3U1_Culminating
{
    public partial class InitialView : Form
    {

        private TextBox UsernameEntry = new TextBox();
        private Label UsernameField = new Label();
        private Button AcceptUsername = new Button();
        public InitialView()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection hind = new PrivateFontCollection();
            hind.AddFontFile(Application.StartupPath + "\\resources\\" + "Hind-Light.ttf");
            MainLabel.Font = new Font(hind.Families[0], 40);
            UsernameField.Font = new Font(hind.Families[0], 11);
            UsernameEntry.Visible = false;
            InitializeTimer();
 
        }

        private void InitialView_Shown(object sender, EventArgs e)
        {
            InitializeUsernameField();
            InitializeAcceptButton();
        }
        private void InitializeAcceptButton()
        {
            PrivateFontCollection hind = new PrivateFontCollection();
            hind.AddFontFile(Application.StartupPath + "\\resources\\" + "Hind-Light.ttf");
            AcceptUsername.Width = 0;
            AcceptUsername.Height = 40;
            AcceptUsername.Location = new Point(this.Width / 2 - AcceptUsername.Width / 2, UsernameEntry.Location.Y + 50);
            AcceptUsername.Font = new Font(hind.Families[0], 12);
            AcceptUsername.Text = "Start";
            AcceptUsername.ForeColor = Color.White;
            AcceptUsername.FlatStyle = FlatStyle.Flat;
            AcceptUsername.FlatAppearance.BorderColor = Color.LightSkyBlue;
            AcceptUsername.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            AcceptUsername.Click += new EventHandler(AcceptButton_Click);
            animate(type.increasingWidth, AcceptUsername, new Size(300, 40));
            this.Controls.Add(AcceptUsername);
        }
        System.Windows.Forms.Timer labelTransition = new System.Windows.Forms.Timer();
        private void InitializeTimer()
        {
            labelTransition.Interval = 1000;
            labelTransition.Enabled = true;
            labelTransition.Tick += new EventHandler(labelTransition_Tick);
            labelTransition.Start();
        }

        private void InitializeUsernameField()
        {
            PrivateFontCollection hind = new PrivateFontCollection();
            hind.AddFontFile(Application.StartupPath + "\\resources\\" + "Hind-Light.ttf");
            UsernameEntry.Font = new Font(hind.Families[0], 12);
            UsernameEntry.Visible = false;
            UsernameEntry.Location = new Point(ActiveForm.Size.Width / 2 - (UsernameEntry.Width + 200), (this.ClientSize.Height / 2) + UsernameEntry.Height / 2);
            UsernameEntry.BackColor = this.BackColor;
            UsernameEntry.ForeColor = Color.White;
            UsernameEntry.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(UsernameEntry);
            animate(type.increasingWidth, UsernameEntry, new Size(500, 50));
            // UsernameField.Location = new Point(ActiveForm.Size.Width / 2 + (UsernameField.Width / 2), UsernameEntry.Location.Y - 40);
            UsernameField.Size = new Size(500, 50);
            UsernameField.Location = new Point((MainLabel.Left + MainLabel.Width / 2) - UsernameField.Width / 2, (this.Height / 2) - (UsernameField.Height / 2));
            UsernameField.Top = ((this.ClientSize.Height / 2) - UsernameField.Height * 2);
            UsernameField.TextAlign = ContentAlignment.MiddleCenter;
            UsernameField.ForeColor = Color.White;
            Controls.Add(UsernameField);
            UsernameField.Visible = false;
            typewriteLabel("Please enter a username of your choice below.", UsernameField);
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(UsernameEntry.Text))
            {
                /*using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://api.carspotter.ca");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    var ReqContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("Username", UsernameEntry.Text)
                    });
                    var result = await client.PostAsync("/addUser", null);
                }*/
                GameView GameView = new GameView();
                GameView.Show();
                this.Close();
                } else
            {
                UsernameField.Text = "Please enter a username.";
                UsernameField.ForeColor = Color.Red;
            }
        }

        public int X = 5;
        private void labelTransition_Tick(object sender, EventArgs e)
        {
            if (MainLabel.Location.Y >= 10)
            {

                if (MainLabel.Location.Y <= 50)
                {
                    if (X <= 1)
                    {
                        X = 1;
                    }
                    else
                    {
                        X -= 1;
                    }
                    MainLabel.Location = new Point(MainLabel.Location.X, MainLabel.Location.Y - X);
                }
                else
                {
                    MainLabel.Location = new Point(MainLabel.Location.X, MainLabel.Location.Y - 5);
                }
            }
            else
            {
                labelTransition.Stop();
                labelTransition.Enabled = false;
            }
            if(labelTransition.Interval == 1000)
            {
                labelTransition.Interval = 10;
            }
        }
        private void typewriteLabel(string text, Label Labl)
        {
            var i = 0;
            var maxLength = text.Length;
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 100;
            tmr.Enabled = true;
            tmr.Start();
            tmr.Tick += new EventHandler(timerTick);

            void timerTick(object sender, EventArgs e)
            {
                if (i >= maxLength)
                {
                    tmr.Stop();
                    tmr.Enabled = false;
                } else
                {
                    Labl.Text += text[i];
                    i++;
                }
                if(Labl == UsernameField)
                {
                    if(MainLabel.Location.Y < Labl.Location.Y)
                    {
                        Labl.Visible = true;
                    }

                }
                
            }
        }
        private void animate(type typ, Control control, Size target)
        {
            if (typ == type.increasingWidth)
            {
                var maxWidth = target.Width;
                System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
                tmr.Interval = 10;
                tmr.Enabled = true;
                tmr.Start();
                tmr.Tick += new EventHandler(timerTick);
                control.Location = new Point(MainLabel.Left + (MainLabel.Width / 2) + (target.Width / 2), control.Location.Y);
                if (control == UsernameEntry)
                {
                    control.Location = new Point(MainLabel.Left + (MainLabel.Width / 2) + target.Width / 4 + 25, control.Location.Y);
                }
                void timerTick(object sender, EventArgs e) {
                    if(control.Width < target.Width)
                    {
                        control.Location = new Point(control.Location.X - 1, control.Location.Y);
                        control.Visible = true;
                        control.Width += 1;
                    } else
                    {
                        control.Location = new Point(MainLabel.Left + (MainLabel.Width / 2) - (control.Width / 2), control.Location.Y);
                        tmr.Enabled = false;
                        tmr.Stop();
                    }


                }
            } else if (typ == type.increasingHeight)
            {
                var maxHeight = target.Height;
                System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
                tmr.Interval = 10;
                tmr.Enabled = true;
                tmr.Start();
                tmr.Tick += new EventHandler(timerTick);
                control.Location = new Point(control.Location.X, control.Location.Y + (target.Height - control.Location.Y));
                void timerTick(object sender, EventArgs e)
                {
                    if (control.Height < maxHeight)
                    {
                        control.Location = new Point(control.Location.X, control.Location.Y - 1);
                        control.Visible = true;
                        control.Height += 1;

                        Console.WriteLine(control.Height);
                    }
                    else
                    {
                        tmr.Enabled = false;
                        tmr.Stop();
                    }


                }
            }

            else
            {
                Console.WriteLine("Whoops");
            }
        }
        enum type
        {
            increasingWidth,
            increasingHeight,
            fading
        }

        // Handle movement of the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
        }
        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Expand(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }

}
/*
                {
                    UsernameField.Location = new Point(ActiveForm.Size.Width / 2 - 250, UsernameEntry.Location.Y - 40);
                    UsernameField.Size = new Size(500, 50);
                    UsernameField.TextAlign = ContentAlignment.MiddleLeft;
                    Controls.Add(UsernameField);
                    typewriteLabel("Please enter a username of your choice below.", UsernameField);
                }
 */
