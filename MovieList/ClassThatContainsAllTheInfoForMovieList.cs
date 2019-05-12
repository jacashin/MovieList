using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    public class ClassThatContainsAllTheInfoForMovieList
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        
    }
}
