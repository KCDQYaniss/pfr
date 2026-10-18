//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsMaterialsGroup")]
[Obfuscation(Exclude = True)]
public sealed class SeasonsMaterialsGroup : SerializedScriptableObject, ISeasonsMaterial
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__5_0; //Field offset: 0x10
		public static Func <>9__6_0; //Field offset: 0x18
		public static Func <>9__7_0; //Field offset: 0x20
		public static Func <>9__8_0; //Field offset: 0x28
		public static Func <>9__9_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal Task <LoadAutumn>b__8_0(ISeasonsMaterial material) { }

		internal Task <LoadAutumnLate>b__9_0(ISeasonsMaterial material) { }

		internal Task <LoadSpring>b__6_0(ISeasonsMaterial material) { }

		internal Task <LoadSpringEarly>b__7_0(ISeasonsMaterial material) { }

		internal Task <LoadSummer>b__4_0(ISeasonsMaterial material) { }

		internal Task <LoadWinter>b__5_0(ISeasonsMaterial material) { }

	}

	public List Materials; //Field offset: 0x58

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsGroup() { }

	public static SeasonsMaterialsGroup Create(string name) { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	public Task Load(Func load) { }

	public override Task LoadAutumn() { }

	public override Task LoadAutumnLate() { }

	public override Task LoadSpring() { }

	public override Task LoadSpringEarly() { }

	public override Task LoadSummer() { }

	public override Task LoadWinter() { }

	public override void Unload() { }

}

