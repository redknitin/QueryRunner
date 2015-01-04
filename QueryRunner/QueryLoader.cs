using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace QueryRunner
{
    /// <summary>
    /// Loads the queries
    /// </summary>
    class QueryLoader
    {
        /// <summary>
        /// Loads the queries from the XML file
        /// </summary>
        /// <param name="aXmlFileName"></param>
        /// <returns></returns>
        public static QueryModel[] LoadXml(string aXmlFileName = "Queries.xml")
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(aXmlFileName);
            var queryNodes = xmldoc.GetElementsByTagName("query");

            List<QueryModel> lstQueries = new List<QueryModel>();

            foreach (var iterNode in queryNodes)
            {
                var iterNodeObj = (XmlElement)iterNode;
                string iterName = iterNodeObj.Attributes["name"].Value;
                string iterSql = iterNodeObj.InnerText.Trim();
                lstQueries.Add(new QueryModel() { 
                    Name = iterName,
                    SQL = iterSql
                });
            }

            return lstQueries.ToArray();
        }
    }
}
