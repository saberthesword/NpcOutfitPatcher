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

        [SynthesisTooltip("Source outfit (e.g. the default hide armor outfit). Its contents are copied into a new outfit record generated in the patch, which is assigned to selected NPCs that have no outfit.")]
        public FormLink<IOutfitGetter> OutfitOverride = new();
    }
}
