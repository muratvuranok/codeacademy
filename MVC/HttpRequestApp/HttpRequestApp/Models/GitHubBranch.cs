using System.Text.Json.Serialization;

namespace HttpRequestApp.Models;

public class GitHubBranch
{ 
    [JsonPropertyName("protected")]
    public bool Protected { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("commit")]
    public Commit Commit { get; set; }   
    public Protection protection { get; set; }
    public string protection_url { get; set; }
}


public class Commit
{
    [JsonPropertyName("sha")]
    public string Sha { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}


 
public class Protection
{
    public RequiredStatusChecks required_status_checks { get; set; }
}

public class RequiredStatusChecks
{
    public string enforcement_level { get; set; }
    public List<string> contexts { get; set; }
}

 