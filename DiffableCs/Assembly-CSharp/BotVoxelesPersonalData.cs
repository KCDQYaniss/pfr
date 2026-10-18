//Type is in global namespace

public class BotVoxelesPersonalData : BotData
{
	private List _allPoints; //Field offset: 0x18
	private AICoversData _data; //Field offset: 0x20
	[CompilerGenerated]
	private NavGraphVoxelSimple <CurVoxel>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnVoxelChange; //Field offset: 0x30

	public event Action OnVoxelChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Vector3 _min
	{
		 get { } //Length: 50
	}

	public private NavGraphVoxelSimple CurVoxel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int MaxX
	{
		 get { } //Length: 35
	}

	public int MaxY
	{
		 get { } //Length: 35
	}

	public int MaxZ
	{
		 get { } //Length: 35
	}

	public BotVoxelesPersonalData(BotOwner owner) { }

	public void Activate(AICoversData data) { }

	[CompilerGenerated]
	public void add_OnVoxelChange(Action value) { }

	public Vector3 get__min() { }

	[CompilerGenerated]
	public NavGraphVoxelSimple get_CurVoxel() { }

	public int get_MaxX() { }

	public int get_MaxY() { }

	public int get_MaxZ() { }

	public GroupPoint GetClosestsPointVoxelesExtended(Vector3 pos, int rad, int connectionGroup, bool withFoliage) { }

	public int GetLastConnectionId() { }

	public List GetVoxelesExtended(Vector3 pos, int rad, bool onlyWithPoints) { }

	public NavGraphVoxelSimple GetVoxelSafe(Vector3 pos, bool withLogs = false) { }

	public NavGraphVoxelSimple GetVoxelSafeByIndex(int x, int y, int z) { }

	public List Points(Func func) { }

	[CompilerGenerated]
	public void remove_OnVoxelChange(Action value) { }

	[CompilerGenerated]
	private void set_CurVoxel(NavGraphVoxelSimple value) { }

	public void SetCurrectVoxel(NavGraphVoxelSimple prevVoxel) { }

}

