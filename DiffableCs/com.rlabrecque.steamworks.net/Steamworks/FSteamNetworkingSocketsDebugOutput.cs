namespace Steamworks;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class FSteamNetworkingSocketsDebugOutput : MulticastDelegate
{

	public FSteamNetworkingSocketsDebugOutput(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg) { }

}

