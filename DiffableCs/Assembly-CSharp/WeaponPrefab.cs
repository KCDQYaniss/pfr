//Type is in global namespace

[DisallowMultipleComponent]
public class WeaponPrefab : AssetPoolObject, IComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__83_0; //Field offset: 0x8
		public static Func <>9__83_1; //Field offset: 0x10
		public static Func <>9__83_2; //Field offset: 0x18
		public static Func <>9__83_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <SetupSpirit>b__83_0(IEventBehaviour x) { }

		internal IEventBehaviour <SetupSpirit>b__83_1(IEventBehaviour x) { }

		internal int <SetupSpirit>b__83_2(IEventBehaviour x) { }

		internal IEventBehaviour <SetupSpirit>b__83_3(IEventBehaviour x) { }

	}

	internal class AimPlane
	{
		public string Name; //Field offset: 0x10
		public float Depth; //Field offset: 0x18

		public AimPlane() { }

	}

	internal class LODConfig
	{
		public float screenRelativeTransitionHeight; //Field offset: 0x10
		public float fadeTransitionWidth; //Field offset: 0x14
		public string[] renderers; //Field offset: 0x18

		public LODConfig() { }

	}

	internal class MaterialConfig
	{
		public string renderer; //Field offset: 0x10
		public Material material; //Field offset: 0x18

		public MaterialConfig() { }

	}

	public const string BONE_ALT_GRIP = "altpose"; //Field offset: 0x0
	public const string BONE_SMOKEPORT = "smokeport"; //Field offset: 0x0
	public const string BONE_FIREPORT = "fireport"; //Field offset: 0x0
	public const string EXTRACTOR_GO_NAME = "extractor_smoke"; //Field offset: 0x0
	[SerializeField]
	public GameObject _weaponObject; //Field offset: 0x90
	[SerializeField]
	public GameObject _weaponObjectSimple; //Field offset: 0x98
	[SerializeField]
	public RuntimeAnimatorController _originalAnimatorController; //Field offset: 0xA0
	[SerializeField]
	public RuntimeAnimatorController _animatorSimple; //Field offset: 0xA8
	[SerializeField]
	public RuntimeAnimatorController _animatorSpirit; //Field offset: 0xB0
	[SerializeField]
	public TextAsset _fastAnimatorControllerBinaryData; //Field offset: 0xB8
	[SerializeField]
	private Avatar _avatar; //Field offset: 0xC0
	[SerializeField]
	public RestSettings RestSettings; //Field offset: 0xC8
	public GameObject DefaultMuzzlePrefab; //Field offset: 0xD0
	public GameObject DefaultSmokeport; //Field offset: 0xD8
	public GameObject DefaultHeatHazeEffect; //Field offset: 0xE0
	public Vector3 RecoilCenter; //Field offset: 0xE8
	public Vector3 RotationCenter; //Field offset: 0xF4
	public Vector3 RotationCenterNoStock; //Field offset: 0x100
	public Vector2 DupletAccuracyPenaltyX; //Field offset: 0x10C
	public Vector2 DupletAccuracyPenaltyY; //Field offset: 0x114
	public AimPlane FarPlane; //Field offset: 0x120
	public AimPlane DefaultAimPlane; //Field offset: 0x128
	public AimPlane[] CustomAimPlanes; //Field offset: 0x130
	[SerializeField]
	public GameObject _objectInstance; //Field offset: 0x138
	[SerializeField]
	private Transform _localWeaponRoot; //Field offset: 0x140
	private IPlayer _player; //Field offset: 0x148
	private IAnimator _animator; //Field offset: 0x150
	private IAnimator _cachedSpiritAnimator; //Field offset: 0x158
	private FirearmsAnimator _firearmsAnimator; //Field offset: 0x160
	private FastAnimatorController _fastAnimatorController; //Field offset: 0x168
	private AnimationEventsEmitter _animEventEmitter; //Field offset: 0x170
	private FlatFastAnimatorController _cachedFlatAnimator; //Field offset: 0x178
	private Weapon _weaponData; //Field offset: 0x180
	private Vector3 _localChildPosition; //Field offset: 0x188
	private Quaternion _localChildRotation; //Field offset: 0x194
	private Vector3 _localChildScale; //Field offset: 0x1A4
	private bool _wasAnimatorInited; //Field offset: 0x1B0
	private bool _cacheInternalObjectsBeenCalled; //Field offset: 0x1B1
	private float _shotTimeOfEndOfOverHeat; //Field offset: 0x1B4
	private List _hotObjectList; //Field offset: 0x1B8
	private List _materials; //Field offset: 0x1C0
	private float _previousOverheat; //Field offset: 0x1C8
	private Animator _formerAnimator; //Field offset: 0x1D0
	[Header("Extractor params")]
	public string[] RemoveChildrenOf; //Field offset: 0x1D8
	public string[] AnimatedBones; //Field offset: 0x1E0
	public TransformLinks Hierarchy; //Field offset: 0x1E8
	public ObjectInHands ObjectInHands; //Field offset: 0x1F0
	public int[] LayersDefaultStates; //Field offset: 0x1F8
	public MaterialConfig[] MaterialsConfig; //Field offset: 0x200
	[Header("Extractor params for LODs")]
	public LODConfig[] LodsConfig; //Field offset: 0x208
	private List _eventBehaviours; //Field offset: 0x210
	private Renderer[] _objectInstanceRenderers; //Field offset: 0x218
	private List _currentModsList; //Field offset: 0x220

	public AnimationEventsEmitter AnimationEventsEmitter
	{
		 get { } //Length: 8
	}

	public IAnimator Animator
	{
		 get { } //Length: 8
	}

	public RuntimeAnimatorController AnimatorController
	{
		 get { } //Length: 8
	}

	public float CurrentOverheat
	{
		 get { } //Length: 399
	}

	public FirearmsAnimator FirearmsAnimator
	{
		 get { } //Length: 8
	}

	public List HotObjects
	{
		 get { } //Length: 8
	}

	public bool IsUnderbarrelWeaponPrefab
	{
		 get { } //Length: 122
	}

	public Renderer[] Renderers
	{
		 get { } //Length: 283
	}

	public GameObject WeaponObject
	{
		 get { } //Length: 8
	}

	public WeaponPrefab() { }

	[CompilerGenerated]
	private IAnimator <Parent>b__82_0() { }

	protected override void CacheInternalObjects() { }

	private void CreateObjectInstance() { }

	public AnimationEventsEmitter get_AnimationEventsEmitter() { }

	public IAnimator get_Animator() { }

	public RuntimeAnimatorController get_AnimatorController() { }

	public float get_CurrentOverheat() { }

	public FirearmsAnimator get_FirearmsAnimator() { }

	public List get_HotObjects() { }

	public bool get_IsUnderbarrelWeaponPrefab() { }

	public Renderer[] get_Renderers() { }

	public GameObject get_WeaponObject() { }

	public virtual void InheritRoleModelData(TAssetPoolObject roleModel) { }

	public Transform Init(IPlayer player, bool parent) { }

	public void InitHotObjects(Weapon weapon) { }

	public void InitMalfunctionState(Weapon weapon, bool hasPlayer, bool malfunctionKnown, out AmmoPoolObject ammoPoolObject) { }

	public void ManualUpdate() { }

	public virtual void OnCreatePoolObject(AbstractAssetsPool assetsPoolParent) { }

	public virtual void OnCreatePoolRoleModel() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private Transform Parent(IPlayer player) { }

	public void RebindAnimator(IPlayer player) { }

	public void RecalculateObjectInstanceRenderers() { }

	private void ReInitHotObjects() { }

	private void ReInitVolumetricLights() { }

	private void ResetAnimationEventsCache() { }

	private void ResetAnimator() { }

	private void ResetHotObject() { }

	public void ResetStatesToDefault(bool onReturnToPool = false) { }

	public void ResetUnderbarrelFastAnimator(Player player) { }

	protected virtual void ReturnToPool() { }

	public void RevertMalfunctionState(Weapon weapon, bool hasPlayer, bool force = false) { }

	public void SetUnderbarrelFastAnimator(Player player) { }

	private void SetupSpirit(Player player) { }

	public void UpdateAnimatorHierarchy() { }

}

