namespace EFT.UI;

public sealed class MagPresetContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MagPresetContextInteractions <>4__this; //Field offset: 0x10
		public Magazine magazine; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public MagPreset preset; //Field offset: 0x10
		public <>c__DisplayClass7_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass7_1() { }

		internal void <.ctor>b__0() { }

	}

	internal enum EMagPresetInteraction
	{
		PresetManager = 0,
	}

	private static readonly Dictionary _itemCache; //Field offset: 0x0
	private readonly InventorySelectableItemContext _itemContext; //Field offset: 0x38
	private readonly ItemFactory _itemFactory; //Field offset: 0x40
	private readonly ItemUiContext _uiContext; //Field offset: 0x48

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	private static MagPresetContextInteractions() { }

	public MagPresetContextInteractions(InventorySelectableItemContext itemContext, MagBuildsStorage storage, ItemUiContext uiContext) { }

	protected virtual void ExecuteInteractionInternal(EMagPresetInteraction interaction) { }

	public virtual bool get_HasIcons() { }

	public virtual bool IsActive(EMagPresetInteraction button) { }

	public virtual IResult IsInteractive(EMagPresetInteraction button) { }

	private bool IsPresetCompatible(MagPreset preset, Magazine magazine) { }

	private void PresetSelectHandler(MagPreset preset, Magazine magazine) { }

}

