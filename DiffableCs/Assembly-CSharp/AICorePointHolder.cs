//Type is in global namespace

public class AICorePointHolder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public List all; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal Vector3 <GetClosest>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public List all; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal Vector3 <GetAnyPointToConnect>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int corePointId; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetCorePoint>b__0(AICorePoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public int corePointId; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetCorePointStatic>b__0(AICorePoint x) { }

	}

	private static AICorePointHolder _cache; //Field offset: 0x0
	public float DrawHeight; //Field offset: 0x20
	public List CorePoints; //Field offset: 0x28
	public bool IsAlwaysDraw; //Field offset: 0x30

	public AICorePointHolder() { }

	public void AddCorePoint(AICorePoint corePoint) { }

	private void DrawInner() { }

	public static List GetAllTestObjects(bool canUseCache = false) { }

	public static AICorePoint GetAnyPointToConnect(Vector3 pos) { }

	public static AICorePoint GetClosest(Vector3 pos) { }

	public AICorePoint GetCorePoint(int corePointId) { }

	public static AICorePoint GetCorePointStatic(int corePointId, bool canUseCache) { }

	private static bool HaveBothPath(Vector3 f, Vector3 t) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public void Refresh() { }

}

