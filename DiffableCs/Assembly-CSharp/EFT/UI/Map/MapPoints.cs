namespace EFT.UI.Map;

public class MapPoints : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <FillEligablePoints>b__5_1(EntryPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ExfiltrationPoint point; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <FillEligablePoints>b__0(EntryPoint x) { }

	}

	private const string MapPointPath = "MapPointConfigs/"; //Field offset: 0x0
	private static readonly Dictionary Map; //Field offset: 0x0
	public List EntryPoints; //Field offset: 0x18
	public List ExtractionPoints; //Field offset: 0x20

	private static MapPoints() { }

	public MapPoints() { }

	public static void FillEligablePoints(ExfiltrationPoint point, string locationId) { }

	public static MapPoints Load(string locationId) { }

}

