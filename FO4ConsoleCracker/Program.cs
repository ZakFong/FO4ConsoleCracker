/*
    File: CrackerForm.cs
    Version: 1.0
    NameSpace: Omi24.Project.Fallout4
    Description: Crack in-game console puzzle.
    Author: 馮瑞祥 - Zak Fong
    Author's Website: http://www.zakfong.com
    Company's Website: http://www.omi24.com
    EMail: z@omi24.com
    Create Time: 20170723
    
    Updates
    20170723: 0.1 - Zak Fong
*/

// Usings
using System;
using System.Windows.Forms;

namespace Omi24.Project.Fallout4
{
    /// <summary>
    /// Entry point.
    /// </summary>
    static class Program
    {
        #region Method
        #region Main: Entry point.
        /// <summary>
        /// Entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrackerForm());
        }
        #endregion 
        #endregion
    }
}
