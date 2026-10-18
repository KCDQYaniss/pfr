//Type is in global namespace

public class DebugGrenadeHoldPlaceNode : BaseNode
{
	private const float ThrowPeriodSecAfterThrow = 5; //Field offset: 0x0
	private const float ThrowPeriodSec = 1; //Field offset: 0x0
	private const float CheatVisionSDist = 10000; //Field offset: 0x0
	private static readonly Color ThrowArrowColor; //Field offset: 0x0
	private const float ThrowArrowDrawDuration = 4; //Field offset: 0x0
	private const float ThrowArrowHeadFraction = 0.22; //Field offset: 0x0
	private const float ThrowArrowHeadWidth = 0.18; //Field offset: 0x0
	private static readonly AIGreandeAng[] AngleCycle; //Field offset: 0x10
	private readonly AIPeriodAction _ensureEnemies; //Field offset: 0x18
	private int _angleIndex; //Field offset: 0x20
	private float _nextThrowTime; //Field offset: 0x24

	private static DebugGrenadeHoldPlaceNode() { }

	public DebugGrenadeHoldPlaceNode(BotOwner bot) { }

	private void CheatReportNearbyEnemies() { }

	private static void DrawOrangeThrowArrow(AIGreanageThrowData d) { }

	private Nullable GetTargetPosition() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

