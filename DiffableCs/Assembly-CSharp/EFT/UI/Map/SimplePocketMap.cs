namespace EFT.UI.Map;

[Obfuscation(Exclude = True)]
public class SimplePocketMap : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <LoadConfig>b__22_0(int x, int y) { }

	}

	internal class JsonMapConfig
	{
		public string bundlePath; //Field offset: 0x10
		public int mapSizeX; //Field offset: 0x18
		public int mapSizeY; //Field offset: 0x1C
		public int tileSizeX; //Field offset: 0x20
		public int tileSizeY; //Field offset: 0x24
		public int scaledVariantsCount; //Field offset: 0x28

		public JsonMapConfig() { }

	}

	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x70
	[SerializeField]
	private PocketMapTile _pocketMapTile; //Field offset: 0x78
	[SerializeField]
	private RectTransform _tilesContainer; //Field offset: 0x80
	[SerializeField]
	private GameObject _loader; //Field offset: 0x88
	[CompilerGenerated]
	private bool <Shown>k__BackingField; //Field offset: 0x90
	protected MapComponent Map; //Field offset: 0x98
	protected Vector2 MapSize; //Field offset: 0xA0
	private Vector2 _tileSize; //Field offset: 0xA8
	private string _bundlePath; //Field offset: 0xB0
	private PocketMapConfig _pocketMapConfig; //Field offset: 0xB8
	protected readonly List Tiles; //Field offset: 0xC0
	private readonly List _tileScaleVariants; //Field offset: 0xC8
	private SimpleMapBundleLoader _bundleLoader; //Field offset: 0xD0

	public private bool Shown
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SimplePocketMap() { }

	[CompilerGenerated]
	private void <Awake>b__17_0(Vector2 arg) { }

	protected override void Awake() { }

	private void BundleLoaded(PocketMapConfig config) { }

	protected void CheckTilesForUpdate() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public bool get_Shown() { }

	private void LoadConfig(string configRelativePath) { }

	[CompilerGenerated]
	private void set_Shown(bool value) { }

	public override void Show(MapComponent map) { }

	public void ShowOnPath(string path) { }

	private void UnloadMapBundle() { }

}

