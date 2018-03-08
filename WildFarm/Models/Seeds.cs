using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Abstraction;

namespace WildFarm.Models
{
    public class Seeds : Food
    {
        public Seeds(int quantity) 
            : base(quantity)
        {
        }
    }
}
