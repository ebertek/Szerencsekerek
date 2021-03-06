﻿using System;
// using System.Globalization;

namespace Szerencsekerek
{
    class Shop
    {
        readonly string[] items;
        readonly int[] prices;

        public Shop()
        {
            items = new string[] { "Természetkalauz", "Képes albumok és lexikonok", "Elin Lux grillsütős gáztűzhely", "Ramses édességek", "Camey ajándékcsomag", "Electrolux ZL620 porszívó", "Aroma kávédaráló", "3 darab 195 perces videokazetta", "Neutralia csomag", "Golf Junior fűnyíró" };
            prices = new int[] { 4630, 13710, 49900, 900, 2500, 14900, 1299, 1080, 3000, 16490 };

        }
        public string Item(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                return items[index];
            }
            return "";
        }
        public int Price(int index)
        {
            if (index >= 0 && index < prices.Length)
            {
                return prices[index];
            }
            return 0;
        }
        public void Buy(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                items[index] = "";
                prices[index] = 0;
            }
        }
        public int LowestPrice()
        {
            int min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > 0 && prices[i] < min)
                {
                    min = prices[i];
                }
            }
            return min;
        }
        public int Length()
        {
            return items.Length;
        }
        public override string ToString()
        {
            string ListOfItems = "";
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != "")
                {
                    ListOfItems += (i + 1) + ") " + items[i] + ", " + String.Format(Global.CI, "{0:C0}", prices[i]) + Environment.NewLine;
                }
            }
            return ListOfItems;
        }
    }
}
