namespace EFT.UI;

public class EnvironmentUIRoot : MonoBehaviour
{
	private struct EnvironmentEventObject
	{
		public EEventType EventType; //Field offset: 0x0
		public GameObject[] GameObjects; //Field offset: 0x8

	}

	public CanvasGroup Shading; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x28
	[SerializeField]
	private EnvironmentCameraMotion _cameraMotion; //Field offset: 0x30
	[SerializeField]
	private Light[] MainScreenLights; //Field offset: 0x38
	[SerializeField]
	private GameObject[] MainScreenObjects; //Field offset: 0x40
	[SerializeField]
	private ScreenPositionAnchor[] ScreenAnchors; //Field offset: 0x48
	[SerializeField]
	private EnvironmentEventObject[] EventObjects; //Field offset: 0x50
	[SerializeField]
	private GameObject _regularLogo; //Field offset: 0x58
	[SerializeField]
	private GameObject _pveLogo; //Field offset: 0x60

	public bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public EnvironmentUIRoot() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	public override void Hide(Action callbackOnHide) { }

	public override void Init(Camera alignmentCamera, IReadOnlyCollection events, bool isMain, EGameMode gameMode) { }

	public void RandomRotate() { }

	public void ResetRotation() { }

	[CompilerGenerated]
	protected void set_IsActive(bool value) { }

	private void SetAlignmentCamera(Camera newCam) { }

	public void SetCameraActive(bool value) { }

	public bool SetEvents(IReadOnlyCollection events) { }

	public void SetGameModeLogo(EGameMode gameMode) { }

	public void SetMain(bool isMain) { }

	public override void Show(Action callbackOnShow) { }

	public override Task WarmupAsync(CancellationToken cancellationToken) { }

}

