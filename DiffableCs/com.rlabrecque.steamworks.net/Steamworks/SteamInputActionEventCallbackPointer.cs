namespace Steamworks;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class SteamInputActionEventCallbackPointer : MulticastDelegate
{

	public SteamInputActionEventCallbackPointer(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IntPtr SteamInputActionEvent, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(IntPtr SteamInputActionEvent) { }

}

