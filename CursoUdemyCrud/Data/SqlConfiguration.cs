using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoUdemyCrud.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration(string cnnString) => _cnnString = cnnString;

            public string _cnnString { get;  }    

    }

}
