namespace DnDCharApp
{
    partial class CharacterAbilityScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterAbilityScores));
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRecall = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtSix = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtFive = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.lblNumberOfRolls = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.numD4 = new System.Windows.Forms.NumericUpDown();
            this.numD4Mods = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblModifiers = new System.Windows.Forms.Label();
            this.lblNumberOfDice = new System.Windows.Forms.Label();
            this.lblD4Result = new System.Windows.Forms.Label();
            this.btnD4Roll = new System.Windows.Forms.Button();
            this.btnD20Roll = new System.Windows.Forms.Button();
            this.lblD20Result = new System.Windows.Forms.Label();
            this.numD20Mods = new System.Windows.Forms.NumericUpDown();
            this.numD20 = new System.Windows.Forms.NumericUpDown();
            this.lblD20 = new System.Windows.Forms.Label();
            this.lblD6Result = new System.Windows.Forms.Label();
            this.lblD8Result = new System.Windows.Forms.Label();
            this.lblD10Result = new System.Windows.Forms.Label();
            this.lblD12Result = new System.Windows.Forms.Label();
            this.lblD100Result = new System.Windows.Forms.Label();
            this.btnD6Roll = new System.Windows.Forms.Button();
            this.numD6Mods = new System.Windows.Forms.NumericUpDown();
            this.numD6 = new System.Windows.Forms.NumericUpDown();
            this.lblD6 = new System.Windows.Forms.Label();
            this.btnD8Roll = new System.Windows.Forms.Button();
            this.numD8Mods = new System.Windows.Forms.NumericUpDown();
            this.numD8 = new System.Windows.Forms.NumericUpDown();
            this.lblD8 = new System.Windows.Forms.Label();
            this.btnD10Roll = new System.Windows.Forms.Button();
            this.numD10Mods = new System.Windows.Forms.NumericUpDown();
            this.numD10 = new System.Windows.Forms.NumericUpDown();
            this.lblD10 = new System.Windows.Forms.Label();
            this.btnD100Roll = new System.Windows.Forms.Button();
            this.numD100Mods = new System.Windows.Forms.NumericUpDown();
            this.numD100 = new System.Windows.Forms.NumericUpDown();
            this.lblD100 = new System.Windows.Forms.Label();
            this.btnD12Roll = new System.Windows.Forms.Button();
            this.numD12Mods = new System.Windows.Forms.NumericUpDown();
            this.numD12 = new System.Windows.Forms.NumericUpDown();
            this.lblD12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD4Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD20Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD6Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD8Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD10Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD100Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD12Mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(185, 201);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Stats";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnStore
            // 
            this.btnStore.Enabled = false;
            this.btnStore.Location = new System.Drawing.Point(104, 201);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.Enabled = false;
            this.btnRecall.Location = new System.Drawing.Point(23, 201);
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.Size = new System.Drawing.Size(75, 23);
            this.btnRecall.TabIndex = 2;
            this.btnRecall.Text = "Recall";
            this.btnRecall.UseVisualStyleBackColor = true;
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // txtOne
            // 
            this.txtOne.BackColor = System.Drawing.SystemColors.Control;
            this.txtOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOne.Enabled = false;
            this.txtOne.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOne.Location = new System.Drawing.Point(100, 48);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(34, 26);
            this.txtOne.TabIndex = 13;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTwo
            // 
            this.txtTwo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTwo.Enabled = false;
            this.txtTwo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwo.Location = new System.Drawing.Point(100, 80);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(34, 26);
            this.txtTwo.TabIndex = 14;
            this.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSix
            // 
            this.txtSix.BackColor = System.Drawing.SystemColors.Control;
            this.txtSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSix.Enabled = false;
            this.txtSix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSix.Location = new System.Drawing.Point(152, 114);
            this.txtSix.Name = "txtSix";
            this.txtSix.Size = new System.Drawing.Size(34, 26);
            this.txtSix.TabIndex = 16;
            this.txtSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThree
            // 
            this.txtThree.BackColor = System.Drawing.SystemColors.Control;
            this.txtThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThree.Enabled = false;
            this.txtThree.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThree.Location = new System.Drawing.Point(100, 114);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(34, 26);
            this.txtThree.TabIndex = 15;
            this.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFive
            // 
            this.txtFive.BackColor = System.Drawing.SystemColors.Control;
            this.txtFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFive.Enabled = false;
            this.txtFive.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFive.Location = new System.Drawing.Point(152, 80);
            this.txtFive.Name = "txtFive";
            this.txtFive.Size = new System.Drawing.Size(34, 26);
            this.txtFive.TabIndex = 18;
            this.txtFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFour
            // 
            this.txtFour.BackColor = System.Drawing.SystemColors.Control;
            this.txtFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFour.Enabled = false;
            this.txtFour.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFour.Location = new System.Drawing.Point(152, 48);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(34, 26);
            this.txtFour.TabIndex = 17;
            this.txtFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberOfRolls
            // 
            this.lblNumberOfRolls.AutoSize = true;
            this.lblNumberOfRolls.Location = new System.Drawing.Point(100, 160);
            this.lblNumberOfRolls.Name = "lblNumberOfRolls";
            this.lblNumberOfRolls.Size = new System.Drawing.Size(94, 13);
            this.lblNumberOfRolls.TabIndex = 19;
            this.lblNumberOfRolls.Text = "Number of Rolls: 5";
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Location = new System.Drawing.Point(377, 48);
            this.lblD4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(19, 13);
            this.lblD4.TabIndex = 20;
            this.lblD4.Text = "d4";
            // 
            // numD4
            // 
            this.numD4.Location = new System.Drawing.Point(338, 46);
            this.numD4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD4.Name = "numD4";
            this.numD4.Size = new System.Drawing.Size(39, 20);
            this.numD4.TabIndex = 21;
            // 
            // numD4Mods
            // 
            this.numD4Mods.Location = new System.Drawing.Point(414, 46);
            this.numD4Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD4Mods.Name = "numD4Mods";
            this.numD4Mods.Size = new System.Drawing.Size(47, 20);
            this.numD4Mods.TabIndex = 22;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(507, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 23;
            this.lblResult.Text = "Result";
            // 
            // lblModifiers
            // 
            this.lblModifiers.AutoSize = true;
            this.lblModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiers.Location = new System.Drawing.Point(411, 30);
            this.lblModifiers.Name = "lblModifiers";
            this.lblModifiers.Size = new System.Drawing.Size(58, 13);
            this.lblModifiers.TabIndex = 24;
            this.lblModifiers.Text = "Mods +/-";
            // 
            // lblNumberOfDice
            // 
            this.lblNumberOfDice.AutoSize = true;
            this.lblNumberOfDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDice.Location = new System.Drawing.Point(335, 30);
            this.lblNumberOfDice.Name = "lblNumberOfDice";
            this.lblNumberOfDice.Size = new System.Drawing.Size(72, 13);
            this.lblNumberOfDice.TabIndex = 25;
            this.lblNumberOfDice.Text = "No. of Dice";
            // 
            // lblD4Result
            // 
            this.lblD4Result.AutoSize = true;
            this.lblD4Result.Location = new System.Drawing.Point(509, 50);
            this.lblD4Result.Name = "lblD4Result";
            this.lblD4Result.Size = new System.Drawing.Size(61, 13);
            this.lblD4Result.TabIndex = 26;
            this.lblD4Result.Text = "lblD4Result";
            // 
            // btnD4Roll
            // 
            this.btnD4Roll.Location = new System.Drawing.Point(467, 46);
            this.btnD4Roll.Name = "btnD4Roll";
            this.btnD4Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD4Roll.TabIndex = 27;
            this.btnD4Roll.Text = "Roll";
            this.btnD4Roll.UseVisualStyleBackColor = true;
            this.btnD4Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // btnD20Roll
            // 
            this.btnD20Roll.Location = new System.Drawing.Point(467, 202);
            this.btnD20Roll.Name = "btnD20Roll";
            this.btnD20Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD20Roll.TabIndex = 32;
            this.btnD20Roll.Text = "Roll";
            this.btnD20Roll.UseVisualStyleBackColor = true;
            this.btnD20Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // lblD20Result
            // 
            this.lblD20Result.AutoSize = true;
            this.lblD20Result.Location = new System.Drawing.Point(509, 204);
            this.lblD20Result.Name = "lblD20Result";
            this.lblD20Result.Size = new System.Drawing.Size(67, 13);
            this.lblD20Result.TabIndex = 31;
            this.lblD20Result.Text = "lblD20Result";
            // 
            // numD20Mods
            // 
            this.numD20Mods.Location = new System.Drawing.Point(414, 202);
            this.numD20Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD20Mods.Name = "numD20Mods";
            this.numD20Mods.Size = new System.Drawing.Size(47, 20);
            this.numD20Mods.TabIndex = 30;
            // 
            // numD20
            // 
            this.numD20.Location = new System.Drawing.Point(338, 202);
            this.numD20.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD20.Name = "numD20";
            this.numD20.Size = new System.Drawing.Size(39, 20);
            this.numD20.TabIndex = 29;
            // 
            // lblD20
            // 
            this.lblD20.AutoSize = true;
            this.lblD20.Location = new System.Drawing.Point(377, 204);
            this.lblD20.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD20.Name = "lblD20";
            this.lblD20.Size = new System.Drawing.Size(25, 13);
            this.lblD20.TabIndex = 28;
            this.lblD20.Text = "d20";
            // 
            // lblD6Result
            // 
            this.lblD6Result.AutoSize = true;
            this.lblD6Result.Location = new System.Drawing.Point(509, 76);
            this.lblD6Result.Name = "lblD6Result";
            this.lblD6Result.Size = new System.Drawing.Size(61, 13);
            this.lblD6Result.TabIndex = 33;
            this.lblD6Result.Text = "lblD6Result";
            // 
            // lblD8Result
            // 
            this.lblD8Result.AutoSize = true;
            this.lblD8Result.Location = new System.Drawing.Point(509, 102);
            this.lblD8Result.Name = "lblD8Result";
            this.lblD8Result.Size = new System.Drawing.Size(61, 13);
            this.lblD8Result.TabIndex = 34;
            this.lblD8Result.Text = "lblD8Result";
            // 
            // lblD10Result
            // 
            this.lblD10Result.AutoSize = true;
            this.lblD10Result.Location = new System.Drawing.Point(509, 128);
            this.lblD10Result.Name = "lblD10Result";
            this.lblD10Result.Size = new System.Drawing.Size(67, 13);
            this.lblD10Result.TabIndex = 35;
            this.lblD10Result.Text = "lblD10Result";
            // 
            // lblD12Result
            // 
            this.lblD12Result.AutoSize = true;
            this.lblD12Result.Location = new System.Drawing.Point(509, 180);
            this.lblD12Result.Name = "lblD12Result";
            this.lblD12Result.Size = new System.Drawing.Size(67, 13);
            this.lblD12Result.TabIndex = 36;
            this.lblD12Result.Text = "lblD12Result";
            // 
            // lblD100Result
            // 
            this.lblD100Result.AutoSize = true;
            this.lblD100Result.Location = new System.Drawing.Point(509, 154);
            this.lblD100Result.Name = "lblD100Result";
            this.lblD100Result.Size = new System.Drawing.Size(73, 13);
            this.lblD100Result.TabIndex = 37;
            this.lblD100Result.Text = "lblD100Result";
            // 
            // btnD6Roll
            // 
            this.btnD6Roll.Location = new System.Drawing.Point(467, 72);
            this.btnD6Roll.Name = "btnD6Roll";
            this.btnD6Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD6Roll.TabIndex = 41;
            this.btnD6Roll.Text = "Roll";
            this.btnD6Roll.UseVisualStyleBackColor = true;
            this.btnD6Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // numD6Mods
            // 
            this.numD6Mods.Location = new System.Drawing.Point(414, 72);
            this.numD6Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD6Mods.Name = "numD6Mods";
            this.numD6Mods.Size = new System.Drawing.Size(47, 20);
            this.numD6Mods.TabIndex = 40;
            // 
            // numD6
            // 
            this.numD6.Location = new System.Drawing.Point(338, 72);
            this.numD6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD6.Name = "numD6";
            this.numD6.Size = new System.Drawing.Size(39, 20);
            this.numD6.TabIndex = 39;
            // 
            // lblD6
            // 
            this.lblD6.AutoSize = true;
            this.lblD6.Location = new System.Drawing.Point(377, 74);
            this.lblD6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(19, 13);
            this.lblD6.TabIndex = 38;
            this.lblD6.Text = "d6";
            // 
            // btnD8Roll
            // 
            this.btnD8Roll.Location = new System.Drawing.Point(467, 98);
            this.btnD8Roll.Name = "btnD8Roll";
            this.btnD8Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD8Roll.TabIndex = 45;
            this.btnD8Roll.Text = "Roll";
            this.btnD8Roll.UseVisualStyleBackColor = true;
            this.btnD8Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // numD8Mods
            // 
            this.numD8Mods.Location = new System.Drawing.Point(414, 98);
            this.numD8Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD8Mods.Name = "numD8Mods";
            this.numD8Mods.Size = new System.Drawing.Size(47, 20);
            this.numD8Mods.TabIndex = 44;
            // 
            // numD8
            // 
            this.numD8.Location = new System.Drawing.Point(338, 98);
            this.numD8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD8.Name = "numD8";
            this.numD8.Size = new System.Drawing.Size(39, 20);
            this.numD8.TabIndex = 43;
            // 
            // lblD8
            // 
            this.lblD8.AutoSize = true;
            this.lblD8.Location = new System.Drawing.Point(377, 100);
            this.lblD8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD8.Name = "lblD8";
            this.lblD8.Size = new System.Drawing.Size(19, 13);
            this.lblD8.TabIndex = 42;
            this.lblD8.Text = "d8";
            // 
            // btnD10Roll
            // 
            this.btnD10Roll.Location = new System.Drawing.Point(467, 124);
            this.btnD10Roll.Name = "btnD10Roll";
            this.btnD10Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD10Roll.TabIndex = 49;
            this.btnD10Roll.Text = "Roll";
            this.btnD10Roll.UseVisualStyleBackColor = true;
            this.btnD10Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // numD10Mods
            // 
            this.numD10Mods.Location = new System.Drawing.Point(414, 124);
            this.numD10Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD10Mods.Name = "numD10Mods";
            this.numD10Mods.Size = new System.Drawing.Size(47, 20);
            this.numD10Mods.TabIndex = 48;
            // 
            // numD10
            // 
            this.numD10.Location = new System.Drawing.Point(338, 124);
            this.numD10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD10.Name = "numD10";
            this.numD10.Size = new System.Drawing.Size(39, 20);
            this.numD10.TabIndex = 47;
            // 
            // lblD10
            // 
            this.lblD10.AutoSize = true;
            this.lblD10.Location = new System.Drawing.Point(377, 126);
            this.lblD10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD10.Name = "lblD10";
            this.lblD10.Size = new System.Drawing.Size(25, 13);
            this.lblD10.TabIndex = 46;
            this.lblD10.Text = "d10";
            // 
            // btnD100Roll
            // 
            this.btnD100Roll.Location = new System.Drawing.Point(467, 150);
            this.btnD100Roll.Name = "btnD100Roll";
            this.btnD100Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD100Roll.TabIndex = 53;
            this.btnD100Roll.Text = "Roll";
            this.btnD100Roll.UseVisualStyleBackColor = true;
            this.btnD100Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // numD100Mods
            // 
            this.numD100Mods.Location = new System.Drawing.Point(414, 150);
            this.numD100Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD100Mods.Name = "numD100Mods";
            this.numD100Mods.Size = new System.Drawing.Size(47, 20);
            this.numD100Mods.TabIndex = 52;
            // 
            // numD100
            // 
            this.numD100.Location = new System.Drawing.Point(338, 150);
            this.numD100.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD100.Name = "numD100";
            this.numD100.Size = new System.Drawing.Size(39, 20);
            this.numD100.TabIndex = 51;
            // 
            // lblD100
            // 
            this.lblD100.AutoSize = true;
            this.lblD100.Location = new System.Drawing.Point(377, 152);
            this.lblD100.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD100.Name = "lblD100";
            this.lblD100.Size = new System.Drawing.Size(31, 13);
            this.lblD100.TabIndex = 50;
            this.lblD100.Text = "d100";
            // 
            // btnD12Roll
            // 
            this.btnD12Roll.Location = new System.Drawing.Point(467, 176);
            this.btnD12Roll.Name = "btnD12Roll";
            this.btnD12Roll.Size = new System.Drawing.Size(36, 20);
            this.btnD12Roll.TabIndex = 57;
            this.btnD12Roll.Text = "Roll";
            this.btnD12Roll.UseVisualStyleBackColor = true;
            this.btnD12Roll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // numD12Mods
            // 
            this.numD12Mods.Location = new System.Drawing.Point(414, 176);
            this.numD12Mods.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numD12Mods.Name = "numD12Mods";
            this.numD12Mods.Size = new System.Drawing.Size(47, 20);
            this.numD12Mods.TabIndex = 56;
            // 
            // numD12
            // 
            this.numD12.Location = new System.Drawing.Point(338, 176);
            this.numD12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.numD12.Name = "numD12";
            this.numD12.Size = new System.Drawing.Size(39, 20);
            this.numD12.TabIndex = 55;
            // 
            // lblD12
            // 
            this.lblD12.AutoSize = true;
            this.lblD12.Location = new System.Drawing.Point(377, 178);
            this.lblD12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblD12.Name = "lblD12";
            this.lblD12.Size = new System.Drawing.Size(25, 13);
            this.lblD12.TabIndex = 54;
            this.lblD12.Text = "d12";
            // 
            // CharacterAbilityScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.btnD12Roll);
            this.Controls.Add(this.numD12Mods);
            this.Controls.Add(this.numD12);
            this.Controls.Add(this.lblD12);
            this.Controls.Add(this.btnD100Roll);
            this.Controls.Add(this.numD100Mods);
            this.Controls.Add(this.numD100);
            this.Controls.Add(this.lblD100);
            this.Controls.Add(this.btnD10Roll);
            this.Controls.Add(this.numD10Mods);
            this.Controls.Add(this.numD10);
            this.Controls.Add(this.lblD10);
            this.Controls.Add(this.btnD8Roll);
            this.Controls.Add(this.numD8Mods);
            this.Controls.Add(this.numD8);
            this.Controls.Add(this.lblD8);
            this.Controls.Add(this.btnD6Roll);
            this.Controls.Add(this.numD6Mods);
            this.Controls.Add(this.numD6);
            this.Controls.Add(this.lblD6);
            this.Controls.Add(this.lblD100Result);
            this.Controls.Add(this.lblD12Result);
            this.Controls.Add(this.lblD10Result);
            this.Controls.Add(this.lblD8Result);
            this.Controls.Add(this.lblD6Result);
            this.Controls.Add(this.btnD20Roll);
            this.Controls.Add(this.lblD20Result);
            this.Controls.Add(this.numD20Mods);
            this.Controls.Add(this.numD20);
            this.Controls.Add(this.lblD20);
            this.Controls.Add(this.btnD4Roll);
            this.Controls.Add(this.lblD4Result);
            this.Controls.Add(this.lblNumberOfDice);
            this.Controls.Add(this.lblModifiers);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numD4Mods);
            this.Controls.Add(this.numD4);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.lblNumberOfRolls);
            this.Controls.Add(this.txtFive);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtSix);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnRecall);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnRoll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterAbilityScores";
            this.Text = "Character Ability Scores";
            ((System.ComponentModel.ISupportInitialize)(this.numD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD4Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD20Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD6Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD8Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD10Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD100Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD12Mods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnRecall;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtSix;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtFive;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.Label lblNumberOfRolls;
        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.NumericUpDown numD4;
        private System.Windows.Forms.NumericUpDown numD4Mods;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblModifiers;
        private System.Windows.Forms.Label lblNumberOfDice;
        private System.Windows.Forms.Label lblD4Result;
        private System.Windows.Forms.Button btnD4Roll;
        private System.Windows.Forms.Button btnD20Roll;
        private System.Windows.Forms.Label lblD20Result;
        private System.Windows.Forms.NumericUpDown numD20Mods;
        private System.Windows.Forms.NumericUpDown numD20;
        private System.Windows.Forms.Label lblD20;
        private System.Windows.Forms.Label lblD6Result;
        private System.Windows.Forms.Label lblD8Result;
        private System.Windows.Forms.Label lblD10Result;
        private System.Windows.Forms.Label lblD12Result;
        private System.Windows.Forms.Label lblD100Result;
        private System.Windows.Forms.Button btnD6Roll;
        private System.Windows.Forms.NumericUpDown numD6Mods;
        private System.Windows.Forms.NumericUpDown numD6;
        private System.Windows.Forms.Label lblD6;
        private System.Windows.Forms.Button btnD8Roll;
        private System.Windows.Forms.NumericUpDown numD8Mods;
        private System.Windows.Forms.NumericUpDown numD8;
        private System.Windows.Forms.Label lblD8;
        private System.Windows.Forms.Button btnD10Roll;
        private System.Windows.Forms.NumericUpDown numD10Mods;
        private System.Windows.Forms.NumericUpDown numD10;
        private System.Windows.Forms.Label lblD10;
        private System.Windows.Forms.Button btnD100Roll;
        private System.Windows.Forms.NumericUpDown numD100Mods;
        private System.Windows.Forms.NumericUpDown numD100;
        private System.Windows.Forms.Label lblD100;
        private System.Windows.Forms.Button btnD12Roll;
        private System.Windows.Forms.NumericUpDown numD12Mods;
        private System.Windows.Forms.NumericUpDown numD12;
        private System.Windows.Forms.Label lblD12;
    }
}