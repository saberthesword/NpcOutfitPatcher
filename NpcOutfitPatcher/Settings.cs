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

        [SynthesisTooltip("Placeholder entry used as the contents of the outfit record created for each NPC whose plugin has no Outfit records.")]
        public FormLink<IOutfitGetter> OutfitOverride = new();
    }
}
