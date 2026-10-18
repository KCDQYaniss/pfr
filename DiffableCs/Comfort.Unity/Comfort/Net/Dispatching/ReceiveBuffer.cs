namespace Comfort.Net.Dispatching;

public sealed class ReceiveBuffer
{
	[CompilerGenerated]
	private sealed class 
	{
		public int ; //Field offset: 0x10
		public int ; //Field offset: 0x14
		public ReceiveBuffer ; //Field offset: 0x18

		public () { }

		internal void (int ) { }

	}

	[CompilerGenerated]
	private sealed class 
	{
		public int ; //Field offset: 0x10
		public ReceiveBuffer ; //Field offset: 0x18

		public () { }

		internal void (int ) { }

	}

	private static readonly ArraySegment ; //Field offset: 0x0
	private readonly ConnectionPerformance ; //Field offset: 0x10
	private bool ; //Field offset: 0x18
	private bool ; //Field offset: 0x19
	private byte[] ; //Field offset: 0x20
	private ulong ; //Field offset: 0x28
	private int ; //Field offset: 0x30
	private int ; //Field offset: 0x34
	private readonly int ; //Field offset: 0x38
	private readonly int ; //Field offset: 0x3C
	private int ; //Field offset: 0x40
	public int _readed; //Field offset: 0x44

	public ulong Received
	{
		 get { } //Length: 5
	}

	private static ReceiveBuffer() { }

	public ReceiveBuffer(int size, ConnectionPerformance performace) { }

	public void Correct(ulong received) { }

	public ulong get_Received() { }

	public bool Pop(out ArraySegment segment, out Action callback) { }

	public bool Reserve(out ArraySegment segment, out Action callback) { }

	public void Reset() { }

	public void Unlock() { }

	private void () { }

}

