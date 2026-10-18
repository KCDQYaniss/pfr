//Type is in global namespace

public class BossTagillaAmbushLayer : BossTagillaAbstractLayer
{
	private const float NEAR_SAVAGE_SQR_DIST = 10000; //Field offset: 0x0
	private const float SAVAGE_CHECK_PERIOD = 4; //Field offset: 0x0
	private float _lastSavageCheckTime; //Field offset: 0xB0
	private bool _haveNearSavageTarget; //Field offset: 0xB4
	private float _periodRecheck; //Field offset: 0xB8
	private float _loseEnemyTime; //Field offset: 0xBC

	public BossTagillaAmbushLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private void <TryRecheckAmbushPeriod>b__9_0(CustomNavigationPoint navigationPoint) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveAmbush() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private void TryRecheckAmbushPeriod() { }

}

