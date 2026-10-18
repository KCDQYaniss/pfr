namespace Comfort.Transceivers;

public class Buffer
{
	private readonly object _syncObject; //Field offset: 0x10
	private byte[] _buffer; //Field offset: 0x18
	private int _count; //Field offset: 0x20
	private bool _readed; //Field offset: 0x24

	public int Count
	{
		 get { } //Length: 4
	}

	public Buffer() { }

	public void Clear() { }

	private void ExpandBuffer(int size) { }

	public int get_Count() { }

	public byte[] Peak() { }

	public byte[] Peak(int skip) { }

	public void Read(Transceiver transceiver) { }

	private void ReduceBuffer(int count) { }

	public void Skip(int count) { }

	public override int Write(ref ArraySegment segment) { }

}

