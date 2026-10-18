//Type is in global namespace

public class ShaderDataReplacer : MonoBehaviour
{
	[SerializeField]
	public string _shaderNameToReplaceData; //Field offset: 0x20
	[SerializeField]
	public Cubemap _cubemap; //Field offset: 0x28
	[SerializeField]
	public Color _reflectColor; //Field offset: 0x30
	[Range(0.01, 10)]
	[SerializeField]
	public float _specularness; //Field offset: 0x40
	[Range(0.01, 10)]
	[SerializeField]
	public float _glossness; //Field offset: 0x44

	public ShaderDataReplacer() { }

}

