namespace EFT.InventoryLogic;

public class SearchableItem : CompoundItem, IItemInfoContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetContainersHashSum>b__8_0(IContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__19 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public SearchableItem <>4__this; //Field offset: 0x20
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
		public <get_ItemInteractionButtons>d__19(int <>1__state) { }

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

	private SearchableItemTemplate _searchableTemplate; //Field offset: 0x90
	private ItemInfo _itemInfo; //Field offset: 0x98

	public virtual int Height
	{
		 get { } //Length: 61
	}

	public virtual bool IsContainer
	{
		 get { } //Length: 3
	}

	public bool IsSearched
	{
		 get { } //Length: 17
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__19))]
		 get { } //Length: 175
	}

	public string SearchSound
	{
		 get { } //Length: 33
	}

	public virtual float TotalWeight
	{
		 get { } //Length: 25
	}

	public virtual int Width
	{
		 get { } //Length: 61
	}

	public SearchableItem(string id, SearchableItemTemplate template) { }

	[CompilerGenerated]
	private SearchableGrid <.ctor>b__5_0(Grid x) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	private override void EFT.IItemInfoContainer.SetItemInfo(ItemInfo itemInfo) { }

	public virtual int get_Height() { }

	public virtual bool get_IsContainer() { }

	public bool get_IsSearched() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__19))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	public string get_SearchSound() { }

	public virtual float get_TotalWeight() { }

	public virtual int get_Width() { }

	protected virtual int GetContainersHashSum() { }

	private int GetSearchableHashSum() { }

	public ItemInfo GetSearchableInfo() { }

}

