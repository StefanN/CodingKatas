using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterKata
{
    public class BookSet
    {
        private const double C_NORMALPRICE = 8;
        private double[] _discountTable = new double[] { 0d, 0d, 0.05d, 0.10d, 0.20d, 0.25d };

        private int[] _set;
        public BookSet()
        {
            _set = new int[5]; //magic number!!!!!!!
        }
        
        public void AddBook(int index)
        {
            _set[index]++;
        }

        public bool DoesNotContainBook(int index)
        {
            return (_set[index] == 0);
        }

        public double CalculatePrice()
        {
            int numberOfBooks = 0;
            for (int i = 0; i < _set.Length; i++)
                if (_set[i] > 0)
                    numberOfBooks++;
            return C_NORMALPRICE * numberOfBooks * (1 - _discountTable[numberOfBooks]);
        }
       
        public BookSet Clone()
        {
            BookSet set = new BookSet();
            for (int i = 0; i < _set.Length; i++)
                if (_set[i] > 0)
                    set.AddBook(i);
            return set;
        }
    }
}
