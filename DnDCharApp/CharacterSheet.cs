using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mime;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLogic;

namespace DnDCharApp
{
    public partial class CharacterSheet : Form
    {
        private List<int> _strCon = new List<int>();
        private List<int> _dexInt = new List<int>();
        private List<int> _wisCha = new List<int>();
        private readonly Repository _repo = new Repository();
        private int _totalExperience;
        private readonly List<int> _experienceList = new List<int> { 0, 1000, 2250, 3750, 5500, 7500, 10000, 13000, 16500, 20500, 26000, 32000, 39000, 47000, 57000, 69000, 83000, 
                                                            99000, 119000, 143000, 175000, 210000, 255000, 310000, 375000, 450000, 550000, 675000, 825000, 1000000 };

        public CharacterSheet()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            ddlRaces.Items.AddRange(_repo.Races());
            ddlClasses.Items.AddRange(_repo.Classes());

            List<Label> labelList = new List<Label> { lblRaceSize, lblSensesRace };

            foreach (var label in labelList)
                label.Text = string.Empty;
        }

        private void txtExperience_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int experience = Convert.ToInt32(txtExperience.Text);
                    _totalExperience += experience;
                    int level = _experienceList.FindLastIndex(item => item <= _totalExperience) + 1;
                    
                    txtLevel.Text = level.ToString();
                    txtExperience.Text = _totalExperience.ToString();
                }
                catch (FormatException)
                {
                }
            }
        }

        private void txtExperience_Enter(object sender, EventArgs e)
        {
            //if (txtExperience.Text == @"Enter XP Here")
                txtExperience.Text = string.Empty;
        }

        private void txtExperience_Leave(object sender, EventArgs e)
        {
            txtExperience.Text = _totalExperience.ToString();
        }

        private void txtAbilityScore_keydown(object sender, KeyEventArgs e)
        {
            TextBox ability = sender as TextBox;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (ability != null)
                        switch (ability.Name)
                        {
                            case "txtStr":
                                CalculateAbilityScores(ability, txtStrAbilityMod);
                                CalculateAbilityModifiers();
                                SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            case "txtCon":
                                CalculateAbilityScores(ability, txtConAbilityMod);
                                CalculateAbilityModifiers();
                                SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            case "txtDex":
                                CalculateAbilityScores(ability, txtDexAbilityMod);
                                CalculateAbilityModifiers();
                                txtInitiativeDex.Text = txtDexAbilityMod.Text;
                                SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            case "txtInt":
                                CalculateAbilityScores(ability, txtIntAbilityMod);
                                CalculateAbilityModifiers();
                                SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            case "txtWis":
                                CalculateAbilityScores(ability, txtWisAbilityMod);
                                CalculateAbilityModifiers();
                                SelectNextControl(ActiveControl, true, true, true, true);
                                break;
                            case "txtCha":
                                CalculateAbilityScores(ability, txtChaAbilityMod);
                                CalculateAbilityModifiers();
                                break;
                        }
                }
            }
            catch (FormatException)
            {
            }
            
        }

        private void CalculateAbilityScores(TextBox ability, TextBox score)
        {
            Dictionary<int, string> abilityScores = new Dictionary<int, string>
            {
                {1, "-5"},
                {2, "-4"},{3, "-4"},
                {4, "-3"},{5, "-3"},
                {6, "-2"},{7, "-2"},
                {8, "-1"},{9, "-1"},
                {10, "0"},{11, "0"},
                {12, "+1"},{13, "+1"},
                {14, "+2"},{15, "+2"},
                {16, "+3"},{17, "+3"},
                {18, "+4"},{19, "+4"},
                {20, "+5"},{21, "+5"},
                {22, "+6"},{23, "+6"},
                {24, "+7"},{25, "+7"},
                {26, "+8"},{27, "+8"}
            };

            string value;
            switch (abilityScores.TryGetValue(Convert.ToInt32(ability.Text), out value))
            {
                case true:
                    score.Text = value;
                    break;
                case false:
                    score.Text = string.Empty;
                    break;
            }
        }

        private void txtLevel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CalculateAbilityModifiers()
        {
            List<TextBox> abilityMods = new List<TextBox> { txtStrModLevel, txtConModLevel, txtDexModLevel, txtIntModLevel, txtWisModLevel, txtChaModLevel };
            List<TextBox> abilities = new List<TextBox> { txtStrAbilityMod, txtConAbilityMod, txtDexAbilityMod, txtIntAbilityMod, txtWisAbilityMod, txtChaAbilityMod };
            double modifier = Math.Round((double)(Convert.ToInt32(txtLevel.Text) / 2));

            for (int i = 0; i < abilityMods.Count; i++)
            {
                if (abilities[i].Text != string.Empty)
                {
                    if (modifier + Convert.ToInt32(abilities[i].Text) >= 0)
                        abilityMods[i].Text = @"+" + (modifier + Convert.ToInt32(abilities[i].Text));
                    else
                        abilityMods[i].Text = (modifier + Convert.ToInt32(abilities[i].Text)).ToString();
                }
                else
                {
                    if (modifier >= 0)
                        abilityMods[i].Text = @"+" + modifier;
                    else
                        abilityMods[i].Text = @"-" + modifier;
                }
            }
        }

        private void CalculateInitiative()
        {
            double mod = Math.Round((double)(Convert.ToInt32(txtLevel.Text) / 2));

            if (mod >= 0)
                txtInitiativeLevel.Text = "+" + mod;
            else
                txtInitiativeLevel.Text = "-" + mod;
        }

        private void CalculateDefenseScores()
        {
            List<TextBox> defenseScores = new List<TextBox>{ txtDefAcLvl, txtDefFortLvl, txtDefRefLvl, txtDefWillLvl };

            double halfLvl = Math.Round((double)(Convert.ToInt32(txtLevel.Text) / 2));

            foreach (var textBox in defenseScores)
                textBox.Text = (10 + halfLvl).ToString();
        }
        
        private void txtInitiative_TextChanged(object sender, EventArgs e)
        {
            TextBox[] initiative = { txtInitiativeDex, txtInitiativeLevel };

            CalculateTotalScore(lblInitiativeScoreResult, initiative);
        }

        private void lblAcScore_Paint(object sender, PaintEventArgs e)
        {
            using (Pen myPen = new Pen(Color.Black, 3))
            {
                Rectangle myRectangle = new Rectangle(2, 2, lblAcScore.Width - 4, lblAcScore.Height - 4);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.DrawEllipse(myPen, myRectangle);
            }
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateAbilityModifiers();
                CalculateInitiative();
                CalculateDefenseScores();
            }
            catch (FormatException)
            {
            }
        }

        private void lblTriangle_paint(object sender, PaintEventArgs e)
        {
            const FillMode fillMode = FillMode.Winding;

            using (SolidBrush brush = new SolidBrush(Color.DarkGray))
            {
                Point pt1 = new Point(0, 0);
                Point pt2 = new Point(0, lblStrConTriangle.Height);
                Point pt3 = new Point(lblStrConTriangle.Width, 0);

                Point[] trianglePoints = { pt1, pt2, pt3 };

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.FillPolygon(brush, trianglePoints, fillMode);
            }
        }

        private void txtStrConMod_TextChanged(object sender, EventArgs e)
        {
            CalculateDefenseAbil(sender, _strCon, txtDefFortAbil);
        }

        private void txtDexIntMod_TextChanged(object sender, EventArgs e)
        {
            CalculateDefenseAbil(sender, _dexInt, txtDefRefAbil, txtDefAcArmor);
        }
        
        private void txtWisChaMod_TextChanged(object sender, EventArgs e)
        {
            CalculateDefenseAbil(sender, _wisCha, txtDefWillAbil);
        }

        private void CalculateDefenseAbil(object sender, List<int> score, params TextBox[] output)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox != null)
            {
                score.Add(Convert.ToInt32(txtBox.Text));

                foreach (var txt in output)
                    txt.Text = score.Max().ToString();
            }
        }

        private void txtAcDefense_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxs = { txtDefAcLvl, txtDefAcArmor, txtDefAcClass, txtDefAcFeat, txtDefAcEnh, txtDefAcMiscOne, txtDefAcMiscTwo };

            CalculateTotalScore(lblAcScore, txtBoxs);
        }

        private void txtFortDefense_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxs = { txtDefFortLvl, txtDefFortAbil, txtDefFortClass, txtDefFortFeat, txtDefFortEnh, txtDefFortMiscOne, txtDefFortMiscTwo };

            CalculateTotalScore(lblFortScore, txtBoxs);
        }

        private void txtRefDefense_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxs = { txtDefRefLvl, txtDefRefAbil, txtDefRefClass, txtDefRefFeat, txtDefRefEnh, txtDefRefMiscOne, txtDefRefMiscTwo };

            CalculateTotalScore(lblRefScore, txtBoxs);
        }

        private void txtWillDefense_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxs = { txtDefWillLvl, txtDefWillAbil, txtDefWillClass, txtDefWillFeat, txtDefWillEnh, txtDefWillMiscOne, txtDefWillMiscTwo };

            CalculateTotalScore(lblWillScore, txtBoxs);
        }

        private void txtMovement_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxs = { txtMovementBase, txtMovementArmor, txtMovementItem, txtMovementMisc };

            CalculateTotalScore(lblMovementScoreResult, txtBoxs);
        }

        private void CalculateTotalScore(Label output, params TextBox[] input)
        {
            int score = 0;
            int sum = 0;

            foreach (var txt in input)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    score = 0;
                    sum += score;
                }
                else
                {
                    score = Convert.ToInt32(txt.Text);
                    sum += score;
                }
            }

            output.Text = sum.ToString();
        }

        private void txtAbilityScores_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;

            if (!string.IsNullOrWhiteSpace(txtbox.Text))
                txtbox.BackColor = DefaultBackColor;
            else
                txtbox.BackColor = Color.Yellow;
        }

        private void ddlRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            BE_Race selectedRace = (BE_Race) ddlRaces.SelectedItem;
            
            txtMovementBase.Text = selectedRace.Speed.ToString();
            txtDefAcMiscOne.Text = selectedRace.Ac.ToString();
            txtDefFortMiscOne.Text = selectedRace.Fort.ToString();
            txtDefRefMiscOne.Text = selectedRace.Reflex.ToString();
            txtDefWillMiscOne.Text = selectedRace.Will.ToString();
            lblRaceSize.Text = selectedRace.Size;
            lblSensesRace.Text = selectedRace.Senses;
        }

        private void ddlClasses_SelectedValueChanged(object sender, EventArgs e)
        {
            BE_Class selectedClass = (BE_Class)ddlClasses.SelectedItem;

            txtDefAcClass.Text = selectedClass.Ac.ToString();
            txtDefFortClass.Text = selectedClass.Fort.ToString();
            txtDefRefClass.Text = selectedClass.Reflex.ToString();
            txtDefWillClass.Text = selectedClass.Will.ToString();
        }

        private void lblRaceSize_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            using (Pen myPen = new Pen(Color.Black, 2))
            {
                if (lbl != null)
                {
                    Point pt1 = new Point(0, 0);
                    Point pt2 = new Point(lbl.Width, 0);

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    e.Graphics.DrawLine(myPen, pt1, pt2);
                }
            }
        }
    }
}
