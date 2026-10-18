//Type is in global namespace

public class BotAttackManager
{
	private const float UPDATE_TIME = 1; //Field offset: 0x0
	private readonly BotOwner _owner; //Field offset: 0x10
	private float _updatePointTimer; //Field offset: 0x18
	[CompilerGenerated]
	private float <LastFailSearch>k__BackingField; //Field offset: 0x1C

	public private float LastFailSearch
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BotAttackManager(BotOwner owner) { }

	[CanBeNull]
	public CustomNavigationPoint CheckDestinations() { }

	[CompilerGenerated]
	public float get_LastFailSearch() { }

	public void PointAndPathDetecting() { }

	[CanBeNull]
	public CustomNavigationPoint PointToGo() { }

	[CompilerGenerated]
	private void set_LastFailSearch(float value) { }

	public void TryPointGetting(bool withShoot, CoverSearchType searchType, ShootToPoint shoot2point, float deistStartSearchSqr, Action OnFind, Action OnFail = null, bool checkCurrent = true) { }

	public void TryPointGetting(CoverShootType coverShootType, CoverSearchType searchType, ShootToPoint shoot2point, float deistStartSearchSqr, Action OnFind, Action OnFail = null, bool checkCurrent = true, bool canChange = true) { }

	public void TryPointGetting(Vector3 centerPos, bool withShoot, float distStart2SerachSqr, CoverSearchType searchType, ShootToPoint shoot2point, Action OnFind, Action OnFail = null, bool checkCurrent = true) { }

	public void TryPointGetting(CoverSearchData searchData, Action OnFind, Action OnFail) { }

	public void TryPointGetting(Vector3 centerPos, CoverShootType coverShootType, float distStart2SerachSqr, CoverSearchType searchType, ShootToPoint shoot2point, Action OnFind, Action OnFail, bool checkCurrent = true, bool recalcNoTimer = false, bool useFightLogic = true, Nullable placeInfo = null) { }

	public void UpdateNextTick() { }

}

