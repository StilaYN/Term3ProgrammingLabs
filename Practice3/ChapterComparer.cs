using System.Collections;
using System.Collections.Generic;

namespace Practice3
{
    public class ChapterComparer:IComparer<Chapter>
    {
        public int Compare(Chapter o1, Chapter o2)
        {
            if (o1.ChapterName.Length > o2.ChapterName.Length) return 1;
            else if (o1.ChapterName.Length < o2.ChapterName.Length) return -1;
            else return 0;
        }
    }
}