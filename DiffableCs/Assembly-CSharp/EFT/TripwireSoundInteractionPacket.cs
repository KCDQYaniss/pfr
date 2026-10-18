namespace EFT;

public struct TripwireSoundInteractionPacket
{
	public bool hasCriticalData; //Field offset: 0x0
	public EInteractionStatus interactionStatus; //Field offset: 0x4
	public bool isSuccess; //Field offset: 0x8
	public bool hasMultiTool; //Field offset: 0x9

	public void Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

