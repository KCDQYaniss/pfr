namespace Steamworks;

public sealed class Callback`1 : Callback, IDisposable
{
	internal sealed class DispatchDelegate : MulticastDelegate
	{

		public DispatchDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T param, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(T param) { }

	}

	[CompilerGenerated]
	private DispatchDelegate m_Func; //Field offset: 0x0
	private bool m_bGameServer; //Field offset: 0x0
	private bool m_bIsRegistered; //Field offset: 0x0
	private bool m_bDisposed; //Field offset: 0x0

	private event DispatchDelegate m_Func
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public virtual bool IsGameServer
	{
		 get { } //Length: 5
	}

	public Callback`1(DispatchDelegate func, bool bGameServer = false) { }

	[CompilerGenerated]
	private void add_m_Func(DispatchDelegate value) { }

	public static Callback Create(DispatchDelegate func) { }

	public static Callback CreateGameServer(DispatchDelegate func) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public virtual bool get_IsGameServer() { }

	internal virtual Type GetCallbackType() { }

	internal virtual void OnRunCallback(IntPtr pvParam) { }

	public void Register(DispatchDelegate func) { }

	[CompilerGenerated]
	private void remove_m_Func(DispatchDelegate value) { }

	internal virtual void SetUnregistered() { }

	public void Unregister() { }

}

