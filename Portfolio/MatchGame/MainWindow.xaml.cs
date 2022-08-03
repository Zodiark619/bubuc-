using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string gameMode;
        DispatcherTimer timer=new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();
            

            //pick a mode
            //ExhibitionMode();
            TimeAttack();
        }

        private void ExhibitionMode()
        {
            gameMode = "Exhibition";
            timer.Interval = TimeSpan.FromSeconds(.1);

            timer.Tick += Timer_Tick;

            WaifuSimpStart();
        }
        private void TimeAttack()
        {
            gameMode = "TimeAttack";
            timer.Interval = TimeSpan.FromSeconds(.1);

            timer.Tick += Timer_TickTA;

            WaifuSimpStart();
        }

        private void Timer_TickTA(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed--;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8 && tenthsOfSecondsElapsed > 1)
            {
                timer.Stop();

                timeTextBlock.Text += " - You survived";

            }
            else if(tenthsOfSecondsElapsed ==0)
            {
                timer.Stop();
                timeTextBlock.Text += " - Game over, you lose";

            }
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if(matchesFound == 8)
            {
                timer.Stop();
                if (tenthsOfSecondsElapsed < 100)
                {
                    timeTextBlock.Text += " - Well played!~";
                    
                }
                else
                {
                    timeTextBlock.Text += " - Play again??";

                }
            }
        }

        private void WaifuSimpStart()
        {
            List<string> waifuEmoji = new List<string>()
            {
                "🦁", "🦁",
                "🥰","🥰",
                "🎅","🎅",
                "🕵️‍","🕵️‍",
                "♀️🏄‍","♀️🏄‍",
                "♂️👍","♂️👍",
                "🎁","🎁",
                "⚽","⚽"

            };
            Random random=new Random();
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(waifuEmoji.Count);
                    string nextEmoji = waifuEmoji[index];
                    textBlock.Text = nextEmoji;
                    waifuEmoji.RemoveAt(index);
                }
                
            }
            timer.Start();
            if (gameMode == "Exhibition")
            {
                tenthsOfSecondsElapsed = 0;

            }
            else if (gameMode == "TimeAttack")
            {
                tenthsOfSecondsElapsed = 100;

            }
            matchesFound = 0;
        }
        TextBlock lastTextBlockClicked;
        bool findingMatch;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch= false;
            }

        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                WaifuSimpStart();

            }
        }
    }
}
