using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Class that contains the user information.
    /// </summary>
    public class clsUser
    {
        /// <summary>
        /// Static name
        /// </summary>
        public static string Name;
        /// <summary>
        /// Static age.
        /// </summary>
        public static int Age;
        /// <summary>
        /// Keeps track of the number of correct answers.
        /// </summary>
        public static int NumberCorrect = 0;
        /// <summary>
        /// Keeps track of the number of incorrect answers.
        /// </summary>
        public static int NumberIncorrect = 0;
        /// <summary>
        /// Keeps track of the number of seconds the game has been going.
        /// </summary>
        public static int SecondsElapsed = 0;
        /// <summary>
        /// Keeps track of the question the user is on.
        /// </summary>
        public static int QuestionNumber = 1;
    }
}
