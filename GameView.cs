using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ICS3U1_Culminating
{
    public partial class GameView : Form
    {
        public GameView()
        {
            InitializeComponent();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            XmlDocument xm = new XmlDocument();
            xm.Load(Application.StartupPath + "\\resources\\" + "Questions.xml");
            XmlNodeList questions = xm.DocumentElement.SelectNodes("/Questions/Question");
            //XmlNode question = xm.DocumentElement.SelectSingleNode("/Question/Question");
            foreach (XmlNode question in questions)
            {
                XmlNodeList answers = question.SelectNodes("Answers");
             
                Console.WriteLine(answers.Count);
                foreach (XmlNode answer in answers) {
                    string firstName = answer["Text"].InnerText;
                    string lastName = answer["isCorrect"].InnerText;
                    Console.WriteLine("Name: {0} {1}", firstName, lastName);
                }
                Console.WriteLine(question.SelectSingleNode("Title").InnerText);
            }
            /*Answer one = new Answer();
            one.Title = "yeah";
            one.IsCorrect = true;
            Answer two = new Answer();
            two.IsCorrect = false;
            two.Title = "isdk";
            Question q = new Question
            {
                QuestionText = "Are youu bluu"
            };
            q.Answers.Add(one);
            q.Answers.Add(two);
            AnswerOne.Text = one.Title;
            AnswerTwo.Text = two.Title;
            AnswerOne.p*/
        }

        private void AnswerOne_Click(object sender, EventArgs e) 
        {

        }








        private void loadQuestions()
        {


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
                }
                else
                {
                    Labl.Text += text[i];
                    i++;
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
                control.Location = new Point(this.Width / 2 + (target.Width / 2), control.Location.Y);
                void timerTick(object sender, EventArgs e)
                {
                    if (control.Width < target.Width)
                    {
                        control.Location = new Point(control.Location.X - 1, control.Location.Y);
                        control.Visible = true;
                        control.Width += 1;
                    }
                    else
                    {
                        control.Location = new Point(this.Width / 2 - (control.Width / 2), control.Location.Y);
                        tmr.Enabled = false;
                        tmr.Stop();
                    }


                }
            }
            else if (typ == type.increasingHeight)
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

public class Answer
{
    public string Title { get; set; }
    public bool IsCorrect { get; set; }
}

public class Question
{
    public string QuestionText { get; set; }
    public IList<Answer> Answers { get; set; }
}