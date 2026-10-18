//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class WaterController : MonoBehaviour
{
	private static readonly int _baseColor; //Field offset: 0x0
	private static readonly int _worldLightDir; //Field offset: 0x4
	private static readonly int _specularColor; //Field offset: 0x8
	private static readonly int _shininess; //Field offset: 0xC
	public Color WaterColor; //Field offset: 0x20
	public Color SpecularColor; //Field offset: 0x30
	[Range(0, 500)]
	public float Shininess; //Field offset: 0x40
	private WaterBase _waterBase; //Field offset: 0x48

	private static WaterController() { }

	public WaterController() { }

	private void Update() { }

}

