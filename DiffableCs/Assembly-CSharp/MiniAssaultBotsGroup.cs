//Type is in global namespace

public class MiniAssaultBotsGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public MiniAssaultBotsGroup <>4__this; //Field offset: 0x10
		public IBotOwner bot; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <SubsribeForDeath>b__0(Player player) { }

	}

	public EBotAssaultAreaStatus Status; //Field offset: 0x10
	private readonly Dictionary _botForAssault; //Field offset: 0x18
	[CompilerGenerated]
	private AIDangerArea <AreaToAssaut>k__BackingField; //Field offset: 0x20

	public private AIDangerArea AreaToAssaut
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MiniAssaultBotsGroup(AIDangerArea area, List botForAssault) { }

	public void BotIsReady(BotOwner bot) { }

	public void BotStartAssault(IBotOwner bot) { }

	public void Dispose() { }

	[CompilerGenerated]
	public AIDangerArea get_AreaToAssaut() { }

	[CompilerGenerated]
	private void set_AreaToAssaut(AIDangerArea value) { }

	private bool SetStatusAndCheckAllready(IBotOwner bot, EBotAssaultAreaStatus status) { }

	private void SubsribeForDeath(IBotOwner bot) { }

}

