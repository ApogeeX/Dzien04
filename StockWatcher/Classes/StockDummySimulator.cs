using System;
using System.Collections;
using System.Collections.Generic;

namespace StockWatcher.Classes
{
    public class StockDummySimulator : IEnumerable<Stock>
    {
        private Random rnd = new Random();
        private string[] names = { "APL", "IBM", "GOG" };
        public IEnumerator<Stock> GetEnumerator()
        {
            Console.WriteLine("Start iterator");
            for (int i = 0; i < 15; i++)
            {
                string ticker = names[rnd.Next(0, names.Length)];
                double val = rnd.Next(1, 101) + rnd.NextDouble();
                yield return new Stock() { Name = ticker, Value = val };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
