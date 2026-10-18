//Type is in global namespace

public class CoverSearchDebug : MonoBehaviour
{
	public static CoverSearchDebug Instance; //Field offset: 0x0
	[SerializeField]
	private List _coverSearchIterations; //Field offset: 0x20
	private DebugCoverPointsLoggerCollector _collector; //Field offset: 0x28

	public List CoverSearchIterations
	{
		 get { } //Length: 5
	}

	public CoverSearchDebug() { }

	private void Awake() { }

	public List get_CoverSearchIterations() { }

	private void OnDrawGizmos() { }

	public void ProcessAddNearGroups(HashSet nearGroups, int level, Vector3 centerPos, float sqrRadius, string searchLabel) { }

	public void SetCoverPointsDataCollector(DebugCoverPointsLoggerCollector collector, Vector3 centerPoint, float radius, float deltaRadius) { }

	public void SetResultCover(CustomNavigationPoint point) { }

}

