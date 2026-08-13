namespace ErpComponents.Core.Interfaces;

/// <summary>
/// Interfaz para la configuración del tema de los componentes
/// </summary>
public interface IThemeConfiguration
{
    /// <summary>
    /// Colores primarios del tema
    /// </summary>
    ThemeColors PrimaryColors { get; }
    
    /// <summary>
    /// Colores secundarios del tema
    /// </summary>
    ThemeColors SecondaryColors { get; }
    
    /// <summary>
    /// Colores de éxito
    /// </summary>
    ThemeColors SuccessColors { get; }
    
    /// <summary>
    /// Colores de advertencia
    /// </summary>
    ThemeColors WarningColors { get; }
    
    /// <summary>
    /// Colores de error/peligro
    /// </summary>
    ThemeColors DangerColors { get; }
    
    /// <summary>
    /// Colores de información
    /// </summary>
    ThemeColors InfoColors { get; }
    
    /// <summary>
    /// Colores neutros (grises)
    /// </summary>
    NeutralColors NeutralColors { get; }
    
    /// <summary>
    /// Configuración de bordes
    /// </summary>
    BorderConfiguration Borders { get; }
    
    /// <summary>
    /// Configuración de sombras
    /// </summary>
    ShadowConfiguration Shadows { get; }
    
    /// <summary>
    /// Espaciado personalizado
    /// </summary>
    SpacingConfiguration Spacing { get; }
}

/// <summary>
/// Configuración de colores del tema
/// </summary>
public record ThemeColors
{
    public string Lightest { get; init; } = "#ffffff";
    public string Lighter { get; init; } = "#f3f4f6";
    public string Light { get; init; } = "#e5e7eb";
    public string Default { get; init; } = "#6b7280";
    public string Dark { get; init; } = "#374151";
    public string Darker { get; init; } = "#1f2937";
    public string Darkest { get; init; } = "#111827";
    
    public static ThemeColors Blue => new()
    {
        Lightest = "#eff6ff",
        Lighter = "#dbeafe",
        Light = "#bfdbfe",
        Default = "#3b82f6",
        Dark = "#2563eb",
        Darker = "#1d4ed8",
        Darkest = "#1e40af"
    };
    
    public static ThemeColors Green => new()
    {
        Lightest = "#f0fdf4",
        Lighter = "#dcfce7",
        Light = "#bbf7d0",
        Default = "#22c55e",
        Dark = "#16a34a",
        Darker = "#15803d",
        Darkest = "#166534"
    };
    
    public static ThemeColors Red => new()
    {
        Lightest = "#fef2f2",
        Lighter = "#fee2e2",
        Light = "#fecaca",
        Default = "#ef4444",
        Dark = "#dc2626",
        Darker = "#b91c1c",
        Darkest = "#991b1b"
    };
    
    public static ThemeColors Amber => new()
    {
        Lightest = "#fffbeb",
        Lighter = "#fef3c7",
        Light = "#fde68a",
        Default = "#f59e0b",
        Dark = "#d97706",
        Darker = "#b45309",
        Darkest = "#92400e"
    };
    
    public static ThemeColors Purple => new()
    {
        Lightest = "#faf5ff",
        Lighter = "#f3e8ff",
        Light = "#e9d5ff",
        Default = "#a855f7",
        Dark = "#9333ea",
        Darker = "#7e22ce",
        Darkest = "#6b21a8"
    };
}

/// <summary>
/// Colores neutros para el tema
/// </summary>
public record NeutralColors
{
    public string White { get; init; } = "#ffffff";
    public string Gray50 { get; init; } = "#f9fafb";
    public string Gray100 { get; init; } = "#f3f4f6";
    public string Gray200 { get; init; } = "#e5e7eb";
    public string Gray300 { get; init; } = "#d1d5db";
    public string Gray400 { get; init; } = "#9ca3af";
    public string Gray500 { get; init; } = "#6b7280";
    public string Gray600 { get; init; } = "#4b5563";
    public string Gray700 { get; init; } = "#374151";
    public string Gray800 { get; init; } = "#1f2937";
    public string Gray900 { get; init; } = "#111827";
    public string Black { get; init; } = "#000000";
}

/// <summary>
/// Configuración de bordes
/// </summary>
public record BorderConfiguration
{
    public string RadiusSm { get; init; } = "0.125rem";
    public string RadiusMd { get; init; } = "0.375rem";
    public string RadiusLg { get; init; } = "0.5rem";
    public string RadiusXl { get; init; } = "0.75rem";
    public string Radius2xl { get; init; } = "1rem";
    public string RadiusFull { get; init; } = "9999px";
    
    public string WidthThin { get; init; } = "1px";
    public string WidthDefault { get; init; } = "2px";
    public string WidthThick { get; init; } = "4px";
}

/// <summary>
/// Configuración de sombras
/// </summary>
public record ShadowConfiguration
{
    public string None { get; init; } = "none";
    public string Sm { get; init; } = "0 1px 2px 0 rgba(0, 0, 0, 0.05)";
    public string Md { get; init; } = "0 4px 6px -1px rgba(0, 0, 0, 0.1), 0 2px 4px -1px rgba(0, 0, 0, 0.06)";
    public string Lg { get; init; } = "0 10px 15px -3px rgba(0, 0, 0, 0.1), 0 4px 6px -2px rgba(0, 0, 0, 0.05)";
    public string Xl { get; init; } = "0 20px 25px -5px rgba(0, 0, 0, 0.1), 0 10px 10px -5px rgba(0, 0, 0, 0.04)";
    public string Inner { get; init; } = "inset 0 2px 4px 0 rgba(0, 0, 0, 0.06)";
}

/// <summary>
/// Configuración de espaciado
/// </summary>
public record SpacingConfiguration
{
    public string Xs { get; init; } = "0.25rem";
    public string Sm { get; init; } = "0.5rem";
    public string Md { get; init; } = "1rem";
    public string Lg { get; init; } = "1.5rem";
    public string Xl { get; init; } = "2rem";
    public string Xxl { get; init; } = "3rem";
}
