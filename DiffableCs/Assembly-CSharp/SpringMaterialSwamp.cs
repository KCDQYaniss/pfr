//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SpringMaterialSwamp")]
[Obfuscation(Exclude = True)]
public sealed class SpringMaterialSwamp : ScriptableObject, ISpringMaterial, ISeasonMaterial
{
	private static readonly int _color0; //Field offset: 0x0
	private static readonly int _mainTex0; //Field offset: 0x4
	private static readonly int _bumpMap0; //Field offset: 0x8
	private static readonly int _color1; //Field offset: 0xC
	private static readonly int _mainTex1; //Field offset: 0x10
	private static readonly int _bumpMap1; //Field offset: 0x14
	private static readonly int _color2; //Field offset: 0x18
	private static readonly int _mainTex2; //Field offset: 0x1C
	private static readonly int _bumpMap2; //Field offset: 0x20
	public Material Material; //Field offset: 0x18
	public Color Color0; //Field offset: 0x20
	public Texture Main0; //Field offset: 0x30
	public Texture BumpMap0; //Field offset: 0x38
	public Color Color1; //Field offset: 0x40
	public Texture Main1; //Field offset: 0x50
	public Texture BumpMap1; //Field offset: 0x58
	public Color Color2; //Field offset: 0x60
	public Texture Main2; //Field offset: 0x70
	public Texture BumpMap2; //Field offset: 0x78

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static SpringMaterialSwamp() { }

	public SpringMaterialSwamp() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

