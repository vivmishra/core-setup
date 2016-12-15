// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace Microsoft.DotNet.Scripts
{
    public static class Dirs
    {
        public static readonly string RepoRoot = Directory.GetCurrentDirectory();
        public static readonly string Pkg = Path.Combine(RepoRoot, "pkg");
        public static readonly string PkgProjects = Path.Combine(Pkg, "projects");
        public static readonly string PkgDeps = Path.Combine(Pkg, "deps");
    }
}
