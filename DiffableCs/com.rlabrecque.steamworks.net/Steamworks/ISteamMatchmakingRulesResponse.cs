namespace Steamworks;

public class ISteamMatchmakingRulesResponse
{
	[CompilerGenerated]
	private static class <>O
	{
		public static InternalRulesResponded <0>__InternalOnRulesResponded; //Field offset: 0x0
		public static InternalRulesFailedToRespond <1>__InternalOnRulesFailedToRespond; //Field offset: 0x8
		public static InternalRulesRefreshComplete <2>__InternalOnRulesRefreshComplete; //Field offset: 0x10

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesFailedToRespond : MulticastDelegate
	{

		public InternalRulesFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesRefreshComplete : MulticastDelegate
	{

		public InternalRulesRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesResponded : MulticastDelegate
	{

		public InternalRulesResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	}

	internal sealed class RulesFailedToRespond : MulticastDelegate
	{

		public RulesFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class RulesRefreshComplete : MulticastDelegate
	{

		public RulesRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class RulesResponded : MulticastDelegate
	{

		public RulesResponded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRule, string pchValue, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string pchRule, string pchValue) { }

	}

	private class VTable
	{
		public InternalRulesResponded m_VTRulesResponded; //Field offset: 0x10
		public InternalRulesFailedToRespond m_VTRulesFailedToRespond; //Field offset: 0x18
		public InternalRulesRefreshComplete m_VTRulesRefreshComplete; //Field offset: 0x20

		public VTable() { }

	}

	private static readonly Dictionary m_Instances; //Field offset: 0x0
	private VTable m_VTable; //Field offset: 0x10
	private IntPtr m_pVTable; //Field offset: 0x18
	private GCHandle m_pGCHandle; //Field offset: 0x20
	private IntPtr m_pInstance; //Field offset: 0x28
	private RulesResponded m_RulesResponded; //Field offset: 0x30
	private RulesFailedToRespond m_RulesFailedToRespond; //Field offset: 0x38
	private RulesRefreshComplete m_RulesRefreshComplete; //Field offset: 0x40

	private static ISteamMatchmakingRulesResponse() { }

	public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete) { }

	protected virtual void Finalize() { }

	[MonoPInvokeCallback(typeof(InternalRulesFailedToRespond))]
	private static void InternalOnRulesFailedToRespond(IntPtr thisptr) { }

	[MonoPInvokeCallback(typeof(InternalRulesRefreshComplete))]
	private static void InternalOnRulesRefreshComplete(IntPtr thisptr) { }

	[MonoPInvokeCallback(typeof(InternalRulesResponded))]
	private static void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	public static IntPtr op_Explicit(ISteamMatchmakingRulesResponse that) { }

}

