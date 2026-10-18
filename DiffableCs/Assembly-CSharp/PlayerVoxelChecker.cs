//Type is in global namespace

public class PlayerVoxelChecker : IVoxelChecker
{
	public const float COEF = 100; //Field offset: 0x0
	private List _changedPath; //Field offset: 0x10
	private NavMeshDoorLink[] _affectedDoorLinks; //Field offset: 0x18
	[CompilerGenerated]
	private NavGraphVoxel <Voxel>k__BackingField; //Field offset: 0x20

	public private NavGraphVoxel Voxel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PlayerVoxelChecker() { }

	public int AffectedDoorElements() { }

	public int AffectedElements() { }

	public override void Dispose() { }

	private void DropCoefIfPossible() { }

	[CompilerGenerated]
	public NavGraphVoxel get_Voxel() { }

	public Vector3 GetVoxelPos() { }

	[CompilerGenerated]
	private void set_Voxel(NavGraphVoxel value) { }

	public override void SetPos(Vector3 pos, bool withLogs = false) { }

	public override void TryDrawAffectionGizmos() { }

}

