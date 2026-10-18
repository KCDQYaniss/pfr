//Type is in global namespace

public class AIVoxelesData : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RestoreData>b__11_0(NavGraphVoxelSimple x) { }

		internal bool <RestoreData>b__11_1(NavGraphVoxelSimple x) { }

	}

	public NavGraphVoxelSimple[,,] VoxelesArray; //Field offset: 0x20
	public List VoxelsList; //Field offset: 0x28
	public Vector3 MinVoxelesValues; //Field offset: 0x30
	public Vector3 MaxVoxelesValues; //Field offset: 0x3C
	public bool DrawVoxeles; //Field offset: 0x48
	public bool DrawClosestsPoints; //Field offset: 0x49
	public bool DrawDoorLinks; //Field offset: 0x4A
	public float DistDrawVoxeles; //Field offset: 0x4C
	public int MaxX; //Field offset: 0x50
	public int MaxY; //Field offset: 0x54
	public int MaxZ; //Field offset: 0x58

	public AIVoxelesData() { }

	public void Clear() { }

	public bool IsRestored() { }

	private void OnDrawGizmosSelected() { }

	public void OptimizeSerialization() { }

	public void RemovePoint(GroupPoint point) { }

	public void RestoreData(Dictionary data, AICoversData covers) { }

	public void SetMaxValues(Vector3 max) { }

}

