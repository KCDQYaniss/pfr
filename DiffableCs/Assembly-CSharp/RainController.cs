//Type is in global namespace

public sealed class RainController : MonoBehaviour
{
	private abstract class AbstractState : IDisposable
	{
		[CompilerGenerated]
		private RainController <Controller>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly ERainControllerStatus <Status>k__BackingField; //Field offset: 0x18

		protected RainController Controller
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		internal ERainControllerStatus Status
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		protected AbstractState(RainController controller, ERainControllerStatus status) { }

		internal override void CameraChanged(CameraManager cameraManager) { }

		internal override void ControlRain(in Vector3 rainDir, float rain, float laingWater, float cloudness, float hour) { }

		internal override void DisableEffect() { }

		public override void Dispose() { }

		[CompilerGenerated]
		protected RainController get_Controller() { }

		[CompilerGenerated]
		internal ERainControllerStatus get_Status() { }

		[CompilerGenerated]
		protected void set_Controller(RainController value) { }

		internal abstract void SetDebugRain(bool debug) { }

		internal override void SetIntensity(float value) { }

		internal override void SetOpaqueness(float opaqueness) { }

		internal override void SetupAutumn() { }

		internal override void SetupAutumnLate() { }

		internal override void SetupSpring() { }

		internal override void SetupSpringEarly(Vector3 springSnowFactor) { }

		internal override void SetupSummer() { }

		internal override void SetupWinter(bool snowWetRendererDisabled) { }

		internal override void SetupWinterStorm() { }

		internal override void SetupWinterStormReconnect() { }

		internal abstract void SetWetting(float wetting, float fogginess, Vector2 mainWind, float t01) { }

		internal override void SetWetting(float wetting) { }

	}

	private abstract class AbstractStateSummer : AbstractState
	{

		protected AbstractStateSummer(RainController controller, ERainControllerStatus status) { }

		internal virtual void CameraChanged(CameraManager cameraManager) { }

		internal virtual void ControlRain(in Vector3 rainDir, float rain, float laingWater, float cloudness, float hour) { }

		internal virtual void DisableEffect() { }

		internal virtual void SetDebugRain(bool debug) { }

		internal virtual void SetIntensity(float value) { }

		internal virtual void SetWetting(float wetting, float fogginess, Vector2 mainWind, float t01) { }

	}

	private abstract class AbstractStateWinter : AbstractState
	{

		protected AbstractStateWinter(RainController controller, ERainControllerStatus status) { }

		internal virtual void DisableEffect() { }

		internal virtual void SetDebugRain(bool debug) { }

		internal virtual void SetIntensity(float value) { }

		internal virtual void SetOpaqueness(float opaqueness) { }

		internal virtual void SetWetting(float wetting, float fogginess, Vector2 mainWind, float t01) { }

	}

	internal enum ERainControllerStatus
	{
		Summer = 0,
		WinterStorm = 1,
		WinterStormReconnect = 2,
		Winter = 3,
		Spring = 4,
		SpringEarly = 5,
		Autumn = 6,
		AutumnLate = 7,
	}

	internal enum ERainIntensity
	{
		None = 0,
		Low = 1,
		Med = 2,
		High = 3,
	}

	private sealed class StateAutumn : AbstractStateSummer
	{

		public StateAutumn(RainController controller) { }

	}

	private sealed class StateAutumnLate : AbstractStateSummer
	{

		public StateAutumnLate(RainController controller) { }

	}

	private sealed class StateSpring : AbstractStateSummer
	{

		public StateSpring(RainController controller) { }

	}

	private sealed class StateSpringEarly : AbstractStateSummer
	{

		public StateSpringEarly(RainController controller, Vector3 springSnowFactor) { }

	}

	private sealed class StateSummer : AbstractStateSummer
	{

		public StateSummer(RainController controller) { }

		internal virtual void SetupAutumn() { }

		internal virtual void SetupAutumnLate() { }

		internal virtual void SetupSpring() { }

		internal virtual void SetupSpringEarly(Vector3 springSnowFactor) { }

		internal virtual void SetupSummer() { }

		internal virtual void SetupWinter(bool snowWetRendererDisabled) { }

		internal virtual void SetupWinterStorm() { }

		internal virtual void SetupWinterStormReconnect() { }

	}

	private sealed class StateWinter : AbstractStateWinter
	{
		private readonly bool _snowWetRendererDisabled; //Field offset: 0x20

		public StateWinter(RainController controller, bool snowWetRendererDisabled) { }

		internal virtual void SetIntensity(float value) { }

		internal virtual void SetWetting(float wetting) { }

	}

	private sealed class StateWinterStorm : AbstractStateWinter
	{

		public StateWinterStorm(RainController controller) { }

		internal virtual void SetWetting(float wetting) { }

	}

