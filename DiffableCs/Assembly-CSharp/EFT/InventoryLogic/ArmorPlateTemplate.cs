namespace EFT.InventoryLogic;

public class ArmorPlateTemplate : ArmoredEquipmentTemplate
{
	[CompilerGenerated]
	private sealed class <get_AllResources>d__3 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ResourceKey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArmorPlateTemplate <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

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
		public <get_AllResources>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

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

	public ResourceKey Lower75Prefab; //Field offset: 0x1D0
	public ResourceKey Lower40Prefab; //Field offset: 0x1D8

	public virtual IEnumerable AllResources
	{
		[IteratorStateMachine(typeof(<get_AllResources>d__3))]
		 get { } //Length: 175
	}

	public ArmorPlateTemplate() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	[IteratorStateMachine(typeof(<get_AllResources>d__3))]
	public virtual IEnumerable get_AllResources() { }

}

