//Type is in global namespace

public static class IconsHash
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetItemHash>b__4_0(int subHash) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllItemHashes>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private Item topLevelItem; //Field offset: 0x20
		public Item <>3__topLevelItem; //Field offset: 0x28
		private int hashSeed; //Field offset: 0x30
		public int <>3__hashSeed; //Field offset: 0x34
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private int <subItemNumber>5__3; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48
		private IEnumerator <>7__wrap4; //Field offset: 0x50

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <GetAllItemHashes>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

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
	private static readonly int <Default>k__BackingField; //Field offset: 0x0

	public static int Default
	{
		[CompilerGenerated]
		 get { } //Length: 82
	}

	private static IconsHash() { }

	[CompilerGenerated]
	public static int get_Default() { }

	[IteratorStateMachine(typeof(<GetAllItemHashes>d__5))]
	private static IEnumerable GetAllItemHashes(Item topLevelItem, int hashSeed = 1) { }

	public static int GetClothingHash(CustomizationClothing clothing) { }

	public static int GetItemHash(Item item) { }

	private static int HashForItem(Item item) { }

}

