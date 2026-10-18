namespace EFT.UI.Insurance;

public sealed class InsuranceContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0
	private readonly InsuranceCompany _insurance; //Field offset: 0x60
	private readonly InsuredItem _item; //Field offset: 0x68
	private readonly ItemUiContext _itemUiContext; //Field offset: 0x70

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	private static InsuranceContextInteractions() { }

	public InsuranceContextInteractions(InsuranceCompany insurance, InsuranceItemContext itemContext, ItemUiContext itemUiContext, Action onClose) { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	protected virtual void Insure() { }

	public virtual bool IsActive(EItemInfoButton button) { }

	protected virtual void RequestRedrawForItem() { }

	private void Uncover() { }

}

