namespace Steamworks;

public sealed class CallResult`1 : CallResult, IDisposable
{
	internal sealed class APIDispatchDelegate : MulticastDelegate
	{

		public APIDispatchDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T param, bool bIOFailure, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T param, bool bIOFailure) { }

	}

	[CompilerGenerated]
	private APIDispatchDelegate m_Func; //Field offset: 0x0
	private SteamAPICall_t m_hAPICall; //Field offset: 0x0
	private bool m_bDisposed; //Field offset: 0x0

	private event APIDispatchDelegate m_Func
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public SteamAPICall_t Handle
	{
		 get { } //Length: 5
	}

	public CallResult`1(APIDispatchDelegate func = null) { }

	[CompilerGenerated]
	private void add_m_Func(APIDispatchDelegate value) { }

	public void Cancel() { }

	public static CallResult Create(APIDispatchDelegate func = null) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public SteamAPICall_t get_Handle() { }

	protected private virtual Type GetCallbackType() { }

	public bool IsActive() { }

	protected private virtual void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) { }

	[CompilerGenerated]
	private void remove_m_Func(APIDispatchDelegate value) { }

	public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate func = null) { }

	protected private virtual void SetUnregistered() { }

}

