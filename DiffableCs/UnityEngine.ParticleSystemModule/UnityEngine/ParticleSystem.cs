namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	internal struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			[NativeThrows]
			 set { } //Length: 93
		}

		public MinMaxCurve rateOverTime
		{
			 get { } //Length: 106
			[NativeThrows]
			 set { } //Length: 93
		}

		internal EmissionModule(ParticleSystem particleSystem) { }

		public MinMaxCurve get_rateOverTime() { }

		private static void get_rateOverTime_Injected(ref EmissionModule _unity_self, out MinMaxCurve ret) { }

		[NativeThrows]
		public void set_enabled(bool value) { }

		private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) { }

		[NativeThrows]
		public void set_rateOverTime(MinMaxCurve value) { }

		private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) { }

	}

	internal struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle; //Field offset: 0x0
		[NativeName("positionSet")]
		private bool m_PositionSet; //Field offset: 0x84
		[NativeName("velocitySet")]
		private bool m_VelocitySet; //Field offset: 0x85
		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[NativeName("rotationSet")]
		private bool m_RotationSet; //Field offset: 0x87
		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[NativeName("startSizeSet")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[NativeName("startColorSet")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

		public Vector3 position
		{
			 set { } //Length: 22
		}

		public uint randomSeed
		{
			 set { } //Length: 11
		}

		public float rotation
		{
			 set { } //Length: 35
		}

		public Color32 startColor
		{
			 set { } //Length: 11
		}

		public float startLifetime
		{
			 set { } //Length: 13
		}

		public float startSize
		{
			 set { } //Length: 24
		}

		public Vector3 velocity
		{
			 set { } //Length: 23
		}

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_rotation(float value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}

	internal struct ExternalForcesModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			[NativeThrows]
			 set { } //Length: 93
		}

		public float multiplier
		{
			 get { } //Length: 78
		}

		internal ExternalForcesModule(ParticleSystem particleSystem) { }

		public float get_multiplier() { }

		private static float get_multiplier_Injected(ref ExternalForcesModule _unity_self) { }

		[NativeThrows]
		public void set_enabled(bool value) { }

		private static void set_enabled_Injected(ref ExternalForcesModule _unity_self, bool value) { }

	}

	internal struct LimitVelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[NativeName("Magnitude")]
		public MinMaxCurve limit
		{
			[NativeThrows]
			 set { } //Length: 93
		}

		internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) { }

		[NativeThrows]
		public void set_limit(MinMaxCurve value) { }

		private static void set_limit_Injected(ref LimitVelocityOverLifetimeModule _unity_self, ref MinMaxCurve value) { }

	}

	internal struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public Transform customSimulationSpace
		{
			 get { } //Length: 78
		}

		public float duration
		{
			 get { } //Length: 78
			[NativeThrows]
			 set { } //Length: 94
		}

		public bool loop
		{
			 get { } //Length: 78
			[NativeThrows]
			 set { } //Length: 93
		}

		public int maxParticles
		{
			 get { } //Length: 78
			[NativeThrows]
			 set { } //Length: 91
		}

		public ParticleSystemScalingMode scalingMode
		{
			 get { } //Length: 78
		}

		public ParticleSystemSimulationSpace simulationSpace
		{
			 get { } //Length: 78
		}

		public MinMaxGradient startColor
		{
			[NativeThrows]
			 set { } //Length: 93
		}

		public MinMaxCurve startDelay
		{
			 get { } //Length: 106
		}

		public MinMaxCurve startLifetime
		{
			 get { } //Length: 106
			[NativeThrows]
			 set { } //Length: 93
		}

		[NativeName("StartSizeX")]
		public MinMaxCurve startSize
		{
			[NativeThrows]
			 set { } //Length: 93
		}

		public MinMaxCurve startSpeed
		{
			 get { } //Length: 106
			[NativeThrows]
			 set { } //Length: 93
		}

		internal MainModule(ParticleSystem particleSystem) { }

		public Transform get_customSimulationSpace() { }

		private static Transform get_customSimulationSpace_Injected(ref MainModule _unity_self) { }

		public float get_duration() { }

		private static float get_duration_Injected(ref MainModule _unity_self) { }

		public bool get_loop() { }

		private static bool get_loop_Injected(ref MainModule _unity_self) { }

		public int get_maxParticles() { }

		private static int get_maxParticles_Injected(ref MainModule _unity_self) { }

		public ParticleSystemScalingMode get_scalingMode() { }

		private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) { }

		public ParticleSystemSimulationSpace get_simulationSpace() { }

		private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) { }

		public MinMaxCurve get_startDelay() { }

		private static void get_startDelay_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		public MinMaxCurve get_startLifetime() { }

		private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		public MinMaxCurve get_startSpeed() { }

		private static void get_startSpeed_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		[NativeThrows]
		public void set_duration(float value) { }

		private static void set_duration_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_loop(bool value) { }

		private static void set_loop_Injected(ref MainModule _unity_self, bool value) { }

		[NativeThrows]
		public void set_maxParticles(int value) { }

		private static void set_maxParticles_Injected(ref MainModule _unity_self, int value) { }

		[NativeThrows]
		public void set_startColor(MinMaxGradient value) { }

		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) { }

		[NativeThrows]
		public void set_startLifetime(MinMaxCurve value) { }

		private static void set_startLifetime_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

		[NativeThrows]
		public void set_startSize(MinMaxCurve value) { }

		private static void set_startSize_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

		[NativeThrows]
		public void set_startSpeed(MinMaxCurve value) { }

		private static void set_startSpeed_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct MinMaxCurve
	{
		[SerializeField]
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private float m_CurveMultiplier; //Field offset: 0x4
		[SerializeField]
		private AnimationCurve m_CurveMin; //Field offset: 0x8
		[SerializeField]
		private AnimationCurve m_CurveMax; //Field offset: 0x10
		[SerializeField]
		private float m_ConstantMin; //Field offset: 0x18
		[SerializeField]
		private float m_ConstantMax; //Field offset: 0x1C

		public float constant
		{
			 get { } //Length: 8
			 set { } //Length: 6
		}

		public float constantMax
		{
			 get { } //Length: 8
		}

		public float constantMin
		{
			 get { } //Length: 8
		}

		public ParticleSystemCurveMode mode
		{
			 get { } //Length: 5
			 set { } //Length: 3
		}

		public MinMaxCurve(float constant) { }

		public MinMaxCurve(float min, float max) { }

		public float Evaluate(float time) { }

		public float Evaluate(float time, float lerpFactor) { }

		public float get_constant() { }

		public float get_constantMax() { }

		public float get_constantMin() { }

		public ParticleSystemCurveMode get_mode() { }

		public static MinMaxCurve op_Implicit(float constant) { }

		public void set_constant(float value) { }

		public void set_mode(ParticleSystemCurveMode value) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct MinMaxGradient
	{
		[SerializeField]
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private Gradient m_GradientMin; //Field offset: 0x8
		[SerializeField]
		private Gradient m_GradientMax; //Field offset: 0x10
		[SerializeField]
		private Color m_ColorMin; //Field offset: 0x18
		[SerializeField]
		private Color m_ColorMax; //Field offset: 0x28

		public MinMaxGradient(Color color) { }

		public static MinMaxGradient op_Implicit(Color color) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	internal struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private uint m_ParentRandomSeed; //Field offset: 0x68
		private float m_Lifetime; //Field offset: 0x6C
		private float m_StartLifetime; //Field offset: 0x70
		private int m_MeshIndex; //Field offset: 0x74
		private float m_EmitAccumulator0; //Field offset: 0x78
		private float m_EmitAccumulator1; //Field offset: 0x7C
		private uint m_Flags; //Field offset: 0x80

		public Vector3 angularVelocity3D
		{
			 set { } //Length: 63
		}

		public Vector3 axisOfRotation
		{
			 get { } //Length: 19
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		public float lifetime
		{
			 set { } //Length: 6
		}

		public Vector3 position
		{
			 get { } //Length: 18
			 set { } //Length: 15
		}

		public uint randomSeed
		{
			 get { } //Length: 6
			 set { } //Length: 4
		}

		public float remainingLifetime
		{
			 get { } //Length: 8
			 set { } //Length: 6
		}

		public float rotation
		{
			 get { } //Length: 16
			 set { } //Length: 28
		}

		public Vector3 rotation3D
		{
			 get { } //Length: 59
			 set { } //Length: 63
		}

		public Color32 startColor
		{
			 set { } //Length: 4
		}

		public float startLifetime
		{
			 set { } //Length: 6
		}

		public float startSize
		{
			 set { } //Length: 17
		}

		public Vector3 velocity
		{
			 get { } //Length: 19
			 set { } //Length: 16
		}

		public Vector3 get_axisOfRotation() { }

		public Vector3 get_position() { }

		public uint get_randomSeed() { }

		public float get_remainingLifetime() { }

		public float get_rotation() { }

		public Vector3 get_rotation3D() { }

		public Vector3 get_velocity() { }

		public Color32 GetCurrentColor(ParticleSystem system) { }

		public float GetCurrentSize(ParticleSystem system) { }

		public void set_angularVelocity3D(Vector3 value) { }

		public void set_lifetime(float value) { }

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_remainingLifetime(float value) { }

		public void set_rotation(float value) { }

		public void set_rotation3D(Vector3 value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}

	internal struct RotationBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			 get { } //Length: 78
		}

		public bool separateAxes
		{
			 get { } //Length: 78
		}

		internal RotationBySpeedModule(ParticleSystem particleSystem) { }

		public bool get_enabled() { }

		private static bool get_enabled_Injected(ref RotationBySpeedModule _unity_self) { }

		public bool get_separateAxes() { }

		private static bool get_separateAxes_Injected(ref RotationBySpeedModule _unity_self) { }

	}

	internal struct RotationOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			 get { } //Length: 78
		}

		public bool separateAxes
		{
			 get { } //Length: 78
		}

		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

		public bool get_enabled() { }

		private static bool get_enabled_Injected(ref RotationOverLifetimeModule _unity_self) { }

		public bool get_separateAxes() { }

		private static bool get_separateAxes_Injected(ref RotationOverLifetimeModule _unity_self) { }

	}

	internal struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public MeshRenderer meshRenderer
		{
			 get { } //Length: 78
			[NativeThrows]
			 set { } //Length: 93
		}

		internal ShapeModule(ParticleSystem particleSystem) { }

		public MeshRenderer get_meshRenderer() { }

		private static MeshRenderer get_meshRenderer_Injected(ref ShapeModule _unity_self) { }

		[NativeThrows]
		public void set_meshRenderer(MeshRenderer value) { }

		private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, MeshRenderer value) { }

	}

	internal struct SubEmittersModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public int subEmittersCount
		{
			 get { } //Length: 78
		}

		internal SubEmittersModule(ParticleSystem particleSystem) { }

		public int get_subEmittersCount() { }

		private static int get_subEmittersCount_Injected(ref SubEmittersModule _unity_self) { }

		[NativeThrows]
		public ParticleSystem GetSubEmitterSystem(int index) { }

		private static ParticleSystem GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index) { }

	}


	public EmissionModule emission
	{
		 get { } //Length: 91
	}

	public ExternalForcesModule externalForces
	{
		 get { } //Length: 91
	}

	public bool isPlaying
	{
		[NativeName("SyncJobs(false)->IsPlaying")]
		 get { } //Length: 78
	}

	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime
	{
		 get { } //Length: 91
	}

	public MainModule main
	{
		 get { } //Length: 91
	}

	public int particleCount
	{
		[NativeName("SyncJobs(false)->GetParticleCount")]
		 get { } //Length: 78
	}

	public uint randomSeed
	{
		[NativeName("SyncJobs(false)->SetRandomSeed")]
		 set { } //Length: 91
	}

	public RotationBySpeedModule rotationBySpeed
	{
		 get { } //Length: 91
	}

	public RotationOverLifetimeModule rotationOverLifetime
	{
		 get { } //Length: 91
	}

	public ShapeModule shape
	{
		 get { } //Length: 91
	}

	public SubEmittersModule subEmitters
	{
		 get { } //Length: 91
	}

	public float time
	{
		[NativeName("SyncJobs(false)->GetSecPosition")]
		 get { } //Length: 78
	}

	public bool useAutoRandomSeed
	{
		[NativeName("GetAutoRandomSeed")]
		 get { } //Length: 78
		[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		 set { } //Length: 93
	}

	public ParticleSystem() { }

	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	public void Clear(bool withChildren) { }

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Particle particle) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count) { }

	[RequiredByNativeCode]
	public void Emit(int count) { }

	private void Emit_Injected(ref EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle) { }

	public EmissionModule get_emission() { }

	public ExternalForcesModule get_externalForces() { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	public bool get_isPlaying() { }

	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	public MainModule get_main() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	public int get_particleCount() { }

	public RotationBySpeedModule get_rotationBySpeed() { }

	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	public ShapeModule get_shape() { }

	public SubEmittersModule get_subEmitters() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	public float get_time() { }

	[NativeName("GetAutoRandomSeed")]
	public bool get_useAutoRandomSeed() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	public int GetParticles(out NativeArray particles, int size) { }

	public int GetParticles(out Particle[] particles) { }

	public int GetParticles(out Particle[] particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	public int GetParticles(out NativeArray particles, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	public void Pause(bool withChildren) { }

	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	public void Play(bool withChildren) { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	public void set_randomSeed(uint value) { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	public void set_useAutoRandomSeed(bool value) { }

	public void SetParticles(out Particle[] particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	public void SetParticles(out Particle[] particles, int size, int offset) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Stop(bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop() { }

}

