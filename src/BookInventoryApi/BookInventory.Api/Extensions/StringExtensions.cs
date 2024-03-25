﻿using AWS.Lambda.Powertools.Logging;
using AWS.Lambda.Powertools.Tracing;

namespace BookInventory.Api.Extensions
{
    public static class StringExtensions
    {
        public static void AddObservabilityTag(this string value, string tag)
        {
            if(string.IsNullOrEmpty(value)) {
                return;
            }

            if(string.IsNullOrEmpty(tag)) {
                return;
            }

            Logger.AppendKey(tag, value);
            Tracing.AddAnnotation(tag, value);
        }
    }
}