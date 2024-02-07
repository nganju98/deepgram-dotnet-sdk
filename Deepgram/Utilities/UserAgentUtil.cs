﻿// Copyright 2021-2023 Deepgram .NET SDK contributors. All Rights Reserved.
// Use of this source code is governed by a MIT license that can be found in the LICENSE file.
// SPDX-License-Identifier: MIT

namespace Deepgram.Utilities;

internal static class UserAgentUtil
{
    /// <summary>
    /// determines the UserAgent Library version
    /// </summary>
    /// <returns></returns>
    public static string GetInfo()
    {
        var libraryVersion = Assembly.GetExecutingAssembly().GetName().Version;

        var languageVersion = new Regex("[ ,/,:,;,_,(,)]")
             .Replace(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
             string.Empty);

        return $"deepgram/{libraryVersion} dotnet/{languageVersion} ";
    }
}
