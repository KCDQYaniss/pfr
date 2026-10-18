//Type is in global namespace

public abstract class BotAbstractMedsToPart : BotAbstractMeds
{
	protected IHealthController _health; //Field offset: 0x30
	protected Nullable _bodyPartToHeal; //Field offset: 0x38
	protected readonly EBodyPart[] parts; //Field offset: 0x40
	[CompilerGenerated]
	private Meds <CurUsingMeds>k__BackingField; //Field offset: 0x48

	public Meds CurUsingMeds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool HaveSmth2Use
	{
		 get { } //Length: 9
	}

	protected BotAbstractMedsToPart(BotOwner owner, Action callback) { }

	[CompilerGenerated]
	public Meds get_CurUsingMeds() { }

	public bool get_HaveSmth2Use() { }

	[CompilerGenerated]
	protected void set_CurUsingMeds(Meds value) { }

}

