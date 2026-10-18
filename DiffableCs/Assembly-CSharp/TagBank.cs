//Type is in global namespace

public class TagBank : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <OnValidate>b__12_0(SpreadGroup g) { }

	}

	public static int[] Sizes; //Field offset: 0x0
	public EPhraseTrigger Trigger; //Field offset: 0x18
	public SpreadGroup[] SpreadGroups; //Field offset: 0x20
	public TaggedClip[] Clips; //Field offset: 0x28
	public Chain ChainEvent; //Field offset: 0x30
	public int Importance; //Field offset: 0x38
	public float Blocker; //Field offset: 0x3C
	public bool IgnoreTags; //Field offset: 0x40
	private List _excludedClips; //Field offset: 0x48
	private List _clips; //Field offset: 0x50

	private static TagBank() { }

	public TagBank() { }

	public static bool Compare(int mask1, int event) { }

	public static int GetBits(int mask, int offset, int width) { }

	public TaggedClip Match(ETagStatus combat = 7, ETagStatus speakerGroup = 24, ETagStatus targetGroup = 768, ETagStatus health = 15360, ETagStatus side = 224, ETagStatus exUsecBoss = 114688, ETagStatus newFractions = 917504, ETagStatus grenade = 3145728) { }

	public TaggedClip Match(int mask, ETagFilter tagFilter = 0) { }

	public void OnValidate() { }

	private void UpdateClips() { }

}

