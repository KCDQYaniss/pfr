namespace AmplifyImpostors;

[CreateAssetMenu(fileName = "New Bake Preset", order = 86)]
public class AmplifyImpostorBakePreset : ScriptableObject
{
	[SerializeField]
	public Shader BakeShader; //Field offset: 0x18
	[SerializeField]
	public Shader RuntimeShader; //Field offset: 0x20
	[SerializeField]
	public PresetPipeline Pipeline; //Field offset: 0x28
	[SerializeField]
	public int AlphaIndex; //Field offset: 0x2C
	[SerializeField]
	public List Output; //Field offset: 0x30

	public AmplifyImpostorBakePreset() { }

}

