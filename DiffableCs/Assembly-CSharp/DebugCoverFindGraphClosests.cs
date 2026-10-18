//Type is in global namespace

public class DebugCoverFindGraphClosests : IDebugCoverSearchGraph
{
	private List _searchedPoints; //Field offset: 0x10
	private Vector3 _startPos; //Field offset: 0x18
	public float TimeSetted; //Field offset: 0x24

	public override List Checked
	{
		 get { } //Length: 5
	}

	public override Vector3 PositionStart
	{
		 get { } //Length: 19
	}

	public DebugCoverFindGraphClosests() { }

	public override List get_Checked() { }

	public override Vector3 get_PositionStart() { }

	public void GizmosDrawBySteps(int debugLastCoverDrawSteps) { }

	public void UpdateList(NetCalcSortedList list, Vector3 startPos, CustomNavigationPoint taken) { }

}

