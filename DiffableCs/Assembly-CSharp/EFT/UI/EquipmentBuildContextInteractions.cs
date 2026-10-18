namespace EFT.UI;

public sealed class EquipmentBuildContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	private static EquipmentBuildContextInteractions() { }

	public EquipmentBuildContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

}

