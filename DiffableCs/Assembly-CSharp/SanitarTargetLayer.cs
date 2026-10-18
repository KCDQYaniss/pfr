//Type is in global namespace

public class SanitarTargetLayer : BaseLogicLayer
{
	protected IBossSanitar _sanitarBoss; //Field offset: 0x90
	private float _nextPOsibleStimulatorPeace; //Field offset: 0x98
	private readonly float STIMULATOR_PEACE_PERIOD; //Field offset: 0x9C

	public SanitarTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	public void SetBossData(IBossSanitar bossData) { }

	public virtual bool ShallUseNow() { }

}

