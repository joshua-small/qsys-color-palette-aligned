using QsysMods.Core;
namespace Designer.Modules.ColorPaletteAligned;
public sealed class PaletteModule : ModModule
{
    public PaletteModule() => Mods.Register("color-palette-aligned", _ => PaletteRows.Install((kind, detail) => Host.Receipt("color-palette-aligned", kind, detail)));
}
