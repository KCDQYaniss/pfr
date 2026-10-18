//Type is in global namespace

public class BossGroup
{
	private BotOwner _boss; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnBossChange; //Field offset: 0x18
	private List _members; //Field offset: 0x20

	public event Action OnBossChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotOwner Boss
	{
		 get { } //Length: 5
	}

	public BossGroup(BotOwner boss, List members) { }

	[CompilerGenerated]
	public void add_OnBossChange(Action value) { }

	public void Dispose() { }

	public BotOwner get_Boss() { }

	public BotOwner GetAliveBot() { }

	private void OnBossDead(IBotOwner boss, List followers) { }

	[CompilerGenerated]
	public void remove_OnBossChange(Action value) { }

	public void RemoveBoss(IBotOwner boss) { }

}

