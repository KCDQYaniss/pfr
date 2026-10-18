namespace Diz.Binding;

public sealed class BindableEvent`1 : IBindableEvent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public BindableEvent <>4__this; //Field offset: 0x0
		public Action handler; //Field offset: 0x0

		public <>c__DisplayClass3_0() { }

		internal void <Bind>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public BindableEvent <>4__this; //Field offset: 0x0
		public Action handler; //Field offset: 0x0

		public <>c__DisplayClass4_0() { }

		internal void <Subscribe>b__0() { }

	}

	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x0

	private event Action _onChange
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public BindableEvent`1() { }

	[CompilerGenerated]
	private void add__onChange(Action value) { }

	public override Action Bind(Action handler, T value) { }

	public void Invoke(T arg) { }

	[CompilerGenerated]
	private void remove__onChange(Action value) { }

	public override Action Subscribe(Action handler) { }

}

