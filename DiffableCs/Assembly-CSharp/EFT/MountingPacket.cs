namespace EFT;

public struct MountingPacket
{
	internal enum EMountingCommand
	{
		Enter = 0,
		Exit = 1,
		Update = 2,
		StartLeaving = 3,
	}

	public bool HasCriticalData; //Field offset: 0x0
	public bool IsMounted; //Field offset: 0x1
	public Vector3 MountingPoint; //Field offset: 0x4
	public float CurrentMountingPointVerticalOffset; //Field offset: 0x10
	public short MountingDirection; //Field offset: 0x14
	public EMountingCommand MountingCommand; //Field offset: 0x16
	public float TransitionTime; //Field offset: 0x18

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(MountingPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

