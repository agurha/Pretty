﻿using Xunit;
using Xunit.Extensions;

namespace Pretty.Tests.Localisation.ptBR
{
    public class NumberToWordsTests : AmbientCulture
    {
        public NumberToWordsTests()
            : base("pt-BR")
        {
        }

        [Theory]
        [InlineData(1, "um")]
        [InlineData(10, "dez")]
        [InlineData(11, "onze")]
        [InlineData(21, "vinte e um")]
        [InlineData(122, "cento e vinte e dois")]
        [InlineData(3501, "três mil quinhentos e um")]
        [InlineData(100, "cem")]
        [InlineData(1000, "mil")]
        [InlineData(100000, "cem mil")]
        [InlineData(1000000, "um milhão")]
        [InlineData(10000000, "dez milhões")]
        [InlineData(100000000, "cem milhões")]
        [InlineData(1000000000, "um bilhão")]
        [InlineData(111, "cento e onze")]
        [InlineData(1111, "mil cento e onze")]
        [InlineData(111111, "cento e onze mil cento e onze")]
        [InlineData(1111101, "um milhão cento e onze mil cento e um")]
        [InlineData(1111111, "um milhão cento e onze mil cento e onze")]
        [InlineData(11111111, "onze milhões cento e onze mil cento e onze")]
        [InlineData(111111111, "cento e onze milhões cento e onze mil cento e onze")]
        [InlineData(1101111101, "um bilhão cento e um milhões cento e onze mil cento e um")]
        [InlineData(1111111111, "um bilhão cento e onze milhões cento e onze mil cento e onze")]
        [InlineData(123, "cento e vinte e três")]
        [InlineData(1234, "mil duzentos e trinta e quatro")]
        [InlineData(8100, "oito mil e cem")]
        [InlineData(12345, "doze mil trezentos e quarenta e cinco")]
        [InlineData(123456, "cento e vinte e três mil quatrocentos e cinquenta e seis")]
        [InlineData(1234567, "um milhão duzentos e trinta e quatro mil quinhentos e sessenta e sete")]
        [InlineData(12345678, "doze milhões trezentos e quarenta e cinco mil seiscentos e setenta e oito")]
        [InlineData(123456789, "cento e vinte e três milhões quatrocentos e cinquenta e seis mil setecentos e oitenta e nove")]
        [InlineData(1234567890, "um bilhão duzentos e trinta e quatro milhões quinhentos e sessenta e sete mil oitocentos e noventa")]
        [InlineData(1999, "mil novecentos e noventa e nove")]
        [InlineData(2014, "dois mil e quatorze")]
        [InlineData(2048, "dois mil e quarenta e oito")]
        public void ToWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords());
        }

        [Theory]
        [InlineData(1, "uma")]
        [InlineData(2, "duas")]
        [InlineData(3, "três")]
        [InlineData(11, "onze")]
        [InlineData(21, "vinte e uma")]
        [InlineData(122, "cento e vinte e duas")]
        [InlineData(232, "duzentas e trinta e duas")]
        [InlineData(343, "trezentas e quarenta e três")]
        [InlineData(3501, "três mil quinhentas e uma")]
        [InlineData(100, "cem")]
        [InlineData(1000, "mil")]
        [InlineData(111, "cento e onze")]
        [InlineData(1111, "mil cento e onze")]
        [InlineData(111111, "cento e onze mil cento e onze")]
        [InlineData(1111101, "um milhão cento e onze mil cento e uma")]
        [InlineData(1111111, "um milhão cento e onze mil cento e onze")]
        [InlineData(1101111101, "um bilhão cento e um milhões cento e onze mil cento e uma")]
        [InlineData(1234, "mil duzentas e trinta e quatro")]
        [InlineData(8100, "oito mil e cem")]
        [InlineData(12345, "doze mil trezentas e quarenta e cinco")]
        public void ToFeminineWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords(GrammaticalGender.Feminine));
        }

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "primeiro")]
        [InlineData(2, "segundo")]
        [InlineData(3, "terceiro")]
        [InlineData(4, "quarto")]
        [InlineData(5, "quinto")]
        [InlineData(6, "sexto")]
        [InlineData(7, "sétimo")]
        [InlineData(8, "oitavo")]
        [InlineData(9, "nono")]
        [InlineData(10, "décimo")]
        [InlineData(11, "décimo primeiro")]
        [InlineData(12, "décimo segundo")]
        [InlineData(13, "décimo terceiro")]
        [InlineData(14, "décimo quarto")]
        [InlineData(15, "décimo quinto")]
        [InlineData(16, "décimo sexto")]
        [InlineData(17, "décimo sétimo")]
        [InlineData(18, "décimo oitavo")]
        [InlineData(19, "décimo nono")]
        [InlineData(20, "vigésimo")]
        [InlineData(21, "vigésimo primeiro")]
        [InlineData(22, "vigésimo segundo")]
        [InlineData(30, "trigésimo")]
        [InlineData(40, "quadragésimo")]
        [InlineData(50, "quinquagésimo")]
        [InlineData(60, "sexagésimo")]
        [InlineData(70, "septuagésimo")]
        [InlineData(80, "octogésimo")]
        [InlineData(90, "nonagésimo")]
        [InlineData(95, "nonagésimo quinto")]
        [InlineData(96, "nonagésimo sexto")]
        [InlineData(100, "centésimo")]
        [InlineData(120, "centésimo vigésimo")]
        [InlineData(121, "centésimo vigésimo primeiro")]
        [InlineData(200, "ducentésimo")]
        [InlineData(300, "trecentésimo")]
        [InlineData(400, "quadringentésimo")]
        [InlineData(500, "quingentésimo")]
        [InlineData(600, "sexcentésimo")]
        [InlineData(700, "septingentésimo")]
        [InlineData(800, "octingentésimo")]
        [InlineData(900, "noningentésimo")]
        [InlineData(1000, "milésimo")]
        [InlineData(1001, "milésimo primeiro")]
        [InlineData(1021, "milésimo vigésimo primeiro")]
        [InlineData(2021, "segundo milésimo vigésimo primeiro")]
        [InlineData(10000, "décimo milésimo")]
        [InlineData(10121, "décimo milésimo centésimo vigésimo primeiro")]
        [InlineData(100000, "centésimo milésimo")]
        [InlineData(1000000, "milionésimo")]
        [InlineData(1000000000, "bilionésimo")]
        public void ToOrdinalWords(int number, string words)
        {
            Assert.Equal(words, number.ToOrdinalWords());
        }

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "primeira")]
        [InlineData(2, "segunda")]
        [InlineData(3, "terceira")]
        [InlineData(4, "quarta")]
        [InlineData(5, "quinta")]
        [InlineData(6, "sexta")]
        [InlineData(7, "sétima")]
        [InlineData(8, "oitava")]
        [InlineData(9, "nona")]
        [InlineData(10, "décima")]
        [InlineData(11, "décima primeira")]
        [InlineData(12, "décima segunda")]
        [InlineData(13, "décima terceira")]
        [InlineData(14, "décima quarta")]
        [InlineData(15, "décima quinta")]
        [InlineData(16, "décima sexta")]
        [InlineData(17, "décima sétima")]
        [InlineData(18, "décima oitava")]
        [InlineData(19, "décima nona")]
        [InlineData(20, "vigésima")]
        [InlineData(21, "vigésima primeira")]
        [InlineData(22, "vigésima segunda")]
        [InlineData(30, "trigésima")]
        [InlineData(40, "quadragésima")]
        [InlineData(50, "quinquagésima")]
        [InlineData(60, "sexagésima")]
        [InlineData(70, "septuagésima")]
        [InlineData(80, "octogésima")]
        [InlineData(90, "nonagésima")]
        [InlineData(95, "nonagésima quinta")]
        [InlineData(96, "nonagésima sexta")]
        [InlineData(100, "centésima")]
        [InlineData(120, "centésima vigésima")]
        [InlineData(121, "centésima vigésima primeira")]
        [InlineData(200, "ducentésima")]
        [InlineData(300, "trecentésima")]
        [InlineData(400, "quadringentésima")]
        [InlineData(500, "quingentésima")]
        [InlineData(600, "sexcentésima")]
        [InlineData(700, "septingentésima")]
        [InlineData(800, "octingentésima")]
        [InlineData(900, "noningentésima")]
        [InlineData(1000, "milésima")]
        [InlineData(1001, "milésima primeira")]
        [InlineData(1021, "milésima vigésima primeira")]
        [InlineData(2021, "segunda milésima vigésima primeira")]
        [InlineData(10000, "décima milésima")]
        [InlineData(10121, "décima milésima centésima vigésima primeira")]
        [InlineData(100000, "centésima milésima")]
        [InlineData(1000000, "milionésima")]
        [InlineData(1000000000, "bilionésima")]
        public void ToFeminineOrdinalWords(int number, string words)
        {
            Assert.Equal(words, number.ToOrdinalWords(GrammaticalGender.Feminine));
        }
    }
}