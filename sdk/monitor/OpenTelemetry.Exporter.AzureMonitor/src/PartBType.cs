// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace OpenTelemetry.Exporter.AzureMonitor
{
    internal enum PartBType
    {
        Unknown,
        Azure,
        Common,
        Db,
        FaaS,
        Http,
        Messaging,
        Rpc
    };
}
