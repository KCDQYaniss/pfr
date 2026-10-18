//Type is in global namespace

public abstract class CoverFindLibrary
{
	private readonly List _listToDel; //Field offset: 0x10

	protected CoverFindLibrary() { }

	protected bool CheckCanOnlyHide(GroupPointSearchData point, IEnumerable carePositions, EditorsCoverPointDebugData dataDebug, CoverSearchData data) { }

	protected bool CheckCanOnlyShoot(ICoverSearchBot bot, CoverShootType withShoot, GroupPointSearchData point, ShootToPoint shootToPoint, HashSet carePositions, EditorsCoverPointDebugData dataDebug, CoverSearchData data) { }

	protected bool CheckCanShotHide(ICoverSearchBot bot, CoverShootType withShoot, GroupPointSearchData point, ShootToPoint shootToPoint, HashSet carePositions, EditorsCoverPointDebugData dataDebug, CoverSearchData data) { }

	protected CustomNavigationPoint GetMax(IEnumerable list) { }

	protected bool IsPointBehindEnemy(Vector3 centerPos, HashSet carePositions, GroupPoint point, EditorsCoverPointDebugData editorsCoverPointDebugData, CoverSearchData searchData) { }

}

