//Type is in global namespace

public class BasePlayerCulling : IDisposable
{
	private class CullingStateToggle : IDisposable
	{
		private const float TOGGLE_DEBOUNCE_TIME = 2.5; //Field offset: 0x0
		private readonly float _cullingDistanceSqrt; //Field offset: 0x10
		private bool _isVisibleByCulling; //Field offset: 0x14
		private bool _isVisibleByBallistics; //Field offset: 0x15
		private float _stateChangeTime; //Field offset: 0x18
		private bool _state; //Field offset: 0x1C
		private ObservedCullingObject _cullingObject; //Field offset: 0x20
		public Action OnChange; //Field offset: 0x28

		public bool State
		{
			 get { } //Length: 5
		}

		public CullingStateToggle(ObservedCullingObject cullingObject, float cullingDistanceSqrt) { }

		private static float AngleFromToPoint(Vector3 fromPoint, Vector3 toPoint, Vector3 zeroDirection) { }

		private bool CheckBallistic(IBallisticsCalculator ballisticsCalculator) { }

		private void CheckBallisticState() { }

		public override void Dispose() { }

		public bool get_State() { }

		public void ManualUpdate() { }

		private void OnVisibilityChanged(bool isVisible) { }

	}

	internal enum EMode
	{
		Disabled = 0,
		Hidden = 1,
		Visible = 2,
		Auto = 3,
	}

	private ObservedCullingObject _cullingObject; //Field offset: 0x10
	private CullingStateToggle _cullingStateToggle; //Field offset: 0x18
	protected readonly List _renderersCache; //Field offset: 0x20
	private EMode _mode; //Field offset: 0x28

	public bool IsCloseToMyPlayerCamera
	{
		 get { } //Length: 35
	}

	public bool IsVisible
	{
		 get { } //Length: 59
	}

	public EMode Mode
	{
		 get { } //Length: 4
	}

	public BasePlayerCulling() { }

	protected override void ApplyVisibleState() { }

	public void Disable() { }

	public void DisableCullingOnDead() { }

	public override void Dispose() { }

	public void Enable() { }

	public bool get_IsCloseToMyPlayerCamera() { }

	public bool get_IsVisible() { }

	public EMode get_Mode() { }

	public void Hide() { }

	protected void Initialize(PlayerBones playerBones) { }

	public void ManualUpdate(float dt) { }

	private void OnStateChanged(bool state) { }

	public override bool SetMode(EMode mode) { }

}

