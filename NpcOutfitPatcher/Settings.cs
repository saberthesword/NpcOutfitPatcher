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

        [SynthesisTooltip("Outfit to assign. Leave empty to auto-find by the Editor ID below.")]
        public FormLink<IOutfitGetter> HideArmorOutfit = new();

        [SynthesisTooltip("Fallback Editor ID used to find the hide armor outfit when no outfit is picked above.")]
        public string HideArmorOutfitEditorId = "ArmorHideOutfit";
    }
}
