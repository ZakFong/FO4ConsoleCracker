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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Omi24.Project.Fallout4
{
    /// <summary>
    /// Crack in-game console puzzle.
    /// </summary>
    public partial class CrackerForm : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public CrackerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Variable
        /// <summary>
        /// User guessed words list.
        /// </summary>
        private List<Guess> _guessList = new List<Guess>();
        /// <summary>
        /// Calculated results list.
        /// </summary>
        private List<string> _resultList = new List<string>();
        /// <summary>
        /// Console puzzle words list.
        /// </summary>
        private List<string> _wordList = new List<string>();
        #endregion

        #region Function
        #region CalculateResult: Calculate result and show it in txtResult.
        /// <summary>
        /// Calculate result and show it in txtResult.
        /// </summary>
        private void CalculateResult()
        {
            _resultList = _wordList.ToList();

            if (_guessList.Count == 0)
            {
                GenerateResult();
                return;
            }

            foreach (var word in _wordList)
            {
                foreach (var guess in _guessList)
                {
                    if (guess.Word.Length != word.Length)
                    {
                        continue;
                    }

                    var mappedCount = 0;

                    for (int index = 0; index < word.Length; index++)
                    {
                        if (word[index] == guess.Word[index])
                        {
                            mappedCount++;
                        }
                    }

                    if 
                    (
                        (guess.CorrectCount == 0 && mappedCount > 0)
                        || (guess.CorrectCount >= 1 && mappedCount == 0)
                        || (word == guess.Word && guess.CorrectCount != word.Length)
                    )
                    {
                        _resultList.Remove(word);
                    }
                }
            }

            GenerateResult();
        }
        #endregion

        #region GenerateResult: Generate result list and show it in txtResult.
        /// <summary>
        /// Generate result list and show it in txtResult.
        /// </summary>
        private void GenerateResult()
        {
            if (_resultList.Count == 0)
            {
                txtResult.Text = string.Empty;
                return;
            }

            var sb = new StringBuilder();

            foreach (var item in _resultList)
            {
                sb.AppendLine(item);
            }

            txtResult.Text = sb.ToString();
        }
        #endregion

        #region ImportGuessList: Import user guess result. (ex: FINAL 5)
        private void ImportGuessList()
        {
            _guessList.Clear();

            if (string.IsNullOrWhiteSpace(txtGuess.Text))
            {
                return;
            }
            else
            {
                foreach (var item in txtGuess.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }

                    var itemContentArray = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (itemContentArray == null || itemContentArray.Length == 0)
                    {
                        continue;
                    }

                    try
                    {
                        _guessList.Add(new Guess() { Word = itemContentArray[0], CorrectCount = int.Parse(itemContentArray[1]) });
                    }
                    catch 
                    {
                        continue;
                    }
                }
            }
        } 
        #endregion

        #region ImportWordList: Import user inputs into _wordList.
        /// <summary>
        /// Import user inputs into _wordList.
        /// </summary>
        private void ImportWordList()
        {
            _wordList.Clear(); 

            if (string.IsNullOrWhiteSpace(txtWord.Text))
            {
                return;
            }

            _wordList.AddRange(txtWord.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
        } 
        #endregion

        #region UpdateResult: Update final results.
        /// <summary>
        /// Update final results.
        /// </summary>
        private void UpdateResult()
        {
            #region Import lists.
            ImportWordList();
            ImportGuessList();
            #endregion

            CalculateResult();
        }
        #endregion

        #endregion

        #region Event
        #region OnTextChangedCalculateResult: On TextBox TextChanged event, calculate result.
        /// <summary>
        /// On TextBox TextChanged event, calculate result.
        /// </summary>
        /// <param name="sender">TextBox who changed text.</param>
        /// <param name="e">General TextBox event arguments.</param>
        private void OnTextChangedCalculateResult(object sender, EventArgs e)
        {
            UpdateResult();
        }
        #endregion 
        #endregion
    }
}