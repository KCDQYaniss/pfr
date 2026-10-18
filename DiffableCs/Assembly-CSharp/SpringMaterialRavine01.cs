//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SpringMaterialRavine01")]
[Obfuscation(Exclude = True)]
public sealed class SpringMaterialRavine01 : ScriptableObject, ISpringMaterial, ISeasonMaterial
{
	private static readonly int _base; //Field offset: 0x0
	private static readonly int _gloss; //Field offset: 0x4
	private static readonly int _normal; //Field offset: 0x8
	public Material Material; //Field offset: 0x18
	public Texture Base; //Field offset: 0x20
	public Texture Gloss; //Field offset: 0x28
	public Texture Normal; //Field offset: 0x30

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static SpringMaterialRavine01() { }

	public SpringMaterialRavine01() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

