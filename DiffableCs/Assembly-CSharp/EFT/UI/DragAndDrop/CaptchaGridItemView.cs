namespace EFT.UI.DragAndDrop;

public sealed class CaptchaGridItemView : BaseSelectableItemView
{

	protected virtual bool Examined
	{
		 get { } //Length: 3
	}

	public CaptchaGridItemView() { }

	public static CaptchaGridItemView Create(Item item, SelectableItemContext sourceItemContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext) { }

	protected virtual bool get_Examined() { }

	protected virtual void HideTooltip() { }

	private CaptchaGridItemView NewCaptchaItemView(Item item, SelectableItemContext sourceItemContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, ItemUiContext itemUiContext) { }

	protected virtual void SetAvailability(bool available, string tooltip) { }

	protected virtual void ShowTooltip() { }

	public virtual void UpdateInfo() { }

}

