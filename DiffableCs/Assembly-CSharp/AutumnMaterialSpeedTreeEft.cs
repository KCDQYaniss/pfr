//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/AutumnMaterialSpeedTreeEft")]
[Obfuscation(Exclude = True)]
public sealed class AutumnMaterialSpeedTreeEft : ScriptableObject, IAutumnMaterial, ISeasonMaterial
{
	private static readonly int _base; //Field offset: 0x0
	private const string HUE_VARIATION_EFFECT = "EFFECT_HUE_VARIATION"; //Field offset: 0x0
	private static readonly int _normalMap; //Field offset: 0x4
	private static readonly int _detail; //Field offset: 0x8
	private static readonly int _hueVariation; //Field offset: 0xC
	private static readonly int _color; //Field offset: 0x10
	public Material Material; //Field offset: 0x18
	public Texture Base; //Field offset: 0x20
	public Texture NormalMap; //Field offset: 0x28
	public Texture Detail; //Field offset: 0x30
	public Color Color; //Field offset: 0x38
	public EHueVariationEnabledState HueVariationEnabledState; //Field offset: 0x48
	public Color HueVariation; //Field offset: 0x4C

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static AutumnMaterialSpeedTreeEft() { }

	public AutumnMaterialSpeedTreeEft() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

