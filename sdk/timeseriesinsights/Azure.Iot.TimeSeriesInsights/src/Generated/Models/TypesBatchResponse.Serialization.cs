// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    public partial class TypesBatchResponse
    {
        internal static TypesBatchResponse DeserializeTypesBatchResponse(JsonElement element)
        {
            Optional<IReadOnlyList<TimeSeriesTypeOrError>> @get = default;
            Optional<IReadOnlyList<TimeSeriesTypeOrError>> put = default;
            Optional<IReadOnlyList<TsiErrorBody>> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("get"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TimeSeriesTypeOrError> array = new List<TimeSeriesTypeOrError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesTypeOrError.DeserializeTimeSeriesTypeOrError(item));
                    }
                    @get = array;
                    continue;
                }
                if (property.NameEquals("put"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TimeSeriesTypeOrError> array = new List<TimeSeriesTypeOrError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesTypeOrError.DeserializeTimeSeriesTypeOrError(item));
                    }
                    put = array;
                    continue;
                }
                if (property.NameEquals("delete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TsiErrorBody> array = new List<TsiErrorBody>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TsiErrorBody.DeserializeTsiErrorBody(item));
                    }
                    delete = array;
                    continue;
                }
            }
            return new TypesBatchResponse(Optional.ToList(@get), Optional.ToList(put), Optional.ToList(delete));
        }
    }
}
