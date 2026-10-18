//Type is in global namespace

public class BotRun : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public BotRun <>4__this; //Field offset: 0x10
		public bool zigZag; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <CalcToCover>b__0(CustomNavigationPoint navigationPoint) { }

	}

	private static NavMeshPath _cachePath; //Field offset: 0x0
	private float _goodCoverRechceckTime; //Field offset: 0x18
	private float _nextPosibleRunTime; //Field offset: 0x1C
	private float _tryRunUntil; //Field offset: 0x20
	private bool _tryRunUntilVal; //Field offset: 0x24
	private bool _going; //Field offset: 0x25
	private float _nextTimeHeckRun; //Field offset: 0x28
	private float _nextRecalcMove; //Field offset: 0x2C
	private readonly bool _canRunByManyShoots; //Field offset: 0x30

	private static BotRun() { }

	public BotRun(BotOwner owner) { }

	public static bool CalcPathToMoveZigZagAndGo(Vector3 targetPoint1, BotOwner bot, EZigZAgType type) { }

	private void CalcToCover(CoverShootType shootType, float deltaCalcTime, bool cantChangeCover, bool zigZag) { }

	public void CheckRunByShoots() { }

	public void EndMove() { }

	private void GoToPoint(CustomNavigationPoint target, bool withZIgZag) { }

	protected bool IsCoverGoodForRun(CustomNavigationPoint point) { }

	private static void ModifZigZagANdGo(Vector3[] corners, BotOwner bot, EZigZAgType type) { }

	private bool ProceedDirection(bool notOpeningDoor, float reachDist) { }

	private bool RefreshGoToPoint(Vector3 point) { }

	public void Run(CoverShootType shootType, ShootToPoint shootPos, float deltaCalcTime, bool notOpeningDoor, bool checkRecalc, bool zigZag) { }

	public bool Run(Vector3 point, bool notOpeningDoor, float reachDist = -1) { }

	public bool RunAwayGrenade(float reachDist = -1) { }

	public void RunFor(float sec) { }

	public bool ShallRunAnyway() { }

	public void StopRunAnyway() { }

}

