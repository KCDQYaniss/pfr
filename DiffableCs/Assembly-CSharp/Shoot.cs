//Type is in global namespace

public class Shoot : BaseNode
{
	public float SilentUntil; //Field offset: 0x18
	public bool WithTalk; //Field offset: 0x1C
	private int _bulletCount; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnShootDone; //Field offset: 0x28

	public event Action OnShootDone
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public Shoot(BotOwner bot) { }

	[CompilerGenerated]
	public void add_OnShootDone(Action value) { }

	[CompilerGenerated]
	public void remove_OnShootDone(Action value) { }

	private void TrySay() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

