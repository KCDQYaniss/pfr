namespace Systems.Effects;

public class Effects : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <GetEmissionEffect>b__0(EmissionEffect x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public GrenadeEmission emission; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <DisposeEmissionEffect>b__0(EmissionEffect x) { }

	}

	internal class Effect
	{
		internal class ParticleSys
		{
			internal enum Type
			{
				Forward = 0,
				Cone = 1,
				Hemisphere = 2,
				Circle = 3,
				ConeNormalized = 4,
				Cone60 = 5,
			}

			public Emitter Particle; //Field offset: 0x10
			public Vector2 Distance; //Field offset: 0x18
			public Type RandomType; //Field offset: 0x20
			public int MinCount; //Field offset: 0x24
			public int RandomCountRange; //Field offset: 0x28
			public bool UseRandomScale; //Field offset: 0x2C
			public Vector3 RandomScale; //Field offset: 0x30

			public ParticleSys() { }

			public void Emit(Vector3 position, Vector3 normal, float distance) { }

		}

		private const float SOUND_OFFSET_DISTANCE = 0.1; //Field offset: 0x0
		public const string CHOKE_GRENADE_KEY = "Grenade"; //Field offset: 0x0
		public const string CHOKE_IMPACT_KEY = "Impact"; //Field offset: 0x0
		public string Name; //Field offset: 0x10
		public MaterialType[] MaterialTypes; //Field offset: 0x18
		public BasicParticleSystemMediator BasicParticleSystemMediator; //Field offset: 0x20
		public ParticleSys[] Particles; //Field offset: 0x28
		public SoundBank Sound; //Field offset: 0x30
		public SoundBank SoundFP; //Field offset: 0x38
		public DecalSystem Decal; //Field offset: 0x40
		public bool Flash; //Field offset: 0x48
		public int FlareID; //Field offset: 0x4C
		public float FlashMaxDist; //Field offset: 0x50
		public float FlashTime; //Field offset: 0x54
		public bool Light; //Field offset: 0x58
		public Color LightColor; //Field offset: 0x5C
		public float LightMaxDist; //Field offset: 0x6C
		public float LightRange; //Field offset: 0x70
		public float LightIntensity; //Field offset: 0x74
		public float LightTime; //Field offset: 0x78
		public float ParticlesShift; //Field offset: 0x7C
		public bool WithShadows; //Field offset: 0x80
		public bool Wind; //Field offset: 0x81
		public float WindIntensity; //Field offset: 0x84
		public float WindRadius; //Field offset: 0x88
		public float WindTime; //Field offset: 0x8C
		public float WindMaxDist; //Field offset: 0x90
		public bool UseDeferredDecals; //Field offset: 0x94
		[HideInInspector]
		public DeferredDecalRenderer DeferredDecals; //Field offset: 0x98
		public LightPool LightPool; //Field offset: 0xA0
		private Vector2 _impactsGagRadius; //Field offset: 0xA8

		public Effect() { }

		public void Clear() { }

		private Vector3 ComputeSoundPositionWithOffset(Vector3 hitPosition, Vector3 hitDirection, Vector3 hitNormal) { }

		public void Emit(Vector3 position, Vector3 normal, Vector3 hitDirection, BallisticCollider hitCollider, bool withDecal = true, float volume = 1, bool isKnife = false, bool isHitPointVisible = true, bool isGrenade = false, EPointOfView pov = 1) { }

		private void PlaySound(Vector3 position, float distance, float volume, bool isFirstPerson, bool isVisible, bool isMeleeWeapon = false) { }

	}

	internal struct EffectEmitDescription
	{
		public Effect Effect; //Field offset: 0x0
		public Vector3 Position; //Field offset: 0x8
		public Vector3 Normal; //Field offset: 0x14
		public Vector3 HitDirection; //Field offset: 0x20
		public BallisticCollider HitCollider; //Field offset: 0x30
		public bool WithDecal; //Field offset: 0x38
		public float Volume; //Field offset: 0x3C
		public bool IsKnife; //Field offset: 0x40
		public bool IsHitPointVisible; //Field offset: 0x41
		public bool IsGrenade; //Field offset: 0x42
		public EPointOfView Pov; //Field offset: 0x44

	}

	internal class EmissionEffect
	{
		public string Key; //Field offset: 0x10
		public GrenadeEmission Instance; //Field offset: 0x18
		private List _cache; //Field offset: 0x20

		public EmissionEffect() { }

		public void Dispose(GrenadeEmission e) { }

		public GrenadeEmission GetEffect() { }

		public void InstantiateNewEffect() { }

	}

	internal struct MuzzleEffectContainer
	{
		public SimpleSparksRenderer Spark; //Field offset: 0x0
		public ParticleSystem Fume; //Field offset: 0x8
		public ParticleSystem Heat; //Field offset: 0x10
		public ParticleSystem HeatHaze; //Field offset: 0x18
		public MuzzleParticleContainer[] CommonSystems; //Field offset: 0x20

	}

	private static readonly int _indoorParamId; //Field offset: 0x0
	private static readonly int MAX_EFFECTS_PER_FRAME; //Field offset: 0x4
	public DeferredDecalRenderer DeferredDecals; //Field offset: 0x20
	public bool UseDecalPainter; //Field offset: 0x28
	public TextureDecalsPainter TexDecals; //Field offset: 0x30
	public MuzzleEffectContainer MuzzleEffect; //Field offset: 0x38
	public SoundBank[] AdditionalSoundEffects; //Field offset: 0x60
	public Effect[] EffectsArray; //Field offset: 0x68
	public EmissionEffect[] EmissionEffects; //Field offset: 0x70
	private EffectsCommutator _effectsCommutator; //Field offset: 0x78
	private LightPool _lightPool; //Field offset: 0x80
	private float _indoorParam; //Field offset: 0x88
	private Dictionary _dict; //Field offset: 0x90
	private Dictionary _names; //Field offset: 0x98
	private List _effectEmitDescriptions; //Field offset: 0xA0
	private HashSet _grenadesOnDuty; //Field offset: 0xA8
	private HashSet _buffer; //Field offset: 0xB0

	public EffectsCommutator EffectsCommutator
	{
		 get { } //Length: 5
	}

	private static Effects() { }

	public Effects() { }

	private void AddEffectEmit(Effect effect, Vector3 position, Vector3 normal, Vector3 hitDirection, BallisticCollider hitCollider, bool withDecal = true, float volume = 1, bool isKnife = false, bool isHitPointVisible = true, bool isGrenade = false, EPointOfView pov = 1) { }

	private void Awake() { }

	public void CacheEffects() { }

	public void ClearDecal() { }

	public void ClearEffects(MaterialType materialType) { }

	public void DisposeEmissionEffect(GrenadeEmission emission) { }

	public void Emit(MaterialType material, BallisticCollider hitCollider, Vector3 position, Vector3 normal, Vector3 hitDirection, float volume = 1, bool isKnife = false, bool isHitPointVisible = true, EPointOfView pov = 1) { }

	public void Emit(string ename, Vector3 position, Vector3 normal) { }

	public void EmitBleeding(Vector3 position, Vector3 normal) { }

	public void EmitBloodOnEnvironment(Vector3 position, Vector3 normal) { }

	public void EmitGrenade(string ename, Vector3 position, Vector3 normal, float volume = 1) { }

	public void EmitPlayerSoundOnly(MaterialType material, IPlayer player, float volumeMult = 1, AudioMixerGroup mixerGroup = null) { }

	public Effect Get(MaterialType id) { }

	public EffectsCommutator get_EffectsCommutator() { }

	public IEnumerable GetActiveGrenadeEffects() { }

	public GrenadeEmission GetEmissionEffect(string key) { }

	private void InitDictionaryAndNames() { }

	private void OnDestroy() { }

	public void OnValidate() { }

	public void PlayerMeshesHit(List renderers, Vector3 point, Vector3 direction) { }

	public void PrewarmEmit(MaterialType material, BallisticCollider hitCollider, Vector3 position, Vector3 normal, Vector3 hitDirection, float volume = 1, bool isKnife = false, bool isHitPointVisible = true, EPointOfView pov = 1) { }

	public void TestEmit(int id, Vector3 position, Vector3 normal) { }

	public void TryAddToMBOITParticleManager(MuzzleParticleContainer[] containers) { }

	public void TryRemoveFromMBOITParticleManager(MuzzleParticleContainer[] containers) { }

	private void Update() { }

	public void UpdateMBOITIndoorAttenuation() { }

	private void UpdateMBOITIndoorAttenuation(bool indoor, MuzzleParticleContainer container) { }

}

