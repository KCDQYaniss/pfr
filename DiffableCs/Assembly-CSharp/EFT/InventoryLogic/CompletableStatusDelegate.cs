namespace EFT.InventoryLogic;

public sealed class CompletableStatusDelegate : MulticastDelegate
{

	public CompletableStatusDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Item item, float progress, EStudyState state, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Item item, float progress, EStudyState state) { }

}

