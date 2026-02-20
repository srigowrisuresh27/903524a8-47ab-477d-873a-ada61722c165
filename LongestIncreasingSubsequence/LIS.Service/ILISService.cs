using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Service
{
    public interface ILISService
    {
        IReadOnlyList<int> GetLongestIncreasingSubsequence(string input);
    }
}
