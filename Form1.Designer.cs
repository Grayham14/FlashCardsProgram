namespace FlashCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            flipCard = new Button();
            deckSelect = new ComboBox();
            textBox1 = new TextBox();
            button4 = new Button();
            InputFront = new TextBox();
            InputBack = new TextBox();
            DeleteButton = new Button();
            button5 = new Button();
            deleteCardIndex = new TextBox();
            currentIndexBox = new TextBox();
            textBox4 = new TextBox();
            LogBox = new TextBox();
            debugsetup = new Button();
            checkedListBox1 = new CheckedListBox();
            name = new TextBox();
            SaveDeck = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Location = new Point(3, 442);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "<Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Location = new Point(121, 442);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Next>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flipCard
            // 
            flipCard.BackColor = Color.Fuchsia;
            flipCard.Location = new Point(58, 402);
            flipCard.Name = "flipCard";
            flipCard.Size = new Size(112, 34);
            flipCard.TabIndex = 2;
            flipCard.Text = "v Flip ^";
            flipCard.UseVisualStyleBackColor = false;
            flipCard.Click += button3_Click;
            // 
            // deckSelect
            // 
            deckSelect.BackColor = Color.FromArgb(255, 128, 0);
            deckSelect.FormattingEnabled = true;
            deckSelect.Items.AddRange(new object[] { "Deck 1", "Deck 2", "Deck 3" });
            deckSelect.Location = new Point(658, 86);
            deckSelect.Name = "deckSelect";
            deckSelect.Size = new Size(182, 33);
            deckSelect.TabIndex = 3;
            deckSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 128);
            textBox1.Location = new Point(658, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "Current Deck:";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Location = new Point(658, 151);
            button4.Name = "button4";
            button4.Size = new Size(340, 34);
            button4.TabIndex = 5;
            button4.Text = "Add Card";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // InputFront
            // 
            InputFront.BackColor = Color.Lime;
            InputFront.Location = new Point(658, 191);
            InputFront.Multiline = true;
            InputFront.Name = "InputFront";
            InputFront.Size = new Size(340, 96);
            InputFront.TabIndex = 6;
            InputFront.Text = "Front";
            // 
            // InputBack
            // 
            InputBack.BackColor = Color.Lime;
            InputBack.Location = new Point(658, 293);
            InputBack.Multiline = true;
            InputBack.Name = "InputBack";
            InputBack.Size = new Size(340, 98);
            InputBack.TabIndex = 7;
            InputBack.Text = "Back";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(791, 402);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(197, 34);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete Deck (WARN!!)";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(791, 442);
            button5.Name = "button5";
            button5.Size = new Size(197, 34);
            button5.TabIndex = 9;
            button5.Text = "Delete Card (WARN!!)";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // deleteCardIndex
            // 
            deleteCardIndex.BackColor = Color.Red;
            deleteCardIndex.Location = new Point(791, 482);
            deleteCardIndex.Name = "deleteCardIndex";
            deleteCardIndex.Size = new Size(197, 31);
            deleteCardIndex.TabIndex = 10;
            deleteCardIndex.Text = "Delete Card Index:";
            // 
            // currentIndexBox
            // 
            currentIndexBox.BackColor = Color.FromArgb(0, 192, 192);
            currentIndexBox.Location = new Point(58, 482);
            currentIndexBox.Name = "currentIndexBox";
            currentIndexBox.ReadOnly = true;
            currentIndexBox.Size = new Size(150, 31);
            currentIndexBox.TabIndex = 11;
            currentIndexBox.Text = "Current Index:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(128, 128, 255);
            textBox4.Location = new Point(22, 153);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(565, 238);
            textBox4.TabIndex = 12;
            textBox4.Text = "Card is great";
            // 
            // LogBox
            // 
            LogBox.BackColor = Color.Yellow;
            LogBox.Location = new Point(449, 525);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.Size = new Size(561, 31);
            LogBox.TabIndex = 13;
            LogBox.Text = "Error Log:";
            // 
            // debugsetup
            // 
            debugsetup.Location = new Point(449, 405);
            debugsetup.Name = "debugsetup";
            debugsetup.Size = new Size(112, 34);
            debugsetup.TabIndex = 14;
            debugsetup.Text = "button3";
            debugsetup.UseVisualStyleBackColor = true;
            debugsetup.Click += debugsetup_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Correct", "Incorrect", "Unsure" });
            checkedListBox1.Location = new Point(252, 442);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 88);
            checkedListBox1.TabIndex = 15;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // name
            // 
            name.Location = new Point(252, 405);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(150, 31);
            name.TabIndex = 16;
            name.Text = "Card Correctness";
            // 
            // SaveDeck
            // 
            SaveDeck.Location = new Point(876, 84);
            SaveDeck.Name = "SaveDeck";
            SaveDeck.Size = new Size(112, 34);
            SaveDeck.TabIndex = 17;
            SaveDeck.Text = "Save Deck";
            SaveDeck.UseVisualStyleBackColor = true;
            SaveDeck.Click += SaveDeck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1036, 568);
            Controls.Add(SaveDeck);
            Controls.Add(name);
            Controls.Add(checkedListBox1);
            Controls.Add(debugsetup);
            Controls.Add(LogBox);
            Controls.Add(textBox4);
            Controls.Add(currentIndexBox);
            Controls.Add(deleteCardIndex);
            Controls.Add(button5);
            Controls.Add(DeleteButton);
            Controls.Add(InputBack);
            Controls.Add(InputFront);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(deckSelect);
            Controls.Add(flipCard);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button flipCard;
        private ComboBox deckSelect;
        private TextBox textBox1;
        private Button button4;
        private TextBox InputFront;
        private TextBox InputBack;
        private Button DeleteButton;
        private Button button5;
        private TextBox deleteCardIndex;
        private TextBox currentIndexBox;
        private TextBox textBox4;
        private TextBox LogBox;
        private Button debugsetup;
        private CheckedListBox checkedListBox1;
        private TextBox name;
        private Button SaveDeck;
    }
}
