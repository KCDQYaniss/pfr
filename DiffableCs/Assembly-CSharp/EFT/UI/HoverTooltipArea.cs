namespace EFT.UI;

public class HoverTooltipArea : HoverTooltipAreaBase, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IDisposable
{
	[SerializeField]
	private string _message; //Field offset: 0x20
	[SerializeField]
	private float _delay; //Field offset: 0x28
	[SerializeField]
	private bool _limitTooltipWidth; //Field offset: 0x2C
	[SerializeField]
	private bool _customOffset; //Field offset: 0x2D
	[SerializeField]
	private Vector2 _offset; //Field offset: 0x30
	private Func _messageGetter; //Field offset: 0x38
	private SimpleTooltip _tooltip; //Field offset: 0x40
	private CanvasGroup _canvasGroup; //Field offset: 0x48
	private bool _rawText; //Field offset: 0x50
	private CancellationToken _cancellationToken; //Field offset: 0x58

	private bool Active
	{
		private get { } //Length: 141
	}

	public CanvasGroup CanvasGroup
	{
		 get { } //Length: 335
	}

	private string Message
	{
		private get { } //Length: 206
	}

	private string RawMessage
	{
		private get { } //Length: 47
	}

	private Nullable TooltipWidthLimit
	{
		private get { } //Length: 89
	}

	public HoverTooltipArea() { }

	private void Awake() { }

	public void Close() { }

	public override void Dispose() { }

	private bool get_Active() { }

	public CanvasGroup get_CanvasGroup() { }

	private string get_Message() { }

	private string get_RawMessage() { }

	private Nullable get_TooltipWidthLimit() { }

	public void Init(SimpleTooltip tooltip, Func textGetter) { }

	public void Init(SimpleTooltip tooltip, string text, bool rawText = false) { }

	private void OnApplicationFocus(bool inFocus) { }

	private void OnDisable() { }

	public virtual void SetMessageText(string text, bool rawText = false) { }

	public virtual void SetMessageText(Func textGetter) { }

	public void SetUnlockStatus(bool value) { }

	private void Show() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

