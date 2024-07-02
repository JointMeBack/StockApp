﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class ComboItem
    {
        public int Id {  get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
        public ComboItem(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }

    
}
