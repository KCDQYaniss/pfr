namespace EFT.InventoryLogic;

public class MobContainer : SearchableItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_1; //Field offset: 0x8
		public static Func <>9__6_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__6_1() { }

		internal EItemAttributeDisplayType <.ctor>b__6_3() { }

	}

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public MobContainer <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.Current
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
		public <get_ItemInteractionButtons>d__8(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.EItemInfoButton>.GetEnumerator() { }

		[DebuggerHidden]
		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	public bool isSecured
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__8))]
		 get { } //Length: 175
	}

	public int sizeHeight
	{
		 get { } //Length: 79
	}

	public int sizeWidth
	{
		 get { } //Length: 79
	}

	public MobContainer(string id, MobContainerTemplate template) { }

	[CompilerGenerated]
	private string <.ctor>b__6_0() { }

	[CompilerGenerated]
	private string <.ctor>b__6_2() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	public bool get_isSecured() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__8))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	public int get_sizeHeight() { }

	public int get_sizeWidth() { }

}

