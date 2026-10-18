namespace EFT.Ballistics;

[IsReadOnly]
public struct TrajectoryInfo
{
	public readonly int index; //Field offset: 0x0
	public readonly float time; //Field offset: 0x4
	public readonly Vector3 position; //Field offset: 0x8
	public readonly Vector3 velocity; //Field offset: 0x14

	public TrajectoryInfo(int index, float time, Vector3 position, Vector3 velocity) { }

}

