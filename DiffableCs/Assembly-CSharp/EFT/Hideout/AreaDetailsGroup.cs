namespace EFT.Hideout;

[DefaultMember("Item")]
public sealed class AreaDetailsGroup : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public EDetailsType type; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <ContainsType>b__0(AreaDetailsData details) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public EDetailsType type; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <get_Item>b__0(AreaDetailsData details) { }

	}

	internal struct DetailsEnumerator : IEnumerator, IEnumerator, IDisposable
	{
		private List _list; //Field offset: 0x0
		private int _index; //Field offset: 0x8
		[CompilerGenerated]
		private AreaDetailsData <Current>k__BackingField; //Field offset: 0x10

		public private override AreaDetailsData Current
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 5
		}

		internal DetailsEnumerator(List list) { }

		public override void Dispose() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override AreaDetailsData get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		[CompilerGenerated]
		private void set_Current(AreaDetailsData value) { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[CompilerGenerated]
	private Action OnDetailsChanged; //Field offset: 0x10
	private List _details; //Field offset: 0x18

	public event Action OnDetailsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int Count
	{
		 get { } //Length: 65
	}

	public AreaDetailsData Item
	{
		 get { } //Length: 228
	}

	public AreaDetailsGroup() { }

	public void Add(AreaDetailsData data) { }

	[CompilerGenerated]
	public void add_OnDetailsChanged(Action value) { }

	public void Clear() { }

	public bool ContainsType(EDetailsType type) { }

	private void DetailsDataChangedHandler(AreaDetailsData data, AreaDetailsCache oldData) { }

	public int get_Count() { }

	public AreaDetailsData get_Item(EDetailsType type) { }

	public override IEnumerator GetEnumerator() { }

	public bool Remove(AreaDetailsData data) { }

	[CompilerGenerated]
	public void remove_OnDetailsChanged(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetDetails(EDetailsType type, out AreaDetailsData result) { }

}

