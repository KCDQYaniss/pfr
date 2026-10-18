//Type is in global namespace

public class BotCoverBounds : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetBoundsExclude>b__8_0(BotCoverBounds x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public bool wall; //Field offset: 0x10
		public bool foliage; //Field offset: 0x11
		public bool snipe; //Field offset: 0x12

		public <>c__DisplayClass9_0() { }

		internal bool <GetBounds>b__0(BotCoverBounds x) { }

	}

	public BoxCollider Collider; //Field offset: 0x20
	public bool WallCovers; //Field offset: 0x28
	public bool FoliageCovers; //Field offset: 0x29
	public bool SnipeCovers; //Field offset: 0x2A
	public bool ExcludeCovers; //Field offset: 0x2B
	public int Id; //Field offset: 0x2C

	public BotCoverBounds() { }

	public static void DisableAllCoilliders() { }

	public static List GetAllBounds() { }

	public static List GetBounds(bool wall, bool foliage, bool snipe) { }

	public static List GetBoundsAsColliders(bool wall, bool foliage, bool snipe) { }

	public static List GetBoundsExclude() { }

}

