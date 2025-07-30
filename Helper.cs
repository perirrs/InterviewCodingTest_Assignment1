using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Helper
    {

        //global Fields & properties

        private string algorithmname;
        public string AlgorithmName
        {
            get => algorithmname;
            set => algorithmname = value;
        }

        private double algorithmvalue1;
        public double AlgorithmValue1
        {
            get => algorithmvalue1;
            set => algorithmvalue1 = value;
        }

        private double algorithmvalue2;
        public double AlgorithmValue2
        {
            get => algorithmvalue2;
            set => algorithmvalue2 = value;
        }

    }
}
