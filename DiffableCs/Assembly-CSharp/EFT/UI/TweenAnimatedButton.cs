namespace EFT.UI;

public sealed class TweenAnimatedButton : SerializedMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerClickHandler, IPointerDownHandler
{
	[SerializeField]
	private IButtonAnimation _animation; //Field offset: 0x60
	[SerializeField]
	private bool _interactable; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnClick; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnMouseEnter; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnMouseExit; //Field offset: 0x80
	private bool _pointerDown; //Field offset: 0x88
	private bool _pointerEnter; //Field offset: 0x89

	public event Action OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMouseEnter
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMouseExit
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public bool Interactable
	{
		 get { } //Length: 5
		 set { } //Length: 161
	}

	public TweenAnimatedButton() { }

	[CompilerGenerated]
	public void add_OnClick(Action value) { }

	[CompilerGenerated]
	public void add_OnMouseEnter(Action value) { }

	[CompilerGenerated]
	public void add_OnMouseExit(Action value) { }

	public bool get_Interactable() { }

	private void OnApplicationFocus(bool hasFocus) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnClick(Action value) { }

	[CompilerGenerated]
	public void remove_OnMouseEnter(Action value) { }

	[CompilerGenerated]
	public void remove_OnMouseExit(Action value) { }

	public void set_Interactable(bool value) { }

}

