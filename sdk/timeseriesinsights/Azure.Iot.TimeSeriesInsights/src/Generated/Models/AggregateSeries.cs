// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Aggregate Series query. Allows to calculate an aggregated time series from events for a given Time Series ID and search span. </summary>
    public partial class AggregateSeries
    {
        /// <summary> Initializes a new instance of AggregateSeries. </summary>
        /// <param name="timeSeriesId"> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </param>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <param name="interval"> Interval size is specified in ISO-8601 duration format. All intervals are the same size. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is &quot;PT1M&quot;, 1 millisecond is &quot;PT0.001S&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeSeriesId"/> or <paramref name="searchSpan"/> is null. </exception>
        public AggregateSeries(IEnumerable<object> timeSeriesId, DateTimeRange searchSpan, TimeSpan interval)
        {
            if (timeSeriesId == null)
            {
                throw new ArgumentNullException(nameof(timeSeriesId));
            }
            if (searchSpan == null)
            {
                throw new ArgumentNullException(nameof(searchSpan));
            }

            TimeSeriesId = timeSeriesId.ToList();
            SearchSpan = searchSpan;
            Interval = interval;
            ProjectedVariables = new ChangeTrackingList<string>();
            InlineVariables = new ChangeTrackingDictionary<string, TimeSeriesVariable>();
        }

        /// <summary> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </summary>
        public IList<object> TimeSeriesId { get; }
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND&apos;ed with filter in each variable. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Interval size is specified in ISO-8601 duration format. All intervals are the same size. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is &quot;PT1M&quot;, 1 millisecond is &quot;PT0.001S&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration. </summary>
        public TimeSpan Interval { get; }
        /// <summary> This allows the user to optionally select the variables that needs to be projected. When it is null or not set, all the variables from inlineVariables and model are returned. Can be null. </summary>
        public IList<string> ProjectedVariables { get; }
        /// <summary> This allows the user the optionally define inline-variables apart from the ones already defined in the model. When the inline variable names have the same name as the model, the inline variable definition takes precedence. Can be null. </summary>
        public IDictionary<string, TimeSeriesVariable> InlineVariables { get; }
    }
}
