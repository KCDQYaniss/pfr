//Type is in global namespace

public class BotCalcGoal : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public BotOwner bot; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <CalcPosition2Search>b__0(PlaceForCheck check) { }

		internal bool <CalcPosition2Search>b__1(PlaceForCheck check) { }

		internal bool <CalcPosition2Search>b__2(PlaceForCheck check) { }

	}

	private float _nextCheckGoalIfHaveEnemy; //Field offset: 0x18

	public List PlacesForCheck
	{
		 get { } //Length: 42
	}

	public BotCalcGoal(BotOwner owner) { }

	public void CalcGoalForBot() { }

	private void CalcGoalTarget(bool withDropEnemy) { }

	private PlaceForCheck CalcPosition2Search(BotOwner bot) { }

	private double CalculateCoef(BotOwner owner, double sec, float dist, float coef) { }

	private bool CheckIsLastPositionOld(float newestPosition) { }

	private PlaceForCheck CheckOnDestinations(BotOwner bot, Vector3 target) { }

	private PlaceForCheck CreatePlaceForChecking(Vector3 suspectedPoint, PlaceForCheckType type, bool canUseCovrPoints = true) { }

	private void FindMinIndex(BotOwner bot, Func condiction, out int minIndex, out double minPoint) { }

	public List get_PlacesForCheck() { }

	private PlaceForCheck SetPointAsGoalIfClose(BotOwner bot, Vector3 pos) { }

}

