using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace QueryRunner
{
    /// <summary>
    /// Model class to hold the query information
    /// </summary>
    public class QueryModel
    {
        /// <summary>
        /// The name assigned to the query
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The actual SQL query string
        /// </summary>
        public string SQL { get; set; }

        /// <summary>
        /// Returns the name of the query model object for display in the dropdown list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
