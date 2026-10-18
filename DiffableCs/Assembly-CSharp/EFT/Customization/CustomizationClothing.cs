namespace EFT.Customization;

public class CustomizationClothing : BaseCustomizationItem
{
	[CompilerGenerated]
	private sealed class <get_AllResources>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ResourceKey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CustomizationClothing <>4__this; //Field offset: 0x28

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
		public <get_AllResources>d__9(int <>1__state) { }

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

	public EBodyModelPart BodyPart; //Field offset: 0x58
	public ResourceKey Prefab; //Field offset: 0x60
	public ResourceKey WatchPrefab; //Field offset: 0x68
	public Vector3 WatchPosition; //Field offset: 0x70
	public Vector3 WatchRotation; //Field offset: 0x7C
	public bool IntegratedArmorVest; //Field offset: 0x88

	public IEnumerable AllResources
	{
		[IteratorStateMachine(typeof(<get_AllResources>d__9))]
		 get { } //Length: 175
	}

	public virtual ECustomizationItemCategory Category
	{
		 get { } //Length: 6
	}

	public CustomizationClothing() { }

	[IteratorStateMachine(typeof(<get_AllResources>d__9))]
	public IEnumerable get_AllResources() { }

	public virtual ECustomizationItemCategory get_Category() { }

	public virtual string ToString() { }

}

