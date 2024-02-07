﻿// Copyright 2021-2024 Deepgram .NET SDK contributors. All Rights Reserved.
// Use of this source code is governed by a MIT license that can be found in the LICENSE file.
// SPDX-License-Identifier: MIT

namespace Deepgram.Models.Manage.v1;

public record MessageResponse
{
    /// <summary>
    /// A message denoting the success of the operation
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
