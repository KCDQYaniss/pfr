//Type is in global namespace

public class TabElement : UIElement
{
	[SerializeField]
	private List _sizeDefiners; //Field offset: 0x70
	[SerializeField]
	private float _widthAdjustment; //Field offset: 0x78
	public int OrderNumber; //Field offset: 0x7C
	[CompilerGenerated]
	private float <Width>k__BackingField; //Field offset: 0x80
	private BindableEvent _onLayoutUpdatedEvent; //Field offset: 0x88

	public BindableEvent OnLayoutUpdatedEvent
	{
		 get { } //Length: 154
	}

	public private float Width
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public TabElement() { }

	public BindableEvent get_OnLayoutUpdatedEvent() { }

	[CompilerGenerated]
	public float get_Width() { }

	private float GetWidth() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_Width(float value) { }

	public void SetWidth(float width, float gap, int orderNumber) { }

	private void Update() { }

}

