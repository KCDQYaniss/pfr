//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class FakeCharacterGI : MonoBehaviour
{
	private static readonly int _inverseView; //Field offset: 0x0
	private static readonly int _giColor; //Field offset: 0x4
	private static readonly int _giDirection; //Field offset: 0x8
	private static readonly int _giPower; //Field offset: 0xC
	private static readonly int _skylightColor; //Field offset: 0x10
	private static readonly int _skylightDirection; //Field offset: 0x14
	private static readonly int _skylightPower; //Field offset: 0x18
	public Shader FakeCharacterGIShader; //Field offset: 0x20
	public Color GIColor; //Field offset: 0x28
	public Vector3 GIDirection; //Field offset: 0x38
	public float GIPower; //Field offset: 0x44
	public Color SkylightColor; //Field offset: 0x48
	public Vector3 SkylightDirection; //Field offset: 0x58
	public float SkylightPower; //Field offset: 0x64
	private Material _material; //Field offset: 0x68
	private Camera _camera; //Field offset: 0x70

	private static FakeCharacterGI() { }

	public FakeCharacterGI() { }

	private void Awake() { }

	private Material GetMaterial() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

	private void OnValidate() { }

	private void SetDefaultValues() { }

}

