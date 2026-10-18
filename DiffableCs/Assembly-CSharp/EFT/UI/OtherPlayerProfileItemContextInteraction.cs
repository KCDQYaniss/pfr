namespace EFT.UI;

public sealed class OtherPlayerProfileItemContextInteraction : BaseItemContextInteractions
{
	private static readonly IReadOnlyList _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	public virtual bool ExaminationRequired
	{
		 get { } //Length: 3
	}

	private static OtherPlayerProfileItemContextInteraction() { }

	public OtherPlayerProfileItemContextInteraction(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction = null) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	public virtual bool get_ExaminationRequired() { }

}

