//Type is in global namespace

public class DebugCoverSystemTester : MonoBehaviour
{
	public float MaxShootDist; //Field offset: 0x20
	public WildSpawnType WildSpawnType; //Field offset: 0x24
	public List CarePos; //Field offset: 0x28
	public Transform ShotPos; //Field offset: 0x30
	public bool DrawLast; //Field offset: 0x38
	public ESearchCoverEngine SearchToDraw; //Field offset: 0x3C
	public bool UseLineCastToCover; //Field offset: 0x40
	public bool RefreshWayBlockerTester; //Field offset: 0x41
	public int StepConstrain; //Field offset: 0x44
	public float RadiusConstrain; //Field offset: 0x48
	public CoverShootType ShootType; //Field offset: 0x4C
	private DebugCoverDataInfo CoverDataInfo; //Field offset: 0x50
	private readonly Dictionary LastSearch; //Field offset: 0x58

	public DebugCoverSystemTester() { }

	public HashSet CarePositions() { }

	public void DoFind() { }

	private void DrawLastSearch() { }

	public EnemyInfo GetGoalEnemy() { }

	private void OnDrawGizmos() { }

	private void OnSearchPoint(CustomNavigationPoint point, NavGraphFindDebug debug, ESearchCoverEngine coverengine) { }

	public void PrintLastInfo() { }

	private void RefreshWayBlocker() { }

}

