namespace Comfort.Transceivers;

public sealed class DataPacketWriter : BinaryWriter
{
	private static readonly byte[] Header; //Field offset: 0x0
	private Transceiver _transceiver; //Field offset: 0x50
	private readonly Action _disposeCallback; //Field offset: 0x58

	private static DataPacketWriter() { }

	public DataPacketWriter(Transceiver transceiver, Action disposeCallback = null) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	private static void WriteCount(byte[] buffer, int count) { }

}

