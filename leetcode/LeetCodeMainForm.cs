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
    }
}
