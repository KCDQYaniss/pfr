//Type is in global namespace

internal sealed class SeasonsMaterialsTerrain : SerializedMonoBehaviour, ISeasonsMaterial
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Fix>b__12_0(MicroSplatTerrain terrain) { }

	}

	[SerializeField]
	public MicroSplatTerrain[] _terrains; //Field offset: 0x60

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsTerrain() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	public override Task LoadAutumn() { }

	public override Task LoadAutumnLate() { }

	public override Task LoadSpring() { }

	public override Task LoadSpringEarly() { }

	public override Task LoadSummer() { }

	public override Task LoadWinter() { }

	private void OnDestroy() { }

	private void Start() { }

	public override void Unload() { }

	private static void UpdateCurrentQuality() { }

}

