//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsMaterialsGrass")]
[Obfuscation(Exclude = True)]
public class SeasonsMaterialsGrass : ScriptableObject, ISeasonsMaterial
{
	public GPUInstancerDetailPrototype Prototype; //Field offset: 0x18
	public SeasonsGrass SeasonsGrass; //Field offset: 0x20

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsGrass() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	public override Task LoadAutumn() { }

	public override Task LoadAutumnLate() { }

	public override Task LoadSpring() { }

	public override Task LoadSpringEarly() { }

	public override Task LoadSummer() { }

	public override Task LoadWinter() { }

	public override void Unload() { }

}

