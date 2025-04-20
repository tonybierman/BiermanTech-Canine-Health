using BiermanTech.CanineHealth;
using Xunit;

namespace BiermanTech.CanineHealth.Tests
{
    public class CanineMerCalculatorTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 2.20462)]
        [InlineData(10, 22.0462)]
        public void KgToLbs_ValidInput_ReturnsCorrectConversion(double kg, double expectedLbs)
        {
            // Act
            double result = CanineMerCalculator.KgToLbs(kg);

            // Assert
            Assert.Equal(expectedLbs, result, 4);
        }

        [Fact]
        public void KgToLbs_NegativeInput_ThrowsArgumentOutOfRangeException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CanineMerCalculator.KgToLbs(-1));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2.20462, 1)]
        [InlineData(22.0462, 10)]
        public void LbsToKg_ValidInput_ReturnsCorrectConversion(double lbs, double expectedKg)
        {
            // Act
            double result = CanineMerCalculator.LbsToKg(lbs);

            // Assert
            Assert.Equal(expectedKg, result, 4);
        }

        [Fact]
        public void LbsToKg_NegativeInput_ThrowsArgumentOutOfRangeException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CanineMerCalculator.LbsToKg(-1));
        }

        [Theory]
        [InlineData(2, 117.7255)] // Corrected: 70 * (2 ^ 0.75) ≈ 117.7255
        [InlineData(10, 393.6389)] // Corrected: 70 * (10 ^ 0.75) ≈ 393.6389
        public void CalculateRer_ValidInput_ReturnsCorrectRer(double bodyWeightKg, double expectedRer)
        {
            // Act
            double result = CanineMerCalculator.CalculateRer(bodyWeightKg);

            // Assert
            Assert.Equal(expectedRer, result, 4);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalculateRer_InvalidInput_ThrowsArgumentOutOfRangeException(double bodyWeightKg)
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CanineMerCalculator.CalculateRer(bodyWeightKg));
        }

        [Theory]
        [InlineData(LifeStageFactorsEnum.NeuteredAdult, 10, 1.4, 1.6)]
        [InlineData(LifeStageFactorsEnum.Puppy0To4Months, 5, 3.0, 3.0)]
        [InlineData(LifeStageFactorsEnum.ActiveWorkingDog, 15, 2.0, 5.0)]
        public void CalculateMer_ValidInput_ReturnsCorrectMerRange(LifeStageFactorsEnum lifeStage, double bodyWeightKg, double lowerFactor, double upperFactor)
        {
            // Arrange
            double expectedRer = CanineMerCalculator.CalculateRer(bodyWeightKg);
            double expectedLowerMer = expectedRer * lowerFactor;
            double expectedUpperMer = expectedRer * upperFactor;

            // Act
            var (rer, lowerMer, upperMer) = CanineMerCalculator.CalculateMer(lifeStage, bodyWeightKg);

            // Assert
            Assert.Equal(expectedRer, rer, 4);
            Assert.Equal(expectedLowerMer, lowerMer, 4);
            Assert.Equal(expectedUpperMer, upperMer, 4);
        }

        [Fact]
        public void CalculateMer_InvalidLifeStage_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => CanineMerCalculator.CalculateMer((LifeStageFactorsEnum)999, 10));
        }

        [Fact]
        public void CalculateMer_NegativeWeight_ThrowsArgumentOutOfRangeException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CanineMerCalculator.CalculateMer(LifeStageFactorsEnum.NeuteredAdult, -1));
        }

        [Theory]
        [InlineData(LifeStageFactorsEnum.NeuteredAdult, 1.4, 1.6)]
        [InlineData(LifeStageFactorsEnum.InactiveObeseProne, 1.2, 1.4)]
        [InlineData(LifeStageFactorsEnum.WeightLoss, 1.0, 1.0)]
        [InlineData(LifeStageFactorsEnum.Puppy0To4Months, 3.0, 3.0)]
        public void GetMerRange_ValidLifeStage_ReturnsCorrectFactors(LifeStageFactorsEnum lifeStage, double expectedLower, double expectedUpper)
        {
            // Act
            var (lowerFactor, upperFactor) = CanineMerCalculator.GetMerRange(lifeStage);

            // Assert
            Assert.Equal(expectedLower, lowerFactor, 4);
            Assert.Equal(expectedUpper, upperFactor, 4);
        }

        [Fact]
        public void GetMerRange_InvalidLifeStage_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => CanineMerCalculator.GetMerRange((LifeStageFactorsEnum)999));
        }

        [Theory]
        [InlineData(LifeStageFactorsEnum.NeuteredAdult, 10)]
        [InlineData(LifeStageFactorsEnum.Puppy0To4Months, 5)]
        public void CalculateMeanMer_ValidInput_ReturnsCorrectMeanMer(LifeStageFactorsEnum lifeStage, double bodyWeightKg)
        {
            // Arrange
            var (rer, lowerMer, upperMer) = CanineMerCalculator.CalculateMer(lifeStage, bodyWeightKg);
            double expectedMeanMer = (lowerMer + upperMer) / 2;

            // Act
            double result = CanineMerCalculator.CalculateMeanMer(lifeStage, bodyWeightKg);

            // Assert
            Assert.Equal(expectedMeanMer, result, 4);
        }

        [Fact]
        public void CalculateMeanMer_InvalidLifeStage_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => CanineMerCalculator.CalculateMeanMer((LifeStageFactorsEnum)999, 10));
        }

        [Fact]
        public void CalculateMeanMer_NegativeWeight_ThrowsArgumentOutOfRangeException()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CanineMerCalculator.CalculateMeanMer(LifeStageFactorsEnum.NeuteredAdult, -1));
        }
    }
}