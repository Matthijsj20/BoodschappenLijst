using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boodschappen_lijst
{
    public class Boodschap
    {
        public string Item;
        public int Amount;
        public Boodschap(string item, int amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
