﻿using System;
using Newtonsoft.Json;

namespace Alexa.NET.Management.Package
{
    public class ExportMetadata
    {
        [JsonProperty("location")]
        public Uri Location { get; set; }

        [JsonProperty("expiresAt"),JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }
    }


}