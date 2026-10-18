//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/WinterMaterialBD2S")]
[Obfuscation(Exclude = True)]
public class WinterMaterialBD2S : ScriptableObject, IWinterMaterial, ISeasonMaterial
{
	private static readonly int _mainTex; //Field offset: 0x0
	private static readonly int _bumpMap; //Field offset: 0x4
	private static readonly int _color; //Field offset: 0x8
	public Material Material; //Field offset: 0x18
	public Texture MainTex; //Field offset: 0x20
	public Texture BumpMap; //Field offset: 0x28
	public Color Color; //Field offset: 0x30

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static WinterMaterialBD2S() { }

	public WinterMaterialBD2S() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

