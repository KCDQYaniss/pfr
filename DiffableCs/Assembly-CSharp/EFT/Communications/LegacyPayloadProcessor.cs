namespace EFT.Communications;

internal sealed class LegacyPayloadProcessor : MulticastDelegate
{

	public LegacyPayloadProcessor(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(byte[] payload, Action onProcessed, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(byte[] payload, Action onProcessed) { }

}

