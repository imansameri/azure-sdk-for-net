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
    [JsonConverter(typeof(DeviceTwinPropertiesConverter))]
    public partial class DeviceTwinProperties
    {
        internal static DeviceTwinProperties DeserializeDeviceTwinProperties(JsonElement element)
        {
            Optional<DeviceTwinMetadata> metadata = default;
            Optional<float> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = DeviceTwinMetadata.DeserializeDeviceTwinMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
            }
            return new DeviceTwinProperties(metadata.Value, Optional.ToNullable(version));
        }

        internal partial class DeviceTwinPropertiesConverter : JsonConverter<DeviceTwinProperties>
        {
            public override void Write(Utf8JsonWriter writer, DeviceTwinProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DeviceTwinProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDeviceTwinProperties(document.RootElement);
            }
        }
    }
}
