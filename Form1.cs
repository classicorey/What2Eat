using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Threading;
using System.Reflection.Emit;
using BackendRestaurants;

namespace What2Eat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "What2Eat";
            //Place first screen elements in their proper places
            lblWelcome.Top = this.Top + 30;
            lblWelcomeStroke.AutoSize = false;
            lblWelcomeStroke.Top = lblWelcome.Top - 2;
            lblWelcomeStroke.Height = lblWelcome.Height + 4;
            btnRollOption.Top = lblWelcome.Top + lblWelcome.Height + 20;
            btnViewOptions.Top = btnRollOption.Top;
            lblSelection.Top = btnViewOptions.Top + btnViewOptions.Height + 30;
            lblSelectionStroke.Top = lblSelection.Top - 2;

            int formWidth = this.Width;
            int perfectOffset = (formWidth - lblWelcome.Width) / 2;
            lblWelcome.Left = perfectOffset;
            lblWelcomeStroke.Left = lblWelcome.Left - 2;
            lblWelcomeStroke.AutoSize = false;
            lblWelcomeStroke.Width = lblWelcome.Width + 4;
            perfectOffset = (formWidth - (btnRollOption.Width + btnViewOptions.Width + 6)) / 2;
            btnRollOption.Left = perfectOffset - 6;
            btnViewOptions.Left = perfectOffset + btnRollOption.Width + 6;

            //Place second screen elements into their proper places
            perfectOffset = (this.Width - lblOptionsWelcome.Width) / 2;
            lblOptionsWelcome.Left = perfectOffset;
            lblOptionsWelcomeStroke.Left = lblOptionsWelcome.Left - 2;
            lblOptionsWelcomeStroke.Top = lblOptionsWelcome.Top - 2;
            lblOptionsWelcomeStroke.Width = lblOptionsWelcome.Width + 4;
            lblOptionsWelcomeStroke.Height = lblOptionsWelcome.Height + 4;

            btnBack.Left = (perfectOffset / 2) - (btnBack.Width / 2);
            //     lay the groundwork for button size, location
            lblOption1.Left = btnBack.Left + btnBack.Width;
            lblOption1.Top = lblWelcome.Top + lblWelcome.Height + 5;
            lblOption1Stroke.Top = lblOption1.Top - 2;
            lblOption1Stroke.Height = lblOption1.Height + 4;
            lblOption1Stroke.Left = lblOption1.Left - 2;
            lblOption1Stroke.Width = lblOption1.Width + 4;
            btnDebugRerollText.Left = this.Width - (perfectOffset / 2) - (btnDebugRerollText.Width / 2);
            btnDebugRerollText.Top = btnBack.Top;
            int optionVertSpacing = lblOption1.Height + 5;
            int optionColumnSpacing = lblOption1.Width + 15;

            lblOption1Name.Left = lblOption1.Left + optionColumnSpacing;
            lblOption1Name.Top = lblOption1.Top;
            lblOption1Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption1Name, lblOption1NameStroke);

            //     place each element in their correct location for option numbers.
            lblOption2.Left = lblOption1.Left;
            lblOption2.Top = lblOption1.Top + optionVertSpacing;
            lblOption2Stroke.Top = lblOption2.Top - 2;
            lblOption2Stroke.Left = lblOption2.Left - 2;
            lblOption2Stroke.Width = lblOption2.Width + 4;
            lblOption2Stroke.Height = lblOption2.Height + 4;

            lblOption2Name.Left = lblOption1Name.Left;
            lblOption2Name.Top = lblOption2.Top;
            lblOption2Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption2Name, lblOption2NameStroke);

            lblOption3.Left = lblOption2.Left;
            lblOption3.Top = lblOption2.Top + optionVertSpacing;
            lblOption3Stroke.Top = lblOption3.Top - 2;
            lblOption3Stroke.Left = lblOption3.Left - 2;
            lblOption3Stroke.Width = lblOption3.Width + 4;
            lblOption3Stroke.Height = lblOption3.Height + 4;

            lblOption3Name.Left = lblOption2Name.Left;
            lblOption3Name.Top = lblOption3.Top;
            lblOption3Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption3Name, lblOption3NameStroke);

            lblOption4.Left = lblOption3.Left;
            lblOption4.Top = lblOption3.Top + optionVertSpacing;
            lblOption4Stroke.Top = lblOption4.Top - 2;
            lblOption4Stroke.Left = lblOption4.Left - 2;
            lblOption4Stroke.Width = lblOption4.Width + 4;
            lblOption4Stroke.Height = lblOption4.Height + 4;

            lblOption4Name.Left = lblOption3Name.Left;
            lblOption4Name.Top = lblOption4.Top;
            lblOption4Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption4Name, lblOption4NameStroke);

            lblOption5.Left = lblOption4.Left;
            lblOption5.Top = lblOption4.Top + optionVertSpacing;
            lblOption5Stroke.Top = lblOption5.Top - 2;
            lblOption5Stroke.Left = lblOption5.Left - 2;
            lblOption5Stroke.Width = lblOption5.Width + 4;
            lblOption5Stroke.Height = lblOption5.Height + 4;

            lblOption5Name.Left = lblOption4Name.Left;
            lblOption5Name.Top = lblOption5.Top;
            lblOption5Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption5Name, lblOption5NameStroke);

            lblOption6.Left = lblOption5.Left;
            lblOption6.Top = lblOption5.Top + optionVertSpacing;
            lblOption6Stroke.Top = lblOption6.Top - 2;
            lblOption6Stroke.Left = lblOption6.Left - 2;
            lblOption6Stroke.Width = lblOption6.Width + 4;
            lblOption6Stroke.Height = lblOption6.Height + 4;

            lblOption6Name.Left = lblOption5Name.Left;
            lblOption6Name.Top = lblOption6.Top;
            lblOption6Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption6Name, lblOption6NameStroke);

            lblOption7.Left = lblOption6.Left;
            lblOption7.Top = lblOption6.Top + optionVertSpacing;
            lblOption7Stroke.Top = lblOption7.Top - 2;
            lblOption7Stroke.Left = lblOption7.Left - 2;
            lblOption7Stroke.Width = lblOption7.Width + 4;
            lblOption7Stroke.Height = lblOption7.Height + 4;

            lblOption7Name.Left = lblOption6Name.Left;
            lblOption7Name.Top = lblOption7.Top;
            lblOption7Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption7Name, lblOption7NameStroke);

            lblOption8.Left = lblOption7.Left;
            lblOption8.Top = lblOption7.Top + optionVertSpacing;
            lblOption8Stroke.Top = lblOption8.Top - 2;
            lblOption8Stroke.Left = lblOption8.Left - 2;
            lblOption8Stroke.Width = lblOption8.Width + 4;
            lblOption8Stroke.Height = lblOption8.Height + 4;

            lblOption8Name.Left = lblOption7Name.Left;
            lblOption8Name.Top = lblOption8.Top;
            lblOption8Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption8Name, lblOption8NameStroke);

            lblOption9.Left = lblOption8.Left;
            lblOption9.Top = lblOption8.Top + optionVertSpacing;
            lblOption9Stroke.Top = lblOption9.Top - 2;
            lblOption9Stroke.Left = lblOption9.Left - 2;
            lblOption9Stroke.Width = lblOption9.Width + 4;
            lblOption9Stroke.Height = lblOption9.Height + 4;

            lblOption9Name.Left = lblOption8Name.Left;
            lblOption9Name.Top = lblOption9.Top;
            lblOption9Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption9Name, lblOption9NameStroke);

            lblOption10.Left = lblOption9.Left - 8;
            lblOption10.Top = lblOption9.Top + optionVertSpacing;
            lblOption10Stroke.Top = lblOption10.Top - 2;
            lblOption10Stroke.Left = lblOption10.Left - 2;
            lblOption10Stroke.Width = lblOption10.Width + 4;
            lblOption10Stroke.Height = lblOption10.Height + 4;

            lblOption10Name.Left = lblOption9Name.Left;
            lblOption10Name.Top = lblOption10.Top;
            lblOption10Name.SizeChanged += (s, ev) => AdjustAutoSizeLabelStroke(lblOption10Name, lblOption10NameStroke);


            this.BackColor = ColorTranslator.FromHtml("#CCBFCA");
            lblWelcome.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblWelcome.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblWelcome.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblWelcomeStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;
            lblSelection.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblSelection.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblSelection.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblSelectionStroke.BackColor = ColorTranslator.FromHtml("#959595");


            btnRollOption.FlatStyle = FlatStyle.Flat;
            btnRollOption.FlatAppearance.BorderSize = 3;
            btnRollOption.BackColor = ColorTranslator.FromHtml("#B98DA1");
            btnRollOption.ForeColor = ColorTranslator.FromHtml("#4C3B43");

            btnViewOptions.FlatStyle = FlatStyle.Flat;
            btnViewOptions.FlatAppearance.BorderSize = 3;
            btnViewOptions.BackColor = ColorTranslator.FromHtml("#B98DA1");
            btnViewOptions.ForeColor = ColorTranslator.FromHtml("#4C3B43");

            //Set aesthetic properties for second screen elements
            lblOptionsWelcome.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOptionsWelcome.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOptionsWelcome.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOptionsWelcomeStroke.BackColor = ColorTranslator.FromHtml("#959595");

            lblOption1.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption1.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption1.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption1Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption1Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption1Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption1Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption1Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption1NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption1NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption2.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption2.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption2.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption2Stroke.BackColor = ColorTranslator.FromHtml("#959595"); ;
            lblOption2Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption2Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption2Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption2Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption2NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption2NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption3.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption3.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption3.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption3Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption3Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption3Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption3Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption3Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption3NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption3NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption4.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption4.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption4.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption4Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption4Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption4Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption4Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption4Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption4NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption4NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption5.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption5.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption5.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption5Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption5Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption5Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption5Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption5Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption5NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption5NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption6.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption6.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption6.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption6Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption6Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption6Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption6Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption6Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption6NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption6NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption7.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption7.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption7.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption7Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption7Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption7Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption7Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption7Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption7NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption7NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption8.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption8.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption8.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption8Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption8Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption8Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption8Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption8Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption8NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption8NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption9.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption9.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption9.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption9Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption9Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption9Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption9Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption9Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption9NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption9NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption10.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption10.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption10.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption10Stroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption10Stroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            lblOption10Name.BackColor = ColorTranslator.FromHtml("#C5B3CC");
            lblOption10Name.ForeColor = ColorTranslator.FromHtml("#4F4F4F");
            lblOption10Name.Font = new Font("Helvetica", lblWelcome.Font.Size);
            lblOption10NameStroke.BackColor = ColorTranslator.FromHtml("#959595");
            lblOption10NameStroke.Font = new Font("Helvetica", lblWelcome.Font.Size);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.BackColor = ColorTranslator.FromHtml("#B98DA1");
            btnBack.ForeColor = ColorTranslator.FromHtml("#4C3B43");

            btnDebugRerollText.FlatStyle = FlatStyle.Flat;
            btnDebugRerollText.FlatAppearance.BorderSize = 3;
            btnDebugRerollText.BackColor = ColorTranslator.FromHtml("#B98DA1");
            btnDebugRerollText.ForeColor = ColorTranslator.FromHtml("#4C3B43");

            //Show and Hide Elements for startup


            //Set default text [depreciated]
            lblWelcome.Text = "Welcome in!\r\nHope you're hungry!\r\n\r\nWe have a few options for you to choose from.";
            showFirstPage();
        }

        private void btnRollOption_Click(object sender, EventArgs e)
        {

            displaySelection();

        }

        private void btnViewOptions_Click(object sender, EventArgs e)
        {
            showSecondPage();
        }
        private void displaySelection()
        {

            string[] choiceText = new string[] { "     We've scrubbed all 14,000,605 realities for the best possible outcome.     ", "     We've passed word around the office. We've got something you'll like.     ", "     Every day is an adventure; today especially.     ", "     This option is scientifically proven to cure your frustrations.     ", "     We're excited about this one in particular.     ", "     We outsourced this one to the magic eight ball.     ", "     The heavens parted, and delivered this message:     ", "     Food? This is where you're going to need to go.     ", "     Our cutting edge algorithms have chosen specifically for you.     ", "     The deliciousness from this suggestion almost broke our servers (just kidding. We don't use servers).     " };

            Random rnd = new Random();
            int i = rnd.Next(0, choiceText.Length);



            lblSelection.Text = choiceText[i] + "\r\n\r\nWe think [Selected Option] is just right today.";

            int formWidth = this.Width;
            int perfectOffset = (formWidth - lblSelection.Width) / 2;

            //Align the suggestion box centered on the form.
            lblSelectionStroke.Width = lblSelection.Width + 4;
            lblSelection.Left = perfectOffset;
            lblSelectionStroke.Left = perfectOffset - 2;
            lblSelection.Visible = true;
            lblSelectionStroke.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showFirstPage();

        }
        private void showFirstPage()
        {
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

            lblWelcome.Visible = true;
            lblWelcomeStroke.Visible = true;
            btnRollOption.Visible = true;
            btnViewOptions.Visible = true;
        }
        private void showSecondPage()
        {
            lblWelcome.Visible = false;
            lblWelcomeStroke.Visible = false;
            btnRollOption.Visible = false;
            btnViewOptions.Visible = false;
            lblSelection.Visible = false;
            lblSelectionStroke.Visible = false;

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
            strokeLabel.Location = new Point(mainLabel.Location.X - 2, mainLabel.Location.Y - 2);
            strokeLabel.Width = mainLabel.Width + 4;
            strokeLabel.Height = mainLabel.Height + 4;
        }

        private void btnDebugRerollText_Click(object sender, EventArgs e)
        {
            string[] optionNameStrings = new string[]
            {
                /*"Option 1",
                "A generic option.",
                "This is option 3.",
                "Short option.",
                "A long option with more text",
                "Option number 6.",
                "Option 7 here",
                "We have room for Option 8",
                "Another option",
                "Option 10 with extra text.",
                "Option 11 can go here.",
                "Option 12 can go here if you would like",
                "Option 13 is a great choice.",
                "Option 14 with a lot of text",
                "Short",
                "Option 16 isn't particularly long.",
                "Option 17 with additional text",
                "Option 18 is a great one too",
                "Option 19 will knock your socks off here.",
                "A very long option with a lot of text to make it longer than the others",
                "Option 21 is different",
                "Option 22 is also different",
                "Option 23 is quite long",
                "Option 24 is unique",
                "Option 25 can have a really long name, but not longer than 20.",
                "Option 26 is definitely not the longest option that we have.",
                "Option 27 is a weird one. Kinda like My parent's dog Charlie. She's a cutie.",
                "Option 28 short",
                "Option 29 is pretty crazy. It's kinda up there in length.",
                "The last option!"*/
                Restaurants[0, 0],
                Restaurants[1, 0],
                Restaurants[2, 0],
                Restaurants[3, 0],
                Restaurants[4, 0],
                Restaurants[5, 0],
                Restaurants[6, 0],
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
            Random rnd = new Random();
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