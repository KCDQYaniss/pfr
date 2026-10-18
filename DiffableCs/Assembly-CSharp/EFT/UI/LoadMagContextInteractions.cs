namespace EFT.UI;

public sealed class LoadMagContextInteractions : LoadAmmoContextInteractions
{
	private readonly Magazine _magazine; //Field offset: 0x40
	private readonly ItemContext _itemContext; //Field offset: 0x48

	public LoadMagContextInteractions(Magazine magazine, ItemContext itemContext, ItemUiContext uiContext) { }

	protected virtual Task Load(string ammoTemplateId) { }

	protected virtual bool ShouldRedraw(string ammoTemplateId) { }

}

