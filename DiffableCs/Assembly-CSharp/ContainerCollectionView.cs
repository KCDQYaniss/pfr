//Type is in global namespace

public class ContainerCollectionView : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__12_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetViewForSlot>b__10_0(IContainer x) { }

		internal string <LogEverything>b__12_0(IContainer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__11`1
	{
		public static readonly <>c__11 <>9; //Field offset: 0x0
		public static Func <>9__11_1; //Field offset: 0x0

		private static <>c__11`1() { }

		public <>c__11`1() { }

		internal SlotView <GetBonesWhereSlot>b__11_1(KeyValuePair pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0`1
	{
		public Func whereFunc; //Field offset: 0x0

		public <>c__DisplayClass11_0`1() { }

		internal bool <GetBonesWhereSlot>b__0(KeyValuePair pair) { }

	}

	internal class SlotView
	{
		public Transform Bone; //Field offset: 0x10
		public Item Item; //Field offset: 0x18
		public Transform ItemView; //Field offset: 0x20

		public SlotView() { }

		public void InsertItem(Item item, GameObject itemView) { }

		public void RemoveItem() { }

	}

	public readonly Dictionary ContainerBones; //Field offset: 0x10
	private AssetPoolObject _poolObject; //Field offset: 0x18
	public GameObject GameObject; //Field offset: 0x20

	public ContainerCollectionView(AssetPoolObject poolObject, GameObject gameObject) { }

	public void AddBone(IContainer container, Transform bone) { }

	public void AddChildBones(Transform childRoot) { }

	public override void Dispose() { }

	public Transform GetBoneForSlot(IContainer container) { }

	public IEnumerable GetBonesWhereSlot(Func whereFunc) { }

	[CanBeNull]
	public SlotView GetViewForSlot(IContainer container) { }

	public void LogEverything() { }

	public void RemoveBone(IContainer container) { }

	public void RemoveBones(IEnumerable containers) { }

}

