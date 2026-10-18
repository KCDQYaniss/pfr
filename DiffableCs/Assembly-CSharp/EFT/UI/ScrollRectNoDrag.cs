namespace EFT.UI;

[ExecuteAlways]
public sealed class ScrollRectNoDrag : ScrollRect, ILayoutElement
{
	[SerializeField]
	public bool ControlSize; //Field offset: 0x130
	[SerializeField]
	public float MaxWidth; //Field offset: 0x134
	[SerializeField]
	public float MaxHeight; //Field offset: 0x138
	[SerializeField]
	public bool AutoZeroing; //Field offset: 0x13C
	[SerializeField]
	public TextAnchor Alignment; //Field offset: 0x140
	private ScrollbarVisibility _defaultHorizontalScrollbarVisibility; //Field offset: 0x144
	private float _preferredWidth; //Field offset: 0x148
	private float _preferredHeight; //Field offset: 0x14C
	private RectTransform _rectTransform; //Field offset: 0x150

	public virtual int layoutPriority
	{
		 get { } //Length: 6
	}

	private override float UnityEngine.UI.ILayoutElement.preferredHeight
	{
		private get { } //Length: 9
	}

	private override float UnityEngine.UI.ILayoutElement.preferredWidth
	{
		private get { } //Length: 9
	}

	public ScrollRectNoDrag() { }

	protected virtual void Awake() { }

	public virtual int get_layoutPriority() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public virtual void OnScroll(PointerEventData data) { }

	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	private override void UnityEngine.UI.ILayoutElement.CalculateLayoutInputHorizontal() { }

	private override void UnityEngine.UI.ILayoutElement.CalculateLayoutInputVertical() { }

	private override float UnityEngine.UI.ILayoutElement.get_preferredHeight() { }

	private override float UnityEngine.UI.ILayoutElement.get_preferredWidth() { }

	private void Update() { }

	public void UpdateLayout() { }

}

