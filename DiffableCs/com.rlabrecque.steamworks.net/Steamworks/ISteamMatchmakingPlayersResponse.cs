namespace Steamworks;

public class ISteamMatchmakingPlayersResponse
{
	[CompilerGenerated]
	private static class <>O
	{
		public static InternalAddPlayerToList <0>__InternalOnAddPlayerToList; //Field offset: 0x0
		public static InternalPlayersFailedToRespond <1>__InternalOnPlayersFailedToRespond; //Field offset: 0x8
		public static InternalPlayersRefreshComplete <2>__InternalOnPlayersRefreshComplete; //Field offset: 0x10

	}

	internal sealed class AddPlayerToList : MulticastDelegate
	{

		public AddPlayerToList(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string pchName, int nScore, float flTimePlayed) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalAddPlayerToList : MulticastDelegate
	{

		public InternalAddPlayerToList(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalPlayersFailedToRespond : MulticastDelegate
	{

		public InternalPlayersFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalPlayersRefreshComplete : MulticastDelegate
	{

		public InternalPlayersRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr thisptr) { }

	}

	internal sealed class PlayersFailedToRespond : MulticastDelegate
	{

		public PlayersFailedToRespond(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class PlayersRefreshComplete : MulticastDelegate
	{

		public PlayersRefreshComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private class VTable
	{
		public InternalAddPlayerToList m_VTAddPlayerToList; //Field offset: 0x10
		public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond; //Field offset: 0x18
		public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete; //Field offset: 0x20

		public VTable() { }

	}

	private static readonly Dictionary m_Instances; //Field offset: 0x0
	private VTable m_VTable; //Field offset: 0x10
	private IntPtr m_pVTable; //Field offset: 0x18
	private GCHandle m_pGCHandle; //Field offset: 0x20
	private IntPtr m_pInstance; //Field offset: 0x28
	private AddPlayerToList m_AddPlayerToList; //Field offset: 0x30
	private PlayersFailedToRespond m_PlayersFailedToRespond; //Field offset: 0x38
	private PlayersRefreshComplete m_PlayersRefreshComplete; //Field offset: 0x40

	private static ISteamMatchmakingPlayersResponse() { }

	public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete) { }

	protected virtual void Finalize() { }

	[MonoPInvokeCallback(typeof(InternalAddPlayerToList))]
	private static void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	[MonoPInvokeCallback(typeof(InternalPlayersFailedToRespond))]
	private static void InternalOnPlayersFailedToRespond(IntPtr thisptr) { }

	[MonoPInvokeCallback(typeof(InternalPlayersRefreshComplete))]
	private static void InternalOnPlayersRefreshComplete(IntPtr thisptr) { }

	public static IntPtr op_Explicit(ISteamMatchmakingPlayersResponse that) { }

}

