﻿using System;
using Pretty;
using Xunit;
using Xunit.Extensions;

namespace Pretty.Tests.Localisation.nb
{
    public class TimeSpanHumanizeTests : AmbientCulture
    {
        public TimeSpanHumanizeTests() : base("nb") { }

        [Theory]
        [InlineData(7, "en uke")]
        [InlineData(14, "2 uker")]
        public void Weeks(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize());
        }

        [Theory]
        [InlineData(1, "en dag")]
        [InlineData(2, "2 dager")]
        public void Days(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize());
        }

        [Theory]
        [InlineData(1, "en time")]
        [InlineData(2, "2 timer")]
        public void Hours(int hours, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromHours(hours).Humanize());
        }

        [Theory]
        [InlineData(1, "ett minutt")]
        [InlineData(2, "2 minutter")]
        public void Minutes(int minutes, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromMinutes(minutes).Humanize());
        }

        [Theory]
        [InlineData(1, "ett sekund")]
        [InlineData(2, "2 sekunder")]
        public void Seconds(int seconds, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromSeconds(seconds).Humanize());
        }

        [Theory]
        [InlineData(1, "ett millisekund")]
        [InlineData(2, "2 millisekunder")]
        public void Milliseconds(int milliseconds, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromMilliseconds(milliseconds).Humanize());
        }

        [Fact]
        public void NoTime()
        {
            Assert.Equal("ingen tid", TimeSpan.Zero.Humanize());
        }
    }
}