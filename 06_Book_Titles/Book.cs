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
                
                //_title = char.ToUpper(_title[0])+_title.Substring(1);
                this._title = "Infernal";
            }
        }
        
    }
}