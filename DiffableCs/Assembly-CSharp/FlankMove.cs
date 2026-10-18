//Type is in global namespace

public abstract class FlankMove : MoveNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Vector3 flankPoint; //Field offset: 0x10
		public float _sDSafeSide; //Field offset: 0x1C

		public <>c__DisplayClass13_0() { }

		internal bool <CalcFlankWayTo>g__GoodPoint|0(GroupPoint arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public FlankMove <>4__this; //Field offset: 0x10
		public EnemyInfo enemy; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal bool <TryMoveFlank>g__GoodPoint|0(GroupPoint arg) { }

	}

	private NavMeshPath _path; //Field offset: 0x28
	private CustomNavigationPoint _middlePoint; //Field offset: 0x30
	private float _nextPeriodFindSub; //Field offset: 0x38
	private float _updatePointTimer; //Field offset: 0x3C
	private EStealthMove _eStealthMove; //Field offset: 0x40
	private float _sDSafeSide; //Field offset: 0x44
	private AIPeriodAction _findCover; //Field offset: 0x48

	protected FlankMove(BotOwner bot, float enemyMinDist) { }

	public static bool CalcFlankWayTo(Vector3 flankPoint, Vector3 from, Vector3 enemy, BotOwner asker, out Vector3[] resultWay, out Nullable middlePoint) { }

	private void MoveToMainTarget() { }

	private void RestartFind() { }

	private void SetState(EStealthMove eStealthMove) { }

	private bool TryMoveFlank(CoreActionResultParamsFlankMove data) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParamsFlankMove data) { }

	private void UpdateState(CoreActionResultParamsFlankMove data) { }

}

