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

        [SynthesisTooltip("Outfit assigned to every selected NPC that doesn't already have one.")]
        public FormLink<IOutfitGetter> OutfitOverride = new();
    }
}
