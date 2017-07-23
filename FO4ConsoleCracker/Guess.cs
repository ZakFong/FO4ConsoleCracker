/*
    File: Guess.cs
    Version: 1.0
    NameSpace: Omi24.Project.Fallout4
    Description: Object to store user guess result.
    Author: 馮瑞祥 - Zak Fong
    Author's Website: http://www.zakfong.com
    Company's Website: http://www.omi24.com
    EMail: z@omi24.com
    Create Time: 20170723
    
    Updates
    20170723: 0.1 - Zak Fong
*/

namespace Omi24.Project.Fallout4
{
    /// <summary>
    /// Object to store user guess result.
    /// </summary>
    class Guess
    {
        #region Property
        /// <summary>
        /// Guess result.
        /// </summary>
        public int CorrectCount { get; set; }
        /// <summary>
        /// User guessed word.
        /// </summary>
        public string Word { get; set; }
        #endregion
    }
}
