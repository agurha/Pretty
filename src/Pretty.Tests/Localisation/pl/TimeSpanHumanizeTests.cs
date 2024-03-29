﻿using System;
using Pretty;
using Xunit;
using Xunit.Extensions;

namespace Pretty.Tests.Localisation.pl
{
    public class TimeSpanHumanizeTests : AmbientCulture
    {
        public TimeSpanHumanizeTests()
            : base("pl")
        {
        }

        [Theory]
        [InlineData(1, "1 milisekunda")]
        [InlineData(2, "2 milisekundy")]
        [InlineData(3, "3 milisekundy")]
        [InlineData(4, "4 milisekundy")]
        [InlineData(5, "5 milisekund")]
        [InlineData(6, "6 milisekund")]
        [InlineData(10, "10 milisekund")]
        public void Milliseconds(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromMilliseconds(number).Humanize());
        }

        [Theory]
        [InlineData(1, "1 sekunda")]
        [InlineData(2, "2 sekundy")]
        [InlineData(3, "3 sekundy")]
        [InlineData(4, "4 sekundy")]
        [InlineData(5, "5 sekund")]
        [InlineData(6, "6 sekund")]
        [InlineData(10, "10 sekund")]
        public void Seconds(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromSeconds(number).Humanize());
        }

        [Theory]
        [InlineData(1, "1 minuta")]
        [InlineData(2, "2 minuty")]
        [InlineData(3, "3 minuty")]
        [InlineData(4, "4 minuty")]
        [InlineData(5, "5 minut")]
        [InlineData(6, "6 minut")]
        [InlineData(10, "10 minut")]
        public void Minutes(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromMinutes(number).Humanize());
        }

        [Theory]
        [InlineData(1, "1 godzina")]
        [InlineData(2, "2 godziny")]
        [InlineData(3, "3 godziny")]
        [InlineData(4, "4 godziny")]
        [InlineData(5, "5 godzin")]
        [InlineData(6, "6 godzin")]
        [InlineData(10, "10 godzin")]
        public void Hours(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromHours(number).Humanize());
        }

        [Theory]
        [InlineData(1, "1 dzień")]
        [InlineData(2, "2 dni")]
        [InlineData(3, "3 dni")]
        [InlineData(4, "4 dni")]
        [InlineData(5, "5 dni")]
        [InlineData(6, "6 dni")]
        public void Days(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(number).Humanize());
        }

        [Theory]
        [InlineData(1, "1 tydzień")]
        [InlineData(2, "2 tygodnie")]
        [InlineData(3, "3 tygodnie")]
        [InlineData(4, "4 tygodnie")]
        [InlineData(5, "5 tygodni")]
        [InlineData(6, "6 tygodni")]
        public void Weeks(int number, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(number * 7).Humanize());
        }

        [Fact]
        public void NoTime()
        {
            Assert.Equal("brak czasu", TimeSpan.Zero.Humanize());
        }
    }
}
