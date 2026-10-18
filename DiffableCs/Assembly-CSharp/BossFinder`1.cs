//Type is in global namespace

public class BossFinder`1 : BotData
{
	private Action _callbackOnFind; //Field offset: 0x0
	private BotsGroup _group; //Field offset: 0x0
	[CompilerGenerated]
	private T <BossLogic>k__BackingField; //Field offset: 0x0

	public private T BossLogic
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BossFinder`1(BotOwner owner) { }

	public void Dispose() { }

	public void FindBoss(Action callbackOnFind = null) { }

	[CompilerGenerated]
	public T get_BossLogic() { }

	public bool HaveLogic() { }

	private void OnBossChange(ABossLogic obj) { }

	private void OnBossFinded(IBossToFollow bossToFollow) { }

	private void OnBossSetted(BotOwner obj) { }

	[CompilerGenerated]
	private void set_BossLogic(T value) { }

	private void SubFindBoss(IBossToFollow bossToFollow) { }

}

