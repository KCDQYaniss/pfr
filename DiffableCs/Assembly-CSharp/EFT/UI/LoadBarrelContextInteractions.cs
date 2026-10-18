namespace EFT.UI;

public sealed class LoadBarrelContextInteractions : LoadAmmoContextInteractions
{
	private readonly Weapon _weapon; //Field offset: 0x40
	private readonly ItemContext _itemContext; //Field offset: 0x48

	public LoadBarrelContextInteractions(Weapon weapon, ItemContext itemContext, ItemUiContext uiContext) { }

	protected virtual Task Load(string ammoTemplateId) { }

}

