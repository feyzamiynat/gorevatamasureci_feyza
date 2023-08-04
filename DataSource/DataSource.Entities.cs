using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace gorevatamasureci_feyza.DataSources
{
   ///RequestEntities
  public class Flow1_ProcessItemsRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public List<object> Users { get; set; }

public List<object> Positions { get; set; }

public System.Int64 Skip { get; set; }

public System.Int64 Take { get; set; }

public System.String Culture { get; set; }

public System.Int64 ProcessType { get; set; }

public System.DateTime EndDate { get; set; }

public System.DateTime StartDate { get; set; }

public System.String FlowName { get; set; }

public System.String ProjectName { get; set; }

public System.Int64 RequestId { get; set; }
    }

public class DataSource_PersonelBilgileriRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.String PDEPID { get; set; }

public System.String USERID { get; set; }
    }

public class getcolumnsRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        
    }
}