using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Abstraction;

namespace WildFarm.Models
{
    public class Fruit : Food
    {
        public Fruit(int quantity) 
            : base(quantity)
        {
        }
    }
}
