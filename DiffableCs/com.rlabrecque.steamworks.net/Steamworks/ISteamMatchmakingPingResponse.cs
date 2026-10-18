namespace Steamworks;

public class ISteamMatchmakingPingResponse
{
	[CompilerGenerated]
	private static class <>O
	{
		public static InternalServerResponded <0>__InternalOnServerResponded; //Field offset: 0x0
		public static InternalServerFailedToRespond <1>__InternalOnServerFailedToRespond; //Field offset: 0x8

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerFailedToRespond : MulticastDelegate
	{

		public InternalServerFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerResponded : MulticastDelegate
	{

		public InternalServerResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, gameserveritem_t server, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, gameserveritem_t server) { }

	}

	internal sealed class ServerFailedToRespond : MulticastDelegate
	{

		public ServerFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class ServerResponded : MulticastDelegate
	{

		public ServerResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(gameserveritem_t server, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(gameserveritem_t server) { }

	}

	private class VTable
	{
		public InternalServerResponded m_VTServerResponded; //Field offset: 0x10
		public InternalServerFailedToRespond m_VTServerFailedToRespond; //Field offset: 0x18

		public VTable() { }

	}

	private static readonly Dictionary m_Instances; //Field offset: 0x0
	private VTable m_VTable; //Field offset: 0x10
	private IntPtr m_pVTable; //Field offset: 0x18
	private GCHandle m_pGCHandle; //Field offset: 0x20
	private IntPtr m_pInstance; //Field offset: 0x28
	private ServerResponded m_ServerResponded; //Field offset: 0x30
	private ServerFailedToRespond m_ServerFailedToRespond; //Field offset: 0x38

	private static ISteamMatchmakingPingResponse() { }

	public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond) { }

	protected virtual void Finalize() { }

	[MonoPInvokeCallback(typeof(InternalServerFailedToRespond))]
	private static void InternalOnServerFailedToRespond(IntPtr thisptr) { }

	[MonoPInvokeCallback(typeof(InternalServerResponded))]
	private static void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server) { }

	public static IntPtr op_Explicit(ISteamMatchmakingPingResponse that) { }

}

