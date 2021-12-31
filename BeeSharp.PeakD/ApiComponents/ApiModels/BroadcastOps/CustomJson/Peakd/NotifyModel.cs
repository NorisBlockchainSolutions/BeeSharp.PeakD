using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.PeakD.ApiComponents.ApiModels.BroadcastOps.CustomJson.Peakd
{
    [CustomJsonOpId("notify", typeof(ArrayShapedCustomJsonModel))]
    [CustomJsonOpListOp("setLastRead")]
    public class NotifyModel : CustomJsonOperation
    {
        public NotifyModel(DateTime date)
        {
            Date = date;
        }

        [JsonPropertyName("date")] public DateTime Date { get; }
    }
}