# ErpComponents - Biblioteca de Componentes Blazor para ERP

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET 9.0](https://img.shields.io/badge/.NET-9.0-purple)](https://dotnet.microsoft.com/)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-512BD4)](https://blazor.net/)
[![Tailwind CSS 4](https://img.shields.io/badge/Tailwind-4.0-38B2AC)](https://tailwindcss.com/)

## Descripción

**ErpComponents** es una biblioteca de componentes reutilizables construida con **Blazor WebAssembly** y **Tailwind CSS 4**, diseñada específicamente para sistemas ERP pero lo suficientemente flexible para ser utilizada en cualquier tipo de aplicación web empresarial.

### Características Principales

✨ **Altamente Personalizable** - Sistema de temas basado en CSS custom properties  
🎨 **Tailwind CSS 4** - Utilidades modernas y eficientes  
♿ **Accesible** - Cumple con estándares WCAG  
📱 **Responsive** - Diseño mobile-first  
🌐 **Internacionalización** - Soporte multi-lenguaje  
🧩 **Componentes Modulares** - Fácil extensión y mantenimiento  

## Componentes Disponibles

### Formulario
- `ErpInput` - Input de texto con validación, iconos y soporte password
- `ErpSelect` - Select personalizado con opciones dinámicas
- `ErpCheckbox` - Checkbox estilizado (próximamente)
- `ErpRadio` - Radio button estilizado (próximamente)

### Datos
- `ErpDataGrid` - Tabla de datos con paginación, ordenamiento y selección

### Layout
- `ErpCard` - Tarjeta contenedora con header, body y footer
- `ErpLayout` - Layout principal de la aplicación (próximamente)
- `ErpSidebar` - Barra lateral de navegación (próximamente)

### Navegación
- `ErpMenu` - Menú de navegación (próximamente)
- `ErpBreadcrumb` - Migas de pan (próximamente)

### Feedback
- `ErpButton` - Botón con múltiples variantes y estados
- `ErpAlert` - Mensajes de alerta (próximamente)
- `ErpModal` - Ventanas modales (próximamente)

## Instalación

### Vía NuGet (Próximamente)

```bash
dotnet add package ErpComponents.Core
```

### Instalación Manual

1. Clona el repositorio:
```bash
git clone https://github.com/tu-usuario/erp-components.git
```

2. Agrega la referencia al proyecto:
```bash
cd tu-proyecto
dotnet add reference ../erp-components/src/ErpComponents.Core/ErpComponents.Core.csproj
```

3. Importa los namespaces en `_Imports.razor`:
```razor
@using ErpComponents.Core
@using ErpComponents.Core.Components.Base
@using ErpComponents.Core.Interfaces
@using ErpComponents.Core.Theme
```

4. Agrega los estilos en `wwwroot/index.html` o `App.razor`:
```html
<link href="_content/ErpComponents.Core/css/erp-components.css" rel="stylesheet" />
```

## Uso

### Configuración del Tema

```csharp
// Tema por defecto
var defaultTheme = new DefaultThemeConfiguration();

// Tema personalizado con ThemeBuilder
var customTheme = new ThemeBuilder()
    .WithPrimaryColors(ThemeColors.Purple)
    .WithSecondaryColors(ThemeColors.Amber)
    .WithSuccessColors(ThemeColors.Green)
    .Build();
```

### Ejemplo: Botón

```razor
<ErpButton Variant="primary" OnClick="HandleClick">
    Guardar
</ErpButton>

<ErpButton Variant="danger" Icon="🗑️" Loading="@isLoading">
    Eliminar
</ErpButton>

<ErpButton Variant="outline" Size="lg">
    Ver Detalles
</ErpButton>
```

### Ejemplo: Input

```razor
<ErpInput 
    Label="Email" 
    @bind-CurrentValue="@email" 
    Type="email"
    Required="true"
    Icon="📧"
    Placeholder="tu@email.com"
    ValidationError="@emailError"
    ErrorMessage="El email no es válido" />
```

### Ejemplo: DataGrid

```razor
<ErpDataGrid 
    Title="Clientes"
    Data="@clientes"
    Columns="@columnas"
    ShowPagination="true"
    PageSize="10"
    ShowRowSelection="true"
    PageChanged="OnPageChanged"
    SortChanged="OnSortChanged">
    
    <ToolbarTemplate>
        <ErpButton Variant="primary" OnClick="NuevoCliente">
            + Nuevo Cliente
        </ErpButton>
    </ToolbarTemplate>
    
    <ActionsTemplate context="cliente">
        <ErpButton Variant="ghost" Size="sm" OnClick="() => Editar(cliente)">
            Editar
        </ErpButton>
    </ActionsTemplate>
</ErpDataGrid>

@code {
    private List<Cliente> clientes = new();
    private IEnumerable<DataGridColumn> columnas = new[]
    {
        new DataGridColumn { Title = "ID", Field = "Id", Sortable = true },
        new DataGridColumn { Title = "Nombre", Field = "Nombre", Sortable = true },
        new DataGridColumn { Title = "Email", Field = "Email" }
    };
}
```

## Arquitectura

```
ErpComponents.Core/
├── Components/
│   ├── Base/           # Clases base para componentes
│   ├── Common/         # Componentes comunes (Button, Card)
│   ├── Forms/          # Componentes de formulario (Input, Select)
│   ├── DataGrid/       # Componentes de datos
│   ├── Layout/         # Componentes de layout
│   └── Navigation/     # Componentes de navegación
├── Interfaces/         # Interfaces para contratos
├── Theme/              # Configuración de temas
├── Styles/             # Estilos CSS/Tailwind
├── Extensions/         # Extensiones y helpers
└── Services/           # Servicios utilitarios
```

## Principios de Diseño

### Clean Architecture
- Separación clara de responsabilidades
- Bajo acoplamiento entre componentes
- Alta cohesión dentro de cada componente

### SOLID
- **Single Responsibility**: Cada componente tiene una única responsabilidad
- **Open/Closed**: Abierto para extensión, cerrado para modificación
- **Liskov Substitution**: Los componentes derivados pueden sustituir a los base
- **Interface Segregation**: Interfaces pequeñas y específicas
- **Dependency Inversion**: Dependencia de abstracciones, no implementaciones

### Buenas Prácticas
- Documentación XML completa
- Validación de parámetros
- Manejo adecuado de estados (loading, disabled, error)
- Soporte para atributos unmatched (CaptureUnmatchedValues)
- Patrones de diseño Blazor (EventCallback, RenderFragment, Two-way binding)

## Roadmap

- [ ] ErpCheckbox
- [ ] ErpRadio
- [ ] ErpModal
- [ ] ErpAlert
- [ ] ErpToast
- [ ] ErpDatePicker
- [ ] ErpAutocomplete
- [ ] ErpTabs
- [ ] ErpAccordion
- [ ] ErpProgressBar
- [ ] ErpSkeleton
- [ ] ErpAvatar
- [ ] ErpBadge
- [ ] Dark Mode completo
- [ ] Internacionalización (i18n)
- [ ] Tests unitarios
- [ ] Documentación interactiva (Storybook-like)

## Contribución

Las contribuciones son bienvenidas. Por favor:

1. Haz un fork del proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

Distribuido bajo la licencia MIT. Ver `LICENSE` para más información.

## Contacto

Tu Nombre - [@twitterhandle](https://twitter.com/handle) - email@example.com

Project Link: [https://github.com/tu-usuario/erp-components](https://github.com/tu-usuario/erp-components)

---

Hecho con ❤️ usando Blazor y Tailwind CSS
