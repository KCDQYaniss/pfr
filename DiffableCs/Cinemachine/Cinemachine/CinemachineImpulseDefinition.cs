namespace Cinemachine;

[DocumentationSorting(Level::API (1))]
public class CinemachineImpulseDefinition
{
	internal enum ImpulseShapes
	{
		Custom = 0,
		Recoil = 1,
		Bump = 2,
		Explosion = 3,
		Rumble = 4,
	}

	internal enum ImpulseTypes
	{
		Uniform = 0,
		Dissipating = 1,
		Propagating = 2,
		Legacy = 3,
	}

	private class LegacySignalSource : ISignalSource6D
	{
		private CinemachineImpulseDefinition m_Def; //Field offset: 0x10
		private Vector3 m_Velocity; //Field offset: 0x18
		private float m_StartTimeOffset; //Field offset: 0x24

		public override float SignalDuration
		{
			 get { } //Length: 51
		}

		public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity) { }

		public override float get_SignalDuration() { }

		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	}

	internal enum RepeatMode
	{
		Stretch = 0,
		Loop = 1,
	}

	private class SignalSource : ISignalSource6D
	{
		private CinemachineImpulseDefinition m_Def; //Field offset: 0x10
		private Vector3 m_Velocity; //Field offset: 0x18

		public override float SignalDuration
		{
			 get { } //Length: 28
		}

		public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity) { }

		public override float get_SignalDuration() { }

		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	}

	private static AnimationCurve[] sStandardShapes; //Field offset: 0x0
	[CinemachineImpulseChannelProperty]
	[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
	public int m_ImpulseChannel; //Field offset: 0x10
	[Tooltip("Shape of the impact signal")]
	public ImpulseShapes m_ImpulseShape; //Field offset: 0x14
	[Tooltip("Defines the custom shape of the impact signal that will be generated.")]
	public AnimationCurve m_CustomImpulseShape; //Field offset: 0x18
	[Tooltip("The time during which the impact signal will occur.  The signal shape will be stretched to fill that time.")]
	public float m_ImpulseDuration; //Field offset: 0x20
	[Tooltip("How the impulse travels through space and time.")]
	public ImpulseTypes m_ImpulseType; //Field offset: 0x24
	[Range(0, 1)]
	[Tooltip("This defines how the widely signal will spread within the effect radius before dissipating with distance from the impact point")]
	public float m_DissipationRate; //Field offset: 0x28
	[CinemachineEmbeddedAssetProperty(True)]
	[Header("Signal Shape")]
	[Tooltip("Legacy mode only: Defines the signal that will be generated.")]
	public SignalSourceAsset m_RawSignal; //Field offset: 0x30
	[Tooltip("Legacy mode only: Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
	public float m_AmplitudeGain; //Field offset: 0x38
	[Tooltip("Legacy mode only: Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
	public float m_FrequencyGain; //Field offset: 0x3C
	[Tooltip("Legacy mode only: How to fit the signal into the envelope time")]
	public RepeatMode m_RepeatMode; //Field offset: 0x40
	[Tooltip("Legacy mode only: Randomize the signal start time")]
	public bool m_Randomize; //Field offset: 0x44
	[Tooltip("Legacy mode only: This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
	public EnvelopeDefinition m_TimeEnvelope; //Field offset: 0x48
	[Header("Spatial Range")]
	[Tooltip("Legacy mode only: The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
	public float m_ImpactRadius; //Field offset: 0x68
	[Tooltip("Legacy mode only: How the signal direction behaves as the listener moves away from the origin.")]
	public DirectionMode m_DirectionMode; //Field offset: 0x6C
	[Tooltip("Legacy mode only: This defines how the signal will dissipate with distance beyond the impact radius.")]
	public DissipationMode m_DissipationMode; //Field offset: 0x70
	[Tooltip("The signal will have no effect outside this radius surrounding the impact point.")]
	public float m_DissipationDistance; //Field offset: 0x74
	[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
	public float m_PropagationSpeed; //Field offset: 0x78

	internal AnimationCurve ImpulseCurve
	{
		internal get { } //Length: 264
	}

	public CinemachineImpulseDefinition() { }

	public ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	public void CreateEvent(Vector3 position, Vector3 velocity) { }

	private static void CreateStandardShapes() { }

	internal AnimationCurve get_ImpulseCurve() { }

	internal static AnimationCurve GetStandardCurve(ImpulseShapes shape) { }

	private ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	public void OnValidate() { }

}

