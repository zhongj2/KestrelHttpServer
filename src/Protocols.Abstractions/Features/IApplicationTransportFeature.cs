// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Buffers;
using System.IO.Pipelines;
using System.Threading;

namespace Microsoft.AspNetCore.Protocols.Features
{
    public interface IApplicationTransportFeature
    {
        IDuplexPipe Application { get; set; }
    }
}
