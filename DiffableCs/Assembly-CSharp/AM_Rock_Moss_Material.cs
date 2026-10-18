//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/AM_Rock_Moss_Material")]
[Obfuscation(Exclude = True)]
public sealed class AM_Rock_Moss_Material : ScriptableObject, IAutumnMaterial, ISeasonMaterial, ISpringMaterial, IWinterMaterial
{
	private static readonly int _TopAlbedoASmoothness; //Field offset: 0x0
	public Material Material; //Field offset: 0x18
	public Texture Texture; //Field offset: 0x20

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private static AM_Rock_Moss_Material() { }

	public AM_Rock_Moss_Material() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

}

