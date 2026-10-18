namespace EFT.UI;

public sealed class HideoutCustomizationSlotItemSelectionCell : ItemSelectionCell, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action slotClickHandler; //Field offset: 0x10
		public HideoutCustomizationSlotItemSelectionCell <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private Button _clickHandlerButton; //Field offset: 0xF8
	[SerializeField]
	private Image _lockIcon; //Field offset: 0x100
	private HideoutCustomizationOffer _offer; //Field offset: 0x108
	private bool _isLocked; //Field offset: 0x110

	protected virtual IEnumerable AvailableItems
	{
		 get { } //Length: 110
	}

	public HideoutCustomizationSlotItemSelectionCell() { }

	public virtual void Close() { }

	protected virtual IEnumerable get_AvailableItems() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public virtual void SetItemsSetAbility(bool canSet) { }

	private void SetLocked() { }

	public void Show(Item currentSelectedItem, Func selectionChecker, Action selectionHandler, Action slotClickHandler, IEnumerable filters, HideoutCustomizationOffer offer) { }

}

