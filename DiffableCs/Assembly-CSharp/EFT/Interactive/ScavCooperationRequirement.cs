namespace EFT.Interactive;

public sealed class ScavCooperationRequirement : ExfiltrationRequirement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateStatus>b__7_0(Player x) { }

		internal bool <UpdateStatus>b__7_1(Player x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ExfiltrationPoint point; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0(int count) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <GetLocalizedTip>b__0(IPlayer x) { }

	}

	private Action _unbind; //Field offset: 0x30

	public ScavCooperationRequirement() { }

	public virtual void Enter(Player player, ExfiltrationPoint point) { }

	public virtual void Exit(Player player, ExfiltrationPoint point) { }

	public virtual string GetLocalizedTip(string profileId) { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

	public virtual void OnDestroy() { }

	public virtual void Start(ExfiltrationPoint point) { }

	public void UpdateStatus(ExfiltrationPoint point) { }

}

