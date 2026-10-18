namespace Steamworks;

[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate
{

	public SteamAPI_CheckCallbackRegistered_t(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int iCallbackNum) { }

}

