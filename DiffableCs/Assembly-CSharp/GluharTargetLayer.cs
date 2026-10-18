//Type is in global namespace

public class GluharTargetLayer : BaseLogicLayer
{
	protected CustomNavigationPoint _pointToProtect; //Field offset: 0x90
	protected Vector3 _protecttionPos; //Field offset: 0x98
	private float _adaptiveGoodDistSqrt; //Field offset: 0xA4
	[CompilerGenerated]
	private BossGluhar <_gluhar>k__BackingField; //Field offset: 0xA8

	protected private BossGluhar _gluhar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GluharTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	[CompilerGenerated]
	protected BossGluhar get__gluhar() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	[CompilerGenerated]
	private void set__gluhar(BossGluhar value) { }

	public void SetBoss(BossGluhar gluhar) { }

	public virtual bool ShallUseNow() { }

}

