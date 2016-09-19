using System.Linq;

namespace _06_Book_Titles
{
    internal class Book
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                string[] skiplist = { "the", "a", "an", "and", "over", "in", "of" };
                string[] words = value.Split(' ');
                string newtitle = "";
                bool first = true;
                foreach (string word in words)
                {
                    if (first || !skiplist.Contains(word))
                    {
                        newtitle += char.ToUpper(word[0]) + word.Substring(1) + " ";
                    }
                    else
                    {
                        newtitle += word + " ";
                    }
                    first = false;
                }
                newtitle = newtitle.Trim();
                this._title = newtitle;
            }
        }
        
    }
}