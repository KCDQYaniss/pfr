namespace EFT.InventoryLogic;

public sealed class UnknownItem : Item, IItemInfoContainer
{
	private sealed class UnknownItemTemplate : ItemTemplate
	{
		[CompilerGenerated]
		private sealed class <get_AllResources>d__1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private ResourceKey <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20

			private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.Current
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
			public <get_AllResources>d__1(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<EFT.ResourceKey>.GetEnumerator() { }

			[DebuggerHidden]
			private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}


		public virtual IEnumerable AllResources
		{
			[IteratorStateMachine(typeof(<get_AllResources>d__1))]
			 get { } //Length: 80
		}

		public UnknownItemTemplate() { }

		[IteratorStateMachine(typeof(<get_AllResources>d__1))]
		public virtual IEnumerable get_AllResources() { }

	}

	private static readonly UnknownItemTemplate _unknownTemplate; //Field offset: 0x0
	private ItemInfo _itemInfo; //Field offset: 0x78

	public virtual int Height
	{
		 get { } //Length: 26
	}

	public virtual ResourceKey Prefab
	{
		 get { } //Length: 83
	}

	public virtual float TotalWeight
	{
		 get { } //Length: 28
	}

	protected virtual float Weight
	{
		 get { } //Length: 28
	}

	public virtual int Width
	{
		 get { } //Length: 26
	}

	private static UnknownItem() { }

	public UnknownItem(ItemInfo info) { }

	private override void EFT.IItemInfoContainer.SetItemInfo(ItemInfo itemInfo) { }

	public virtual int get_Height() { }

	public virtual ResourceKey get_Prefab() { }

	public virtual float get_TotalWeight() { }

	protected virtual float get_Weight() { }

	public virtual int get_Width() { }

	public virtual int GetHashSum() { }

	public virtual ItemInfo GetInfo() { }

}

