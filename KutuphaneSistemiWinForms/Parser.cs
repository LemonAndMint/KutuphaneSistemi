using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using KutuphaneSistemi.SystemData;

namespace KutuphaneSistemi
{
    public static class Parser
    {
        //Bu parser kendisine gonderilen verileri AND sql querisine donusturur. \ Corpyr.
        public static String unparseAdd<T>(List<String> variableNames, List<String> searchValues) where T: Data
        {
            if(variableNames.Count != searchValues.Count)
            {
                new ArgumentOutOfRangeException("Parser degiskenleri ayni buyuklukte degil!");
                return null;
            }

            String tableName = typeof(T).Name.ToLower();

            String query = "select * from " + tableName + " where";

            for(int i = 0; i <= variableNames.Count() - 2; i++)
            {
                string tempQueryPiece = " " + variableNames[i] + "=" + "\"" + searchValues[i] + "\" " + "and";
                query += tempQueryPiece;
            }

            {
                query += " " + variableNames[variableNames.Count - 1] + "=" + "\"" + searchValues[searchValues.Count - 1] + "\";";
            }

            Debug.WriteLine(query);

            return query;
        
        }

    }
}
