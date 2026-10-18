namespace EFT.UI;

[Obfuscation(Exclude = True)]
public class BaseNotificationView : UIElement, IPointerClickHandler, IEventSystemHandler
{
	private const float ANIMATION_PREPARE_TIME = 0.3; //Field offset: 0x0
	private static readonly int _speed; //Field offset: 0x0
	private static readonly int _autoComplete; //Field offset: 0x4
	private static readonly int _forcedComplete; //Field offset: 0x8
	[SerializeField]
	protected Image _icon; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x78
	[SerializeField]
	private LayoutElement _layout; //Field offset: 0x80
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x88
	[SerializeField]
	protected RectTransform _container; //Field offset: 0x90
	[SerializeField]
	protected Image _background; //Field offset: 0x98
	[FormerlySerializedAs("_defaultColor")]
	[SerializeField]
	private Color _defaultTextColor; //Field offset: 0xA0
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0xB0
	[SerializeField]
	private Animator _animator; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnHideComplete; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <IsHiding>k__BackingField; //Field offset: 0xD0
	private Notification _notification; //Field offset: 0xD8
	private float _height; //Field offset: 0xE0

	public event Action OnHideComplete
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private bool IsHiding
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool ReturnToPool
	{
		 get { } //Length: 3
	}

	private static BaseNotificationView() { }

	public BaseNotificationView() { }

	[CompilerGenerated]
	private void <Init>b__24_0() { }

	[CompilerGenerated]
	private void <Init>b__24_1() { }

	[CompilerGenerated]
	private void <StopAnimation>b__31_0() { }

	[CompilerGenerated]
	public void add_OnHideComplete(Action value) { }

	[CompilerGenerated]
	public bool get_IsHiding() { }

	public override bool get_ReturnToPool() { }

	protected override float GetHeight() { }

	public bool HasSameNotification(Notification other) { }

	private void HideNotification(bool invokeCallback) { }

	public void Init(Notification notification) { }

	[UsedImplicitly]
	public void OnAnimationDone() { }

	[UsedImplicitly]
	private void OnDisable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnHideComplete(Action value) { }

	[CompilerGenerated]
	private void set_IsHiding(bool value) { }

	private void StartAnimation() { }

	private void StopAnimation() { }

}

