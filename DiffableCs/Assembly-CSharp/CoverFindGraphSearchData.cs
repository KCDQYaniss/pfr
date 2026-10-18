//Type is in global namespace

public class CoverFindGraphSearchData : CoverFindLibrary
{
	private readonly HashSet _atCheckList; //Field offset: 0x18
	private readonly HashSet _checked; //Field offset: 0x20
	private readonly NetCalcSortedList _list; //Field offset: 0x28

	public CoverFindGraphSearchData() { }

	private bool CheckPointAndAddMore(CoverSearchData data, GroupPointSearchData pointToCheck, DebugCoverFindGraphSearchData debug, out CustomNavigationPoint customNavigationPoint) { }

	[CanBeNull]
	public CustomNavigationPoint GetCover(CoverSearchData data) { }

	private bool IsPointGood(CoverSearchData data, GroupPointSearchData check) { }

	private GroupPointSearchData TryAdd(GroupPoint e, CoverSearchData data) { }

}

