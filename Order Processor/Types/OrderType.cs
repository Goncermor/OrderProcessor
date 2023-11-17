﻿using System.Text.Json.Serialization;

namespace Order_Processor.Types
{
    public class OrderType
    {
        [JsonPropertyName("po")]
        public string PurchaseOrder { get; set; } = "";
        [JsonPropertyName("r")]
        public string Ref { get; set; } = "";
        [JsonPropertyName("n")]
        public string Name { get; set; } = "";
        [JsonPropertyName("c")]
        public string Client { get; set; } = "";
        [JsonPropertyName("ld")]
        public long LimitDate { get; set; }
        [JsonPropertyName("od")]
        public long OrderDate { get; set; }
        [JsonPropertyName("s")]
        public StateType State { get; set; } = StateType.Undefined;
        [JsonPropertyName("ms")]
        public MaterialStateType MaterialState { get; set; } = MaterialStateType.Undefined;
        [JsonPropertyName("no")]
        public string Notes { get; set; } = "";

    }
}
