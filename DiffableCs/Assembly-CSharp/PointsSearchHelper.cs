//Type is in global namespace

public static class PointsSearchHelper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public float sDistToEnemy; //Field offset: 0x10
		public Vector3 dirEnemy; //Field offset: 0x14
		public Vector3 wallVector; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal bool <CanIHideFromPos>b__0() { }

	}


	public static bool CanIHide(Vector3 posToHide, Vector3 wallVector, IEnumerable positionsIMustCare, float minSDistToEnemy, bool useRaycast, bool useAng = true) { }

	public static bool CanIHideFromPos(Vector3 posToHide, Vector3 wallVector, float minSDistToEnemy, bool useRaycast, bool useAng, Vector3 carePosition) { }

	public static bool IsDangerPositionFarEnough(Vector3 positionToCheck, IEnumerable positionsIMustCare, float minSDistToEnemy) { }

}

