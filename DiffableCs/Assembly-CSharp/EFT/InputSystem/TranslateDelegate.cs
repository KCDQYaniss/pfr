namespace EFT.InputSystem;

public sealed class TranslateDelegate : MulticastDelegate
{

	public TranslateDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(List commands, ref float[] axes, ref ECursorResult shouldLockCursor, AsyncCallback callback, object object) { }

	public override void EndInvoke(ref float[] axes, ref ECursorResult shouldLockCursor, IAsyncResult result) { }

	public override void Invoke(List commands, ref float[] axes, ref ECursorResult shouldLockCursor) { }

}

