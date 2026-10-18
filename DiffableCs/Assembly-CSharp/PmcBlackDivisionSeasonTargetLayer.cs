//Type is in global namespace

internal class PmcBlackDivisionSeasonTargetLayer : BaseLogicLayer
{
	private const float SEARCH_REAL_RADIUS_SQR = 2500; //Field offset: 0x0
	private const float MAX_Y_DELTA_TO_SEARCH = 6; //Field offset: 0x0
	private const float SEARCH_DIST_SQR = 900; //Field offset: 0x0

	public PmcBlackDivisionSeasonTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveNearTarget(IBotOwner owner) { }

	private bool HaveRealEnemyInSearchRadius() { }

	public virtual string Name() { }

	private bool ShallSearch() { }

	public virtual bool ShallUseNow() { }

}

