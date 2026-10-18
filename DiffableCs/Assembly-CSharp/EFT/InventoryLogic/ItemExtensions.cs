namespace EFT.InventoryLogic;

[Extension]
public static class ItemExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x8
		public static Func <>9__42_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetPrefabPathsWithChildren>b__42_0(Item x) { }

		internal string <GetPrefabPathsWithChildren>b__42_1(Item x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Predicate <0>__MergesWithChildren; //Field offset: 0x0
		public static Predicate <1>__NotMergedWithChildren; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <GetAllItems>d__2 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Item topLevelItem; //Field offset: 0x28
		public Item <>3__topLevelItem; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllItems>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllItems>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Item topLevelItem; //Field offset: 0x28
		public Item <>3__topLevelItem; //Field offset: 0x30
		private Predicate goInsideItemPredicate; //Field offset: 0x38
		public Predicate <>3__goInsideItemPredicate; //Field offset: 0x40
		private Predicate goInsideContainerPredicate; //Field offset: 0x48
		public Predicate <>3__goInsideContainerPredicate; //Field offset: 0x50
		private IEnumerator <>7__wrap1; //Field offset: 0x58
		private IEnumerator <>7__wrap2; //Field offset: 0x60
		private IEnumerator <>7__wrap3; //Field offset: 0x68

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllItems>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllItemsFromCollection>d__3 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ContainerCollection topLevelCollection; //Field offset: 0x28
		public ContainerCollection <>3__topLevelCollection; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllItemsFromCollection>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllItemsFromCollections>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable topLevelCollections; //Field offset: 0x28
		public IEnumerable <>3__topLevelCollections; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllItemsFromCollections>d__8(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllItemsFromGridItemCollectionNonAlloc>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private GridItemCollection gridItemCollection; //Field offset: 0x28
		public GridItemCollection <>3__gridItemCollection; //Field offset: 0x30
		private List preAllocatedList; //Field offset: 0x38
		public List <>3__preAllocatedList; //Field offset: 0x40
		private Enumerator <>7__wrap1; //Field offset: 0x48
		private Item <item>5__3; //Field offset: 0x60
		private Enumerator <>7__wrap3; //Field offset: 0x68

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllItemsFromGridItemCollectionNonAlloc>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllParentItems>d__34 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ItemAddress location; //Field offset: 0x28
		public ItemAddress <>3__location; //Field offset: 0x30
		private bool onlyMerged; //Field offset: 0x38
		public bool <>3__onlyMerged; //Field offset: 0x39

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllParentItems>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllParentItemsAndSelf>d__35 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Item item; //Field offset: 0x28
		public Item <>3__item; //Field offset: 0x30
		private bool onlyMerged; //Field offset: 0x38
		public bool <>3__onlyMerged; //Field offset: 0x39
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetAllParentItemsAndSelf>d__35(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetAllParentLocations>d__32 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ItemAddress <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Item item; //Field offset: 0x28
		public Item <>3__item; //Field offset: 0x30
		private bool onlyMerged; //Field offset: 0x38
		public bool <>3__onlyMerged; //Field offset: 0x39

		private override ItemAddress System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemAddress>.Current
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
		public <GetAllParentLocations>d__32(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ItemAddress>.GetEnumerator() { }

		[DebuggerHidden]
		private override ItemAddress System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemAddress>.get_Current() { }

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
	private sealed class <GetAllParentLocations>d__33 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ItemAddress <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ItemAddress location; //Field offset: 0x28
		public ItemAddress <>3__location; //Field offset: 0x30
		private bool onlyMerged; //Field offset: 0x38
		public bool <>3__onlyMerged; //Field offset: 0x39

		private override ItemAddress System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemAddress>.Current
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
		public <GetAllParentLocations>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ItemAddress>.GetEnumerator() { }

		[DebuggerHidden]
		private override ItemAddress System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemAddress>.get_Current() { }

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
	private sealed class <GetComponents>d__1`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable items; //Field offset: 0x0
		public IEnumerable <>3__items; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetComponents>d__1`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private sealed class <GetFirstLevelContainers>d__19 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ContainerCollection rootItem; //Field offset: 0x28
		public ContainerCollection <>3__rootItem; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40

		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.Current
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
		public <GetFirstLevelContainers>d__19(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.IContainer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.get_Current() { }

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
	private sealed class <GetFirstLevelContainersOrSelf>d__18 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IContainer rootContainer; //Field offset: 0x28
		public IContainer <>3__rootContainer; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40

		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.Current
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
		public <GetFirstLevelContainersOrSelf>d__18(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.IContainer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.get_Current() { }

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
	private sealed class <GetFirstLevelItems>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ContainerCollection rootItem; //Field offset: 0x28
		public ContainerCollection <>3__rootItem; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetFirstLevelItems>d__16(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetFirstLevelItemsOrSelf>d__17 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Item rootItem; //Field offset: 0x28
		public Item <>3__rootItem; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetFirstLevelItemsOrSelf>d__17(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

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
	private sealed class <GetTopLevelItemsFromCollection>d__14 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ContainerCollection topLevelCollection; //Field offset: 0x28
		public ContainerCollection <>3__topLevelCollection; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetTopLevelItemsFromCollection>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class SameIdGenerator : IDatabaseIdGenerator
	{
		public static readonly SameIdGenerator Instance; //Field offset: 0x0

		public override MongoID NextId
		{
			 get { } //Length: 78
		}

		private static SameIdGenerator() { }

		private SameIdGenerator() { }

		public override MongoID get_NextId() { }

		public override void RollBack() { }

	}


	[Extension]
	public static bool CheckForLockable(Item item, out LockableComponent lockable) { }

	[Extension]
	public static T CloneBodyItem(T originalItem) { }

	[Extension]
	public static T CloneItem(T originalItem, IDatabaseIdGenerator idGenerator = null) { }

	private static T CloneItemInternal(T originalItem, IDatabaseIdGenerator idGenerator = null, bool skipInvisibleContent = false, bool resetSpawnedInSession = false) { }

	[Extension]
	public static T CloneItemWithSameId(T originalItem) { }

	[Extension]
	public static T CloneVisibleItem(T originalItem) { }

	[Extension]
	public static bool Contains(CompoundItem container, Item item) { }

	[Extension]
	public static void GetAllAssembledItems(Item thisItem, List preAllocatedList) { }

	[Extension]
	public static void GetAllAssembledItemsNonAlloc(Item thisItem, List preAllocatedList) { }

	[Extension]
	public static Token GetAllBundleTokens(Item item) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllItems>d__5))]
	public static IEnumerable GetAllItems(Item topLevelItem, Predicate goInsideItemPredicate, Predicate goInsideContainerPredicate) { }

	[Extension]
	public static IEnumerable GetAllItems(Item topLevelItem, Predicate goDeeperPredicate) { }

	[Extension]
	public static IEnumerable GetAllItems(Item topLevelItem, Predicate goDeeperPredicate) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllItems>d__2))]
	public static IEnumerable GetAllItems(Item topLevelItem) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllItemsFromCollection>d__3))]
	public static IEnumerable GetAllItemsFromCollection(ContainerCollection topLevelCollection) { }

	[Extension]
	public static void GetAllItemsFromCollectionNonAlloc(ContainerCollection topLevelCollection, List preAllocatedList) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllItemsFromCollections>d__8))]
	public static IEnumerable GetAllItemsFromCollections(IEnumerable topLevelCollections) { }

	[Extension]
	public static void GetAllItemsFromCollectionsNonAlloc(IEnumerable topLevelCollections, List preAllocatedList) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllItemsFromGridItemCollectionNonAlloc>d__4))]
	public static IEnumerable GetAllItemsFromGridItemCollectionNonAlloc(GridItemCollection gridItemCollection, List preAllocatedList) { }

	[Extension]
	public static void GetAllItemsNonAlloc(Item thisItem, List preAllocatedList, bool onlyMerged = false, bool includeParent = true) { }

	[Extension]
	public static IEnumerable GetAllParentItems(Item item, bool onlyMerged = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllParentItems>d__34))]
	public static IEnumerable GetAllParentItems(ItemAddress location, bool onlyMerged = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllParentItemsAndSelf>d__35))]
	public static IEnumerable GetAllParentItemsAndSelf(Item item, bool onlyMerged = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllParentLocations>d__32))]
	public static IEnumerable GetAllParentLocations(Item item, bool onlyMerged = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllParentLocations>d__33))]
	public static IEnumerable GetAllParentLocations(ItemAddress location, bool onlyMerged = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetComponents>d__1`1))]
	public static IEnumerable GetComponents(IEnumerable items) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetFirstLevelContainers>d__19))]
	public static IEnumerable GetFirstLevelContainers(ContainerCollection rootItem) { }

	[IteratorStateMachine(typeof(<GetFirstLevelContainersOrSelf>d__18))]
	private static IEnumerable GetFirstLevelContainersOrSelf(IContainer rootContainer) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetFirstLevelItems>d__16))]
	public static IEnumerable GetFirstLevelItems(ContainerCollection rootItem) { }

	[IteratorStateMachine(typeof(<GetFirstLevelItemsOrSelf>d__17))]
	private static IEnumerable GetFirstLevelItemsOrSelf(Item rootItem) { }

	[Extension]
	public static int GetIndexOfItemType(Item i) { }

	[Extension]
	public static IEnumerable GetItemComponentsInChildren(Item thisItem, bool onlyMerged = true) { }

	[Extension]
	public static void GetItemComponentsInChildrenNonAlloc(Item thisItem, List preAllocatedList, bool onlyMerged = true) { }

	[Extension]
	public static IEnumerable GetMergedItemContent(Item thisItem) { }

	[Extension]
	public static IEnumerable GetNotMergedItems(Item thisItem) { }

	[CanBeNull]
	[Extension]
	public static Item GetNotMergedParent(Item item) { }

	[Extension]
	public static IEnumerable GetPrefabPathsWithChildren(Item item) { }

	[Extension]
	public static int GetRandomAnimationVariant(Item item) { }

	[CanBeNull]
	[Extension]
	public static Item GetRootItem(ItemAddress itemAddress) { }

	[Extension]
	public static Item GetRootItem(Item item) { }

	[Extension]
	public static Item GetRootMergedItem(Item item) { }

	[Extension]
	public static string GetSingleItemWeightString(Item item) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetTopLevelItemsFromCollection>d__14))]
	public static IEnumerable GetTopLevelItemsFromCollection(ContainerCollection topLevelCollection) { }

	[Extension]
	public static string GetTruncatedWeightString(Item item) { }

	[Extension]
	public static bool IncompatibleByMalfunction(Weapon weapon, Item mod) { }

	[Extension]
	public static bool IsChildOf(Item item, Item possibleParent) { }

	[Extension]
	public static bool IsChildOf(ItemAddress itemAddress, Item rootItem, bool notMergedWithThisItem = false) { }

	[Extension]
	public static bool IsEmpty(Item item) { }

	[Extension]
	public static bool IsEquipmentAddress(Inventory inventory, ItemAddress to, out InventoryEquipment parentEquipment) { }

	[Extension]
	public static bool IsNotEmpty(Item item) { }

	private static bool IsUnderbarrelPayload(Item mod, Weapon weapon) { }

	[Extension]
	public static bool ParentRecursiveCheck(Item item, Item containerItem) { }

	[Extension]
	public static bool TryGetRootMergedItem(ItemAddress address, out Item item) { }

}

