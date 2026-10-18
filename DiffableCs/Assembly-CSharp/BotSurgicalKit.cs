//Type is in global namespace

public class BotSurgicalKit : BotAbstractMedsToPart
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public BotSurgicalKit <>4__this; //Field offset: 0x10
		public Action callbackEndUse; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <ApplyToCurrentPart>b__0(Result hands) { }

		internal void <ApplyToCurrentPart>b__1(Result applyResult) { }

	}

	private bool _shallUseInSafe; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Damaged>k__BackingField; //Field offset: 0x51

	public bool Damaged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HaveWork
	{
		 get { } //Length: 18
	}

	public BotSurgicalKit(BotOwner owner, Action callback) { }

	public virtual void Activate() { }

	public void ApplyToCurrentPart(Action callbackEndUse = null) { }

	public void FindDamagedPart() { }

	[CompilerGenerated]
	public bool get_Damaged() { }

	public bool get_HaveWork() { }

	public override void GetDamage() { }

	public void Refresh() { }

	protected override void RefreshMeds() { }

	[CompilerGenerated]
	public void set_Damaged(bool value) { }

	public void SetRandomPartToHeal() { }

	public bool ShallStartUse() { }

}

