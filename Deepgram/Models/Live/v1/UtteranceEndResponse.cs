﻿// Copyright 2021-2023 Deepgram .NET SDK contributors. All Rights Reserved.
// Use of this source code is governed by a MIT license that can be found in the LICENSE file.
// SPDX-License-Identifier: MIT

namespace Deepgram.Models.Live.v1;

public record UtteranceEndResponse
{
    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LiveType? Type { get; set; } = LiveType.UtteranceEnd;

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("channel_index")]
    public int[]? Channel { get; set; }

    /// <summary>
    /// TODO
    /// </summary>
    [JsonPropertyName("last_word_end")]
    public decimal? LastWordEnd { get; set; }
}
