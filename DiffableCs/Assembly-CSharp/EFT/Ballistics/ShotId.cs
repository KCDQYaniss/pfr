namespace EFT.Ballistics;

public struct ShotId
{
	public static readonly ShotId EMPTY_SHOT_ID; //Field offset: 0x0
	private readonly string _ammoId; //Field offset: 0x0
	private readonly int _fragmentIndex; //Field offset: 0x8

	private static ShotId() { }

	public ShotId(string ammoId, int fragmentIndex) { }

	public bool Equals(ShotId other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

