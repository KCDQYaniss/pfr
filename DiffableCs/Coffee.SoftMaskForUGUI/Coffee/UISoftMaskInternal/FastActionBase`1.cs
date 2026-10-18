namespace Coffee.UISoftMaskInternal;

internal class FastActionBase`1
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LinkedListNode <.cctor>b__7_0() { }

		internal bool <.cctor>b__7_1(LinkedListNode _) { }

		internal void <.cctor>b__7_2(LinkedListNode x) { }

	}

	private static readonly InternalObjectPool s_NodePool; //Field offset: 0x0
	private readonly LinkedList _delegates; //Field offset: 0x0

	private static FastActionBase`1() { }

	public FastActionBase`1() { }

	public void Add(T rhs) { }

	public void Clear() { }

	protected void Invoke(Action callback) { }

	public void Remove(T rhs) { }

}

