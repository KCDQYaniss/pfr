namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingCellReadCallback : MulticastDelegate
{

	public CullingCellReadCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(TemporaryCullingCellData data, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(TemporaryCullingCellData data) { }

}

