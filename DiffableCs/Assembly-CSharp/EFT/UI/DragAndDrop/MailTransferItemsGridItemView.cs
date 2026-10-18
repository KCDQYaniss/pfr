namespace EFT.UI.DragAndDrop;

public sealed class MailTransferItemsGridItemView : GridItemView
{
	[SerializeField]
	private GameObject _expiredTimeBackground; //Field offset: 0x2E0
	[SerializeField]
	private TMP_Text _timeLeftText; //Field offset: 0x2E8
	private Nullable _timeLeft; //Field offset: 0x2F0

	public MailTransferItemsGridItemView() { }

	public static MailTransferItemsGridItemView Create(Item item, MailTransferItemsItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistManager) { }

	private void EnableExpirationView(bool enable) { }

	private MailTransferItemsGridItemView NewMailTransferItemsGridItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, Nullable timeLeft, WishlistManager wishlistManager) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

}

