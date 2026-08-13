using ErpComponents.Core.Interfaces;

namespace ErpComponents.Core.Theme;

/// <summary>
/// Implementación por defecto de la configuración del tema
/// </summary>
public class DefaultThemeConfiguration : IThemeConfiguration
{
    public ThemeColors PrimaryColors { get; } = ThemeColors.Blue;
    public ThemeColors SecondaryColors { get; } = ThemeColors.Purple;
    public ThemeColors SuccessColors { get; } = ThemeColors.Green;
    public ThemeColors WarningColors { get; } = ThemeColors.Amber;
    public ThemeColors DangerColors { get; } = ThemeColors.Red;
    public ThemeColors InfoColors { get; } = ThemeColors.Blue;
    public NeutralColors NeutralColors { get; } = new NeutralColors();
    public BorderConfiguration Borders { get; } = new BorderConfiguration();
    public ShadowConfiguration Shadows { get; } = new ShadowConfiguration();
    public SpacingConfiguration Spacing { get; } = new SpacingConfiguration();
}

/// <summary>
/// Constructor fluido para crear configuraciones de tema personalizadas
/// </summary>
public class ThemeBuilder
{
    private ThemeColors _primaryColors = ThemeColors.Blue;
    private ThemeColors _secondaryColors = ThemeColors.Purple;
    private ThemeColors _successColors = ThemeColors.Green;
    private ThemeColors _warningColors = ThemeColors.Amber;
    private ThemeColors _dangerColors = ThemeColors.Red;
    private ThemeColors _infoColors = ThemeColors.Blue;
    private NeutralColors _neutralColors = new NeutralColors();
    private BorderConfiguration _borders = new BorderConfiguration();
    private ShadowConfiguration _shadows = new ShadowConfiguration();
    private SpacingConfiguration _spacing = new SpacingConfiguration();

    public ThemeBuilder WithPrimaryColors(ThemeColors colors)
    {
        _primaryColors = colors;
        return this;
    }

    public ThemeBuilder WithSecondaryColors(ThemeColors colors)
    {
        _secondaryColors = colors;
        return this;
    }

    public ThemeBuilder WithSuccessColors(ThemeColors colors)
    {
        _successColors = colors;
        return this;
    }

    public ThemeBuilder WithWarningColors(ThemeColors colors)
    {
        _warningColors = colors;
        return this;
    }

    public ThemeBuilder WithDangerColors(ThemeColors colors)
    {
        _dangerColors = colors;
        return this;
    }

    public ThemeBuilder WithInfoColors(ThemeColors colors)
    {
        _infoColors = colors;
        return this;
    }

    public ThemeBuilder WithNeutralColors(NeutralColors colors)
    {
        _neutralColors = colors;
        return this;
    }

    public ThemeBuilder WithBorders(BorderConfiguration borders)
    {
        _borders = borders;
        return this;
    }

    public ThemeBuilder WithShadows(ShadowConfiguration shadows)
    {
        _shadows = shadows;
        return this;
    }

    public ThemeBuilder WithSpacing(SpacingConfiguration spacing)
    {
        _spacing = spacing;
        return this;
    }

    public IThemeConfiguration Build()
    {
        return new CustomThemeConfiguration(
            _primaryColors,
            _secondaryColors,
            _successColors,
            _warningColors,
            _dangerColors,
            _infoColors,
            _neutralColors,
            _borders,
            _shadows,
            _spacing
        );
    }
}

/// <summary>
/// Implementación de tema personalizado
/// </summary>
internal class CustomThemeConfiguration : IThemeConfiguration
{
    public CustomThemeConfiguration(
        ThemeColors primaryColors,
        ThemeColors secondaryColors,
        ThemeColors successColors,
        ThemeColors warningColors,
        ThemeColors dangerColors,
        ThemeColors infoColors,
        NeutralColors neutralColors,
        BorderConfiguration borders,
        ShadowConfiguration shadows,
        SpacingConfiguration spacing)
    {
        PrimaryColors = primaryColors;
        SecondaryColors = secondaryColors;
        SuccessColors = successColors;
        WarningColors = warningColors;
        DangerColors = dangerColors;
        InfoColors = infoColors;
        NeutralColors = neutralColors;
        Borders = borders;
        Shadows = shadows;
        Spacing = spacing;
    }

    public ThemeColors PrimaryColors { get; }
    public ThemeColors SecondaryColors { get; }
    public ThemeColors SuccessColors { get; }
    public ThemeColors WarningColors { get; }
    public ThemeColors DangerColors { get; }
    public ThemeColors InfoColors { get; }
    public NeutralColors NeutralColors { get; }
    public BorderConfiguration Borders { get; }
    public ShadowConfiguration Shadows { get; }
    public SpacingConfiguration Spacing { get; }
}
