using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Math_Game_Outline
{
    /// <summary>
    /// Class for sounds.
    /// </summary>
    public class clsSounds
    {
        /// <summary>
        /// Plays the successful sound for if the user gets it right.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void PlaySuccessSound()
        {
            try
            {
                Random random = new Random();
                SoundPlayer sound = new SoundPlayer("Sounds\\yay-roblox.wav");
                sound.Play();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Plays the unsuccessful sound for if the user gets it wrong.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void PlayFailSound()
        {
            try
            {
                Random random = new Random();
                SoundPlayer sound = new SoundPlayer("Sounds\\Roblox - Oof Death (Sound Effect).wav");
                sound.Play();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
