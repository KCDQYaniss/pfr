namespace EFT.CameraControl;

public class PlayerCameraController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CameraStateFactoryDelegate <>9__48_0; //Field offset: 0x8
		public static CameraStateFactoryDelegate <>9__48_1; //Field offset: 0x10
		public static CameraStateFactoryDelegate <>9__48_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal CameraState <GetOperationFactoryDelegates>b__48_0(PlayerCameraController playerCamera) { }

		internal CameraState <GetOperationFactoryDelegates>b__48_1(PlayerCameraController playerCamera) { }

		internal CameraState <GetOperationFactoryDelegates>b__48_2(PlayerCameraController playerCamera) { }

	}

	private sealed class CameraStateFactoryDelegate : MulticastDelegate
	{

		public CameraStateFactoryDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PlayerCameraController playerCameraController, AsyncCallback callback, object object) { }

		public override CameraState EndInvoke(IAsyncResult result) { }

		public override CameraState Invoke(PlayerCameraController playerCameraController) { }

	}

	[CompilerGenerated]
	private static Action OnPlayerCameraControllerCreated; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnPlayerCameraControllerDestroyed; //Field offset: 0x8
	[SerializeField]
	private EUpdateQueue _playerUpdateQueue; //Field offset: 0x20
	[CompilerGenerated]
	private Player <Player>k__BackingField; //Field offset: 0x28
	public bool ExternalControl; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsInSpectatorCamera>k__BackingField; //Field offset: 0x31
	private CameraState _currentCameraState; //Field offset: 0x38
	private readonly Dictionary _internalState; //Field offset: 0x40
	private Dictionary _operationFactory; //Field offset: 0x48
	private VisorEffect _visorsEffect; //Field offset: 0x50
	private NightVisionZBlur _nightVisionZBlur; //Field offset: 0x58
	private Action _pointOfViewUnsubscribe; //Field offset: 0x60
	private bool _onFaceShieldChangedIsLive; //Field offset: 0x68
	private Action _nightVisionSubscription; //Field offset: 0x70
	private Action _thermalVisionSubscription; //Field offset: 0x78
	private Action _faceShieldSubscription; //Field offset: 0x80
	private Action _faceCoverShieldSubscription; //Field offset: 0x88
	private Action _faceCoverMaskSubscription; //Field offset: 0x90
	private HysteresisFilter _visorsSwitcher; //Field offset: 0x98

	public static event Action OnPlayerCameraControllerCreated
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public static event Action OnPlayerCameraControllerDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 269
		[CompilerGenerated]
		 remove { } //Length: 269
	}

	public Camera Camera
	{
		 get { } //Length: 84
	}

	private CameraManager CameraManager
	{
		private get { } //Length: 69
	}

	public bool IsInSpectatorCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private bool IsSpectatorCameraActive
	{
		private get { } //Length: 122
	}

	public private Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PlayerCameraController() { }

	[CompilerGenerated]
	public static void add_OnPlayerCameraControllerCreated(Action value) { }

	[CompilerGenerated]
	public static void add_OnPlayerCameraControllerDestroyed(Action value) { }

	private PlayerCameraController Construct(Player player) { }

	public static PlayerCameraController Create(Player player) { }

	public static void Destroy(Player player) { }

	public void EnterSpectatorMode(ObservedPlayerView target) { }

	private void FixedUpdate() { }

	public Camera get_Camera() { }

	private CameraManager get_CameraManager() { }

	[CompilerGenerated]
	public bool get_IsInSpectatorCamera() { }

	private bool get_IsSpectatorCameraActive() { }

	[CompilerGenerated]
	public Player get_Player() { }

	private Dictionary GetOperationFactoryDelegates() { }

	public void InitiateOperation() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnFaceCoverMaskChanged() { }

	private void OnFaceCoverShieldChanged() { }

	private void OnFaceShieldChanged() { }

	private void OnFaceShieldComponentChanged(FaceShieldComponent faceShield) { }

	private void OnNightVisionChanged() { }

	private void OnThermalVisionChanged() { }

	[CompilerGenerated]
	public static void remove_OnPlayerCameraControllerCreated(Action value) { }

	[CompilerGenerated]
	public static void remove_OnPlayerCameraControllerDestroyed(Action value) { }

	[CompilerGenerated]
	public void set_IsInSpectatorCamera(bool value) { }

	[CompilerGenerated]
	private void set_Player(Player value) { }

	public void SetSpectatingTarget(ObservedPlayerView target) { }

	private void Update() { }

	public void UpdatePointOfView() { }

}

