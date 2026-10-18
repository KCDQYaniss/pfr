namespace EFT.RocketLauncher.Explosion;

public struct ComputableUnit : IEquatable
{
	public float Weight; //Field offset: 0x0
	public Vector3 WorldPosition; //Field offset: 0x4
	public Vector3Int NormalizedGridPosition; //Field offset: 0x10
	public Vector3Int Direction; //Field offset: 0x1C

	public override bool Equals(ComputableUnit other) { }

}

