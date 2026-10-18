namespace Bsg.GameSettings;

public class StateGameSetting`1 : GameSetting
{
	[CompilerGenerated]
	private struct <SetValue>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StateGameSetting <>4__this; //Field offset: 0x0
		public T value; //Field offset: 0x0
		private BindableState <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly BindableState _internalState; //Field offset: 0x0
	private T _defaultValue; //Field offset: 0x0

	internal StateGameSetting`1(string key, T defaultValue, Func asyncPreProcessor) { }

	internal StateGameSetting`1(string key, T defaultValue, Func preProcessor) { }

	public virtual Action Bind(Action handler) { }

	public virtual Action BindWithoutValue(ICheckChanges handler) { }

	public virtual void ForceApply() { }

	public virtual T GetValue() { }

	public virtual bool HasSameValue(GameSetting other) { }

	private void Init(T defaultValue) { }

	public virtual void ResetToDefault() { }

	[AsyncStateMachine(typeof(<SetValue>d__3))]
	public virtual Task SetValue(T value) { }

	public virtual Action Subscribe(Action handler) { }

	public virtual void TakeValueFrom(GameSetting other) { }

}

