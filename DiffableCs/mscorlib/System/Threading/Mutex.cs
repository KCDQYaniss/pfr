namespace System.Threading;

[ComVisible(True)]
public sealed class Mutex : WaitHandle
{

	public Mutex(bool initiallyOwned, string name) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public void ReleaseMutex() { }

	private static bool ReleaseMutex_internal(IntPtr handle) { }

}

