using System.Windows;
using System;
using System.Windows.Controls;
using System.Reflection;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Interaction logic for wndEnterUserData.xaml
    /// </summary>
    public partial class wndEnterUserData : Window
    {
        /// <summary>
        /// Constructor for creating the window.
        /// </summary>
        public wndEnterUserData()
        {
            InitializeComponent();

            //MAKE SURE TO INCLUDE THIS LINE OR THE APPLICATION WILL NOT CLOSE
            //BECAUSE THE WINDOWS ARE STILL IN MEMORY
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;///////////////////////////////////////////////////////////
        }
        /// <summary>
        /// <para>Makes sure that the name is entered properly.</para>
        /// <para>Will make sure that the field is not empty.</para>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isnameproper"></param>
        /// <exception cref="Exception"></exception>
        private void ValidateName(string name, ref bool isnameproper)
        {
            try
            {
                if (name == "")
                {
                    isnameproper = false;
                }
                else
                {
                    isnameproper = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        /// <summary>
        /// <para>Makes sure that age is entered properly.</para>
        /// </summary>
        /// <param name="age"></param>
        /// <param name="isageproper"></param>
        /// <exception cref="Exception"></exception>
        private void ValidateAge(ref int age, ref bool isageproper)
        {
            try
            {
                if (Int32.TryParse(AgeLabel.Text, out age) && age >= 3 && age <= 10)
                {
                    isageproper = true;
                }
                else
                {
                    isageproper = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Make sure a radio is selected.
        /// </summary>
        /// <param name="isradioselected"></param>
        /// <param name="SelectedGameType"></param>
        /// <exception cref="Exception"></exception>
        private void ValidateRadio(ref bool isradioselected, ref int SelectedGameType)
        {
            try
            {
                if (AddRadio.IsChecked == true)
                {
                    isradioselected = true;
                    SelectedGameType = 0;
                }
                else if (SubtractRadio.IsChecked == true)
                {
                    isradioselected = true;
                    SelectedGameType = 1;
                }
                else if (MultiplyRadio.IsChecked == true)
                {
                    isradioselected = true;
                    SelectedGameType = 2;
                }
                else if (DivideRadio.IsChecked == true)
                {
                    isradioselected = true;
                    SelectedGameType = 3;
                }
                else
                {
                    isradioselected = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "."+
                                    MethodInfo.GetCurrentMethod().Name+" -> "+ex.Message);
            }

        }
        /// <summary>
        /// <para>Starts the game</para>
        /// <para>Runs the all the validate input functions then starts game and creates new window.</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStartGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isnameproper = false;
                bool isradioselected = false;
                bool isageproper = false;
                string Name = NameLabel.Text;
                int Age = 0;
                int SelectedGameType = 0;
                ValidateName(Name, ref isnameproper);
                ValidateAge(ref Age, ref isageproper);
                ValidateRadio(ref isradioselected, ref SelectedGameType);
                ErrorLabel.Content = "";
                ErrorLabel.Visibility = Visibility.Hidden;
                if(isnameproper && isageproper && isradioselected)
                {
                    clsUser.Age = Age;
                    clsUser.Name = Name;
                    clsGame.SelectedGameType = (clsGame.GameType)SelectedGameType;

                    this.Hide();
                    wndGame wndMyGameWindow = new wndGame();
                    wndMyGameWindow.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (isageproper == false && isradioselected == false && isnameproper == false)
                    {
                        ErrorLabel.Content = "All values are invalid!";
                        ErrorLabel.Visibility = Visibility.Visible;
                    }
                    else if(isnameproper == false)
                    {
                        ErrorLabel.Content = "The name is empty or not proper!";
                        ErrorLabel.Visibility = Visibility.Visible;
                    }
                    else if (isradioselected == false)
                    {
                        ErrorLabel.Content = "A gamemode must be selected!";
                        ErrorLabel.Visibility = Visibility.Visible;
                    }
                    else if (isageproper == false)
                    {
                        ErrorLabel.Content = "The age must be between 3 and 10";
                        ErrorLabel.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ErrorLabel.Content = "One or more values are invalid";
                        ErrorLabel.Visibility = Visibility.Visible;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler error = new ErrorHandler();
                error.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}