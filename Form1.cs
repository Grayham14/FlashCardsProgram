using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FlashCards
{

    //to do:
    // 1. implment user inputted 'right, wrong, or unsure' system
    // 2. improve shuffling cabplities, including shuffling only correct or only incorrect or unsure cards (or a mix of them?)
    // 3. acutally make the decks save locally, write over the save when a deck is deleted
    // 4. different color schemes, light, dark, or fun (the current theme)
    // 5. fix bug where deck out of range after deleting all the cards in a deck

    public partial class Form1 : Form
    {

        List<Flashcard> Deck1 = new List<Flashcard>();
        List<Flashcard> Deck2 = new List<Flashcard>();
        List<Flashcard> Deck3 = new List<Flashcard>();

        List<Flashcard> currentDeck = new List<Flashcard>();

        int currentCardIndex = 0;
        bool showingFront = true;

        public Form1()
        {
            InitializeComponent();
            LogBox.Text = "Deck 1 selected";
            deckSelect.SelectedIndex = 0;
            currentIndexBox.Text = currentCardIndex.ToString();

            textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";
        }
        private void LoadDeck(string deckName)
        {
            try
            {
                // Match the same naming rule as SaveDeck
                string safeDeckName = deckName.Replace(" ", "");
                string filePath = Path.Combine(Application.StartupPath, $"{safeDeckName}.json");

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    currentDeck = JsonSerializer.Deserialize<List<Flashcard>>(json) ?? new List<Flashcard>();
                    MessageBox.Show($"{deckName} loaded successfully!");
                }
                else
                {
                    currentDeck = new List<Flashcard>();
                    MessageBox.Show($"No save found for {deckName}. A new deck has been created.");
                }

                //UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading deck: {ex.Message}");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //deck select
        {
            if (deckSelect.SelectedItem != null)
            {
                string selectedDeck = deckSelect.SelectedItem.ToString();
                switch (selectedDeck)
                {
                    case "Deck 1":
                        currentDeck = Deck1;
                        LoadDeck("Deck1");
                        LogBox.Text = "Deck 1 selected";
                        if (Deck1.Count == 0)
                        {
                            ;
                            textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";
                        }

                        break;
                    case "Deck 2":
                        currentDeck = Deck2;
                        LogBox.Text = "Deck 2 selected";
                        if (Deck2.Count == 0)
                        {
                            textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";
                        }
                        break;
                    case "Deck 3":
                        currentDeck = Deck3;
                        if (Deck3.Count == 0)
                        {
                            textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";
                        }
                        break;
                }
                currentCardIndex = 0;
                showingFront = true;
            }

            currentIndexBox.Text = currentCardIndex.ToString();

        }

        private void button4_Click(object sender, EventArgs e) //add card
        {
            currentDeck.Add(new Flashcard(InputFront.Text, InputBack.Text, Flashcard.currentStatus.Unsure));
            currentCardIndex++;
        }

        private void button3_Click(object sender, EventArgs e) //flip card
        {
            showingFront = !showingFront;

            if (showingFront)
            {
                textBox4.Text = currentDeck[currentCardIndex].Frontside;
            }
            else
            {
                textBox4.Text = currentDeck[currentCardIndex].Backside;
            }
        }

        private void button2_Click(object sender, EventArgs e) //next card
        {
            currentCardIndex++;
            currentIndexBox.Text = currentCardIndex.ToString();
            showingFront = true;

            if (currentCardIndex >= currentDeck.Count)
            {
                currentCardIndex = 0;
            }
            if (currentDeck.Count == 0)
            {
                textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";

            }
            else if (currentDeck.Count > 0)
            {
                switch (currentDeck[currentCardIndex].CurrentStatus)
                {
                    case Flashcard.currentStatus.Correct:
                        comboBox1.SelectedIndex = 0; // Correct
                        break;
                    case Flashcard.currentStatus.False:
                        comboBox1.SelectedIndex = 1; // Incorrect;
                        break;
                    case Flashcard.currentStatus.Unsure:
                        comboBox1.SelectedIndex = 2; // Unsure
                        break;
                }
                textBox4.Text = currentDeck[currentCardIndex].Frontside;
            }


        }

        private void button1_Click(object sender, EventArgs e) //previous card
        {

            showingFront = true;

            if (currentDeck.Count == 0)
            {
                textBox4.Text = "Welcome to Flashcards! This deck is currently Empty, please add a card to get started";

            }
            else if (currentDeck.Count > 0)
            {
                currentCardIndex--;
                if (currentCardIndex < 0)
                {
                    currentCardIndex = currentDeck.Count - 1;

                }
                switch (currentDeck[currentCardIndex].CurrentStatus)
                {
                    case Flashcard.currentStatus.Correct:
                        comboBox1.SelectedIndex = 0; // Correct
                        break;
                    case Flashcard.currentStatus.False:
                        comboBox1.SelectedIndex = 1; // Incorrect;
                        break;
                    case Flashcard.currentStatus.Unsure:
                        comboBox1.SelectedIndex = 2; // Unsure
                        break;
                }
                currentIndexBox.Text = currentCardIndex.ToString();
                textBox4.Text = currentDeck[currentCardIndex].Frontside; //bug occurs here for out of index?

            }


        }

        private void button5_Click(object sender, EventArgs e) //remove card index
        {
            currentCardIndex--;
            currentDeck.RemoveAt(int.Parse(deleteCardIndex.Text));




        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            currentCardIndex = 0;
            currentDeck.Clear();



        }

        private void debugsetup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                currentDeck.Add(new Flashcard($"Front{i}", $"Back{i}", Flashcard.currentStatus.Unsure));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveyDeck(string deckName)
        {
            try
            {
                // Make the file name safe and consistent
                string safeDeckName = deckName.Replace(" ", "");
                string filePath = Path.Combine(Application.StartupPath, $"{safeDeckName}.json");

                string json = JsonSerializer.Serialize(currentDeck, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                MessageBox.Show($"{deckName} saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving deck: {ex.Message}");
            }
        }

        private void SaveDeck_Click(object sender, EventArgs e)
        {
            string deckName = deckSelect.SelectedItem.ToString(); // like "Deck1"
            SaveyDeck(deckName);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string currentSelectedOption = comboBox1.SelectedItem.ToString();
            if (currentDeck.Count > 0)
            {
                switch (currentSelectedOption)
                {
                    case "Correct":
                        currentDeck[currentCardIndex].CurrentStatus = Flashcard.currentStatus.Correct;
                        break;
                    case "Incorrect":
                        currentDeck[currentCardIndex].CurrentStatus = Flashcard.currentStatus.False;
                        break;
                    case "Unsure":
                        currentDeck[currentCardIndex].CurrentStatus = Flashcard.currentStatus.Unsure;
                        break;
                }
            }
        }
    }
}
