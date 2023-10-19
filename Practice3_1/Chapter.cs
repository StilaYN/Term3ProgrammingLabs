using System;

namespace Practice3_1
{
    public class Chapter : IComparable, ICloneable
    {
        private string _chapterName;
        private int _pageNumber;
        public Chapter(string chapterName, int pageNumber)
        {
            _chapterName = chapterName;
            _pageNumber = pageNumber;
        }

        public int CompareTo(object o)
        {
            Chapter chapter = o as Chapter;
            if (chapter != null) return this.ChapterName.CompareTo(chapter.ChapterName);
            else throw new Exception("You cannot compare this object");
        }

        public object Clone() => MemberwiseClone();

        public string ChapterName
        {
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Wrong chapter name,Empty string");
                }
                _chapterName = value;
            }
            get => _chapterName;
        }

        public int PageNumber
        {

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong page number,page number can not be less than 0");
                }
                _pageNumber = value;
            }
            get => _pageNumber;
        }
        public override string ToString()
        {
            string outputString = ChapterName + (new string('.', 50 - ChapterName.Length)) + _pageNumber.ToString();
            return outputString;
        }
        public void ShowChapterInformation()//Выводит информацию в формате название количество страниц 
        {
            string outputString = ChapterName + (new string('.', 50 - ChapterName.Length)) + _pageNumber.ToString();
            Console.WriteLine(outputString);
        }
    }
}