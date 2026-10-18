//Type is in global namespace

public abstract class GluharFightAbstractLayer : BossKillaLayer
{
	protected CustomNavigationPoint _pointToProtect; //Field offset: 0xD0
	protected Vector3 _protecttionPos; //Field offset: 0xD8
	private float _adaptiveGoodDistSqrt; //Field offset: 0xE4
	[CompilerGenerated]
	private BossGluhar <_gluhar>k__BackingField; //Field offset: 0xE8

	protected private BossGluhar _gluhar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GluharFightAbstractLayer(BotOwner owner, int priority) { }

	[CompilerGenerated]
	protected BossGluhar get__gluhar() { }

	[CompilerGenerated]
	private void set__gluhar(BossGluhar value) { }

	public void SetBoss(BossGluhar gluhar) { }

}

