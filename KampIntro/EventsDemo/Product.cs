﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock 
        {
            get { return _stock; }
            set 
            {
                _stock = value;
                if (value <= 15 && value >= 0 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }
        public void Sell(int amount)
        {
            Stock -= amount;
            if (Stock > 0)
            {
                Console.WriteLine("{0} Stock amount: {1}", ProductName, Stock);
            }
            else
            {
                Console.WriteLine("{0} Stock bitti" ,ProductName);
            }
        }
    }
}
