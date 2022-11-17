namespace CourtStack.CTC.Workshop.Models
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CaseSummary
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(CaseSummaryParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("category")]
        public Code? Category { get; set; }

        [JsonProperty("fileDate")]
        public DateTimeOffset FileDate { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("security")]
        public Code? Security { get; set; }

        [JsonProperty("subtype")]
        public Code? Subtype { get; set; }

        [JsonProperty("status")]
        public Code Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public Code Type { get; set; }
    }

    public class Code
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(CaseSummaryParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class CaseSummary
    {
        public static CaseSummary FromJson(string json) => JsonConvert.DeserializeObject<CaseSummary>(json, CaseSummaryConverter.Settings);
    }

    public static class CaseSummarySerialize
    {
        public static string ToJson(this CaseSummary self) => JsonConvert.SerializeObject(self, CaseSummaryConverter.Settings);
    }

    internal static class CaseSummaryConverter
    {
        public static readonly JsonSerializerSettings Settings = new()
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CaseSummaryParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            string? value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            long value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly CaseSummaryParseStringConverter Singleton = new();
    }

}
