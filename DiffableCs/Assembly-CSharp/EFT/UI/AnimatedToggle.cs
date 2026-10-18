namespace EFT.UI;

public sealed class AnimatedToggle : Toggle
{
	[SerializeField]
	private string _onTrigger; //Field offset: 0x128
	[SerializeField]
	private string _offTrigger; //Field offset: 0x130
	[CompilerGenerated]
	private Action OnMouseDown; //Field offset: 0x138

	public event Action OnMouseDown
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	internal bool IsToggled
	{
		internal get { } //Length: 8
		internal set { } //Length: 73
	}

	public string OffTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public string OnTrigger
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public AnimatedToggle() { }

	[CompilerGenerated]
	public void add_OnMouseDown(Action value) { }

	protected virtual void Awake() { }

	internal bool get_IsToggled() { }

	public string get_OffTrigger() { }

	public string get_OnTrigger() { }

	protected virtual void InstantClearState() { }

	protected virtual void OnEnable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnMouseDown(Action value) { }

	internal void set_IsToggled(bool value) { }

	public void set_OffTrigger(string value) { }

	public void set_OnTrigger(string value) { }

	public void ToggleSilent(bool value) { }

	public void TriggerAnimation(bool value) { }

	private void TriggerAnimation(string triggerName) { }

}

