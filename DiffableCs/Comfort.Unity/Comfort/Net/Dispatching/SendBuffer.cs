namespace Comfort.Net.Dispatching;

public sealed class SendBuffer
{
	[CompilerGenerated]
	private sealed class 
	{
		public int ; //Field offset: 0x10
		public int ; //Field offset: 0x14
		public SendBuffer ; //Field offset: 0x18

		public () { }

		internal void (int ) { }

	}

	private static readonly ArraySegment ; //Field offset: 0x0
	private readonly ConnectionPerformance ; //Field offset: 0x10
	private bool ; //Field offset: 0x18
	private readonly int ; //Field offset: 0x1C
	private readonly int ; //Field offset: 0x20
	private readonly int ; //Field offset: 0x24
	private byte[] ; //Field offset: 0x28
	private int ; //Field offset: 0x30
	private int ; //Field offset: 0x34
	private ulong ; //Field offset: 0x38
	private int ; //Field offset: 0x40

	private static SendBuffer() { }

	public SendBuffer(int size, int backupLimit, ConnectionPerformance performace) { }

	public bool Pop(out ArraySegment segment, out Action callback) { }

	public void Reset() { }

	public bool Unlock(ulong correction) { }

	public int Write(ref ArraySegment segment) { }

	private void (int ) { }

	private void (int ) { }

}

