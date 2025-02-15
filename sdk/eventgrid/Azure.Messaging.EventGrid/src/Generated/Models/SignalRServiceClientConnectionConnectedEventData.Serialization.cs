// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(SignalRServiceClientConnectionConnectedEventDataConverter))]
    public partial class SignalRServiceClientConnectionConnectedEventData
    {
        internal static SignalRServiceClientConnectionConnectedEventData DeserializeSignalRServiceClientConnectionConnectedEventData(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> hubName = default;
            Optional<string> connectionId = default;
            Optional<string> userId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("hubName"))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"))
                {
                    userId = property.Value.GetString();
                    continue;
                }
            }
            return new SignalRServiceClientConnectionConnectedEventData(Optional.ToNullable(timestamp), hubName.Value, connectionId.Value, userId.Value);
        }

        internal partial class SignalRServiceClientConnectionConnectedEventDataConverter : JsonConverter<SignalRServiceClientConnectionConnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, SignalRServiceClientConnectionConnectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SignalRServiceClientConnectionConnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSignalRServiceClientConnectionConnectedEventData(document.RootElement);
            }
        }
    }
}
