using System;

namespace Labs2
{
    public static class StringExtension
    {
        public static bool IsSymbolContains(this String str, char symb)//Проверяет на содержание заданного символа в строке
        {
            foreach (var i in str)
            {
                if (i == symb) return true;
            }
            return false;
        }
    }
}