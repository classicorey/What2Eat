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
            this.Text = "What2Eat";
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
            //    This part's a little jumbled compared to the first screen. I plan on re-organizing it to make this more readable.
            //    Center the welcome message
            perfectOffset = (this.Width - lblOptionsWelcome.Width) / 2;
            lblOptionsWelcome.Left = perfectOffset;
            // Place the stroke label accordingly
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
            btnDebugRerollText.Left = this.Width - (perfectOffset / 2) - (btnDebugRerollText.Width / 2);
            btnDebugRerollText.Top = btnBack.Top;

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

            //Set the form color to the decided upon value.
            this.BackColor = ColorTranslator.FromHtml("#CCBFCA");

            //Set aesthetic properties for first screen elements.
            SetLabelColors(lblWelcome, lblWelcomeStroke);
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;
            SetLabelColors(lblSelection, lblSelectionStroke);

            SetButtonColors(btnRollOption);
            SetButtonColors(btnViewOptions);
            SetButtonColors(btnBack);
            SetButtonColors(btnDebugRerollText);

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

            showFirstPage();
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
            //Show the second page, and hide the first.
            showSecondPage();
        }
        private void displaySelection()
        {
            //Create an array of strings for a varried result each click.
            string[] choiceText = new string[] { "     We've scrubbed all 14,000,605 realities for the best possible outcome.     ", "     We've passed word around the office. We've got something you'll like.     ", "     Every day is an adventure; today especially.     ", "     This option is scientifically proven to cure your frustrations.     ", "     We're excited about this one in particular.     ", "     We outsourced this one to the magic eight ball.     ", "     The heavens parted, and delivered this message:     ", "     Food? This is where you're going to need to go.     ", "     Our cutting edge algorithms have chosen specifically for you.     ", "     The deliciousness from this suggestion almost broke our servers (just kidding. We don't use servers).     " };

            //Start a random number object.
            Random rnd = new Random();
            int i = rnd.Next(0, choiceText.Length);


            //pick a random string from the choiceText array as an opener, and then display the result.
            lblSelection.Text = choiceText[i] + "\r\n\r\nWe think [Selected Option] is just right today.";

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
            showFirstPage();

        }
        private void showFirstPage()
        {
            //Hide every element on the second page
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
            btnDebugRerollText.Visible = false;

            //Show every element on the first page
            lblWelcome.Visible = true;
            lblWelcomeStroke.Visible = true;
            btnRollOption.Visible = true;
            btnViewOptions.Visible = true;
        }
        private void showSecondPage()
        {
            //Hide every element on the first page
            lblWelcome.Visible = false;
            lblWelcomeStroke.Visible = false;
            btnRollOption.Visible = false;
            btnViewOptions.Visible = false;
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;

            //Show every element on the second page.
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
            btnDebugRerollText.Visible = true;
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

        private void btnDebugRerollText_Click(object sender, EventArgs e)
        {
            //Create a 2D to store the restaurant list
            string[,] Restaurants = new string[7, 7];
            //Populate the option "genre's"
            Restaurants[0, 0] = "Asian";
            Restaurants[1, 0] = "Fast Food";
            Restaurants[2, 0] = "Mexican";
            Restaurants[3, 0] = "Seafood";
            Restaurants[4, 0] = "Dessert";
            Restaurants[5, 0] = "Italian";
            Restaurants[6, 0] = "Pizza";

            //Populate the restaurant names for each of the categories

            Restaurants[0, 1] = "Panda Express";
            Restaurants[0, 2] = "Noodles && Company";
            Restaurants[0, 3] = "Buffet King";
            Restaurants[0, 4] = "Wasabi Wok";
            Restaurants[0, 5] = "The Great Wall";
            Restaurants[0, 6] = "Coco China";

            Restaurants[1, 1] = "McDonalds";
            Restaurants[1, 2] = "Burger King";
            Restaurants[1, 3] = "Arbys";
            Restaurants[1, 4] = "Wendy's";
            Restaurants[1, 5] = "Subway";

            Restaurants[2, 1] = "Taco Bell";
            Restaurants[2, 2] = "Taco Casa";
            Restaurants[2, 3] = "Casa Torres";
            Restaurants[2, 4] = "Dos Chiles";

            Restaurants[3, 1] = "Long John Silvers";
            Restaurants[3, 2] = "Zeke's Fish And Chips";

            Restaurants[4, 1] = "Dairy Queen";
            Restaurants[4, 2] = "Braums";

            Restaurants[5, 1] = "Olive Garden";
            Restaurants[5, 2] = "Fazolis";

            Restaurants[6, 1] = "Pizza Hut";
            Restaurants[6, 2] = "Papa Johns";
            Restaurants[6, 3] = "Dominos";
            Restaurants[6, 4] = "Hungry Howies";
            Restaurants[6, 5] = "Little Caesars";
            Restaurants[6, 6] = "Cici's Pizza";

            //Create an array to store the option names for the label text randomizer (note that it does not contain category names)
            string[] optionNameStrings = new string[]
            {
                Restaurants[0, 1],
                Restaurants[0, 2],
                Restaurants[0, 3],
                Restaurants[0, 4],
                Restaurants[0, 5],
                Restaurants[0, 6],
                Restaurants[1, 1],
                Restaurants[1, 2],
                Restaurants[1, 3],
                Restaurants[1, 4],
                Restaurants[1, 5],
                Restaurants[2, 1],
                Restaurants[2, 2],
                Restaurants[2, 3],
                Restaurants[2, 4],
                Restaurants[3, 1],
                Restaurants[3, 2],
                Restaurants[4, 1],
                Restaurants[4, 2],
                Restaurants[5, 1],
                Restaurants[5, 2],
                Restaurants[6, 1],
                Restaurants[6, 2],
                Restaurants[6, 3],
                Restaurants[6, 4],
                Restaurants[6, 5],
                Restaurants[6, 6],
            };
            //Create a random number object
            Random rnd = new Random();
            //Store a random selection from the Restaraunt array above into a temp variable. Makes sure each entry is unique.
            int i1 = rnd.Next(0, optionNameStrings.Length);
            int i = rnd.Next(0, optionNameStrings.Length);
            while (i == i1)
                i = rnd.Next(0, optionNameStrings.Length);
            int i2 = i;
            while ((i == i1) || (i == i2))
                i = rnd.Next(0, optionNameStrings.Length);
            int i3 = i;
            while ((i == i1) || (i == i2) || (i == i3))
                i = rnd.Next(0, optionNameStrings.Length);
            int i4 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4))
                i = rnd.Next(0, optionNameStrings.Length);
            int i5 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4) || (i == i5))
                i = rnd.Next(0, optionNameStrings.Length);
            int i6 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4) || (i == i5) || (i == i6))
                i = rnd.Next(0, optionNameStrings.Length);
            int i7 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4) || (i == i5) || (i == i6) || (i == i7))
                i = rnd.Next(0, optionNameStrings.Length);
            int i8 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4) || (i == i5) || (i == i6) || (i == i7) || (i == i8))
                i = rnd.Next(0, optionNameStrings.Length);
            int i9 = i;
            while ((i == i1) || (i == i2) || (i == i3) || (i == i4) || (i == i5) || (i == i6) || (i == i7) || (i == i8) || (i == i9))
                i = rnd.Next(0, optionNameStrings.Length);
            int i10 = i;
            //Assign label text to the option name in their associated variable.
            lblOption1Name.Text = optionNameStrings[i1];
            lblOption2Name.Text = optionNameStrings[i2];
            lblOption3Name.Text = optionNameStrings[i3];
            lblOption4Name.Text = optionNameStrings[i4];
            lblOption5Name.Text = optionNameStrings[i5];
            lblOption6Name.Text = optionNameStrings[i6];
            lblOption7Name.Text = optionNameStrings[i7];
            lblOption8Name.Text = optionNameStrings[i8];
            lblOption9Name.Text = optionNameStrings[i9];
            lblOption10Name.Text = optionNameStrings[i10];
        }
    }
}