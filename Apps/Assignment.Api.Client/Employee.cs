﻿#if EXAMPLE
// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using QuickType;
//
//    var emp = Employee.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class Employee
    {
        [JsonPropertyName("employeeId")]
        public virtual long EmployeeId { get; set; }

        [JsonPropertyName("lastName")]
        public virtual string LastName { get; set; }

        [JsonPropertyName("firstName")]
        public virtual string FirstName { get; set; }

        [JsonPropertyName("title")]
        public virtual string Title { get; set; }

        [JsonPropertyName("titleOfCourtesy")]
        public virtual string TitleOfCourtesy { get; set; }

        [JsonPropertyName("birthDate")]
        public virtual DateTimeOffset BirthDate { get; set; }

        [JsonPropertyName("hireDate")]
        public virtual DateTimeOffset HireDate { get; set; }

        [JsonPropertyName("address")]
        public virtual string Address { get; set; }

        [JsonPropertyName("city")]
        public virtual string City { get; set; }

        [JsonPropertyName("region")]
        public virtual string Region { get; set; }

        [JsonPropertyName("postalCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public virtual long PostalCode { get; set; }

        [JsonPropertyName("country")]
        public virtual string Country { get; set; }

        [JsonPropertyName("homePhone")]
        public virtual string HomePhone { get; set; }

        [JsonPropertyName("extension")]
        [JsonConverter(typeof(ParseStringConverter))]
        public virtual long Extension { get; set; }

        [JsonPropertyName("photo")]
        public virtual string Photo { get; set; }

        [JsonPropertyName("photoDisplay")]
        public virtual string PhotoDisplay { get; set; }

        [JsonPropertyName("notes")]
        public virtual string Notes { get; set; }

        [JsonPropertyName("reportsTo")]
        public virtual object ReportsTo { get; set; }

        [JsonPropertyName("photoPath")]
        public virtual Uri PhotoPath { get; set; }

        [JsonPropertyName("reportsToEmployee")]
        public virtual object ReportsToEmployee { get; set; }

        [JsonPropertyName("employeeTerritories")]
        public virtual object EmployeeTerritories { get; set; }

        [JsonPropertyName("orders")]
        public virtual List<object> Orders { get; set; }

        [JsonPropertyName("reportingEmployees")]
        public virtual object ReportingEmployees { get; set; }
    }

    public partial class Employee
    {
        public static Employee FromJson(string json) => JsonSerializer.Deserialize<Employee>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Employee self) => JsonSerializer.Serialize(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class ParseStringConverter : JsonConverter<long>
    {
        public override bool CanConvert(Type t) => t == typeof(long);

        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.ToString(), options);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
#endif