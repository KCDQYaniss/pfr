namespace EFT.Console.Core;

public abstract class CommandItemBase
{
	[CompilerGenerated]
	private sealed class <GetParents>d__13 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CommandItemBase <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private bool includeSelf; //Field offset: 0x24
		public bool <>3__includeSelf; //Field offset: 0x25
		public CommandItemBase <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

		private override CommandItemBase System.Collections.Generic.IEnumerator<EFT.Console.Core.CommandItemBase>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetParents>d__13(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Console.Core.CommandItemBase>.GetEnumerator() { }

		[DebuggerHidden]
		private override CommandItemBase System.Collections.Generic.IEnumerator<EFT.Console.Core.CommandItemBase>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private readonly string[] <Names>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly CommandItemBase <Parent>k__BackingField; //Field offset: 0x20

	public string BaseName
	{
		 get { } //Length: 39
	}

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string[] Names
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CommandItemBase Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected CommandItemBase(CommandItemBase parent, string[] names, string description) { }

	public bool ContainsNameVariant(string variant) { }

	public abstract ConstructorFindResult FindConstructor(IEnumerable arguments) { }

	public string get_BaseName() { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public string[] get_Names() { }

	[CompilerGenerated]
	public CommandItemBase get_Parent() { }

	public string GetAliasesNames() { }

	public string GetFullName() { }

	[IteratorStateMachine(typeof(<GetParents>d__13))]
	public IEnumerable GetParents(bool includeSelf) { }

}

