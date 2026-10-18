namespace EFT.UI.Map;

public class MapPointsManager : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SelectPoint>b__15_0(ExtractionPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public EntryPoint entryPoint; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <EntryPointExtractions>b__0(ExtractionPoint extraction) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public ExtractionPoint exfil; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <EligibleEntryPoints>b__0(KeyValuePair x) { }

	}

	[SerializeField]
	private SimplePocketMap _pocketMap; //Field offset: 0x70
	[SerializeField]
	private SelectEntryPointPanel _entryPointPanel; //Field offset: 0x78
	[SerializeField]
	private EntryPointView _entryPointTemplate; //Field offset: 0x80
	[SerializeField]
	private ExtractionPointView _extractionPointTemplate; //Field offset: 0x88
	[SerializeField]
	private bool _editPointPositions; //Field offset: 0x90
	private bool _allowSelection; //Field offset: 0x91
	private MapPoints _pointsConfig; //Field offset: 0x98
	private readonly Dictionary _entryPoints; //Field offset: 0xA0
	private readonly List _extractionPoints; //Field offset: 0xA8

	public MapPointsManager() { }

	[CompilerGenerated]
	private void <CreateEntryMapPoint>b__10_0(EntryPoint arg) { }

	[CompilerGenerated]
	private void <CreateEntryMapPoint>b__10_1(EntryPoint arg) { }

	private void Clear() { }

	public virtual void Close() { }

	private void CreateEntryMapPoint(EntryPoint entryPoint) { }

	private void CreateExtractionMapPoint(ExtractionPoint extractionPoint) { }

	private int EligibleEntryPoints(ExtractionPoint exfil) { }

	private IEnumerable EntryPointExtractions(EntryPoint entryPoint) { }

	public void Load() { }

	private void OnEntryPointDisable(EntryPoint entryPoint) { }

	public void SelectPoint(EntryPoint entryPoint) { }

	public void Show(bool allowSelection, MapPoints mapPoints) { }

}

