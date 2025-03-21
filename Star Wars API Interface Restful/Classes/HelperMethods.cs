using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Star_Wars_API_Interface_Restful.Classes
{
    internal class HelperMethods
    {
        public string GetPlanetFilterText(Classes.Planet c, String[] Where, string optionalOrderBy= "")
        {
            string filteredResult = $"from s in c{System.Environment.NewLine}";
            for (int i = 0; i < Where.Length; i++)
            {
                filteredResult += $"{Where[i]} {System.Environment.NewLine}";
            }
            if (optionalOrderBy.Length != 0)
            {
                filteredResult += $"{optionalOrderBy}.OrderBy(n => n){System.Environment.NewLine}";
            }
            filteredResult += "select s;";

            return filteredResult;

        }

    }
}
