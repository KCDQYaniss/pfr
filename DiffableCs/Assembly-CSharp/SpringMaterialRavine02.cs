//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SpringMaterialRavine02")]
[Obfuscation(Exclude = True)]
public sealed class SpringMaterialRavine02 : ScriptableObject, ISpringMaterial, ISeasonMaterial
{
	private static readonly int _base; //Field offset: 0x0
	private static readonly int _gloss; //Field offset: 0x4
	private static readonly int _normal; //Field offset: 0x8
	private static readonly int _top; //Field offset: 0xC
	private static readonly int _topNormal; //Field offset: 0x10
	private static readonly int _topColor; //Field offset: 0x14
	public Material Material; //Field offset: 0x18
	public Texture Base; //Field offset: 0x20
	public Texture Gloss; //Field offset: 0x28
	public Texture Normal; //Field offset: 0x30
	public Texture Top; //Field offset: 0x38
	public Texture TopNormal; //Field offset: 0x40
	public Color TopColor; //Field offset: 0x48

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static SpringMaterialRavine02() { }

	public SpringMaterialRavine02() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

