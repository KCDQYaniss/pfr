//Type is in global namespace

public class MuzzleManager : BaseSystemComponent, IMuzzleParticlePivot, ISparksEmitter, IFumeEmitter, IHeatHazeEmitter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__49_0; //Field offset: 0x8
		public static Func <>9__49_2; //Field offset: 0x10
		public static Func <>9__49_3; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal GameObject <UpdateJetsAndFumes>b__49_0(MuzzleFume f) { }

		internal GameObject <UpdateJetsAndFumes>b__49_2(MuzzleEffect x) { }

		internal float <UpdateJetsAndFumes>b__49_3(MuzzleJet x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public EMuzzleParticlePivot pivot; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <IMuzzleParticlePivot.Play>b__0(MuzzleParticleContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public GameObject[] launcherGo; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <UpdateJetsAndFumes>b__1(MuzzleEffect x) { }

	}

	private const string OBJECT_NAME = "Muzzle Light"; //Field offset: 0x0
	private static readonly int _shotVals; //Field offset: 0x0
	public Material JetMaterial; //Field offset: 0x20
	public int AtlasXCount; //Field offset: 0x28
	public int AtlasYCount; //Field offset: 0x2C
	public AnimationCurve MoveCurve; //Field offset: 0x30
	public AnimationCurve JetLightCurve; //Field offset: 0x38
	public float ShotLength; //Field offset: 0x40
	public bool TestPlay; //Field offset: 0x44
	public bool TestShoot; //Field offset: 0x45
	public bool TestHold; //Field offset: 0x46
	public float TestDebugPosition; //Field offset: 0x48
	public float TestDelay; //Field offset: 0x4C
	public MuzzleLight Light; //Field offset: 0x50
	public string MeshParentName; //Field offset: 0x58
	private MuzzleJet[] _muzzleJets; //Field offset: 0x60
	private MuzzleSparks[] _muzzleSparks; //Field offset: 0x68
	private MuzzleFume[] _muzzleFumes; //Field offset: 0x70
	private MuzzleFume[] _launcherFumes; //Field offset: 0x78
	private MuzzleSmoke[] _muzzleSmokes; //Field offset: 0x80
	private MuzzleParticlePivot[] _muzzleParticlePlayers; //Field offset: 0x88
	private HeatEmitter[] _heatEmitters; //Field offset: 0x90
	private HeatHazeEmitter[] _heatHazeEmitters; //Field offset: 0x98
	private Vector2 _cellSize; //Field offset: 0xA0
	private float _nextTime; //Field offset: 0xA8
	public Transform Hierarchy; //Field offset: 0xB0
	private float _summaryJetsProbability; //Field offset: 0xB8
	private float _tMaxAllowedValue; //Field offset: 0xBC
	private float _tLightMaxAllowedValue; //Field offset: 0xC0
	private bool _tAfterEnd; //Field offset: 0xC4
	private bool _tLightAfterEnd; //Field offset: 0xC5
	private bool _isMuzzleActive; //Field offset: 0xC6
	[CompilerGenerated]
	private GameObject[] <MuzzleJets>k__BackingField; //Field offset: 0xC8

	public private GameObject[] MuzzleJets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static MuzzleManager() { }

	public MuzzleManager() { }

	private void Awake() { }

	private T[] FindEffects() { }

	[CompilerGenerated]
	public GameObject[] get_MuzzleJets() { }

	private override void IFumeEmitter.Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	private override void IHeatHazeEmitter.Emit(Vector3 position, float rotation, Vector3 velocity, float size, float lifetime, Color32 color) { }

	private override void IMuzzleParticlePivot.Play(EMuzzleParticlePivot pivot, Transform pTransform) { }

	private override void ISparksEmitter.Emit(Vector3 position, Vector3 velocity, float time, float gravity, float drag, float lifeTime, byte emission, byte size, byte turbulence, byte frequency) { }

	private void LateUpdateLights(float t) { }

	public void LateUpdateMuzzleEffectsValues(Camera cam) { }

	public void LauncherShot() { }

	public void ManualLateUpdate() { }

	public void ManualUpdate() { }

	private void MuzzleEffectsClear() { }

	private void OnDestroy() { }

	protected virtual void OnDisable() { }

	[CompilerGenerated]
	private void set_MuzzleJets(GameObject[] value) { }

	public void SetMuzzleActive(bool active) { }

	public void SetT(float t) { }

	public void Shot(bool isVisible = true, float sqrCameraDistance = 0) { }

	public void UpdateJetsAndFumes() { }

	internal void UpdateLights() { }

	private void UpdateMuzzleEffectsValues() { }

}

