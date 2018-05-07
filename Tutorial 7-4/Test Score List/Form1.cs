using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class frmTestScoreList : Form
    {
        public frmTestScoreList()
        {
            InitializeComponent();
        }

        private void btnGetScores_Click(object sender, EventArgs e)
        {       //Code for the Get Scores button.

            //A list is first created to hold the test values.
            List<int> scores = new List<int>();

            //The test values are retrieved and put into said list using a method defined later on.
            ReadScores(scores);

            //The test values are put into the list box via method.
            DisplayScores(scores);

            //The average is retrieved via method and put into a variable. The value of the variable is displayed in the appropriate control.
            double avgScore = Average(scores);
            lblAverage.Text = avgScore.ToString("n1");

            //The number of tests below average is retrieved via method. Same as the previous one.
            int testsBelow = BelowAverage(scores);
            lblBelowAverage.Text = testsBelow.ToString();

            //Same as test below average, except this time it's done with tests above average.
            int testsAbove = AboveAverage(scores);
            lblAboveAverage.Text = testsAbove.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {       //Exit button.
            Close();
        }

        private void ReadScores(List<int> scoresList)
        {       //Code for the ReadScores method.
            try
            {       //Data source for the list is set to the text file in the Debug folder.
                StreamReader inputFile = File.OpenText(@"..\..\..\..\..\ChapSevenHomework\Test Scores\TestScores.txt");

                //All lines of the text file are put into the list object that is provided.
                while (!inputFile.EndOfStream)
                {
                    scoresList.Add(int.Parse(inputFile.ReadLine()));
                }

                //The StreamReader is then closed.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayScores(List<int> scoresList)
        {       //Code for the DisplayScores method.

            //Super simple: all scores in whatever is put into this is then put into the list box on the form.
            foreach (int score in scoresList)
            {
                lbTestScores.Items.Add(score);
            }


        }

        
        private double Average(List<int> scoresList)
        {       //Code for the Average method.

            //A variable to hold the total is created.
            int total = 0;
            
            //Essentially just adds up all of the test scores.
            foreach (int score in scoresList)
            {
                total += score;
            }

            //That total is then divided by the number of scores there are, and that value is a new variable that is then returned.
            double average = (double)total / scoresList.Count;

            return average;

        }

        private int AboveAverage(List<int> scoresList)
        {       //Code for the AboveAverage method.

            //A variable to count how many tests were above average, and a variable to hold what the average is, are created.
            int testsAbove = 0;
            double avg = Average(scoresList);

            //Then each score is checked, and if that test score is above the average, the test counter increments.
            foreach (int score in scoresList)
            {
                if (score > avg)
                {
                    testsAbove++;
                }

            }


            return testsAbove;
        }

        private int BelowAverage(List<int> scoresList)
        {       //Code for the BelowAverage method.

            //Does the same thing as AboveAverage, but increments if the test score is below the average.
            int testsBelow = 0;
            double avg = Average(scoresList);

            foreach (int score in scoresList)
            {
                if (score < avg)
                {
                    testsBelow++;
                }
            }

            return testsBelow;
        }


    }
}
