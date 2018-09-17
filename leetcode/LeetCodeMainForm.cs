using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using leetcode.problems;

namespace leetcode
{
    public partial class LeetCodeMainForm : Form
    {
        public LeetCodeMainForm()
        {
            InitializeComponent();
        }

        private async void GetMoviesButton_Click(object sender, EventArgs e)
        {
            string[] titles = await GetMovies.getAsyncMovieTitles("spiderman");
        }

        private void CoderpadSquareButton_Click(object sender, EventArgs e)
        {
            string inputRepresentation = "a->b;b->c;c->d;b->d";
            Graph_ListParents test = new Graph_ListParents();
            String result = test.Parse(inputRepresentation);
            ResultsTextBox.Text = result;
        }

        private void CodilityCantaloupeButton_Click(object sender, EventArgs e)
        {

        }

        private void FizzBuzzButton_Click(object sender, EventArgs e)
        {
            leetcode.problems.FizzBuzz fb = new FizzBuzz();

            string s = fb.run(50);
            string s2 = fb.withoutRemainderOperator(50);
            ResultsTextBox.Text = s + Environment.NewLine + s2;
        }
    }
}
