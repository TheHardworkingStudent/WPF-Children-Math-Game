using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Class that contains the game logic.
    /// </summary>
    public class clsGame
    {
        /// <summary>
        /// Game Type is the enum that contains the Game Type
        /// </summary>
        public enum GameType { Addition = 0, Subtract = 1, Multiply = 2, Divide = 3 }
        /// <summary>
        /// Instance of game type that keeps track of the selected game.
        /// </summary>
        public static GameType SelectedGameType;
        /// <summary>
        /// Boolean that keeps track of if the game is on the last question.
        /// </summary>
        public static bool LastQuestion = false;
        /// <summary>
        /// Boolean that keeps track if the game is in progress/started.
        /// </summary>
        public static bool GameStarted = false;
        // public property eGameType
        // MathGameQuestion
        /// <summary>
        /// Generates the question for the game.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void GenerateQuestion()
        {
            try
            {
                if (GameStarted == true)
                {
                    //Use the eGameType enum to generate a question for the MathGameQuestion type and return it
                    Random random = new Random();
                    MathGameQuestion.LeftNumber = random.Next(1, 10);
                    MathGameQuestion.RightNumber = random.Next(1, 10);
                    if (SelectedGameType == GameType.Addition)
                    {
                        MathGameQuestion.AnswerNumber = MathGameQuestion.LeftNumber + MathGameQuestion.RightNumber;
                        MathGameQuestion.QuestionString = MathGameQuestion.LeftNumber.ToString() + " + " + MathGameQuestion.RightNumber.ToString() + " = ";
                    }
                    else if (SelectedGameType == GameType.Subtract)
                    {
                        while (MathGameQuestion.LeftNumber < MathGameQuestion.RightNumber)
                        {
                            MathGameQuestion.LeftNumber = random.Next(1, 10);
                            MathGameQuestion.RightNumber = random.Next(1, 10);
                        }
                        MathGameQuestion.AnswerNumber = MathGameQuestion.LeftNumber - MathGameQuestion.RightNumber;
                        MathGameQuestion.QuestionString = MathGameQuestion.LeftNumber.ToString() + " - " + MathGameQuestion.RightNumber.ToString() + " = ";
                    }
                    else if (SelectedGameType == GameType.Multiply)
                    {
                        MathGameQuestion.LeftNumber = random.Next(1, 6);
                        MathGameQuestion.RightNumber = random.Next(1, 6);
                        MathGameQuestion.AnswerNumber = MathGameQuestion.LeftNumber * MathGameQuestion.RightNumber;
                        MathGameQuestion.QuestionString = MathGameQuestion.LeftNumber.ToString() + " * " + MathGameQuestion.RightNumber.ToString() + " = ";
                    }
                    else if (SelectedGameType == GameType.Divide)
                    {
                        MathGameQuestion.RightNumber = random.Next(1, 10);
                        MathGameQuestion.AnswerNumber = random.Next(1, 10);
                        MathGameQuestion.LeftNumber = MathGameQuestion.RightNumber * MathGameQuestion.AnswerNumber;
                        MathGameQuestion.QuestionString = MathGameQuestion.LeftNumber.ToString() + " / " + MathGameQuestion.RightNumber.ToString() + " = ";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Validate the answer the user input.
        /// </summary>
        /// <param name="answer"></param>
        /// <exception cref="Exception"></exception>
        public static void ValidateAnswer(int answer)
        {
            try
            {
                if (GameStarted == true)
                {
                    clsUser.QuestionNumber++;
                    if (MathGameQuestion.AnswerNumber == answer)
                    {
                        clsUser.NumberCorrect++;
                        clsSounds.PlaySuccessSound();
                    }
                    else
                    {
                        clsUser.NumberIncorrect++;
                        clsSounds.PlayFailSound();
                    }
                    if (clsUser.QuestionNumber == 11)
                    {
                        LastQuestion = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Starts the game.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void Start_Game()
        {
            try
            {
                GameStarted = true;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Stops the game and resets the stats.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void Stop_Game()
        {
            try
            {
                if (GameStarted == true)
                {
                    clsUser.Name = "";
                    clsUser.Age = 0;
                    clsUser.NumberCorrect = 0;
                    clsUser.NumberIncorrect = 0;
                    clsUser.SecondsElapsed = 0;
                    clsUser.QuestionNumber = 1;
                    MathGameQuestion.LeftNumber = 0;
                    MathGameQuestion.RightNumber = 0;
                    MathGameQuestion.AnswerNumber = 0;
                    MathGameQuestion.QuestionString = "";
                    LastQuestion = false;
                    GameStarted = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
    }
    /// <summary>
    /// Class that contains the game question.
    /// </summary>
    public class MathGameQuestion
    {
        public static int LeftNumber;
        public static int RightNumber;
        public static int AnswerNumber;
        public static string QuestionString;
    }
}