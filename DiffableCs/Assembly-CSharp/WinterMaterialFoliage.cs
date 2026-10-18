//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/WinterMaterialFoliage")]
[Obfuscation(Exclude = True)]
public sealed class WinterMaterialFoliage : ScriptableObject, IWinterMaterial, ISeasonMaterial
{
	private static readonly int _mainTexArray; //Field offset: 0x0
	private static readonly int _normalMapArray; //Field offset: 0x4
	private static readonly int _dryColor; //Field offset: 0x8
	private static readonly int _healthyColor; //Field offset: 0xC
	private static readonly int _windWaveTintColor; //Field offset: 0x10
	public Material Material; //Field offset: 0x18
	public Texture2DArray MainTexArray; //Field offset: 0x20
	public Texture2DArray NormalMapArray; //Field offset: 0x28
	public Color DryColor; //Field offset: 0x30
	public Color HealthyColor; //Field offset: 0x40
	public Color WindWaveTintColor; //Field offset: 0x50

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static WinterMaterialFoliage() { }

	public WinterMaterialFoliage() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