	private sealed class StateWinterStormReconnect : AbstractStateWinter
	{

		public StateWinterStormReconnect(RainController controller) { }

	}

	[CompilerGenerated]
	private static bool <IsCameraUnderRain>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static float <Intensity>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static float <Opaqueness>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static float <Wetting>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static Action WettingChangedEvent; //Field offset: 0x10
	[CompilerGenerated]
	private static Vector3 <FallingVectorV3>k__BackingField; //Field offset: 0x18
	private static readonly List _rainCondensators; //Field offset: 0x28
	private static readonly int _waterLevel; //Field offset: 0x30
	private static readonly int _rainIntensity; //Field offset: 0x34
	[MinMaxVec2(0, 1, -1)]
	public Vector2 PuddleWaterLevel; //Field offset: 0x20
	[SerializeField]
	private DepthPhotograper _depthPhotograper; //Field offset: 0x28
	[SerializeField]
	private RainSplashController _rainSplashController; //Field offset: 0x30
	[SerializeField]
	private RainFallDrops _rainFallDrops; //Field offset: 0x38
	[SerializeField]
	private WetRenderer _wetRenderer; //Field offset: 0x40
	[SerializeField]
	private RippleController _rippleController; //Field offset: 0x48
	[SerializeField]
	private SnowFlakes _snowFlakes; //Field offset: 0x50
	[SerializeField]
	private SnowWetRenderer _snowWetRenderer; //Field offset: 0x58
	[SerializeField]
	private SnowRippleController _snowRippleController; //Field offset: 0x60
	private AbstractState _state; //Field offset: 0x68
	private RainScreenDrops _rainScreenDrops; //Field offset: 0x70
	private ScreenWater _screenWater; //Field offset: 0x78
	private Transform _camera; //Field offset: 0x80

	public static event Action WettingChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public private static Vector3 FallingVectorV3
	{
		[CompilerGenerated]
		 get { } //Length: 104
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public private static float Intensity
	{
		[CompilerGenerated]
		 get { } //Length: 85
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public static ERainIntensity IntensityType
	{
		 get { } //Length: 238
	}

	public private static bool IsCameraUnderRain
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 88
	}

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public private static float Opaqueness
	{
		[CompilerGenerated]
		 get { } //Length: 85
		[CompilerGenerated]
		private set { } //Length: 98
	}

	private AbstractState State
	{
		private get { } //Length: 336
	}

	public float StormSideSpeed
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public private static float Wetting
	{
		[CompilerGenerated]
		 get { } //Length: 85
		[CompilerGenerated]
		private set { } //Length: 98
	}

	private static RainController() { }

	public RainController() { }

	[CompilerGenerated]
	public static void add_WettingChangedEvent(Action value) { }

	internal static void AddRainCondensator(RainCondensator rainCondensator) { }

	private void Awake() { }

	private void CameraChanged() { }

	internal void ControlRain(in Vector3 rainDir, float rain, float laingWater, float cloudiness, float hour) { }

	internal void DisableEffect() { }

	[CompilerGenerated]
	public static Vector3 get_FallingVectorV3() { }

	[CompilerGenerated]
	public static float get_Intensity() { }

	public static ERainIntensity get_IntensityType() { }

	[CompilerGenerated]
	public static bool get_IsCameraUnderRain() { }

	private static AbstractLogger get_Logger() { }

	[CompilerGenerated]
	public static float get_Opaqueness() { }

	private AbstractState get_State() { }

	public float get_StormSideSpeed() { }

	[CompilerGenerated]
	public static float get_Wetting() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public static void remove_WettingChangedEvent(Action value) { }

	internal static void RemoveRainCondensator(RainCondensator rainCondensator) { }

	[CompilerGenerated]
	private static void set_FallingVectorV3(Vector3 value) { }

	[CompilerGenerated]
	private static void set_Intensity(float value) { }

	[CompilerGenerated]
	private static void set_IsCameraUnderRain(bool value) { }

	[CompilerGenerated]
	private static void set_Opaqueness(float value) { }

	public void set_StormSideSpeed(float value) { }

	[CompilerGenerated]
	private static void set_Wetting(float value) { }

	internal void SetDebugRain(bool debug) { }

	internal void SetOpaqueness(float opaqueness) { }

	internal void SetupAutumn() { }

	internal void SetupAutumnLate() { }

	internal void SetupSpring() { }

	internal void SetupSpringEarly(Vector3 springSnowFactor) { }

	internal void SetupStorm() { }

	internal void SetupStormReconnect() { }

	internal void SetupSummer() { }

	internal void SetupWinter(bool snowWetRendererDisabled) { }

	internal void SetWetting(float wetting) { }

	internal void SetWetting(float wetting, float fogginess, Vector2 mainWind, float t01) { }

	private void Update() { }

	private void UpdateRainCondensators() { }

}

