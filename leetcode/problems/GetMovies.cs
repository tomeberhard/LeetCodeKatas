using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
//using System.Threading.Tasks;
using Newtonsoft.Json;

namespace leetcode.problems
{
    using System.Threading.Tasks;

    /*
    public class Movie
    {
        public string Poster;
        public string Title;
        public string Type;
        public int Year;
        public string imdbID;
    }
    */

    public class GetMovies
    {
        public static async Task<string[]> getAsyncMovieTitles(string substr)
        {
            List<string> movies = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                // TODO: get the page count, don't just request pages until there's no more pages
                bool oneMorePage = true;
                int page = 1;

                while (oneMorePage)
                {
                    // TODO: encode substr to handle spaces and other characters
                    string searchString = substr + "&page=" + page.ToString();
                    
                    string uri = @"https://jsonmock.hackerrank.com/api/movies/search/?Title=" + searchString;

                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();

                        // TODO: get better at using Newtonsoft and LINQ.
                        // I looked at https://stackoverflow.com/questions/13839865/how-to-parse-my-json-string-in-c4-0using-newtonsoft-json-package for inspiration
                        dynamic dynObj = JsonConvert.DeserializeObject(jsonContent);

                        int moviesAdded = 0;
                        foreach (var movie in dynObj.data)
                        {
                            try
                            {
                                movies.Add(movie.Title.ToString());
                                moviesAdded++;
                            }
                            catch (Exception ex)
                            {
                                // TODO: add logging
                            }
                        }
                        if ( moviesAdded == 0)
                        {
                            oneMorePage = false;
                        }
                        page++;
                    }
                    else
                    {
                        oneMorePage = false;
                    }
                }
            }

            movies.Sort();
            return movies.ToArray();
        }
    }
}
