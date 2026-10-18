namespace Sirenix.Utilities;

[DefaultMember("Item")]
public sealed class ImmutableList : IImmutableList, IImmutableList, IList, ICollection, IEnumerable, IList, ICollection, IEnumerable
{
	[CompilerGenerated]
	private sealed class <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ImmutableList <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private IList innerList; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 78
	}

	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 78
	}

	public override object Item
	{
		 get { } //Length: 89
	}

	public override object SyncRoot
	{
		 get { } //Length: 78
	}

	private override object System.Collections.Generic.IList<System.Object>.Item
	{
		private get { } //Length: 89
		private set { } //Length: 78
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 89
		private set { } //Length: 78
	}

	public ImmutableList(IList innerList) { }

	public override bool Contains(object value) { }

	public override void CopyTo(object[] array, int arrayIndex) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(int index) { }

	public override object get_SyncRoot() { }

	public IEnumerator GetEnumerator() { }

	public override int IndexOf(object value) { }

	private override void System.Collections.Generic.ICollection<System.Object>.Add(object item) { }

	private override void System.Collections.Generic.ICollection<System.Object>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Object>.Remove(object item) { }

	[IteratorStateMachine(typeof(<System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25))]
	private override IEnumerator System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	private override object System.Collections.Generic.IList<System.Object>.get_Item(int index) { }

	private override void System.Collections.Generic.IList<System.Object>.Insert(int index, object item) { }

	private override void System.Collections.Generic.IList<System.Object>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

