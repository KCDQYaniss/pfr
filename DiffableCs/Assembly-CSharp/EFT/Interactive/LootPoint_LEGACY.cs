namespace EFT.Interactive;

public sealed class LootPoint_LEGACY : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal WeightedLootPointSpawnPosition <AsLootPointParameters>b__7_0(WeightedSpawnPosition x) { }

	}

	internal sealed class WeightedSpawnPosition
	{
		public Transform Transform; //Field offset: 0x10
		public float Weight; //Field offset: 0x18

		public WeightedSpawnPosition() { }

	}

	[SerializeField]
	private List _groupPositions; //Field offset: 0x20
	public LootPointParameters Settings; //Field offset: 0x28

	public List GroupPositions
	{
		 get { } //Length: 5
	}

	public LootPoint_LEGACY() { }

	public LootPointParameters AsLootPointParameters() { }

	public void Convert() { }

	public List get_GroupPositions() { }

	private void OnValidate() { }

}

