using ErpComponents.Core.Interfaces;
using ErpComponents.Core.Theme;
using Xunit;

namespace ErpComponents.Tests;

public class ThemeConfigurationTests
{
    [Fact]
    public void DefaultThemeConfiguration_ShouldHaveDefaultColors()
    {
        // Arrange & Act
        var theme = new DefaultThemeConfiguration();
        
        // Assert
        Assert.NotNull(theme.PrimaryColors);
        Assert.NotNull(theme.SecondaryColors);
        Assert.NotNull(theme.SuccessColors);
        Assert.NotNull(theme.WarningColors);
        Assert.NotNull(theme.DangerColors);
        Assert.NotNull(theme.InfoColors);
        Assert.NotNull(theme.NeutralColors);
    }
    
    [Fact]
    public void ThemeBuilder_ShouldCreateCustomTheme()
    {
        // Arrange & Act
        var theme = new ThemeBuilder()
            .WithPrimaryColors(ThemeColors.Purple)
            .WithSecondaryColors(ThemeColors.Amber)
            .WithSuccessColors(ThemeColors.Green)
            .Build();
        
        // Assert
        Assert.Equal(ThemeColors.Purple, theme.PrimaryColors);
        Assert.Equal(ThemeColors.Amber, theme.SecondaryColors);
        Assert.Equal(ThemeColors.Green, theme.SuccessColors);
    }
    
    [Fact]
    public void ThemeColors_Blue_ShouldHaveCorrectHexValues()
    {
        // Arrange
        var blue = ThemeColors.Blue;
        
        // Assert
        Assert.Equal("#eff6ff", blue.Lightest);
        Assert.Equal("#3b82f6", blue.Default);
        Assert.Equal("#1e40af", blue.Darkest);
    }
    
    [Fact]
    public void NeutralColors_ShouldHaveAllGrayShades()
    {
        // Arrange
        var neutral = new NeutralColors();
        
        // Assert
        Assert.Equal("#ffffff", neutral.White);
        Assert.Equal("#f9fafb", neutral.Gray50);
        Assert.Equal("#111827", neutral.Gray900);
        Assert.Equal("#000000", neutral.Black);
    }
    
    [Fact]
    public void BorderConfiguration_ShouldHaveDefaultRadiusValues()
    {
        // Arrange
        var borders = new BorderConfiguration();
        
        // Assert
        Assert.Equal("0.125rem", borders.RadiusSm);
        Assert.Equal("0.375rem", borders.RadiusMd);
        Assert.Equal("0.5rem", borders.RadiusLg);
        Assert.Equal("9999px", borders.RadiusFull);
    }
    
    [Fact]
    public void ShadowConfiguration_ShouldHaveAllShadowLevels()
    {
        // Arrange
        var shadows = new ShadowConfiguration();
        
        // Assert
        Assert.Equal("none", shadows.None);
        Assert.Contains("rgba", shadows.Sm);
        Assert.Contains("rgba", shadows.Md);
        Assert.Contains("rgba", shadows.Lg);
        Assert.Contains("rgba", shadows.Xl);
    }
}
