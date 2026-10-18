namespace EFT.Hideout;

public sealed class HideoutCamera : MonoBehaviour, IDisposable
{
	private const int TP_CAMERA_PRIORITY = 10; //Field offset: 0x0
	private const float ZOOM_TIME = 0.5; //Field offset: 0x0
	private const float MAX_ZOOM = 10; //Field offset: 0x0
	public static bool NegativeDirection; //Field offset: 0x0
	[SerializeField]
	private CinemachineVirtualCamera _virtualCamera; //Field offset: 0x20
	[SerializeField]
	private RailCameraMoveSettings _railCameraMoveSettings; //Field offset: 0x28
	[SerializeField]
	private FreeSpaceCameraMoveSettings _freeSpaceCameraMoveSettings; //Field offset: 0x30
	private float _defaultFOV; //Field offset: 0x38
	private float _currentFOV; //Field offset: 0x3C
	private ECameraMoveType _cameraMoveType; //Field offset: 0x40
	private ICameraMover _cameraMover; //Field offset: 0x48

	private float FieldOfView
	{
		private get { } //Length: 31
		private set { } //Length: 93
	}

	public Transform Transform
	{
		 get { } //Length: 90
	}

	public HideoutCamera() { }

	[CompilerGenerated]
	private float <Zoom>b__18_0() { }

	[CompilerGenerated]
	private void <Zoom>b__18_1(float x) { }

	private void Awake() { }

	public override void Dispose() { }

	private float get_FieldOfView() { }

	public Transform get_Transform() { }

	public void Move(Vector3 direction) { }

	private void set_FieldOfView(float value) { }

	public void SetCameraActive(bool value) { }

	public void SetPosition(object position) { }

	public void Show(ECameraMoveType cameraMoveType) { }

	public void SuppressEdgePan() { }

	public void Tick(bool panByScreenEdge) { }

	public void Zoom(Nullable zoom) { }

}

