namespace Bsg.GameSettings;

public sealed class ListGameSetting`1 : GameSetting
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CopyItem <>9__6_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TType <.ctor>b__6_0(TType item) { }

	}

	[CompilerGenerated]
	private struct <SetValue>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ListGameSetting <>4__this; //Field offset: 0x0
		public List value; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CopyItem : MulticastDelegate
	{

		public CopyItem(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TType item, AsyncCallback callback, object object) { }

		public override TType EndInvoke(IAsyncResult result) { }

		public override TType Invoke(TType item) { }

	}

	internal sealed class EqualityCheck : MulticastDelegate
	{

		public EqualityCheck(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TType x, TType y, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(TType x, TType y) { }

	}

	private readonly BindableEvent _onListChanged; //Field offset: 0x0
	private readonly EqualityCheck _equalityCheck; //Field offset: 0x0
	private readonly CopyItem _copyItem; //Field offset: 0x0
	private List _value; //Field offset: 0x0

	internal ListGameSetting`1(string key, CopyItem copyItem = null, EqualityCheck equalityCheck = null, Func preProcessor = null) { }

	public virtual Action Bind(Action handler) { }

	public virtual Action BindWithoutValue(ICheckChanges handler) { }

	public virtual void ForceApply() { }

	public virtual List GetValue() { }

	public virtual bool HasSameValue(GameSetting other) { }

	public virtual void ResetToDefault() { }

	[AsyncStateMachine(typeof(<SetValue>d__8))]
	public virtual Task SetValue(List value) { }

	public virtual Action Subscribe(Action handler) { }

	public virtual void TakeValueFrom(GameSetting other) { }

	public TType[] ToArray() { }

}

