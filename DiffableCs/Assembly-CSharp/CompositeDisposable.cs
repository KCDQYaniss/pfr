//Type is in global namespace

public class CompositeDisposable : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public UnityEvent unityEvent; //Field offset: 0x10
		public UnityAction handler; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <SubscribeEvent>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0`1
	{
		public UnityEvent unityEvent; //Field offset: 0x0
		public UnityAction handler; //Field offset: 0x0

		public <>c__DisplayClass11_0`1() { }

		internal void <SubscribeEvent>b__0() { }

	}

	private Action _oneCase; //Field offset: 0x10
	private List _destroys; //Field offset: 0x18
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x20

	public CancellationToken CancellationToken
	{
		 get { } //Length: 294
	}

	public CompositeDisposable() { }

	public CompositeDisposable(int capacity) { }

	public void AddDisposable(Action destroy) { }

	public T AddDisposable(T disposable) { }

	public void BindEvent(UnityEvent unityEvent, UnityAction handler) { }

	public void BindEvent(IBindableEvent bindableEvent, Action handler, T defaultValue) { }

	public void BindEvent(IBindableEvent bindableEvent, Action handler) { }

	public void BindEvent(UnityEvent unityEvent, UnityAction handler, T value) { }

	public void BindState(IBindable state, Action handler) { }

	private void ClearCancellationToken() { }

	public override void Dispose() { }

	public void DisposeReference(ref T disposable) { }

	public CancellationToken get_CancellationToken() { }

	public void SubscribeEvent(IBindableEvent bindableEvent, Action handler) { }

	public void SubscribeEvent(IBindableEvent bindableEvent, Action handler) { }

	public void SubscribeEvent(UnityEvent unityEvent, UnityAction handler) { }

	public void SubscribeEvent(UnityEvent unityEvent, UnityAction handler) { }

	public void SubscribeState(IBindable state, Action handler) { }

}

