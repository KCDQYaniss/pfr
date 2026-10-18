namespace EFT.InventoryLogic;

public class ArmorPlate : ArmoredEquipment
{
	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__6 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public ArmorPlate <>4__this; //Field offset: 0x20
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
		public <get_ItemInteractionButtons>d__6(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <GetSuitableArmorHolders>d__1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArmorHolderComponent <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private CompoundItem[] collections; //Field offset: 0x28
		public CompoundItem[] <>3__collections; //Field offset: 0x30
		public ArmorPlate <>4__this; //Field offset: 0x38
		private Enumerator <>7__wrap1; //Field offset: 0x40

		private override ArmorHolderComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ArmorHolderComponent>.Current
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
		public <GetSuitableArmorHolders>d__1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ArmorHolderComponent>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArmorHolderComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ArmorHolderComponent>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static List _preAllocatedList; //Field offset: 0x0

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__6))]
		 get { } //Length: 175
	}

	public virtual ResourceKey Prefab
	{
		 get { } //Length: 476
	}

	private static ArmorPlate() { }

	public ArmorPlate(string id, ArmoredEquipmentTemplate template) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__6))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	public virtual ResourceKey get_Prefab() { }

	[IteratorStateMachine(typeof(<GetSuitableArmorHolders>d__1))]
	public IEnumerable GetSuitableArmorHolders(CompoundItem[] collections) { }

}

