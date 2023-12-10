﻿
namespace Deepgram.Models;

/// <summary>
/// Configuration for the Deepgram client
/// </summary>
public class DeepgramClientOptions
{
    /// <summary>
    /// Additional headers 
    /// </summary>
    public Dictionary<string, string>? Headers { get; set; }

    /// <summary>
    /// BaseAddress of the server :defaults to api.deepgram.com
    /// no need to attach the protocol it will be added internally
    /// </summary>

    /* Unmerged change from project 'Deepgram (net6.0)'
    Before:
        public string BaseAddress { get; set; } = Common.Defaults.DEFAULT_URI;
    After:
        public string BaseAddress { get; set; } = Defaults.DEFAULT_URI;
    */
    public string BaseAddress { get; set; } = Defaults.DEFAULT_URI;

    /// <summary>
    /// Sets the timeout for calls to Deepgram.
    /// If not set, the default is 120 seconds.
    /// Not used if the HttpClient is provided.
    /// </summary>
    public TimeSpan HttpTimeout { get; set; } = TimeSpan.FromSeconds(120);

    internal string ApiKey { get; }

    /// <summary>
    /// Creates a new Deepgram client options
    /// </summary>
    /// <param name="apiKey">The key to authenticate with Deepgram</param>
    public DeepgramClientOptions(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            Log.ApiKeyNotPresent(LogProvider.GetLogger(nameof(DeepgramClientOptions)), nameof(DeepgramClientOptions));
            throw new ArgumentNullException(nameof(apiKey));
        }

        ApiKey = apiKey;
    }
}
