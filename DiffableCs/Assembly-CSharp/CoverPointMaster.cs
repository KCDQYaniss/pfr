//Type is in global namespace

public class CoverPointMaster
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int recursionLevel; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal Tuple <GetRadDebug>b__0() { }

	}

	internal struct FriendCloseCoverData
	{
		public Vector3 CoverPos; //Field offset: 0x0
		public float MinDistToFriend; //Field offset: 0xC

	}

	public const float LOWEST_ANG_COVER = 0.1736482; //Field offset: 0x0
	private static readonly NearCoverGroupsCache _nearCoverGroupsCache; //Field offset: 0x0
	private CoverFindGraphSearchData _finderByGraph; //Field offset: 0x10
	private bool canDraw; //Field offset: 0x18
	private readonly List _listToDel; //Field offset: 0x20
	private HashSet _nearGroups; //Field offset: 0x28
	private HashSet _nearGroupByPlace; //Field offset: 0x30
	[CompilerGenerated]
	private readonly BotZone <BotZone>k__BackingField; //Field offset: 0x38

	public BotZone BotZone
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static CoverPointMaster() { }

	public CoverPointMaster(BotZone zone) { }

	[CanBeNull]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, Nullable friendCover, Nullable placeId, out float sDist) { }

	[CanBeNull]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, Nullable friendCover, Nullable placeId, CoverLevel minCoverLevel, out float sDist) { }

	[CanBeNull]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 point, BotOwner bot, float minDistToTarget, Vector3 trg, Nullable friendCover, out float sDist) { }

	public static CoverPointMaster Create(BotZone zone) { }

	public void Dispose() { }

	[CompilerGenerated]
	public BotZone get_BotZone() { }

	public List GetClosePoints(Vector3 pos, BotOwner bot, float dist) { }

	[CanBeNull]
	public CustomNavigationPoint GetCoverPointMain(CoverSearchData data, bool checkCurrent) { }

	[CanBeNull]
	private CustomNavigationPoint GetCoverPointMain2(CoverSearchData data) { }

	public CustomNavigationPoint GetFreeClosePoint(Vector3 pos, BotCoversData bot, float minSDistToEnemy) { }

	private static HashSet GetNearGroups(CustomNavigationPoint[] coverPointGroups, CoverSearchData data, int recursionLevel) { }

	public static CustomNavigationPoint GetNearPoint(CustomNavigationPoint[] coverPointGroups, Vector3 playerPos, out float sDist) { }

	private static Func GetRadDebug(int recursionLevel) { }

	public bool IsCurrentPointGood(CoverSearchType searchType, CoverSearchData data, out CustomNavigationPoint point) { }

}

