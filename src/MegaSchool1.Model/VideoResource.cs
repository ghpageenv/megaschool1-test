﻿using System.Text.Json.Serialization;

namespace MegaSchool1.Model;

public class VideoResource
{
    [JsonPropertyName("contentId")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Content ContentId { get; set; }

    [JsonPropertyName("videoId")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("platform")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public VideoPlatform Platform { get; set; }

    [JsonPropertyName("videoHash")]
    public string? Hash { get; set; }

    [JsonPropertyName("userHandle")]
    public string? UserHandle { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("appTitle")]
    public string AppTitle { get; set; } = default!;

    [JsonPropertyName("shareableTitle")]
    public string ShareableTitle { get; set; } = default!;
    
    [JsonPropertyName("duration")]
    public TimeSpan? Duration { get;  set; }

    [JsonPropertyName("imageId")]
    public Image? Image { get; set; }

    [JsonPropertyName("downloadUrl")]
    public string? DownloadUrl { get; set; }
}
