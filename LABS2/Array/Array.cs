﻿using System;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace Labs2
{
    public class Array
    {
        private int[] _array;//массив целых чисел
        private int _size;//размер массива

        public Array(int size)
        {
            _array = new int[size];
            _size = size;
        }
        public Array(params int[] values)
        {
            _array = values;
            _size = values.Length;
        }

        public int Length => _size;
        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public static Array operator * (Array left, Array right)
        {
            Array array = new Array(Math.Min(left.Length, right.Length));
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = left[i]* right[i];
            }
            return array;
        }
        public static implicit operator int (Array left) => left.Length;
        public static bool operator true(Array left)=> IsAllElementPositive(left);
        public static bool operator false(Array left)=>!IsAllElementPositive(left);
        public static bool operator ==(Array left, Array right) => IsEqual(left, right);
        public static bool operator !=(Array left, Array right) => !IsEqual(left, right);
        public static bool operator <(Array left,Array right)=> IsLower(left, right);
        public static bool operator >(Array left,Array right)=> !IsLower(left, right) && !IsEqual(left,right);

        public static bool IsAllElementPositive(Array left)//Проверяет содержатся ли в массиве только положительные значения 
        {

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] < 0) return false;
            }
            return true;
        }

        public static bool IsEqual(Array left, Array right) //Проверяет на равенство два объекта
        {
            if(left.Length != right.Length) return false;
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i]) return false;
            }
            return false;
        }

        public static bool IsLower(Array left, Array right)//Проверяет все ли элементы первого массива меньше элементов второго массива
        {
            if(IsEqual(left,right)) return false;
            for (int i = 0; i < left.Length || i < right.Length; i++)
            {
                if (left[i] >= right[i]) return false;
            }
            return true;
        }

        
    }
}