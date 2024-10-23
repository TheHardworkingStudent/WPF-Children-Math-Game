using System.Reflection;
using System;
using System.Windows;
using System.Xml.Linq;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Interaction logic for wndFinalScoresScreen.xaml
    /// </summary>
    public partial class wndFinalScoresScreen : Window
    {
        /// <summary>
        /// Final score screen constructor that assigns values to gui.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public wndFinalScoresScreen()
        {
            try
            {
                InitializeComponent();
                ScoreNameLabel.Content = "Name: " + clsUser.Name;
                ScoreAgeLabel.Content = "Age: " + clsUser.Age;
                ScoreNumberCorrectAnswers.Content = "Number of correct answers: " + clsUser.NumberCorrect;
                ScoreNumberIncorrectAnswers.Content = "Number of incorrect answers: " + clsUser.NumberIncorrect;
                ScoreTimeToComplete.Content = "Time to complete: " + clsUser.SecondsElapsed;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Will close the screen when click the close high scores screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCloseHighScores_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
