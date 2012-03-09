using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterKata
{
    public class PriceCalculator
    {
        public double Calculate(int[] basket)
        {
            BookSets sets = new BookSets();
            //loop through the various versions in the basket
            for (int i = 0; i < basket.Length; i++)
            
                //loop through the copies of the same version
                for (int j = 0; j < basket[i]; j++)
                    sets.AddBookToBestBookset(i);

            return sets.BestPrice();
        }
    }
}
