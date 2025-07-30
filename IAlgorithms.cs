using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface IAlgorithm<AlgorithmInput, AlgorithmResult> // googled the syntax 
    {
        AlgorithmResult RunAlgorithm(AlgorithmInput input);
    }

}
