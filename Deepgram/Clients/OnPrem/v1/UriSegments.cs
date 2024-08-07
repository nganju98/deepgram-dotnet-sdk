﻿// Copyright 2021-2024 Deepgram .NET SDK contributors. All Rights Reserved.
// Use of this source code is governed by a MIT license that can be found in the LICENSE file.
// SPDX-License-Identifier: MIT

namespace Deepgram.Clients.OnPrem.v1;

/// <summary>
/// <remarks>
// *********** WARNING ***********
// This class provides the UriSegments implementation
//
// Deprecated: This class is deprecated. Use the `Deepgram.Clients.SelfHosted.v1` namespace instead.
// This will be removed in a future release.
//
// This package is frozen and no new functionality will be added.
// *********** WARNING ***********
/// </remarks>
[Obsolete("Please use Deepgram.Clients.SelfHosted.v1.UriSegments instead", false)]
public static class UriSegments
{
    //using constants instead of inline value(magic strings) make consistence
    //across SDK And Test Projects Simpler and Easier to change
    public const string PROJECTS = "projects";
    public const string ONPREM = "onprem/distribution/credentials";
}
