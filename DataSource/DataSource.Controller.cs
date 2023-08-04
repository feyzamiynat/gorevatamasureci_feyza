using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Bimser.Framework.Domain.Option;
using Bimser.Framework.Domain.Option.Filters;
using Bimser.Framework.Domain.Option.Pagination;
using Bimser.Framework.Domain.Option.Sorts;
using System.Collections;
using System.Collections.Generic;

namespace gorevatamasureci_feyza.DataSources 
{
    [Route("apps/gorevatamasureci_feyza/latest/api/DataSource/[action]")]
    [Route("apps/gorevatamasureci_feyza/{v:int:min(1)}/api/DataSource/[action]")]
    [Route("api/DataSource/[action]")]
    [Produces ("application/json")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage) 
        {

        }

        #endregion

        ///Actions
        [HttpPost]
[AcceptVerbs("POST")]
[ActionName("Flow1_ProcessItems")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> Flow1_ProcessItems_Action([FromBody] Flow1_ProcessItemsRequest request)
{
    return await Flow1_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("DataSource_PersonelBilgileri")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> DataSource_PersonelBilgileri_Action([FromBody] DataSource_PersonelBilgileriRequest request)
{
    return await DataSource_PersonelBilgileri(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("getcolumns")]
[NoRequestHeaders]
[NoResponseHeaders]
public async Task<object> getcolumns_Action([FromBody] getcolumnsRequest request)
{
    return await getcolumns(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> Flow1_ProcessItems(Flow1_ProcessItemsRequest request)
{
    string queryContent = "{\"name\":\"Flow1_ProcessItems\",\"connectionId\":\"992ba769-858e-4140-a292-9f883c4dbeae\",\"connectionType\":1,\"description\":{},\"id\":null,\"properties\":{ \"commandText\":\"SELECT MAX(PROCESSES.ID) AS ProcessID,\\nMAX(CONCAT(OSUSERS.FIRSTNAME, ' ', OSUSERS.LASTNAME)) AS 'User',\\nMAX(PROCESSREQUESTS.REQUESTDATE) AS CreateDate,\\nMAX(PROCESSREQUESTS.ID) AS RequestId,\\nMAX(PROJECTFLOWSTATUSESML.CAPTION) AS Caption,\\nMAX(PROJECTS.MOBILEFORMVIEW) AS MobileFormView,\\nMAX(PROJECTCOREPUBLISHMENTS.PACKAGEVERSION) AS PackageVersion,\\nMAX(PROCESSES.CREATEDATE) AS ProcessStartDate\\n FROM PROCESSREQUESTS\\nLEFT  JOIN PROCESSREQUESTDOCUMENTS WITH(NOLOCK) ON PROCESSREQUESTDOCUMENTS.PROCESSREQUESTID = PROCESSREQUESTS.ID\\nLEFT  JOIN DOCUMENTS WITH(NOLOCK) ON DOCUMENTS.ID = PROCESSREQUESTDOCUMENTS.DOCUMENTID\\nINNER JOIN PROCESSES WITH(NOLOCK) ON PROCESSES.ID = PROCESSREQUESTS.PROCESSID\\nINNER JOIN PROJECTS WITH(NOLOCK) ON PROJECTS.ID = PROCESSES.PROJECTID AND PROJECTS.NAME = {{ProjectName}}\\nLEFT  JOIN PROJECTFLOWSTATUSES WITH(NOLOCK) ON PROJECTFLOWSTATUSES.ID = PROCESSES.FLOWSTATUSID\\nLEFT  JOIN PROJECTFLOWSTATUSESML WITH(NOLOCK) ON PROJECTFLOWSTATUSESML.FLOWSTATUSID = PROJECTFLOWSTATUSES.ID AND PROJECTFLOWSTATUSESML.CULTURE = {{Culture}}\\nINNER JOIN OSUSERS WITH(NOLOCK) ON OSUSERS.ID = PROCESSES.USERID\\nINNER JOIN PROJECTFLOWS WITH(NOLOCK) ON PROJECTFLOWS.ID = PROCESSES.FLOWID AND PROJECTFLOWS.NAME = {{FlowName}}\\nINNER JOIN PROJECTCOREDEPLOYMENTS WITH(NOLOCK) ON PROJECTCOREDEPLOYMENTS.ID = PROCESSES.DEPLOYMENTID\\nINNER JOIN PROJECTCOREPUBLISHMENTS WITH(NOLOCK) ON PROJECTCOREPUBLISHMENTS.ID = PROJECTCOREDEPLOYMENTS.PUBLISHMENTID\\nWHERE\\n(\\n({{ProcessType}} = 0 AND ((PROCESSREQUESTS.STATUS=1 AND PROCESSREQUESTS.RESPONSEDATE IS NULL AND ((PROCESSREQUESTS.OWNEDREQUESTID IS NULL) OR (PROCESSREQUESTS.OWNEDREQUESTID=PROCESSREQUESTS.ID))) OR (PROCESSREQUESTS.STATUS = 1 AND (PROCESSREQUESTS.RESPONSEDATE IS NULL))) AND PROCESSES.FINISHDATE IS NULL AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 1 AND (PROCESSREQUESTS.REQUESTTYPE=6 AND PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 2 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 3 AND (PROCESSREQUESTS.STATUS=1 AND PROCESSES.FINISHDATE IS NULL AND PROCESSREQUESTS.REQUESTTYPE=3) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 4 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}))\\nOR\\n({{ProcessType}} = 5 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE IN (2, 3) AND PROCESSREQUESTS.RESPONSEDATE IS NOT NULL) AND PROCESSES.DELETEDATE IS NULL)\\nOR\\n({{ProcessType}} = 6 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=6 ))\\nOR\\n({{ProcessType}} = 7 AND(PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=1))\\nOR\\n({{ProcessType}} = 8 AND (PROCESSREQUESTS.DELETEDFROMLIST=0 AND PROCESSREQUESTS.STATUS=4 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}} AND PROCESSREQUESTS.REQUESTTYPE=2 AND PROCESSREQUESTS.RESPONSEDATE IS NOT NULL))\\nOR\\n({{ProcessType}} = 10 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL AND PROCESSES.FINISHDATE IS NULL)\\nOR\\n({{ProcessType}} = 11 AND (PROCESSREQUESTS.REQUESTTYPE = 1 AND PROCESSREQUESTS.DELETEDFROMLIST = 0 AND PROCESSREQUESTS.REQUESTDATE BETWEEN {{StartDate}} AND {{EndDate}}) AND PROCESSES.DELETEDATE IS NULL AND PROCESSES.FINISHDATE IS NOT NULL)\\nOR\\n(({{ProcessType}} < 0 OR {{ProcessType}} IS NULL) AND {{RequestId}} > 0)\\n)\\nAND\\nPROCESSREQUESTS.ID = CASE WHEN {{RequestId}} IS NULL OR {{RequestId}} <= 0 THEN PROCESSREQUESTS.ID ELSE {{RequestId}} END AND\\nPROJECTS.STATUS = 1 AND\\nPROJECTCOREDEPLOYMENTS.DELETEDAT IS NULL AND\\n(({{RequestId}} IS NOT NULL AND {{RequestId}} > 0) OR (PROCESSREQUESTS.USERID IN ({{Users}}) OR PROCESSREQUESTS.POSITIONID IN ({{Positions}})))\\nGROUP BY PROCESSREQUESTS.ID\\nORDER BY PROCESSREQUESTS.ID DESC\\nOFFSET {{Skip}} ROWS FETCH NEXT {{Take}} ROWS ONLY\\n\",\"parameters\":[{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Users\",\"value\":[0],\"valueType\":10,\"length\":10000,\"subType\":3},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Positions\",\"value\":[0],\"valueType\":10,\"length\":1000, \"subType\":3},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Skip\",\"value\":0,\"valueType\":3,\"length\":1000},{\"caption\":\"\",\"isActive\":true,\"isRequired\":true,\"key\":\"Take\",\"value\":0,\"valueType\":3,\"length\":1000},{\"caption\":\"Culture\",\"isActive\":true,\"isRequired\":true,\"key\":\"Culture\",\"value\":\"%User.Language%\",\"valueType\":1,\"length\":10},{\"caption\":\"ProcessType\",\"isActive\":true,\"isRequired\":true,\"key\":\"ProcessType\",\"value\":0,\"valueType\":3,\"length\":100},{\"caption\":\"EndDate\",\"isActive\":true,\"isRequired\":true,\"key\":\"EndDate\",\"value\":\"2021-09-25T21:48:29+03:00\",\"valueType\":6,\"length\":100},{\"caption\":\"StartDate\",\"isActive\":true,\"isRequired\":true,\"key\":\"StartDate\",\"value\":\"2021-09-25T21:48:29+03:00\",\"valueType\":6,\"length\":100}, {\"caption\":\"FlowName\",\"isActive\":true,\"isRequired\":true,\"key\":\"FlowName\",\"value\":\"FlowName\",\"valueType\":1,\"length\":200}, {\"caption\":\"ProjectName\",\"isActive\":true,\"isRequired\":true,\"key\":\"ProjectName\",\"value\":\"ProjectName\",\"valueType\":1,\"length\":500}, {\"caption\":\"RequestId\",\"isActive\":true,\"isRequired\":true,\"key\":\"RequestId\",\"value\":0,\"valueType\":3,\"length\":1000}],\"commandType\":1,\"executionType\":3},\"structure\":{ \"columns\":[{\"name\":\"ProcessId\",\"caption\":\"ProcessId\",\"type\":3,\"displayFormat\":null},{\"name\":\"User\",\"caption\":\"User\",\"type\":1,\"displayFormat\":null},{\"name\":\"CreatedDate\",\"caption\":\"CreatedDate\",\"type\":6,\"displayFormat\":null},{\"name\":\"RequestId\",\"caption\":\"RequestId\",\"type\":3,\"displayFormat\":null},{\"name\":\"Caption\",\"caption\":\"Caption\",\"type\":1,\"displayFormat\":null},{\"name\":\"MobileFormView\",\"caption\":\"MobileFormView\",\"type\":2,\"displayFormat\":null},{\"name\":\"PackageVersion\",\"caption\":\"PackageVersion\",\"type\":3,\"displayFormat\":null},{\"name\":\"ProcessStartDate\",\"caption\":\"ProcessStartDate\",\"type\":12,\"displayFormat\":null}],\"returnType\":null}}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> DataSource_PersonelBilgileri(DataSource_PersonelBilgileriRequest request)
{
    string queryContent = "{\n  \"name\": \"DataSource_PersonelBilgileri\",\n  \"connectionId\": \"c914bb72-a9c0-43a9-b1a4-4bf5dfae6f4d\",\n  \"connectionName\": {\n    \"tr-TR\": \"SYNERGY\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT * from OSUSERS\\r\\nWHERE STATUS = 1 AND DEPARTMENT = {{PDEPID}} and ID != {{USERID}} ;\",\n    \"parameters\": [\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"PDEPID\",\n        \"value\": \"%User.Department.Id%\",\n        \"valueType\": 1,\n        \"length\": 255,\n        \"subType\": null\n      },\n      {\n        \"caption\": \"\",\n        \"isActive\": true,\n        \"isRequired\": true,\n        \"key\": \"USERID\",\n        \"value\": \"%User.Id%\",\n        \"valueType\": 1,\n        \"length\": 255,\n        \"subType\": null\n      }\n    ],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [\n      {\n        \"name\": \"ID\",\n        \"type\": 3,\n        \"caption\": \"ID\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"USERNAME\",\n        \"type\": 1,\n        \"caption\": \"USERNAME\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"FIRSTNAME\",\n        \"type\": 1,\n        \"caption\": \"FIRSTNAME\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"LASTNAME\",\n        \"type\": 1,\n        \"caption\": \"LASTNAME\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PASSWORD\",\n        \"type\": 1,\n        \"caption\": \"PASSWORD\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"EMAIL\",\n        \"type\": 1,\n        \"caption\": \"EMAIL\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"STATUS\",\n        \"type\": 3,\n        \"caption\": \"STATUS\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"IMPORTSTATUS\",\n        \"type\": 3,\n        \"caption\": \"IMPORTSTATUS\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"BIRTHDATE\",\n        \"type\": 12,\n        \"caption\": \"BIRTHDATE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"EMPLOYEMENTSTART\",\n        \"type\": 12,\n        \"caption\": \"EMPLOYEMENTSTART\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"EMPLOYEMENTEND\",\n        \"type\": 12,\n        \"caption\": \"EMPLOYEMENTEND\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"CATEGORY\",\n        \"type\": 3,\n        \"caption\": \"CATEGORY\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"SEX\",\n        \"type\": 3,\n        \"caption\": \"SEX\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"TYPE\",\n        \"type\": 3,\n        \"caption\": \"TYPE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"DEPARTMENT\",\n        \"type\": 3,\n        \"caption\": \"DEPARTMENT\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PROFESSION\",\n        \"type\": 3,\n        \"caption\": \"PROFESSION\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PHONE\",\n        \"type\": 1,\n        \"caption\": \"PHONE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"MOBILEPHONE\",\n        \"type\": 1,\n        \"caption\": \"MOBILEPHONE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"REGISTRATIONNUMBER\",\n        \"type\": 1,\n        \"caption\": \"REGISTRATIONNUMBER\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"WAYOFWORK\",\n        \"type\": 1,\n        \"caption\": \"WAYOFWORK\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PLACEOFBIRTH\",\n        \"type\": 1,\n        \"caption\": \"PLACEOFBIRTH\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"MARITALSTATUS\",\n        \"type\": 1,\n        \"caption\": \"MARITALSTATUS\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"IDENTIFICATIONNUMBER\",\n        \"type\": 1,\n        \"caption\": \"IDENTIFICATIONNUMBER\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PERSONALEMAIL\",\n        \"type\": 1,\n        \"caption\": \"PERSONALEMAIL\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PERSONALPHONE\",\n        \"type\": 1,\n        \"caption\": \"PERSONALPHONE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"PERSONALMOBILEPHONE\",\n        \"type\": 1,\n        \"caption\": \"PERSONALMOBILEPHONE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"ADDRESS\",\n        \"type\": 1,\n        \"caption\": \"ADDRESS\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"EDUCATIONALSTATUS\",\n        \"type\": 1,\n        \"caption\": \"EDUCATIONALSTATUS\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"SHIFTID\",\n        \"type\": 3,\n        \"caption\": \"SHIFTID\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"DEFAULTCULTURE\",\n        \"type\": 1,\n        \"caption\": \"DEFAULTCULTURE\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"MFAENABLED\",\n        \"type\": 2,\n        \"caption\": \"MFAENABLED\",\n        \"columns\": []\n      },\n      {\n        \"name\": \"AUTHENTICATORENABLED\",\n        \"type\": 2,\n        \"caption\": \"AUTHENTICATORENABLED\",\n        \"columns\": []\n      }\n    ],\n    \"returnType\": 10\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

internal async Task<DataSourceResponse<object>> getcolumns(getcolumnsRequest request)
{
    string queryContent = "{\n  \"name\": \"getcolumns\",\n  \"connectionId\": \"c914bb72-a9c0-43a9-b1a4-4bf5dfae6f4d\",\n  \"connectionName\": {\n    \"tr-TR\": \"SYNERGY\"\n  },\n  \"connectionType\": 1,\n  \"description\": {},\n  \"id\": null,\n  \"properties\": {\n    \"cacheTTL\": 60000,\n    \"cacheType\": \"Memory\",\n    \"enableCache\": true,\n    \"timeout\": 60,\n    \"commandText\": \"SELECT * FROM E_gorevatamasureci_feyza_Form1\",\n    \"parameters\": [],\n    \"commandType\": 1,\n    \"executionType\": 3\n  },\n  \"structure\": {\n    \"columns\": [],\n    \"returnType\": null\n  }\n}";

    JObject queryObj = JObject.Parse(queryContent);

    string connectionId = queryObj.Value<string>("connectionId");

    DataSourceConnectionObject connectionObj = await DataSourceApi.GetConnectionObject(GetContextData(), HttpClientOptions, connectionId);
    CurrentUserInfo currentUserInfo = await DataSourceApi.GetCurrentUserInfo(GetContextData(), HttpClientOptions);

    IProvider provider = DataSourceApi.CreateProvider(connectionObj.Type, connectionObj.Properties, currentUserInfo);

    string requestContent = queryObj["properties"].ToString();

    var executeRequest = provider.MergeParameters(request,  requestContent);

    return await provider.ExecuteAsync(executeRequest);
}

        ///Iterators
        [NonAction] public IEnumerable Flow1_ProcessItemsIterator(Flow1_ProcessItemsRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = Flow1_ProcessItems(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable DataSource_PersonelBilgileriIterator(DataSource_PersonelBilgileriRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = DataSource_PersonelBilgileri(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

[NonAction] public IEnumerable getcolumnsIterator(getcolumnsRequest request)
{
            int pagingSkip = 0;
            int pagingTake = 100;
            int pageIndex = 0;
            var filters = new List<IFilter>();
            var sorts = new List<ISort>();

            bool endOfSource = false;
            while (!endOfSource)
            {
                if (request.LoadOptions != null)
                {
                    filters = request.LoadOptions.Filters;
                    sorts = request.LoadOptions.Sorts;
                    if (pageIndex > 0 && request.LoadOptions.Pagination != null)
                    {
                        pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                        pagingTake = request.LoadOptions.Pagination.Take;
                    }
                }

                request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

                var response = getcolumns(request).Result;
                endOfSource = response.IsEndOfSource;
                if (response.Success && response.Result != null)
                {
                    JArray data = (JArray)response.Result;

                    foreach (var item in data)
                    {
                        var dataItem = item.ToObject<Dictionary<string, object>>();
                        yield return dataItem;
                    }
                }
                else
                {
                    endOfSource = true;
                }

                pageIndex++;
            }
}

    }
}