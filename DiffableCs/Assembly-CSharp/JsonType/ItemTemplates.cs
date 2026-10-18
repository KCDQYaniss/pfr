namespace JsonType;

public class ItemTemplates : Dictionary
{
	[CompilerGenerated]
	private sealed class <GetAllCompatibleTemplates>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ItemTemplate <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable parentTemplates; //Field offset: 0x28
		public IEnumerable <>3__parentTemplates; //Field offset: 0x30
		private Dictionary allChildrenDict; //Field offset: 0x38
		public Dictionary <>3__allChildrenDict; //Field offset: 0x40
		private Stack <templatesStack>5__2; //Field offset: 0x48
		private HashSet <visitedTemplates>5__3; //Field offset: 0x50
		private ItemTemplate <current>5__4; //Field offset: 0x58

		private override ItemTemplate System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemTemplate>.Current
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
		public <GetAllCompatibleTemplates>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ItemTemplate>.GetEnumerator() { }

		[DebuggerHidden]
		private override ItemTemplate System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemTemplate>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private Dictionary _typesDictionary; //Field offset: 0x50

	public ItemTemplates() { }

	private bool CheckForFilter(CompoundItemTemplate template, MongoID key) { }

	private static IEnumerable GetAllChildTemplateIds(ItemTemplate template, IDictionary allChildrenDict) { }

	[IteratorStateMachine(typeof(<GetAllCompatibleTemplates>d__5))]
	public static IEnumerable GetAllCompatibleTemplates(IEnumerable parentTemplates, Dictionary allChildrenDict) { }

	private static IEnumerable GetFirstLevelCompatibleTemplates(CompoundItemTemplate parentTemplate, Dictionary allChildrenDict) { }

	public static ResourceType GetResourceType(ItemTemplate template, ResourceKey resource) { }

	public ResourceTypeInfo GetResourceTypeByBundlePath(string bundlePath) { }

	public void Init() { }

}

