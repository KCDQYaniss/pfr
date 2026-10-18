//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsMaterial")]
[Obfuscation(Exclude = True)]
public sealed class SeasonsMaterial : SerializedScriptableObject, ISeasonsMaterial
{
	[OdinSerialize]
	private ISummerMaterial _summerMaterial; //Field offset: 0x58
	[OdinSerialize]
	private IAutumnMaterial _autumnMaterial; //Field offset: 0x60
	[OdinSerialize]
	private IAutumnMaterial _autumnLateMaterial; //Field offset: 0x68
	[OdinSerialize]
	private IWinterMaterial _winterMaterial; //Field offset: 0x70
	[OdinSerialize]
	private ISpringMaterial _springMaterial; //Field offset: 0x78
	[OdinSerialize]
	private ISpringMaterial _springEarlyMaterial; //Field offset: 0x80
	private ISeasonMaterial _loadedMaterial; //Field offset: 0x88

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterial() { }

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

