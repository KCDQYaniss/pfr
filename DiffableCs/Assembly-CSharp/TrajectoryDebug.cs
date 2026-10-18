//Type is in global namespace

public class TrajectoryDebug : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string groupName; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <Add>b__0(TrajectoryDebugPointsGroup p) { }

	}

	[SerializeField]
	private List _points; //Field offset: 0x20

	public List Points
	{
		 get { } //Length: 5
	}

	public TrajectoryDebug() { }

	public void Add(string groupName, Vector3 point, float time) { }

	public void Add(string groupName, string label, Vector3 point, float time) { }

	public void Clear() { }

	public List get_Points() { }

	private void OnDrawGizmos() { }

}

