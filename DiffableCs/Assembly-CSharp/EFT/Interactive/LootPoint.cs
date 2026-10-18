namespace EFT.Interactive;

[DisallowMultipleComponent]
[RequireComponent(typeof(LootPointViewer))]
public sealed class LootPoint : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8
		public static Func <>9__22_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal WeightedLootPointSpawnPosition <AsLootPointParameters>b__22_0(GroupLootPoint position) { }

		internal IEnumerable <get_LootSetFilters>b__21_0(string lootSet) { }

	}

	public LootPointMode Mode; //Field offset: 0x20
	public string Id; //Field offset: 0x28
	public bool Enabled; //Field offset: 0x30
	public bool UseGravity; //Field offset: 0x31
	public bool RandomRotation; //Field offset: 0x32
	public float ChanceModifier; //Field offset: 0x34
	public bool IsAlwaysSpawn; //Field offset: 0x38
	public ELootRarity Rarity; //Field offset: 0x3C
	[SerializeField]
	private List _lootSets; //Field offset: 0x40
	[SerializeField]
	private string[] _filterInclusive; //Field offset: 0x48
	[SerializeField]
	private List _groupPositions; //Field offset: 0x50

	public List GroupPositions
	{
		 get { } //Length: 5
	}

	public bool IsGroupPosition
	{
		 get { } //Length: 69
	}

	private string[] LootSetFilters
	{
		private get { } //Length: 492
	}

	public string[] SelectedFilters
	{
		 get { } //Length: 18
	}

	public LootPoint() { }

	public void AddGroupPoint() { }

	public void AddLootSet(string id) { }

	public void ApplyLootPointParameters(LootPointParameters parameters) { }

	public LootPointParameters AsLootPointParameters() { }

	public void ClearLootSets() { }

	private GroupLootPoint CreateGroupPoint() { }

	public void GenerateGUID() { }

	private string GenerateHumanId() { }

	public List get_GroupPositions() { }

	public bool get_IsGroupPosition() { }

	private string[] get_LootSetFilters() { }

	public string[] get_SelectedFilters() { }

	public bool IsLootSetSelected(string id) { }

	private void OnDrawGizmos() { }

	private void OnValidate() { }

	public void RandomizeRotation() { }

	public void RemoveGroupPoint(GroupLootPoint point) { }

	public void RemoveLootSet(string id) { }

	private void SetDirty() { }

	public void SetSelectedFilters(string[] selectedFilters) { }

}

