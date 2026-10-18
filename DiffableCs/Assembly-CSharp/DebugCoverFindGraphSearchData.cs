//Type is in global namespace

public class DebugCoverFindGraphSearchData : IDebugCoverSearchGraph
{
	public float TimeSetted; //Field offset: 0x10
	private readonly CoverSearchData _data; //Field offset: 0x18
	private int lastStep; //Field offset: 0x20
	private readonly NavGraphVoxelSimple _startVoxel; //Field offset: 0x28
	private readonly List _checked; //Field offset: 0x30
	private readonly List pointsAtSteps; //Field offset: 0x38
	private readonly bool _doLog; //Field offset: 0x40

	public override List Checked
	{
		 get { } //Length: 76
	}

	public override Vector3 PositionStart
	{
		 get { } //Length: 41
	}

	public DebugCoverFindGraphSearchData(CoverSearchData data, NavGraphVoxelSimple voxel) { }

	public void AddStep(GroupPointSearchData point, NetCalcSortedList list) { }

	public override List get_Checked() { }

	public override Vector3 get_PositionStart() { }

	public static Color GetColorByCause(ECoverCheckCause cause) { }

	public void GizmosDrawBySteps(int debugLastCoverDrawSteps) { }

	public void TryPrintLogs(CustomNavigationPoint result) { }

}

