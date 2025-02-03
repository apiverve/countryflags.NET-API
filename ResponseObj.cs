using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("countryCode")]
    public string countryCode { get; set; }

    [JsonProperty("shape")]
    public string shape { get; set; }

    [JsonProperty("format")]
    public string format { get; set; }

    [JsonProperty("downloadUrl")]
    public string downloadUrl { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
