//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/AutumnMaterialSpeedTree8")]
[Obfuscation(Exclude = True)]
public sealed class AutumnMaterialSpeedTree8 : ScriptableObject, IAutumnMaterial, ISeasonMaterial
{
	private static readonly int _mainTex; //Field offset: 0x0
	private const string HUE_VARIATION_EFFECT = "EFFECT_HUE_VARIATION"; //Field offset: 0x0
	private static readonly int _normalMap; //Field offset: 0x4
	private static readonly int _color; //Field offset: 0x8
	private static readonly int _hueVariationColor; //Field offset: 0xC
	public Material Material; //Field offset: 0x18
	public Texture MainTex; //Field offset: 0x20
	public Texture NormalMap; //Field offset: 0x28
	public Color Color; //Field offset: 0x30
	public EHueVariationEnabledState HueVariationEnabledState; //Field offset: 0x40
	public Color HueVariation; //Field offset: 0x44

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static AutumnMaterialSpeedTree8() { }

	public AutumnMaterialSpeedTree8() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	public void Unload() { }

}

