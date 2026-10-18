namespace Diz.Binding;

public abstract class BaseBindable`1 : IBindable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public BaseBindable <>4__this; //Field offset: 0x0
		public Action handler; //Field offset: 0x0

		public <>c__DisplayClass21_0() { }

		internal void <Subscribe>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public BaseBindable <>4__this; //Field offset: 0x0
		public ICheckChanges handler; //Field offset: 0x0

		public <>c__DisplayClass23_0() { }

		internal void <BindWithoutValue>b__0() { }

	}

	protected T CurrentState; //Field offset: 0x0
	private readonly IEqualityComparer _equalityComparer; //Field offset: 0x0
	private List _changedEvents; //Field offset: 0x0
	private List _checkChanges; //Field offset: 0x0
	private bool _isUpdatingValue; //Field offset: 0x0
	private readonly Queue _delayedUnSubs; //Field offset: 0x0

	private List ChangedEvents
	{
		private get { } //Length: 332
	}

	private List CheckChanges
	{
		private get { } //Length: 327
	}

	[CanBeNull]
	public IReadOnlyList Handlers
	{
		 get { } //Length: 5
	}

	public bool HasCheckChanges
	{
		 get { } //Length: 74
	}

	public bool HasHandlers
	{
		 get { } //Length: 22
	}

	public override T Value
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	protected BaseBindable`1(IEqualityComparer equalityComparer = null) { }

	public override Action Bind(Action handler) { }

	public override Action BindWithoutValue(ICheckChanges handler) { }

	private List get_ChangedEvents() { }

	private List get_CheckChanges() { }

	public IReadOnlyList get_Handlers() { }

	public bool get_HasCheckChanges() { }

	public bool get_HasHandlers() { }

	public override T get_Value() { }

	private bool IsValueEqualsToCurrentState(T newState) { }

	public static T op_Implicit(BaseBindable setting) { }

	public override void set_Value(T value) { }

	public override Action Subscribe(Action handler) { }

	private void ThrowIfUpdatingValue() { }

	protected override void Unbind(Action handler) { }

	protected void UpdateState(T newState) { }

}

