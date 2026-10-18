namespace Diz.Binding;

public sealed class BindableEvent : IBindableEvent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public BindableEvent <>4__this; //Field offset: 0x10
		public Action handler; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Subscribe>b__0() { }

	}

	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x10

	private event Action _onChange
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public BindableEvent() { }

	[CompilerGenerated]
	private void add__onChange(Action value) { }

	public override Action Bind(Action handler) { }

	public void Invoke() { }

	[CompilerGenerated]
	private void remove__onChange(Action value) { }

	public override Action Subscribe(Action handler) { }

}

