namespace EFT.Interactive;

public class BetterPropagationGroups : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <CollectVolumes>b__5_0(BetterPropagationVolume v) { }

	}

	internal class Volumes
	{
		public Vector4 Area; //Field offset: 0x10
		public BetterPropagationVolume[] PropagationVolumes; //Field offset: 0x20

		public Volumes() { }

		public bool Contains2dPoint(Vector3 position) { }

	}

	[Header("Keep Area size: X < Z and Y < W")]
	public Volumes[] Groups; //Field offset: 0x20
	private List _searchList; //Field offset: 0x28

	public BetterPropagationGroups() { }

	[ContextMenu("Collect volumes")]
	private void CollectVolumes() { }

	public List GetIsolatedVolumes(Vector3 position, List volumesBuffer) { }

	public void GetVolumes(Vector3 position, in List buffer) { }

}

