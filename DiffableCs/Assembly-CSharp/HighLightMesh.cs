//Type is in global namespace

[ExecuteInEditMode]
public sealed class HighLightMesh : MonoBehaviour
{
	private sealed class Part
	{
		[CanBeNull]
		private readonly Mesh _mesh; //Field offset: 0x10
		private readonly Transform _transform; //Field offset: 0x18
		[CanBeNull]
		private readonly SkinnedMeshRenderer _smr; //Field offset: 0x20

		public Part(Mesh mesh, Transform transform, SkinnedMeshRenderer smr = null) { }

		public void Draw(CommandBuffer cmd, Material mat, int pass) { }

	}

	private static readonly int _color; //Field offset: 0x0
	private static readonly int _offset; //Field offset: 0x4
	private static readonly int _maskRTId; //Field offset: 0x8
	private static readonly int _finalRTId; //Field offset: 0xC
	[SerializeField]
	private Material Mat; //Field offset: 0x20
	public Color Color; //Field offset: 0x28
	public float LineWidth; //Field offset: 0x38
	public bool Always; //Field offset: 0x3C
	public Transform Target; //Field offset: 0x40
	private Transform _lastTarget; //Field offset: 0x48
	private float _lastLineWidth; //Field offset: 0x50
	private Color _lastColor; //Field offset: 0x54
	private Part[] _targetParts; //Field offset: 0x68
	private int _lastWidth; //Field offset: 0x70
	private int _lastHeight; //Field offset: 0x74
	private Camera _camera; //Field offset: 0x78
	private CommandBuffer _cmb; //Field offset: 0x80
	private RenderTexture _maskRT; //Field offset: 0x88

	private static HighLightMesh() { }

	public HighLightMesh() { }

	private void Awake() { }

	private void DrawMeshes(int pass) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void Update() { }

}

