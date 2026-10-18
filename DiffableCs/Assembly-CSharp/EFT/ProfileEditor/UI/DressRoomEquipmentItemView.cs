namespace EFT.ProfileEditor.UI;

internal sealed class DressRoomEquipmentItemView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action onItemSelected; //Field offset: 0x10
		public DressRoomEquipmentItemView <>4__this; //Field offset: 0x18
		public ItemIcon itemIcon; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	private const float TOOLTIP_DELAY = 0.6; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private Button _button; //Field offset: 0x78
	private string _tooltip; //Field offset: 0x80
	private bool _equipped; //Field offset: 0x88

	public DressRoomEquipmentItemView() { }

	private void Highlight(bool hover = false) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void SetEquipped(bool equipped) { }

	public void Show(Item item, Action onItemSelected) { }

}

