﻿using Pretty.Localisation;
using Xunit.Extensions;

namespace Pretty.Tests.Localisation.frBE
{
    public class DateHumanizeTests : AmbientCulture
    {
        public DateHumanizeTests() : base("fr-BE") { }

        [Theory]
        [InlineData(1, "il y a une seconde")]
        [InlineData(10, "il y a 10 secondes")]
        public void SecondsAgo(int seconds, string expected) 
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Past);
        }

        [Theory]
        [InlineData(1, "dans une seconde")]
        [InlineData(10, "dans 10 secondes")]
        public void SecondsFromNow(int seconds, string expected) 
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Future);
        }

        [Theory]
        [InlineData(1, "il y a une minute")]
        [InlineData(10, "il y a 10 minutes")]
        [InlineData(60, "il y a une heure")]
        public void MinutesAgo(int minutes, string expected) 
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Past);
        }

        [Theory]
        [InlineData(1, "dans une minute")]
        [InlineData(10, "dans 10 minutes")]
        public void MinutesFromNow(int minutes, string expected) 
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Future);
        }

        [Theory]
        [InlineData(1, "il y a une heure")]
        [InlineData(10, "il y a 10 heures")]
        public void HoursAgo(int hours, string expected) 
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Past);
        }

        [Theory]
        [InlineData(1, "dans une heure")]
        [InlineData(10, "dans 10 heures")]
        public void HoursFromNow(int hours, string expected) 
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Future);
        }

        [Theory]
        [InlineData(1, "hier")]
        [InlineData(10, "il y a 10 jours")]
        public void DaysAgo(int days, string expected) 
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Past);
        }

        [Theory]
        [InlineData(1, "demain")]
        [InlineData(10, "dans 10 jours")]
        public void DaysFromNow(int days, string expected) 
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Future);
        }

        [Theory]
        [InlineData(1, "il y a un mois")]
        [InlineData(10, "il y a 10 mois")]
        public void MonthsAgo(int months, string expected) 
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Past);
        }

        [Theory]
        [InlineData(1, "dans un mois")]
        [InlineData(10, "dans 10 mois")]
        public void MonthsFromNow(int months, string expected) 
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Future);
        }

        [Theory]
        [InlineData(1, "il y a un an")]
        [InlineData(2, "il y a 2 ans")]
        public void YearsAgo(int years, string expected) 
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Past);
        }

        [Theory]
        [InlineData(1, "dans un an")]
        [InlineData(2, "dans 2 ans")]
        public void YearsFromNow(int years, string expected) 
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Future);
        }
    }
}
