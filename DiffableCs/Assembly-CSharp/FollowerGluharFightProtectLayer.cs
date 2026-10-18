//Type is in global namespace

public class FollowerGluharFightProtectLayer : PmcLayer
{
	private BossFinder _boss; //Field offset: 0xD8
	private CustomNavigationPoint CoverAtHome; //Field offset: 0xE0
	private float _nextCheckCover; //Field offset: 0xE8

	public FollowerGluharFightProtectLayer(BotOwner bot, int priority) { }

	public void CalcInnerCover() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public bool FightAtHome() { }

	private AICoreActionResult FightAtZone() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	protected virtual bool ProtectCareKill() { }

	protected virtual bool ProtectWantKill() { }

}

