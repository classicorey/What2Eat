using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Threading;
using System.Reflection.Emit;
using What2Eat;

namespace What2Eat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Empty the Option names in case there was an error.
            lblOption1Name.Text = String.Empty;
            lblOption2Name.Text = String.Empty;
            lblOption3Name.Text = String.Empty;
            lblOption4Name.Text = String.Empty;
            lblOption5Name.Text = String.Empty;
            lblOption6Name.Text = String.Empty;
            lblOption7Name.Text = String.Empty;
            lblOption8Name.Text = String.Empty;
            lblOption9Name.Text = String.Empty;
            lblOption10Name.Text = String.Empty;


            this.Text = "What2Eat";
            lblWelcome.Text = "Welcome in!\nHope you're hungry!\n\nLet's get you something to eat.";
            //Place first screen elements in their proper places
            //    put the welcome message, the selection message, and the buttons at their correct heights on screen.
            lblWelcome.Top = this.Top + 30;
            btnRollOption.Top = lblWelcome.Top + lblWelcome.Height + 20;
            btnViewOptions.Top = btnRollOption.Top;
            lblSelection.Top = btnViewOptions.Top + btnViewOptions.Height + 30;
            lblSelectionStroke.Top = lblSelection.Top - 2;


            //    put the welcome message, the selection message, and the buttons at their correct X cord on screen.
            int formWidth = this.Width;
            int perfectOffset = (formWidth - lblWelcome.Width) / 2;
            lblWelcome.Left = perfectOffset;
            PlaceLabelStroke(lblWelcome, lblWelcomeStroke);
            perfectOffset = (formWidth - (btnRollOption.Width + btnViewOptions.Width + 6)) / 2;
            btnRollOption.Left = perfectOffset - 6;
            btnViewOptions.Left = perfectOffset + btnRollOption.Width + 6;

            //Place second screen elements into their proper places
            //  This part's a little jumbled compared to the first screen. I plan on re-organizing it to make this more readable.
            //  Center the welcome message
            perfectOffset = (this.Width - lblOptionsWelcome.Width) / 2;
            lblOptionsWelcome.Left = perfectOffset;
            //  Place the stroke label accordingly
            PlaceLabelStroke(lblOptionsWelcome, lblOptionsWelcomeStroke);
            //    Set the back button's X coord properly.
            btnBack.Left = (perfectOffset / 2) - (btnBack.Width / 2);
            //    lay the groundwork for button size, location
            //    Set the first "Option X:" label where it needs to go using the button's location.
            lblOption1.Left = btnBack.Left + btnBack.Width;
            lblOption1.Top = lblWelcome.Top + lblWelcome.Height + 5;
            //    Place the stoke label where it needs to go.
            PlaceLabelStroke(lblOption1, lblOption1Stroke);
            //    Place the Reroll Text Button where it needs to go using the welcome message, and back button's location
            btnRemoveOptions.Left = this.Width - (perfectOffset / 2) - (btnRemoveOptions.Width / 2);
            btnRemoveOptions.Top = btnBack.Top - btnRemoveOptions.Height;
            btnAddOptions.Top = btnBack.Top + btnAddOptions.Height;
            btnAddOptions.Left = btnRemoveOptions.Left;

            //    Set two variables to control the spacing vertically and horizontally between the option labels.
            //        change once, change many.
            int optionVertSpacing = lblOption1.Height + 5;
            int optionColumnSpacing = lblOption1.Width + 15;

            //Set the first option label's position using the coorisponding information label position. 
            lblOption1Name.Left = lblOption1.Left + optionColumnSpacing;
            lblOption1Name.Top = lblOption1.Top;
            //Adjust the stroke label's position and size.
            lblOption1Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption1Name, lblOption1NameStroke);

            //     place each option label and stroke label in their correct location for option numbers using the above method.
            //     Yes. I do realize this can be further refactored. It's 3:44 AM and I just want to go to bed.
            lblOption2.Left = lblOption1.Left;
            lblOption2.Top = lblOption1.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption2, lblOption2Stroke);

            lblOption2Name.Left = lblOption1Name.Left;
            lblOption2Name.Top = lblOption2.Top;
            lblOption2Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption2Name, lblOption2NameStroke);

            lblOption3.Left = lblOption2.Left;
            lblOption3.Top = lblOption2.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption3, lblOption3Stroke);

            lblOption3Name.Left = lblOption2Name.Left;
            lblOption3Name.Top = lblOption3.Top;
            lblOption3Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption3Name, lblOption3NameStroke);

            lblOption4.Left = lblOption3.Left;
            lblOption4.Top = lblOption3.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption4, lblOption4Stroke);

            lblOption4Name.Left = lblOption3Name.Left;
            lblOption4Name.Top = lblOption4.Top;
            lblOption4Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption4Name, lblOption4NameStroke);

            lblOption5.Left = lblOption4.Left;
            lblOption5.Top = lblOption4.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption5, lblOption5Stroke);

            lblOption5Name.Left = lblOption4Name.Left;
            lblOption5Name.Top = lblOption5.Top;
            lblOption5Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption5Name, lblOption5NameStroke);

            lblOption6.Left = lblOption5.Left;
            lblOption6.Top = lblOption5.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption6, lblOption6Stroke);

            lblOption6Name.Left = lblOption5Name.Left;
            lblOption6Name.Top = lblOption6.Top;
            lblOption6Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption6Name, lblOption6NameStroke);

            lblOption7.Left = lblOption6.Left;
            lblOption7.Top = lblOption6.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption7, lblOption7Stroke);

            lblOption7Name.Left = lblOption6Name.Left;
            lblOption7Name.Top = lblOption7.Top;
            lblOption7Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption7Name, lblOption7NameStroke);

            lblOption8.Left = lblOption7.Left;
            lblOption8.Top = lblOption7.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption8, lblOption8Stroke);

            lblOption8Name.Left = lblOption7Name.Left;
            lblOption8Name.Top = lblOption8.Top;
            lblOption8Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption8Name, lblOption8NameStroke);

            lblOption9.Left = lblOption8.Left;
            lblOption9.Top = lblOption8.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption9, lblOption9Stroke);

            lblOption9Name.Left = lblOption8Name.Left;
            lblOption9Name.Top = lblOption9.Top;
            lblOption9Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption9Name, lblOption9NameStroke);

            lblOption10.Left = lblOption9.Left - 8;
            lblOption10.Top = lblOption9.Top + optionVertSpacing;
            PlaceLabelStroke(lblOption10, lblOption10Stroke);

            lblOption10Name.Left = lblOption9Name.Left;
            lblOption10Name.Top = lblOption10.Top;
            lblOption10Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption10Name, lblOption10NameStroke);

            perfectOffset = lblOptionsWelcome.Left + ((lblOptionsWelcome.Width - txtInput.Width) / 2);
            txtInput.Left = perfectOffset;
            txtInput.Top = lblOption3.Top;

            perfectOffset = txtInput.Left + ((txtInput.Width - btnConfirm.Width) / 2);
            btnConfirm.Left = perfectOffset;
            btnConfirm.Top = lblOption7.Top;

            //Set the form color to the decided upon value.
            this.BackColor = ColorTranslator.FromHtml("#CCBFCA");

            //Set the tops and rights for the 'remove option' buttons

            int newSize = 6;
            btnRemoveOption1.Font = new Font(btnRemoveOption1.Font.FontFamily, newSize);
            btnRemoveOption1.Height = 25;
            btnRemoveOption1.Top = lblOption1.Top-5;
            btnRemoveOption1.Left = lblOption1.Left-20;
            //Set the locations of the other buttons using inherritance from the previous
            setButtonLocations(btnRemoveOption1, btnRemoveOption2);
            setButtonLocations(btnRemoveOption2, btnRemoveOption3);
            setButtonLocations(btnRemoveOption3, btnRemoveOption4);
            setButtonLocations(btnRemoveOption4, btnRemoveOption5);
            setButtonLocations(btnRemoveOption5, btnRemoveOption6);      
            setButtonLocations(btnRemoveOption6, btnRemoveOption7);
            setButtonLocations(btnRemoveOption7, btnRemoveOption8);
            setButtonLocations(btnRemoveOption8, btnRemoveOption9);
            setButtonLocations(btnRemoveOption9, btnRemoveOption10);

            //Center and place the "back" button for removing options using the form's height
            btnOptionRemoveBack.Top = btnRemoveOptions.Top;
            btnOptionRemoveBack.Left = btnRemoveOptions.Left;

            //Set aesthetic properties for first screen elements.
            SetLabelColors(lblWelcome, lblWelcomeStroke);
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;
            SetLabelColors(lblSelection, lblSelectionStroke);

            SetButtonColors(btnRollOption);
            SetButtonColors(btnViewOptions);

            //Set aesthetic properties for second screen elements
            SetLabelColors(lblOptionsWelcome, lblOptionsWelcomeStroke);
            SetLabelColors(lblOption1, lblOption1Stroke);
            SetLabelColors(lblOption2, lblOption2Stroke);
            SetLabelColors(lblOption3, lblOption3Stroke);
            SetLabelColors(lblOption4, lblOption4Stroke);
            SetLabelColors(lblOption5, lblOption5Stroke);
            SetLabelColors(lblOption6, lblOption6Stroke);
            SetLabelColors(lblOption7, lblOption7Stroke);
            SetLabelColors(lblOption8, lblOption8Stroke);
            SetLabelColors(lblOption9, lblOption9Stroke);
            SetLabelColors(lblOption10, lblOption10Stroke);
            SetLabelColors(lblOption1Name, lblOption1NameStroke);
            SetLabelColors(lblOption2Name, lblOption2NameStroke);
            SetLabelColors(lblOption3Name, lblOption3NameStroke);
            SetLabelColors(lblOption4Name, lblOption4NameStroke);
            SetLabelColors(lblOption5Name, lblOption5NameStroke);
            SetLabelColors(lblOption6Name, lblOption6NameStroke);
            SetLabelColors(lblOption7Name, lblOption7NameStroke);
            SetLabelColors(lblOption8Name, lblOption8NameStroke);
            SetLabelColors(lblOption9Name, lblOption9NameStroke);
            SetLabelColors(lblOption10Name, lblOption10NameStroke);

            SetButtonColors(btnBack);
            SetButtonColors(btnRemoveOptions);
            SetButtonColors(btnAddOptions);
            SetButtonColors(btnConfirm);
            SetButtonColors(btnRemoveOption1);
            SetButtonColors(btnRemoveOption2);
            SetButtonColors(btnRemoveOption3);
            SetButtonColors(btnRemoveOption4);
            SetButtonColors(btnRemoveOption5);
            SetButtonColors(btnRemoveOption6);
            SetButtonColors(btnRemoveOption7);
            SetButtonColors(btnRemoveOption8);
            SetButtonColors(btnRemoveOption9);
            SetButtonColors(btnRemoveOption10);
            SetButtonColors(btnOptionRemoveBack);

            txtInput.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            txtInput.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            txtInput.Font = new Font("Helvetica", lblWelcome.Font.Size);

            pageToFirst();
        }

        //When the Roll Option button is clicked,
        private void btnRollOption_Click(object sender, EventArgs e)
        {
            //Display the selection.
            displaySelection();

        }

        //When the View Options button is clicked,
        private void btnViewOptions_Click(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome in!\nHope you're hungry!\n\nLet's get you something to eat.";
            //Show the second page, and hide the first.
            pageToSecond();
            populateOptionLabels();
        }
        private void displaySelection()
        {
            if (isListEmpty() == true)
            {
                lblWelcome.Text = "You don't have options recorded. \nView your options to add one.";
                return;
            }
            //Create an array of strings for a varried result each click.
            string[] choiceText = new string[] {
                "     We've scrubbed all 14,000,605 realities for the best possible outcome.     ",
                "     We've passed word around the office. We've got something you'll like.     ",
                "     Every day is an adventure; today especially.     ",
                "     This option is scientifically proven to cure your frustrations.     ",
                "     We're excited about this one in particular.     ",
                "     We outsourced this one to the magic eight ball.     ",
                "     The heavens parted, and delivered this message:     ",
                "     Food? This is where you're going to need to go.     ",
                "     Our cutting edge algorithms have chosen specifically for you.     ",
                "     The deliciousness from this suggestion almost broke our servers (just kidding. We don't use servers).     "
            };

            //Start a random number object.
            Random rnd = new Random();
            int i = rnd.Next(0, choiceText.Length);
            string chosenIntro = choiceText[i];

            //Read the file,
            string filePath = @"restaraunts.txt";
            string maxFileContents = lblOption1Name.Text + "," + lblOption2Name.Text + "," + lblOption3Name.Text + "," + lblOption4Name.Text + "," + lblOption5Name.Text + "," + lblOption6Name.Text + "," + lblOption7Name.Text + "," + lblOption8Name.Text + "," + lblOption9Name.Text + "," + lblOption10Name.Text;
            File.WriteAllText(filePath, maxFileContents);
            string chosenText = "";
            //While we don't have an option yet (reroll if the option is empty),
            while (chosenText == "")
            {
                //Choose one randomly.
                i = rnd.Next(0, 9);
                switch (i)
                {
                    case 0:
                        chosenText = lblOption1Name.Text;
                        break;
                    case 1:
                        chosenText = lblOption2Name.Text;
                        break;
                    case 2:
                        chosenText = lblOption3Name.Text;
                        break;
                    case 3:
                        chosenText = lblOption4Name.Text;
                        break;
                    case 4:
                        chosenText = lblOption5Name.Text;
                        break;
                    case 5:
                        chosenText = lblOption6Name.Text;
                        break;
                    case 6:
                        chosenText = lblOption7Name.Text;
                        break;
                    case 7:
                        chosenText = lblOption8Name.Text;
                        break;
                    case 8:
                        chosenText = lblOption9Name.Text;
                        break;
                    case 9:
                        chosenText = lblOption10Name.Text;
                        break;
                }
            }
            //pick a random string from the choiceText array as an opener, and then display the result.
            lblSelection.Text = chosenIntro + "\r\n\r\n     We think " + chosenText + " is the right call today.     ";

            //Create some helper variables to determine the precice loction the labels need to be at.
            int formWidth = this.Width;
            int perfectOffset = (formWidth - lblSelection.Width) / 2;

            //Align the suggestion box centered on the form.
            lblSelectionStroke.Width = lblSelection.Width + 4;
            lblSelection.Left = perfectOffset;
            lblSelectionStroke.Left = perfectOffset - 2;
            lblSelection.Visible = true;
            lblSelectionStroke.Visible = true;
        }

        //when the page-2 back button is clicked,
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show the first page and hide the second.
            pageToFirst();

        }
        private void populateOptionLabels()
        {
            //Read the file,
            string filePath = @"restaraunts.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            string fileContents = lines[0];

            //For each line in the file
            foreach (string line in lines)
            {
                int i = 1;
                //Split it by comma separated values.
                String[] parts = line.Split(',');
                //And in each of those parts,
                foreach (string part in parts)
                {
                    //If the section isn't empty,
                    if (part != "")
                    {
                        //Set each option name to the corresponding thing in the file.
                        switch (i)
                        {
                            case 1:
                                lblOption1Name.Text = part;
                                break;
                            case 2:
                                lblOption2Name.Text = part;
                                break;
                            case 3:
                                lblOption3Name.Text = part;
                                break;
                            case 4:
                                lblOption4Name.Text = part;
                                break;
                            case 5:
                                lblOption5Name.Text = part;
                                break;
                            case 6:
                                lblOption6Name.Text = part;
                                break;
                            case 7:
                                lblOption7Name.Text = part;
                                break;
                            case 8:
                                lblOption8Name.Text = part;
                                break;
                            case 9:
                                lblOption9Name.Text = part;
                                break;
                            case 10:
                                lblOption10Name.Text = part;
                                break;
                        }
                    }
                    i++;
                }
            }

            //Write all the content of the option names to the file, to ensure we only get 10 elements total. We don't need a file leak with 4TB of options we never use.
            string maxFileContents = lblOption1Name.Text + "," + lblOption2Name.Text + "," + lblOption3Name.Text + "," + lblOption4Name.Text + "," + lblOption5Name.Text + "," + lblOption6Name.Text + "," + lblOption7Name.Text + "," + lblOption8Name.Text + "," + lblOption9Name.Text + "," + lblOption10Name.Text;
            File.WriteAllText(filePath, maxFileContents);
        }

        private void AdjustAutoSizeLabelStroke(System.Windows.Forms.Label mainLabel, System.Windows.Forms.Label strokeLabel)
        {
            //Use the "main" label to set the location and size for the secondary label.
            //I tried using this for both auto-size true and false labels, for some reason it only works if it's in two different functions?
            //I think I need another 15 minutes to figure that out and just have one function.
            //They look like they're doing the exact some thing.
            strokeLabel.Location = new Point(mainLabel.Location.X - 2, mainLabel.Location.Y - 2);
            strokeLabel.Width = mainLabel.Width + 4;
            strokeLabel.Height = mainLabel.Height + 4;
        }

        private void PlaceLabelStroke(System.Windows.Forms.Label mainLabel, System.Windows.Forms.Label strokeLabel)
        {
            //Same thing as above.
            //I have zero clue as to why this wasn't working with auto-size true labels.
            strokeLabel.Location = new Point(mainLabel.Location.X - 2, mainLabel.Location.Y - 2);
            strokeLabel.Width = mainLabel.Width + 4;
            strokeLabel.Height = mainLabel.Height + 4;
        }

        private void SetLabelColors(System.Windows.Forms.Label mainLabel, System.Windows.Forms.Label strokeLabel)
        {
            //Set the label and stroke label colours to match the aesthetic directions.
            mainLabel.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            mainLabel.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            mainLabel.Font = new Font("Helvetica", lblWelcome.Font.Size);
            strokeLabel.BackColor = ColorTranslator.FromHtml("#959595");
            strokeLabel.Font = new Font("Helvetica", lblWelcome.Font.Size);
        }
        private void SetButtonColors(System.Windows.Forms.Button button)
        {
            //Set the button colours to match the aesthetic directions.
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 3;
            button.BackColor = ColorTranslator.FromHtml("#B98DA1");
            button.ForeColor = ColorTranslator.FromHtml("#4C3B43");
        }

        private void btnRemoveOption (object sender, EventArgs e)
        {
            //Hide the second page,
            hideSecondPage();
            //then show the other items for the user to interact with
            btnRemoveOption1.Visible = true;
            btnRemoveOption2.Visible = true;
            btnRemoveOption3.Visible = true;
            btnRemoveOption4.Visible = true;
            btnRemoveOption5.Visible = true;
            btnRemoveOption6.Visible = true;
            btnRemoveOption7.Visible = true;
            btnRemoveOption8.Visible = true;
            btnRemoveOption9.Visible = true;
            btnRemoveOption10.Visible = true;
            btnOptionRemoveBack.Visible = true;
            lblOptionsWelcome.Visible = true;
            lblOptionsWelcomeStroke.Visible = true;
            lblOption1Name.Visible = true;
            lblOption1NameStroke.Visible = true;
            lblOption2Name.Visible = true;
            lblOption2NameStroke.Visible = true;
            lblOption3Name.Visible = true;
            lblOption3NameStroke.Visible = true;
            lblOption4Name.Visible = true;
            lblOption4NameStroke.Visible = true;
            lblOption5Name.Visible = true;
            lblOption5NameStroke.Visible = true;
            lblOption6Name.Visible = true;
            lblOption6NameStroke.Visible = true;
            lblOption7Name.Visible = true;
            lblOption7NameStroke.Visible = true;
            lblOption8Name.Visible = true;
            lblOption8NameStroke.Visible = true;
            lblOption9Name.Visible = true;
            lblOption9NameStroke.Visible = true;
            lblOption10Name.Visible = true;
            lblOption10NameStroke.Visible = true;

            //Set the notif text to tell the user what to do.
            lblOptionsWelcome.Text = "Which option would you like to delete?";
        }
        private void btnAddOptions_Click(object sender, EventArgs e)
        {
            hideSecondPage();
            //set the UI elements to visible for the user to know what to do.
            lblOptionsWelcome.Visible = true;
            lblOptionsWelcome.Text = "Type the name of the restaraunt to add below.\nLong Names get cut off.";
            txtInput.Visible = true;
            btnConfirm.Visible = true;
        }

        private void deleteFromFile(string optionToDelete)
        {
            //Reset all the option names
            lblOption1Name.Text = String.Empty;
            lblOption2Name.Text = String.Empty;
            lblOption3Name.Text = String.Empty;
            lblOption4Name.Text = String.Empty;
            lblOption5Name.Text = String.Empty;
            lblOption6Name.Text = String.Empty;
            lblOption7Name.Text = String.Empty;
            lblOption8Name.Text = String.Empty;
            lblOption9Name.Text = String.Empty;
            lblOption10Name.Text = String.Empty;

            //Read the file
            string filePath = @"restaraunts.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            string fileContents = lines[0];

            //Split it into CSV's
            foreach (string line in lines)
            {
                int i = 1;
                String[] parts = line.Split(',');
                //For each of those parts,
                foreach (string part in parts)
                {
                    //Write to the option labels to populate them.
                    if (part != "" && part != optionToDelete)
                    {
                        switch (i)
                        {
                            case 1:
                                lblOption1Name.Text = part;
                                break;
                            case 2:
                                lblOption2Name.Text = part;
                                break;
                            case 3:
                                lblOption3Name.Text = part;
                                break;
                            case 4:
                                lblOption4Name.Text = part;
                                break;
                            case 5:
                                lblOption5Name.Text = part;
                                break;
                            case 6:
                                lblOption6Name.Text = part;
                                break;
                            case 7:
                                lblOption7Name.Text = part;
                                break;
                            case 8:
                                lblOption8Name.Text = part;
                                break;
                            case 9:
                                lblOption9Name.Text = part;
                                break;
                            case 10:
                                lblOption10Name.Text = part;
                                break;
                        }
                    }
                    i++;
                }
            }
            //Use the option labels to write to the file to ensure uniformity.
            string maxFileContents = lblOption1Name.Text + "," + lblOption2Name.Text + "," + lblOption3Name.Text + "," + lblOption4Name.Text + "," + lblOption5Name.Text + "," + lblOption6Name.Text + "," + lblOption7Name.Text + "," + lblOption8Name.Text + "," + lblOption9Name.Text + "," + lblOption10Name.Text;
            File.WriteAllText(filePath, maxFileContents);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Add variables to keep track of statisitcs.
            int maxStringLength = 60;
            bool textAdded = false;

            //If the answer has too many letters,
            if (txtInput.Text.Length > maxStringLength)
            {
                //Tell them to cut it down.
                lblOptionsWelcome.Text = "We can't allow more than " + maxStringLength + " characters in a name.\nYou're currently at " + txtInput.Text.Length + " characters.";
                return;
            }

            //If the answer contains a comma, 
            if (txtInput.Text.Contains(","))
            {
                //Tell them it will mess up our list and re-input the option.
                lblOptionsWelcome.Text = "Unfortunately your restaraunt has a comma in it.\nThat seriously messes up our list.\nPlease don't give us commas.";
                return;
            }

            //Go through each label, if it is empty and we haven't already added the text, add it here.

            if (lblOption1Name.Text == String.Empty && textAdded == false)
            {
                lblOption1Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption2Name.Text == String.Empty && textAdded == false)
            {
                lblOption2Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption3Name.Text == String.Empty && textAdded == false)
            {
                lblOption3Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption4Name.Text == String.Empty && textAdded == false)
            {
                lblOption4Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption5Name.Text == String.Empty && textAdded == false)
            {
                lblOption5Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption6Name.Text == String.Empty && textAdded == false)
            {
                lblOption6Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption7Name.Text == String.Empty && textAdded == false)
            {
                lblOption7Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption8Name.Text == String.Empty && textAdded == false)
            {
                lblOption8Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption9Name.Text == String.Empty && textAdded == false)
            {
                lblOption9Name.Text = txtInput.Text;
                textAdded = true;
            }

            if (lblOption10Name.Text == String.Empty && textAdded == false)
            {
                lblOption10Name.Text = txtInput.Text;
                textAdded = true;
            }

            //Set visibilities for the user to the next page.
            btnConfirm.Visible = false;
            txtInput.Visible = false;
            txtInput.Text = "";
            pageToSecond();
            //Write out the file to ensure uniformity.
            string filePath = @"restaraunts.txt";
            string maxFileContents = lblOption1Name.Text + "," + lblOption2Name.Text + "," + lblOption3Name.Text + "," + lblOption4Name.Text + "," + lblOption5Name.Text + "," + lblOption6Name.Text + "," + lblOption7Name.Text + "," + lblOption8Name.Text + "," + lblOption9Name.Text + "," + lblOption10Name.Text;
            File.WriteAllText(filePath, maxFileContents);
            lblOptionsWelcome.Text = "Hey there! Feel free to make some edits here!";
        }
        //btnRemoveOptionX functions are on-click events that will check to see if the restaraunt is empty, and if not it will delete the record there and show the next page.
        private void btnRemoveOption1_Click(object sender, EventArgs e)
        {
            if (lblOption1Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 1.";
            }
            else
            {
                deleteFromFile(lblOption1Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption2_Click(object sender, EventArgs e)
        {

            if (lblOption2Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 2.";
            }
            else
            {
                deleteFromFile(lblOption2Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption3_Click(object sender, EventArgs e)
        {

            if (lblOption3Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 3.";
            }
            else
            {
                deleteFromFile(lblOption3Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption4_Click(object sender, EventArgs e)
        {

            if (lblOption4Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 4.";
            }
            else
            {
                deleteFromFile(lblOption4Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption5_Click(object sender, EventArgs e)
        {

            if (lblOption5Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 5.";
            }
            else
            {
                deleteFromFile(lblOption5Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption6_Click(object sender, EventArgs e)
        {

            if (lblOption6Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 6.";
            }
            else
            {
                deleteFromFile(lblOption6Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption7_Click(object sender, EventArgs e)
        {

            if (lblOption7Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 7.";
            }
            else
            {
                deleteFromFile(lblOption7Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption8_Click(object sender, EventArgs e)
        {

            if (lblOption8Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 8.";
            }
            else
            {
                deleteFromFile(lblOption8Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption9_Click(object sender, EventArgs e)
        {

            if (lblOption9Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 9.";
            }
            else
            {
                deleteFromFile(lblOption9Name.Text);
                pageToSecond();
            }
        }

        private void btnRemoveOption10_Click(object sender, EventArgs e)
        {

            if (lblOption10Name.Text == String.Empty)
            {
                lblOptionsWelcome.Text = "You don't have any restaraunt in Option 10.";
            }
            else
            {
                deleteFromFile(lblOption10Name.Text);
                pageToSecond();
            }
        }

        private void setButtonLocations(System.Windows.Forms.Button beforeButton, System.Windows.Forms.Button currentButton)
        {
            int newSize = 6;
            currentButton.Font = new Font(currentButton.Font.FontFamily, newSize);
            currentButton.Height = 25;
            //set a current putton location using an int spacer, and the previous button's location.
            currentButton.Top = beforeButton.Top + currentButton.Height;
            currentButton.Left = beforeButton.Left;
        }

        private void hideSecondPage()
        {
            //Set visibility properties for the second page.
            lblOptionsWelcome.Visible = false;
            lblOptionsWelcomeStroke.Visible = false;
            btnBack.Visible = false;
            lblOption1.Visible = false;
            lblOption2.Visible = false;
            lblOption3.Visible = false;
            lblOption4.Visible = false;
            lblOption5.Visible = false;
            lblOption6.Visible = false;
            lblOption7.Visible = false;
            lblOption8.Visible = false;
            lblOption9.Visible = false;
            lblOption10.Visible = false;
            lblOption1Stroke.Visible = false;
            lblOption2Stroke.Visible = false;
            lblOption3Stroke.Visible = false;
            lblOption4Stroke.Visible = false;
            lblOption5Stroke.Visible = false;
            lblOption6Stroke.Visible = false;
            lblOption7Stroke.Visible = false;
            lblOption8Stroke.Visible = false;
            lblOption9Stroke.Visible = false;
            lblOption10Stroke.Visible = false;
            lblOption1Name.Visible = false;
            lblOption2Name.Visible = false;
            lblOption3Name.Visible = false;
            lblOption4Name.Visible = false;
            lblOption5Name.Visible = false;
            lblOption6Name.Visible = false;
            lblOption7Name.Visible = false;
            lblOption8Name.Visible = false;
            lblOption9Name.Visible = false;
            lblOption10Name.Visible = false;
            lblOption1NameStroke.Visible = false;
            lblOption2NameStroke.Visible = false;
            lblOption3NameStroke.Visible = false;
            lblOption4NameStroke.Visible = false;
            lblOption5NameStroke.Visible = false;
            lblOption6NameStroke.Visible = false;
            lblOption7NameStroke.Visible = false;
            lblOption8NameStroke.Visible = false;
            lblOption9NameStroke.Visible = false;
            lblOption10NameStroke.Visible = false;
            btnRemoveOptions.Visible = false;
            btnAddOptions.Visible = false;
            txtInput.Visible = false;
            btnConfirm.Visible = false;
            btnRemoveOption1.Visible = false;
            btnRemoveOption2.Visible = false;
            btnRemoveOption3.Visible = false;
            btnRemoveOption4.Visible = false;
            btnRemoveOption5.Visible = false;
            btnRemoveOption6.Visible = false;
            btnRemoveOption7.Visible = false;
            btnRemoveOption8.Visible = false;
            btnRemoveOption9.Visible = false;
            btnRemoveOption10.Visible = false;
            btnOptionRemoveBack.Visible = false;
        }
        private void showSecondPage()
        {
            //Set visibility properties for the Second page. Ensure the first and second page is hidden first, so that we do not get any elements from the sub-pages like btnRemove.
            hideFirstPage();
            hideSecondPage();
            lblOptionsWelcome.Visible = true;
            lblOptionsWelcomeStroke.Visible = true;
            btnBack.Visible = true;
            lblOption1.Visible = true;
            lblOption2.Visible = true;
            lblOption3.Visible = true;
            lblOption4.Visible = true;
            lblOption5.Visible = true;
            lblOption6.Visible = true;
            lblOption7.Visible = true;
            lblOption8.Visible = true;
            lblOption9.Visible = true;
            lblOption10.Visible = true;
            lblOption1Stroke.Visible = true;
            lblOption2Stroke.Visible = true;
            lblOption3Stroke.Visible = true;
            lblOption4Stroke.Visible = true;
            lblOption5Stroke.Visible = true;
            lblOption6Stroke.Visible = true;
            lblOption7Stroke.Visible = true;
            lblOption8Stroke.Visible = true;
            lblOption9Stroke.Visible = true;
            lblOption10Stroke.Visible = true;
            lblOption1Name.Visible = true;
            lblOption2Name.Visible = true;
            lblOption3Name.Visible = true;
            lblOption4Name.Visible = true;
            lblOption5Name.Visible = true;
            lblOption6Name.Visible = true;
            lblOption7Name.Visible = true;
            lblOption8Name.Visible = true;
            lblOption9Name.Visible = true;
            lblOption10Name.Visible = true;
            lblOption1NameStroke.Visible = true;
            lblOption2NameStroke.Visible = true;
            lblOption3NameStroke.Visible = true;
            lblOption4NameStroke.Visible = true;
            lblOption5NameStroke.Visible = true;
            lblOption6NameStroke.Visible = true;
            lblOption7NameStroke.Visible = true;
            lblOption8NameStroke.Visible = true;
            lblOption9NameStroke.Visible = true;
            lblOption10NameStroke.Visible = true;
            btnRemoveOptions.Visible = true;
            btnAddOptions.Visible = true;
            txtInput.Visible = false;
            btnConfirm.Visible = false;
            btnRemoveOption1.Visible = true;
            btnRemoveOption2.Visible = true;
            btnRemoveOption3.Visible = true;
            btnRemoveOption4.Visible = true;
            btnRemoveOption5.Visible = true;
            btnRemoveOption6.Visible = true;
            btnRemoveOption7.Visible = true;
            btnRemoveOption8.Visible = true;
            btnRemoveOption9.Visible = true;
            btnRemoveOption10.Visible = true;



            btnRemoveOption1.Visible = false;
            btnRemoveOption2.Visible = false;
            btnRemoveOption3.Visible = false;
            btnRemoveOption4.Visible = false;
            btnRemoveOption5.Visible = false;
            btnRemoveOption6.Visible = false;
            btnRemoveOption7.Visible = false;
            btnRemoveOption8.Visible = false;
            btnRemoveOption9.Visible = false;
            btnRemoveOption10.Visible = false;
        }
        private void showFirstPage()
        {
            //Set visibility properties for the first page.
            lblWelcome.Visible = true;
            lblWelcomeStroke.Visible = true;
            btnRollOption.Visible = true;
            btnViewOptions.Visible = true;
        }
        private void hideFirstPage()
        {
            //Set visibility properties for the first page.
            lblWelcome.Visible = false;
            lblWelcomeStroke.Visible = false;
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;
            btnRollOption.Visible = false;
            btnViewOptions.Visible = false;
        }
        private void pageToFirst()
        {
            //Hide the second page, and show the first page.
            hideSecondPage();
            showFirstPage();
        }
        private void pageToSecond()
        {
            //Hide the first page and show the second.
            showSecondPage();
            hideFirstPage();
        }

        private void btnOptionRemoveBack_Click(object sender, EventArgs e)
        {
            showSecondPage();
        }

        private bool isListEmpty()
        {
            //Make sure you write out all the labels first,
            populateOptionLabels();
            bool empty = true;

            //Check each option label. If it is not empty, set the empty bool to false. This way, the bool will only be true if all options are empty.
            if (lblOption1.Name != string.Empty)
                empty = false;
            if (lblOption2.Name != string.Empty)
                empty = false;
            if (lblOption3.Name != string.Empty)
                empty = false;
            if (lblOption4.Name != string.Empty)
                empty = false;
            if (lblOption5.Name != string.Empty)
                empty = false;
            if (lblOption6.Name != string.Empty)
                empty = false;
            if (lblOption7.Name != string.Empty)
                empty = false;
            if (lblOption8.Name != string.Empty)
                empty = false;
            if (lblOption9.Name != string.Empty)
                empty = false;
            if (lblOption10.Name != string.Empty)
                empty = false;

            return empty;
        }
    }
}

