//Type is in global namespace

public abstract class BaseWedgeLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public AIPlaceInfo place; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <TryChangeSectorOrHold>b__0(GroupPoint point) { }

	}

	protected const float ENEMY_FORGOT = 15; //Field offset: 0x0
	private const float NEXT_COVER_DELTA = 7; //Field offset: 0x0
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0x90
	private float _nextCheckCoverInMiddle; //Field offset: 0x98
	protected BossFinder _boss; //Field offset: 0xA0
	private float _nextCanGoRound; //Field offset: 0xA8
	private float _startShootAsLook; //Field offset: 0xAC

	protected BaseWedgeLayer(BotOwner bot, int priority) { }

	protected AICoreActionResult AttackMovingFlankToPointWithGroupCooldown(string flankReason) { }

	protected bool CanGoRound() { }

	protected void DelayNextGoRound() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected bool GoodPoint(GroupPoint arg) { }

	protected AICoreActionResult LookOrHold(string keyWork, float nextHold, float nextLook) { }

	protected void RecheckCoverAtMiddle() { }

	protected bool TryChangeSectorOrHold(out AICoreActionResult result) { }

}

