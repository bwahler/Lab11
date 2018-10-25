using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        public Movie()
        {
        }
        public Movie(string title, string category)
        {
            movieTitle = title;
            movieCategory = category;
        }


        private string movieTitle;
        public string MovieTitle
        {
            get
            {
                return movieTitle;
            }
            set
            {
                movieTitle = value;
            }
        }
        private string movieCategory;
        public string MovieCategory
        {
            get
            {
                return movieCategory;
            }
            set
            {
                movieCategory = value;
            }
        }
    }
}
