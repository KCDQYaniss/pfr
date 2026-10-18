namespace EFT.UI;

public sealed class ItemInfoWindowLabels : UIElement
{
	private const float ZOOM_SPEED = 0.12; //Field offset: 0x0
	[SerializeField]
	private GameObject _previewPanel; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _itemType; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _weightText; //Field offset: 0x90
	private DragTrigger _dragTrigger; //Field offset: 0x98
	private ScrollTrigger _scrollTrigger; //Field offset: 0xA0
	private WeaponPreview _weaponPreview; //Field offset: 0xA8

	private DragTrigger DragTrigger
	{
		private get { } //Length: 344
	}

	private ScrollTrigger ScrollTrigger
	{
		private get { } //Length: 344
	}

	public ItemInfoWindowLabels() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	[CompilerGenerated]
	private void <Show>b__13_1() { }

	private DragTrigger get_DragTrigger() { }

	private ScrollTrigger get_ScrollTrigger() { }

	private void Rotate(PointerEventData pointerData) { }

	internal void SetCaptionText(string value) { }

	internal void SetDescriptionText(string value) { }

	internal void SetItemTypeText(string value, bool addToText = false) { }

	internal void SetWeightText(string value) { }

	internal void Show(WeaponPreview weaponPreview, bool canDrag = true) { }

	private void Zoom(PointerEventData pointerData) { }

}

