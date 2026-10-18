//Type is in global namespace

public class BotCullingState : BotData
{
	private bool _shouldBeInvisible; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnShouldBeInvisibleChanged; //Field offset: 0x20

	public event Action OnShouldBeInvisibleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool ShouldBeInvisible
	{
		 get { } //Length: 5
		 set { } //Length: 33
	}

	public BotCullingState(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnShouldBeInvisibleChanged(Action value) { }

	public bool get_ShouldBeInvisible() { }

	[CompilerGenerated]
	public void remove_OnShouldBeInvisibleChanged(Action value) { }

	public void set_ShouldBeInvisible(bool value) { }

}

