﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;

namespace Microsoft.Bot.Builder.Telemetry
{
    public interface ITelemetryReporter : ISetTelemetryContext
    {
        Task AddLuisEventDetailsAsync(IIntentTelemetry intentTelemetry);
        Task AddResponseAsync(IResponseTelemetry responseTelemetry);
        Task AddDialogImpressionAsync(string dialog);
        Task AddServiceResultAsync(IServiceResultTelemetry serviceResultTelemetry);
        Task AddEventAsync(string key, string value);
        Task AddEventAsync(string key, double value);
        Task AddEventAsync(Dictionary<string, double> metrics);
        Task AddEventAsync(Dictionary<string, string> properties, Dictionary<string, double> metrics = null);
        Task SetContextFrom(IActivity activity, ITelemetryContext context = null);
    }
}
