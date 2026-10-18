//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsMaterialsMap")]
[Obfuscation(Exclude = True)]
public sealed class SeasonsMaterialsMap : ScriptableObject, ISeasonsMaterial
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__4_0; //Field offset: 0x10
		public static Func <>9__5_0; //Field offset: 0x18
		public static Func <>9__6_0; //Field offset: 0x20
		public static Func <>9__7_0; //Field offset: 0x28
		public static Func <>9__8_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal Task <LoadAutumn>b__7_0(ISeasonsMaterial material) { }

		internal Task <LoadAutumnLate>b__8_0(ISeasonsMaterial material) { }

		internal Task <LoadSpring>b__5_0(ISeasonsMaterial material) { }

		internal Task <LoadSpringEarly>b__6_0(ISeasonsMaterial material) { }

		internal Task <LoadSummer>b__3_0(ISeasonsMaterial material) { }

		internal Task <LoadWinter>b__4_0(ISeasonsMaterial material) { }

	}

	public SeasonsMaterialsGroup[] Groups; //Field offset: 0x18

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsMap() { }

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

