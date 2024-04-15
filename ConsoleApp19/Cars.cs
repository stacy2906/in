using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Cars: IComparable<Cars>
    {
        public int Ident { set; get; }
        public string Mark { set; get; }
        public int MaxSpeed { set; get; }
        public double Price { set; get; }
        public double Sale { set; get; }

        public Cars()
        {
            this.Ident = Ident;
            this.Mark = Mark;
            this.MaxSpeed = MaxSpeed;
            this.Price = Price;
            this.Sale = Sale;
        }


        public int CompareTo(Cars price)
        {
            return Price.CompareTo(price.Price);
        }

    }
}
