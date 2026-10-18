//Type is in global namespace

public class AIManualPointsHolder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public GroupPoint point; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <TryConnectPoint>b__0(GroupPoint x) { }

	}

	[SerializeField]
	public List ManualPoints; //Field offset: 0x20
	public bool DrawWithEdges; //Field offset: 0x28
	public bool DrawWithCore; //Field offset: 0x29
	public bool AlwaysDrawGizmos; //Field offset: 0x2A
	public float DrawHeight; //Field offset: 0x2C

	public AIManualPointsHolder() { }

	public bool AddPoint(GroupPoint point) { }

	private void DrawPoints() { }

	public int GetMaxIdAndRecalcIds() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public void RemovePoint(GroupPoint point) { }

	public static bool TryConnect(GroupPoint p1, GroupPoint p2, AICoversData covers) { }

	public static bool TryConnectPoint(GroupPoint point, AICoversData data) { }

}

