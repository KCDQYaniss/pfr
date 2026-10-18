namespace EFT.CameraControl;

public class OpticRetrice : MonoBehaviour
{
	private static readonly int NonJitteredProjId; //Field offset: 0x0
	private const float SCALE_DECREASE_RATIO = 0.1; //Field offset: 0x0
	private static readonly int ScaleId; //Field offset: 0x4
	private CommandBuffer _commandBuffer; //Field offset: 0x20
	private Camera _camera; //Field offset: 0x28
	private Material _material; //Field offset: 0x30
	private float _scale; //Field offset: 0x38
	private bool _canUpdate; //Field offset: 0x3C
	[SerializeField]
	private SkinnedMeshRenderer _renderer; //Field offset: 0x40
	[SerializeField]
	private CameraEvent _cameraEvent; //Field offset: 0x48

	public bool CanUpdate
	{
		 get { } //Length: 5
	}

	public SkinnedMeshRenderer Renderer
	{
		 get { } //Length: 5
	}

	private static OpticRetrice() { }

	public OpticRetrice() { }

	private void Awake() { }

	public void Clear() { }

	public bool get_CanUpdate() { }

	public SkinnedMeshRenderer get_Renderer() { }

	private void Initialize() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnPreCull() { }

	public void SetOpticSight(OpticSight opticSight) { }

	public void UpdateTransform(OpticSight opticSight) { }

}

