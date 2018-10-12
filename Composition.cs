using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_4
{
    class Composition
    {
        public Flower[] _compositionOfFlowers;
        public double compositionCost;
        public Composition(params Flower [] composition)
        {
            _compositionOfFlowers = composition;
        }
        public double CompositionCost()
        {
            for (int i = 0; i < _compositionOfFlowers.Length; i++)
            {
                compositionCost += _compositionOfFlowers[i]._cost;
            }
            return compositionCost;
        }
        public string CompositionOfFlowers()
        {
            string composition = null;
            for (int i = 0; i < _compositionOfFlowers.Length; i++)
            {
                composition += _compositionOfFlowers[i]._color + " " + _compositionOfFlowers[i]._name + " ";
            }
            return composition;
        }
    }
}
