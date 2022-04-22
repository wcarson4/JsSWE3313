using System.Configuration;
using System.Security;

namespace SWE3313_JsRestaurant.Data.Entities;

public class Report
{
    public string ReportName { get; set; }
    public Dictionary<string,string> QueryParamaters { get; set; }
    public string Query { get; set; }
}