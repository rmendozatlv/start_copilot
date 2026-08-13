using Microsoft.AspNetCore.Components;

namespace ErpComponents.Core.Components.Base;

/// <summary>
/// Clase base para todos los componentes de ERP Components
/// Proporciona funcionalidad común y acceso a la configuración del tema
/// </summary>
public abstract class ErpComponentBase : ComponentBase, IDisposable
{
    private bool _disposed;
    
    /// <summary>
    /// Servicio de configuración del tema (inyectado en componentes derivados)
    /// </summary>
    [Parameter]
    public Interfaces.IThemeConfiguration? Theme { get; set; }
    
    /// <summary>
    /// Clase CSS personalizada adicional
    /// </summary>
    [Parameter]
    public string? Class { get; set; }
    
    /// <summary>
    /// Estilo inline personalizado adicional
    /// </summary>
    [Parameter]
    public string? Style { get; set; }
    
    /// <summary>
    /// Indica si el componente está deshabilitado
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }
    
    /// <summary>
    /// Tamaño del componente (sm, md, lg)
    /// </summary>
    [Parameter]
    public string Size { get; set; } = "md";
    
    /// <summary>
    /// Evento invocado cuando el componente se inicializa
    /// </summary>
    public event EventHandler? ComponentInitialized;
    
    /// <summary>
    /// Obtiene el tema actual o el tema por defecto
    /// </summary>
    protected Interfaces.IThemeConfiguration CurrentTheme => Theme ?? new Theme.DefaultThemeConfiguration();
    
    /// <summary>
    /// Construye clases CSS combinando clases base y personalizadas
    /// </summary>
    /// <param name="baseClasses">Clases base del componente</param>
    /// <returns>Cadena de clases CSS completa</returns>
    protected string BuildClass(params string[] baseClasses)
    {
        var classes = new List<string>(baseClasses.Where(c => !string.IsNullOrWhiteSpace(c)));
        
        if (!string.IsNullOrWhiteSpace(Class))
        {
            classes.Add(Class);
        }
        
        if (Disabled)
        {
            classes.Add("opacity-50");
            classes.Add("cursor-not-allowed");
            classes.Add("pointer-events-none");
        }
        
        return string.Join(" ", classes);
    }
    
    /// <summary>
    /// Obtiene las clases de tamaño según el parámetro Size
    /// </summary>
    protected string GetSizeClasses()
    {
        return Size switch
        {
            "sm" => "text-sm px-2 py-1",
            "lg" => "text-lg px-4 py-3",
            _ => "text-base px-3 py-2"
        };
    }
    
    /// <summary>
    /// Invoca el evento de inicialización del componente
    /// </summary>
    protected virtual void OnComponentInitialized()
    {
        ComponentInitialized?.Invoke(this, EventArgs.Empty);
    }
    
    /// <summary>
    /// Método llamado después de que el componente se haya inicializado
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();
        OnComponentInitialized();
    }
    
    /// <summary>
    /// Libera recursos utilizados por el componente
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    /// <summary>
    /// Método protegido para liberar recursos
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            // Liberar recursos administrados aquí
        }
        
        _disposed = true;
    }
}
