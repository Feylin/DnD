using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;

namespace DnDCharApp
{
    public partial class CharacterAbilityScores : Form
    {
        private readonly Repository _repo = new Repository();
        private readonly List<TextBox> _textBoxs;
        private readonly List<int> _stats = new List<int>();
        private int _numberOfRolls = 5;

        public CharacterAbilityScores()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _textBoxs = new List<TextBox> { txtOne, txtTwo, txtThree, txtFour, txtFive, txtSix };
            List<Label> labels = new List<Label> { lblD4Result, lblD6Result, lblD8Result, lblD10Result, lblD100Result, lblD12Result, lblD20Result };

            foreach (var label in labels)
                label.Text = string.Empty;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            foreach (var textbox in _textBoxs)
            {
                List<int> rolls = new List<int>();

                for (int i = 0; i < 4; i++)
                    rolls.Add(_repo.Random(1, 7));

                rolls.Remove(rolls.Min());

                textbox.Text = rolls.Sum().ToString();
            }

            _numberOfRolls--;

            lblNumberOfRolls.Text = @"Number of Rolls: " + _numberOfRolls;

            if (_numberOfRolls == 0)
                btnRoll.Enabled = false;

            btnStore.Enabled = true;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            _stats.Clear();

            foreach (var textbox in _textBoxs)
                _stats.Add(Convert.ToInt32(textbox.Text));

            btnRecall.Enabled = true;
        }

        private void btnRecall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _stats.Count; i++)
                _textBoxs[i].Text = _stats[i].ToString();
        }

        private void DiceRoll(int min, int max, NumericUpDown dice, NumericUpDown mods, Label resultLabel)
        {
            decimal result = 0;
            int diceRoll = 0;
            decimal minimumResult = dice.Value * 1;

            for (int i = 0; i < dice.Value; i++)
                diceRoll += _repo.Random(min, max + 1);

            result += diceRoll;
            result += mods.Value;

            if (result < minimumResult)
                resultLabel.Text = diceRoll + " + " + mods.Value + " = " + minimumResult;
            else
                resultLabel.Text = diceRoll + " + " + mods.Value + " = " + result;
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
                switch (btn.Name)
                {
                    case "btnD4Roll":
                        DiceRoll(1, 4, numD4, numD4Mods, lblD4Result);
                        break;
                    case "btnD6Roll":
                        DiceRoll(1, 6, numD6, numD6Mods, lblD6Result);
                        break;
                    case "btnD8Roll":
                        DiceRoll(1, 8, numD8, numD8Mods, lblD8Result);
                        break;
                    case "btnD10Roll":
                        DiceRoll(1, 10, numD10, numD10Mods, lblD10Result);
                        break;
                    case "btnD100Roll":
                        DiceRoll(1, 100, numD100, numD100Mods, lblD100Result);
                        break;
                    case "btnD12Roll":
                        DiceRoll(1, 12, numD12, numD12Mods, lblD12Result);
                        break;
                    case "btnD20Roll":
                        DiceRoll(1, 20, numD20, numD20Mods, lblD20Result);
                        break;
                }
        }
    }
}
