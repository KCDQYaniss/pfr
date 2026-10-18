//Type is in global namespace

public class MiddleGraphPathTestRunner : MonoBehaviour
{
	[SerializeField]
	private AIMiddleGraphContainer _graph; //Field offset: 0x20
	[SerializeField]
	private Transform _start; //Field offset: 0x28
	[SerializeField]
	private Transform _finish; //Field offset: 0x30
	[Min(0.1)]
	[SerializeField]
	private float _debugDrawDuration; //Field offset: 0x38
	[SerializeField]
	private float _lineYOffset; //Field offset: 0x3C
	[SerializeField]
	private Color _directPathColor; //Field offset: 0x40
	[SerializeField]
	private Color _detourPathColor; //Field offset: 0x50

	public Transform FinishTransform
	{
		 get { } //Length: 76
	}

	public AIMiddleGraphContainer Graph
	{
		 get { } //Length: 5
	}

	public Transform StartTransform
	{
		 get { } //Length: 5
	}

	public MiddleGraphPathTestRunner() { }

	public void BuildAndDrawRoutes() { }

	private void DrawPathWithDebug(IReadOnlyList path, Color color) { }

	private MiddleGraphPoint FindNearestGraphPoint(Vector3 worldPosition) { }

	public Transform get_FinishTransform() { }

	public AIMiddleGraphContainer get_Graph() { }

	public Transform get_StartTransform() { }

}

