namespace CourtStack.CTC.Workshop.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CaseDetail
    {
        [JsonProperty("case", NullValueHandling = NullValueHandling.Ignore)]
        public Case Case { get; set; }

        [JsonProperty("caseParties", NullValueHandling = NullValueHandling.Ignore)]
        public List<CaseParty> CaseParties { get; set; }

        [JsonProperty("charges")]
        public object Charges { get; set; }

        [JsonProperty("documents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Document> Documents { get; set; }

        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<Event> Events { get; set; }

        [JsonProperty("flags")]
        public Code Flags { get; set; }

        [JsonProperty("hearings")]
        public object Hearings { get; set; }
    }

    public class Case
    {
        [JsonProperty("category")]
        public Code Category { get; set; }

        [JsonProperty("fileDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FileDate { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        [JsonProperty("security")]
        public Code Security { get; set; }

        [JsonProperty("subtype")]
        public Code Subtype { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Code Status { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Code Type { get; set; }
    }

    public class CaseParty
    {
        [JsonProperty("charges", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Charges { get; set; }

        [JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Connections { get; set; }

        [JsonProperty("fees", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Fees { get; set; }

        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Address> Addresses { get; set; }

        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTimeOffset> DateOfBirth { get; set; }

        [JsonProperty("driverLicenses", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> DriverLicenses { get; set; }

        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Email> Emails { get; set; }

        [JsonProperty("eyeColor")]
        public object EyeColor { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("hairColor")]
        public object HairColor { get; set; }

        [JsonProperty("height")]
        public object Height { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("isEntity", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEntity { get; set; }

        [JsonProperty("language")]
        public Code Language { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Code Type { get; set; }

        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public List<Name> Names { get; set; }

        [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
        public List<Phone> Phones { get; set; }

        [JsonProperty("race")]
        public Code Race { get; set; }

        [JsonProperty("weight")]
        public object Weight { get; set; }
    }

    public class Address
    {
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("line1", NullValueHandling = NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public object Line2 { get; set; }

        [JsonProperty("line3")]
        public object Line3 { get; set; }

        [JsonProperty("line4")]
        public object Line4 { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("zipCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? ZipCode { get; set; }
    }

    public class Email
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }
    }

    public class Name
    {
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public object MiddleName { get; set; }

        [JsonProperty("fullName")]
        public object FullName { get; set; }

        [JsonProperty("prefix")]
        public object Prefix { get; set; }

        [JsonProperty("suffix")]
        public object Suffix { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }
    }

    public class Phone
    {
        [JsonProperty("extension")]
        public object Extension { get; set; }

        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Code Type { get; set; }
    }

    public class Document
    {
        [JsonProperty("caseId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? CaseId { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public string Extension { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        [JsonProperty("payloadType")]
        public object PayloadType { get; set; }

        [JsonProperty("security")]
        public string Security { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public class Event
    {
        [JsonProperty("caseId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? CaseId { get; set; }

        [JsonProperty("comment")]
        public object Comment { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(CaseDetailParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("isDocketable")]
        public object IsDocketable { get; set; }

        [JsonProperty("parameters")]
        public object Parameters { get; set; }

        [JsonProperty("security")]
        public object Security { get; set; }

        [JsonProperty("sequenceNumber")]
        public object SequenceNumber { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Code Type { get; set; }
    }

    public partial class CaseDetail
    {
        public static CaseDetail FromJson(string json) => JsonConvert.DeserializeObject<CaseDetail>(json, CaseDetailConverter.Settings);
    }

    public static class CaseDetailSerialize
    {
        public static string ToJson(this CaseDetail self) => JsonConvert.SerializeObject(self, CaseDetailConverter.Settings);
    }

    internal static class CaseDetailConverter
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

    internal class CaseDetailParseStringConverter : JsonConverter
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

        public static readonly CaseDetailParseStringConverter Singleton = new();
    }
}
