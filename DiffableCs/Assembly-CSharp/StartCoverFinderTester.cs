//Type is in global namespace

public class StartCoverFinderTester : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8
		public static Func <>9__9_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnDrawGizmos>b__9_0(NavGraphVoxelSimple x) { }

		internal bool <OnDrawGizmos>b__9_1(NavGraphVoxelSimple x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public StartCoverFinderTester <>4__this; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal Vector3 <GetStartPointSingle>b__0(int i) { }

	}

	public GroupPoint LastPoint; //Field offset: 0x20
	public bool WorkOnUpdate; //Field offset: 0x28
	public AICoversData CoversData; //Field offset: 0x30
	public GroupPoint LastSearched; //Field offset: 0x38
	public NavGraphVoxelSimple LastVoxel; //Field offset: 0x40

	public StartCoverFinderTester() { }

	public void DoFind(AICoversData data) { }

	public void DoSearch() { }

	public void DropLastPoint() { }

	public GroupPoint GetStartPoint(AICoversData data, Vector3 pos) { }

	public GroupPoint GetStartPoint2(AICoversData data, Vector3 pos) { }

	public GroupPoint GetStartPointSingle(AICoversData data, Vector3 pos) { }

	public void ManualUpdate() { }

	private void OnDrawGizmos() { }

}

