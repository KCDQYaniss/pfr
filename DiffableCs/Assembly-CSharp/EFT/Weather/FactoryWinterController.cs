namespace EFT.Weather;

public sealed class FactoryWinterController : MonoBehaviour
{
	private abstract class AbstractState : IDisposable
	{
		[CompilerGenerated]
		private FactoryWinterController <Controller>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly EStatus <Status>k__BackingField; //Field offset: 0x18

		protected FactoryWinterController Controller
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		internal EStatus Status
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		protected AbstractState(FactoryWinterController controller, EStatus status) { }

		internal override void CameraChanged(CameraManager cameraManager) { }

		internal abstract void DisableEffect() { }

		public override void Dispose() { }

		[CompilerGenerated]
		protected FactoryWinterController get_Controller() { }

		[CompilerGenerated]
		internal EStatus get_Status() { }

		[CompilerGenerated]
		protected void set_Controller(FactoryWinterController value) { }

		internal override void SetupWinter() { }

	}

	internal enum EStatus
	{
		Default = 0,
		Winter = 1,
	}

	private sealed class StateDefault : AbstractState
	{

		public StateDefault(FactoryWinterController controller) { }

		internal virtual void DisableEffect() { }

		internal virtual void SetupWinter() { }

	}

	private sealed class StateWinter : AbstractState
	{

		public StateWinter(FactoryWinterController controller) { }

		internal virtual void DisableEffect() { }

	}

	[CompilerGenerated]
	private static FactoryWinterController <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private SnowWetRenderer _snowWetRenderer; //Field offset: 0x20
	[SerializeField]
	private SnowFlakes _snowFlakes; //Field offset: 0x28
	[SerializeField]
	private DepthPhotograper _depthPhotographer; //Field offset: 0x30
	private Transform _camera; //Field offset: 0x38
	private AbstractState _state; //Field offset: 0x40

	public private static FactoryWinterController Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	private AbstractState State
	{
		private get { } //Length: 243
	}

	public FactoryWinterController() { }

	private void Awake() { }

	private void CameraChanged() { }

	[CompilerGenerated]
	public static FactoryWinterController get_Instance() { }

	private static AbstractLogger get_Logger() { }

	private AbstractState get_State() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	[CompilerGenerated]
	private static void set_Instance(FactoryWinterController value) { }

	internal void SetupWinter() { }

}

