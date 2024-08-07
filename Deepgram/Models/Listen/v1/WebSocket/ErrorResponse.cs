﻿// Copyright 2024 Deepgram .NET SDK contributors. All Rights Reserved.
// Use of this source code is governed by a MIT license that can be found in the LICENSE file.
// SPDX-License-Identifier: MIT

namespace Deepgram.Models.Listen.v1.WebSocket;

public record ErrorResponse
{
    /// <summary>
    /// Error Description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("description")]
    public string? Description { get; set; } = "";

    /// <summary>
    /// Error Message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("message")]
    public string? Message { get; set; } = "";

    /// <summary>
    /// Error Variant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("variant")]
    public string? Variant { get; set; } = "";

    /// <summary>
    /// Error event type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	[JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ListenType? Type { get; set; } = ListenType.Error;

    /// <summary>
    /// Override ToString method to serialize the object
    /// </summary>
    public override string ToString()
    {
        return Regex.Unescape(JsonSerializer.Serialize(this, JsonSerializeOptions.DefaultOptions));
    }
}
