namespace EFT;

public struct ObserverMovementFrameInfo
{
	public int FrameId; //Field offset: 0x0
	public float TimeStamp; //Field offset: 0x4
	public Vector3 Position; //Field offset: 0x8

	public static ObserverMovementFrameInfo Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

