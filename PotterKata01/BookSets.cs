using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterKata
{
    public class BookSets
    {
        private List<BookSet> _booksets = new List<BookSet>();
        public void AddBookToBestBookset(int index)
        {
            if (_booksets.Count == 0)
            {
                _booksets.Add(CreateNewBookSetContainingBook(index));
                return;
            }

            BookSet bestSetToAddBookTo = GetBestSetToAddBookTo(index);

            if (bestSetToAddBookTo == null)
            {
                _booksets.Add(CreateNewBookSetContainingBook(index));
            }
            else
                bestSetToAddBookTo.AddBook(index);
        }

        private BookSet CreateNewBookSetContainingBook(int index)
        {
            BookSet set = new BookSet();
            set.AddBook(index);
            return set;
        }

        private BookSet GetBestSetToAddBookTo(int index)
        {
            //loop through the current booksets
            //and see what happens if you add it to that specific set
            BookSet bestSetToAddBookTo = null;
            double lowestPrice = 0;

            foreach (BookSet set in _booksets)
                if (set.DoesNotContainBook(index))
                {
                    //this is a candidate to add the book to
                    double priceIfAddedToThisSet = CalculatePriceIfBookWasAddedToSet(set, index);
                    if (lowestPrice == 0)
                    {
                        lowestPrice = priceIfAddedToThisSet;
                        bestSetToAddBookTo = set;
                    }
                    else
                        if (priceIfAddedToThisSet < lowestPrice)
                        {
                            lowestPrice = priceIfAddedToThisSet;
                            bestSetToAddBookTo = set;
                        }
                }

            return bestSetToAddBookTo;
        }

        public double CalculatePriceIfBookWasAddedToSet(BookSet potentialSet, int index)
        {
            double total = 0;
            foreach (BookSet set in _booksets)
                if (set == potentialSet)
                {
                    BookSet copy = potentialSet.Clone();
                    copy.AddBook(index);
                    total += copy.CalculatePrice();
                }
                else
                    total += set.CalculatePrice();
            return total;
        }

        public double CalculatePrice()
        {
            double total = 0;
            foreach (BookSet set in _booksets)
                total += set.CalculatePrice();
            return total;
        }

        public double BestPrice()
        {
            return CalculatePrice();
        }
    }
}
