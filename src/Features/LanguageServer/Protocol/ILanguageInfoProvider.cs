﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Features.Workspaces;

namespace Microsoft.CodeAnalysis.LanguageServer
{
    internal interface ILanguageInfoProvider : ILspService
    {
        LanguageInformation? GetLanguageInformation(string documentPath, string? languageId = null);
    }
}
