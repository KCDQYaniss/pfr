//Type is in global namespace

public sealed class SeasonsMaterialsGrassInitialization : MonoBehaviour, ISeasonsMaterial
{
	private ESeason _season; //Field offset: 0x20
	public GrassInitialization GrassInitialization; //Field offset: 0x28

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsGrassInitialization() { }

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

}

