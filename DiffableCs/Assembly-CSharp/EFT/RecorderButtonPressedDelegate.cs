namespace EFT;

public sealed class RecorderButtonPressedDelegate : MulticastDelegate
{

	public RecorderButtonPressedDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(TapeItem tape, bool result, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(TapeItem tape, bool result) { }

}

