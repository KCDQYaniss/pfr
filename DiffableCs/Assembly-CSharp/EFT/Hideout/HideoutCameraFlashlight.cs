namespace EFT.Hideout;

public sealed class HideoutCameraFlashlight : MonoBehaviour
{
	internal struct TransitionSettings
	{
		public float TransitionTime; //Field offset: 0x0
		public Ease TransitionType; //Field offset: 0x4

	}

	[SerializeField]
	private Light _flashlight; //Field offset: 0x20
	[SerializeField]
	private TransitionSettings _turnOnTransition; //Field offset: 0x28
	[SerializeField]
	private TransitionSettings _turnOffTransition; //Field offset: 0x30
	[SerializeField]
	private bool _startsActivated; //Field offset: 0x38
	private bool _flashlightState; //Field offset: 0x39
	private float _flashlightIntensity; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x40

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HideoutCameraFlashlight() { }

	private void Awake() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	public void SetState(bool active) { }

}

