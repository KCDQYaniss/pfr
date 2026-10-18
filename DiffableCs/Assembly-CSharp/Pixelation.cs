//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Pixelation : MonoBehaviour
{
	internal enum PixelationMode
	{
		Point = 0,
		CRT = 1,
		None = 10,
	}

	private static readonly int _pixelBlockCount; //Field offset: 0x0
	private static readonly int _pixelBlockSize; //Field offset: 0x4
	private static readonly int _mask; //Field offset: 0x8
	private static readonly int _alpha1; //Field offset: 0xC
	public bool On; //Field offset: 0x20
	public PixelationMode Mode; //Field offset: 0x24
	[SerializeField]
	private Shader _pixelationShader; //Field offset: 0x28
	[Range(2, 2048)]
	[SerializeField]
	private float _blockCount; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _alpha; //Field offset: 0x34
	[SerializeField]
	private Texture _pixelationMask; //Field offset: 0x38
	private Camera _camera; //Field offset: 0x40
	private Material _material; //Field offset: 0x48

	private static Pixelation() { }

	public Pixelation() { }

	private void Awake() { }

	private Material GetMaterial() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destanation) { }

	private void SetMaterialProperties() { }

}

