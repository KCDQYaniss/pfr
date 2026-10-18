namespace EFT.Communications;

public abstract class Notification
{
	[JsonProperty("type")]
	public ENotificationType Type; //Field offset: 0x10
	[JsonProperty("time")]
	public float Time; //Field offset: 0x14
	[JsonIgnore]
	public ENotificationDurationType Duration; //Field offset: 0x18
	[JsonIgnore]
	public Nullable SoundType; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <ShowImmediately>k__BackingField; //Field offset: 0x24
	public BindableEvent OnForceHide; //Field offset: 0x28

	public override Nullable BackgroundColor
	{
		 get { } //Length: 15
	}

	public abstract string Description
	{
		 get { } //Length: 0
	}

	public override ENotificationIconType Icon
	{
		 get { } //Length: 3
	}

	public override bool ShowImmediately
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool ShowNotification
	{
		 get { } //Length: 3
	}

	public override Nullable TextColor
	{
		 get { } //Length: 15
	}

	protected Notification() { }

	public override BaseNotificationView CreateView(INotificationViewFactory viewFactory) { }

	public override Nullable get_BackgroundColor() { }

	public abstract string get_Description() { }

	public override ENotificationIconType get_Icon() { }

	[CompilerGenerated]
	public override bool get_ShowImmediately() { }

	public override bool get_ShowNotification() { }

	public override Nullable get_TextColor() { }

	[CompilerGenerated]
	public override void set_ShowImmediately(bool value) { }

	public virtual string ToString() { }

}

