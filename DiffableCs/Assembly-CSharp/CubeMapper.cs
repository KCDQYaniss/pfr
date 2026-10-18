//Type is in global namespace

public class CubeMapper : MonoBehaviour
{
	private static readonly int _cube; //Field offset: 0x0
	private static readonly int _reflectColor; //Field offset: 0x4
	private static readonly int _specularness; //Field offset: 0x8
	private static readonly int _glossness; //Field offset: 0xC
	[SerializeField]
	protected string _weaponShaderNameToReplace; //Field offset: 0x20
	protected ShaderDataReplacer _sdr; //Field offset: 0x28

	private static CubeMapper() { }

	public CubeMapper() { }

	protected override void Update() { }

	private void UpdateCubemaps() { }

}

