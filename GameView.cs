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
using System.Xml.Linq;



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
            nextQuestion();
            tm.Enabled = true;
            tm.Interval = 1000;
            tm.Tick += new EventHandler(tm_Tick);
        }
        Timer tm = new Timer();
        int subtractedpoints = 0;
        int count = 0;
        private void tm_Tick(object sender, EventArgs e)
        {
            if (count < 30)
            {
                subtractedpoints += 10;
            }

        }
        private void AnswerOne_Click(object sender, EventArgs e)
        {
            if (AnswerOne.isCorrect)
            {
                questionText.Text = "Congratulations!";
                Globals.points += (500 - subtractedpoints);
            }
            else
            {
                questionText.Text = "Sorry.";
            }
            PointsLabel.Text = Globals.points.ToString();
            NextButton.Visible = true;
            AnswerOne.Enabled = false;
            AnswerTwo.Enabled = false;
            AnswerThree.Enabled = false;
            AnswerFour.Enabled = false;
        }

        private void AnswerTwo_Click(object sender, EventArgs e)
        {
            if (AnswerTwo.isCorrect)
            {
                questionText.Text = "Congratulations!";
                Globals.points += (500 - subtractedpoints);
            }
            else
            {
                questionText.Text = "Sorry.";
            }
            PointsLabel.Text = Globals.points.ToString();
            NextButton.Visible = true;
            AnswerOne.Enabled = false;
            AnswerTwo.Enabled = false;
            AnswerThree.Enabled = false;
            AnswerFour.Enabled = false;
        }

        private void AnswerThree_Click(object sender, EventArgs e)
        {
            if (AnswerThree.isCorrect)
            {
                questionText.Text = "Congratulations!";
                Globals.points += (500 - subtractedpoints);
            }
            else
            {
                questionText.Text = "Sorry.";
            }
            PointsLabel.Text = Globals.points.ToString();
            NextButton.Visible = true;
            AnswerOne.Enabled = false;
            AnswerTwo.Enabled = false;
            AnswerThree.Enabled = false;
            AnswerFour.Enabled = false;
        }

        private void AnswerFour_Click(object sender, EventArgs e)
        {
            tm.Stop();
            if (AnswerFour.isCorrect)
            {
                questionText.Text = "Congratulations!";
                Globals.points += (500 - subtractedpoints);
            }
            else
            {
                questionText.Text = "Sorry.";
            }
            PointsLabel.Text = Globals.points.ToString();
            NextButton.Visible = true;
            AnswerOne.Enabled = false;
            AnswerTwo.Enabled = false;
            AnswerThree.Enabled = false;
            AnswerFour.Enabled = false;
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            AnswerOne.Enabled = true;
            AnswerTwo.Enabled = true;
            AnswerThree.Enabled = true;
            AnswerFour.Enabled = true;
            nextQuestion();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }
        private void nextQuestion()
        {
            NextButton.Visible = false;
            var xm = Globals.xm;
            var questions = Globals.questions;
            if (questions.Count() < 1)
            {
                AnswerOne.Enabled = false;
                AnswerTwo.Enabled = false;
                AnswerThree.Enabled = false;
                AnswerFour.Enabled = false;
                Button Finish = new Button();
                Finish = NextButton;
                Finish.Text = "Finish";
                Finish.Enabled = true;
                Finish.Visible = true;
                Finish.Click += new EventHandler(finishButton_Click);
                this.Controls.Add(Finish);
            }
            else {
                Random rndm = new Random();
                int rand = rndm.Next(0, questions.Count());
                var currentQuestion = questions.ElementAt(rand);
                questionText.Text = currentQuestion.Element("Title").Value;
                var answers = currentQuestion.Element("Answers").Elements();

                foreach (var answer in answers)
                {
                    string text = answer.Element("Text").Value;
                    bool isCorrect = Boolean.Parse(answer.Element("isCorrect").Value.ToString());
                    if (answer == answers.First())
                    {
                        AnswerOne.Text = answer.Element("Text").Value;
                        AnswerOne.isCorrect = Boolean.Parse(answer.Element("isCorrect").Value);
                    }
                    else if (answer == answers.ElementAt(1))
                    {
                        AnswerTwo.Text = answer.Element("Text").Value;
                        AnswerTwo.isCorrect = Boolean.Parse(answer.Element("isCorrect").Value);
                    }
                    else if (answer == answers.ElementAt(2))
                    {
                        AnswerThree.Text = answer.Element("Text").Value;
                        AnswerThree.isCorrect = Boolean.Parse(answer.Element("isCorrect").Value);
                    }
                    else if (answer == answers.ElementAt(3))
                    {
                        AnswerFour.Text = answer.Element("Text").Value;
                        AnswerFour.isCorrect = Boolean.Parse(answer.Element("isCorrect").Value);
                    }
                }
                xm.Element("Questions").Elements().ElementAt(rand).Remove();
                tm.Start();
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

        private void GameView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

public class CButton : Button
{
    private bool Correct;

    public bool isCorrect { get { return Correct; } set { Correct = value; } }
}

public static class Globals
{
    public static String username = "null";
    public static int points = 0;
    public static XDocument xm = XDocument.Load(Application.StartupPath + "\\resources\\" + "Questions.xml");
    public static IEnumerable<XElement> questions = xm.Element("Questions").Elements();
}