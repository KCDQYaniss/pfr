namespace EFT.WeaponMounting;

public sealed class MountPointData
{
	[CompilerGenerated]
	private readonly EMountSideDirection <MountSideDirection>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Vector3 <MountPoint>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly Vector3 <MountDirection>k__BackingField; //Field offset: 0x20

	public Vector3 MountDirection
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public Vector3 MountPoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public EMountSideDirection MountSideDirection
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public MountPointData(Vector3 mountPoint, Vector3 mountDirection, EMountSideDirection mountSideDirection) { }

	[CompilerGenerated]
	public Vector3 get_MountDirection() { }

	[CompilerGenerated]
	public Vector3 get_MountPoint() { }

	[CompilerGenerated]
	public EMountSideDirection get_MountSideDirection() { }

}

