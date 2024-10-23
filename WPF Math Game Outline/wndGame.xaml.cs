using System;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Interaction logic for wndGame.xaml
    /// </summary>
    public partial class wndGame : Window
    {
        /// <summary>
        /// Creates the instance of the timer.
        /// </summary>
        private DispatcherTimer Timer;
        /// <summary>
        /// Creates the components for the game.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public wndGame()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// <para>This is the start game button</para>
        /// <para>Starts timer, runs start game button, generate question</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStartGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StartGameButton.Visibility = Visibility.Hidden;
                ReturnMenuButton.Visibility = Visibility.Visible;
                Start_Timer();
                clsGame.Start_Game();
                clsGame.GenerateQuestion();
                Update_Gui();
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Will create the final score screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFinalScoreScreen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndFinalScoresScreen wndMyFinalScoresScreen = new wndFinalScoresScreen();
                this.Hide();
                wndMyFinalScoresScreen.ShowDialog();
                clsGame.Stop_Game();
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// This button will return the game to main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReturnToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                clsGame.Stop_Game();
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Starts the timer and increments on a seperate thread.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void Start_Timer()
        {
            try
            {
                Timer = new System.Windows.Threading.DispatcherTimer();
                Timer.Tick += new EventHandler(Time_Tick);
                Timer.Interval = TimeSpan.FromSeconds(1);
                Timer.Start();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        /// <summary>
        /// Updates the gui whenever the game values change.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void Update_Gui()
        {
            try
            {
                QuestionContentLabel.Content = MathGameQuestion.QuestionString;
                QuestionCounterLabel.Content = "Question " + clsUser.QuestionNumber.ToString();
                AnswerTextBox.Text = "";
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Time tick function is called every 1 second and updates the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void Time_Tick(object sender, EventArgs e)
        {
            try
            {
                clsUser.SecondsElapsed++;
                TimerLabel.Content = "Time Elapsed: " + clsUser.SecondsElapsed;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// <para>Will attempt to submet the answer but checks for the user input first.</para>
        /// <para>If on the right question then goes to final score screen.</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int answer;
                if (Int32.TryParse(AnswerTextBox.Text, out answer))
                {
                    clsGame.ValidateAnswer(answer);
                    clsGame.GenerateQuestion();
                    Update_Gui();
                    if (clsGame.LastQuestion == true && clsGame.GameStarted == true)
                    {
                        Timer.Stop();
                        wndFinalScoresScreen wndMyFinalScoresScreen = new wndFinalScoresScreen();

                        //Fill up the clsUser object with the user's correct/incorrect/time stats
                        //Call a method behind the final score window to display data and pass in the clsUser object to the method
                        this.Hide();
                        wndMyFinalScoresScreen.ShowDialog();
                        clsGame.Stop_Game();
                    }
                }
                else
                {
                    QuestionContentLabel.Content = "Input must\nbe a\nnumber";
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// <para>Triggers SubmitAnswerButton_Click if you press the enter key.</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            try
            {
                if (e.Key == System.Windows.Input.Key.Enter)
                {
                    SubmitAnswerButton_Click((object)sender, e);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
