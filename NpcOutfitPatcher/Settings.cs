using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;

namespace HideArmorOutfitPatcher
{
    public class Settings
    {
        [SynthesisTooltip("NPCs to patch. Only these NPCs are touched; nothing else in the load order is.")]
        public List<FormLink<INpcGetter>> Npcs = new();

        [SynthesisTooltip("Placeholder contents for the outfit record of selected NPCs that have no outfit. NPCs that already have one are copied from their own outfit.")]
        public FormLink<IOutfitGetter> OutfitOverride = new();
    }
}
