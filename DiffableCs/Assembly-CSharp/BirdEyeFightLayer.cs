//Type is in global namespace

public class BirdEyeFightLayer : BirdEyeAbstractLayer
{
	private const string NAME_AGRO = "BirdEyeAgro"; //Field offset: 0x0
	private const string NAME_NORMAL = "BirdEyeFight"; //Field offset: 0x0
	private readonly BotFindPlaceToShoot _finder; //Field offset: 0xB8
	private float _changePose; //Field offset: 0xC0
	private string _nameCur; //Field offset: 0xC8
	private float _recheckAggroTime; //Field offset: 0xD0
	private bool _canAggro; //Field offset: 0xD4

	public BirdEyeFightLayer(BotOwner bot, int priority, int preferAttackDist = -1, int minStackDist = -1) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual ShootToPoint GetShootPoint() { }

	public virtual string Name() { }

	private void OnMemberRemove(BotOwner obj) { }

	private bool OtherTeamAttack() { }

	private void RecheckCanAggro() { }

	private void SetAgro(bool val) { }

	public virtual bool ShallUseNow() { }

	private bool ShouldHeal() { }

	private AICoreActionEnd SubEndGoToPoint() { }

}

