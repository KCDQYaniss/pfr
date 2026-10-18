namespace EFT.SynchronizableObjects;

public class AirdropSynchronizableObject : SynchronizableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8
		public static Func <>9__17_1; //Field offset: 0x10
		public static Func <>9__17_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal Item <ParseItemData>b__17_0(JsonLootItem x) { }

		internal bool <ParseItemData>b__17_1(Item x) { }

		internal IEnumerable <ParseItemData>b__17_2(Item x) { }

	}

	internal struct AirdropViewData
	{
		public EAirdropViewType ViewType; //Field offset: 0x0
		public GameObject[] EnableGameObjects; //Field offset: 0x8
		public BoxCollider LootContainerCollider; //Field offset: 0x10

	}

	internal enum EAirdropViewType
	{
		Default = 0,
		NewYear = 1,
	}

	public AirdropViewData[] AirdropViews; //Field offset: 0x88
	public EAirdropType AirdropType; //Field offset: 0x90
	public TaggedClip SqueakClip; //Field offset: 0x98
	public TaggedClip FlareSound; //Field offset: 0xA0
	public GameObject AirdropFlare; //Field offset: 0xA8
	public GameObject AirdropDust; //Field offset: 0xB0
	public GameObject Parachute; //Field offset: 0xB8
	public GameObject ParachuteJoint; //Field offset: 0xC0
	public BoxCollider CollisionCollider; //Field offset: 0xC8
	public MeshRenderer[] DecalRenderers; //Field offset: 0xD0
	public Material GunDecal; //Field offset: 0xD8
	public Material MedicineDecal; //Field offset: 0xE0
	public Material SupplyDecal; //Field offset: 0xE8

	public AirdropSynchronizableObject() { }

	public void ApplyAirdropViewType(EAirdropViewType viewType) { }

	public virtual void Deserialize(NetworkReader reader) { }

	private Item ParseItemData(NetworkReader reader) { }

}

