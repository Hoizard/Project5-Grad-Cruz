using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3
{
    public interface IIOHelper
    {
        List<string> ListAllMortgages();
        void AddMortgages(string formattedTempString);
        void ClearAllMortgages();
    }
}