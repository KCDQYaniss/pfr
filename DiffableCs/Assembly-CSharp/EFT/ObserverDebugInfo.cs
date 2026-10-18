namespace EFT;

public struct ObserverDebugInfo
{
	public bool HasData; //Field offset: 0x0
	public int ProfileId; //Field offset: 0x4
	public float TimeStamp; //Field offset: 0x8
	public ObserverMovementFrameInfo PrevFrame; //Field offset: 0xC
	public ObserverMovementFrameInfo CurrentFrame; //Field offset: 0x20
	public Vector3 InterpolatedPosition; //Field offset: 0x34
	public Vector3 InterpolatedStomachPosition; //Field offset: 0x40
	public Vector3 InterpolatedHeadPosition; //Field offset: 0x4C
	public float Layer0NT; //Field offset: 0x58

	public static ObserverDebugInfo Deserialize(IBitReaderStream reader) { }

	public static void Serialize(ObserverDebugInfo info, IBitWriterStream writer) { }

	public virtual string ToString() { }

}

