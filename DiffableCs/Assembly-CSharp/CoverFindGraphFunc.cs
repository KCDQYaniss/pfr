//Type is in global namespace

public class CoverFindGraphFunc : CoverFindLibrary
{
	private const float BEST_SIDST = 49; //Field offset: 0x0
	private readonly HashSet _checked; //Field offset: 0x18
	private readonly NetCalcSortedList _list; //Field offset: 0x20
	private bool _doFullLogs; //Field offset: 0x28
	private GroupPoint _safeCover; //Field offset: 0x30
	private float _lastPower; //Field offset: 0x38
	private StringBuilder _debugLogString; //Field offset: 0x40
	private int _iteration; //Field offset: 0x48

	public CoverFindGraphFunc() { }

	private void AddToLogs(string info, bool withLine = false) { }

	private bool CheckPointAndAddMore(BotOwner bot, Vector3 pos, bool noRestrictions, Func goodFunc, GroupPoint curUsingPoint, int maxIterations, out CustomNavigationPoint customNavigationPoint, ref int deepCheck) { }

	public static GroupPoint FoundStartPointExtended(ICoverSearchBot bot, Vector3 pos) { }

	public CustomNavigationPoint GetClosestPoint(BotOwner bot, Vector3 pos, bool noRestrictions, Func goodFunc, bool printErrorLogsIfFail, int maxIterations = 1000) { }

	public static GroupPoint GetStartPoint(ICoverSearchBot bot, Vector3 pos, out string replaceInfo) { }

	private void SetLastDebug(Vector3 startPos, BotOwner bot, CustomNavigationPoint taken) { }

	private GroupPointSearchData TryAdd(GroupPoint groupP, Vector3 targetPos) { }

}

