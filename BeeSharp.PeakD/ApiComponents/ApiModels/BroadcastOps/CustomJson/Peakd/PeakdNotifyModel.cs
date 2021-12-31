using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.PeakD.ApiComponents.ApiModels.BroadcastOps.CustomJson.Peakd
{
    [CustomJsonOpId("peakd_notify")]
    public class PeakdNotifyModel : CustomJsonOperation
    {
        public PeakdNotifyModel(string action, DateTime dateTime)
        {
            Action = action;
            DateTime = dateTime;
        }

        [JsonPropertyName("action")] public string Action { get; }
        [JsonPropertyName("date")] public DateTime DateTime { get; }
    }
}