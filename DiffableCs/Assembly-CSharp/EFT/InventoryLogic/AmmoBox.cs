namespace EFT.InventoryLogic;

public class AmmoBox : ContainerCollection, IAmmoContainer
{
	[CompilerGenerated]
	private sealed class <get_Containers>d__13 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AmmoBox <>4__this; //Field offset: 0x28

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
		public <get_Containers>d__13(int <>1__state) { }

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
	private StackSlot <Cartridges>k__BackingField; //Field offset: 0x78

	public virtual bool CanSellOnRagfair
	{
		 get { } //Length: 92
	}

	public override StackSlot Cartridges
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__13))]
		 get { } //Length: 175
	}

	public override int Count
	{
		 get { } //Length: 29
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 70
	}

	public int MaxCount
	{
		 get { } //Length: 26
	}

	public virtual bool MergesWithChildren
	{
		 get { } //Length: 3
	}

	public AmmoBox(string id, AmmoBoxTemplate template) { }

	public virtual bool Compare(Item item) { }

	public virtual bool get_CanSellOnRagfair() { }

	[CompilerGenerated]
	public override StackSlot get_Cartridges() { }

	[IteratorStateMachine(typeof(<get_Containers>d__13))]
	public virtual IEnumerable get_Containers() { }

	public override int get_Count() { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

	public int get_MaxCount() { }

	public virtual bool get_MergesWithChildren() { }

	public override Ammo GetBulletAtPosition(int index) { }

	public virtual IContainer GetContainer(string containerId) { }

	public virtual int GetHashSum() { }

	[CompilerGenerated]
	protected void set_Cartridges(StackSlot value) { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

	public virtual bool TryFindItem(Func predicate, out Item item) { }

}

