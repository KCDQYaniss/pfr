//Type is in global namespace

public sealed class EffectsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <UpdateRadialBlur>d__59 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EffectsController <>4__this; //Field offset: 0x20
		public bool isActive; //Field offset: 0x28
		public float strengthFrom; //Field offset: 0x2C
		public float strengthTo; //Field offset: 0x30
		public float residueTime; //Field offset: 0x34
		public float targetStrength; //Field offset: 0x38
		private float <currentStrength>5__2; //Field offset: 0x3C
		private float <t>5__3; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UpdateRadialBlur>d__59(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class CC_BlendAccumulator : EffectAccumulator
	{
		private CC_Blend _effect; //Field offset: 0x30
		private float _startTime; //Field offset: 0x38
		private float _inTime; //Field offset: 0x3C
		private bool _fade; //Field offset: 0x40
		private float _amount; //Field offset: 0x44

		public CC_BlendAccumulator(EffectsController effectsController, CC_Blend cameraEffect, float maxEffectValue, Type[] types) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_DoubleVisionAccumulator : EffectAccumulator
	{
		private CC_DoubleVision _effect; //Field offset: 0x30

		public CC_DoubleVisionAccumulator(EffectsController effectsController, CC_DoubleVision cameraEffect, float maxEffectValue, Type[] types) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_FastVignetteAccumulator : EffectAccumulator
	{
		private CC_FastVignette _effect; //Field offset: 0x30

		public CC_FastVignetteAccumulator(EffectsController effectsController, CC_FastVignette cameraEffect, float maxEffectValue, Type[] types) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_HueFocusAccumulator : EffectAccumulator
	{
		private CC_HueFocus _effect; //Field offset: 0x30

		public CC_HueFocusAccumulator(EffectsController effectsController, CC_HueFocus cameraEffect, float maxEffectValue, Type[] types) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_RadialBlurAccumulator : EffectAccumulator
	{
		private const int SIN_PERIOD = 3; //Field offset: 0x0
		private const int COS_PERIOD = 7; //Field offset: 0x0
		private const float AMPLITUDE = 0.2; //Field offset: 0x0
		private const float NOISE_BORDER = 2; //Field offset: 0x0
		private readonly CC_RadialBlur _effect; //Field offset: 0x30
		private float _painStrength; //Field offset: 0x38
		[CompilerGenerated]
		private bool <ForceActivePainSources>k__BackingField; //Field offset: 0x3C
		public Vector2 StrengthRange; //Field offset: 0x40

		public bool ForceActivePainSources
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public CC_RadialBlurAccumulator(EffectsController controller, CC_RadialBlur effect, float maxValue, Type[] types) { }

		protected virtual float CurrentAmount() { }

		[CompilerGenerated]
		public bool get_ForceActivePainSources() { }

		[CompilerGenerated]
		public void set_ForceActivePainSources(bool value) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_SharpenAccumulator : EffectAccumulator
	{
		private CC_Sharpen _effect; //Field offset: 0x30
		private float _defaultSharpenStrength; //Field offset: 0x38
		private bool _isSubscribed; //Field offset: 0x3C

		public CC_SharpenAccumulator(EffectsController effectsController, CC_Sharpen cameraEffect, float maxEffectValue, float durationTime, Type[] types) { }

		public void ChangeDefaultSharpenValue(float defaultValue) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class CC_WiggleAccumulator : EffectAccumulator
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__10_0; //Field offset: 0x8
			public static Func <>9__10_3; //Field offset: 0x10
			public static Func <>9__10_4; //Field offset: 0x18
			public static Func <>9__13_0; //Field offset: 0x20

			private static <>c() { }

			public <>c() { }

			internal float <CurrentAmount>b__13_0(IStimulatorBuff buff) { }

			internal bool <UpdateScaleAndSpeed>b__10_0(IHealthEffect e) { }

			internal float <UpdateScaleAndSpeed>b__10_3(IStimulatorBuff b) { }

			internal float <UpdateScaleAndSpeed>b__10_4(IStimulatorBuff b) { }

		}

		private CC_Wiggle _effect; //Field offset: 0x30
		private float _maxSpeed; //Field offset: 0x38
		private float _maxScale; //Field offset: 0x3C
		private List _stimulatorBuffs; //Field offset: 0x40
		private Dictionary _effectsSpeed; //Field offset: 0x48
		private Dictionary _effectsScale; //Field offset: 0x50

		public CC_WiggleAccumulator(EffectsController effectsController, CC_Wiggle cameraEffect, float maxEffectValue, Type[] types) { }

		[CompilerGenerated]
		private float <UpdateScaleAndSpeed>b__10_1(IHealthEffect e) { }

		[CompilerGenerated]
		private float <UpdateScaleAndSpeed>b__10_2(IHealthEffect e) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		protected virtual float CurrentAmount() { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void StimulatorBuff(IStimulatorBuff buff) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

		private void UpdateScaleAndSpeed() { }

	}

	private sealed class DesaturateAccumulator : EffectAccumulator
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__7_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal float <UpdateMaxEffectValue>b__7_0(IHealthEffect x) { }

		}

		private static readonly Dictionary _effectMaxValues; //Field offset: 0x0
		private const float STANDARD_VALUE = 0; //Field offset: 0x0
		private readonly CC_Sharpen _cameraEffect; //Field offset: 0x30

		private static DesaturateAccumulator() { }

		public DesaturateAccumulator(EffectsController effectsController, CC_Sharpen cameraEffect) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		private static bool IsValidEffect(IHealthEffect effect) { }

		public virtual void UpdateAmount() { }

		private void UpdateDesaturate() { }

		private void UpdateMaxEffectValue() { }

	}

	private sealed class DesaturateMaskAccumulator : EffectAccumulator
	{
		private const float MAX_VALUE = 1; //Field offset: 0x0
		private const float STANDARD_VALUE = 0; //Field offset: 0x0
		private readonly CC_Sharpen _cameraEffect; //Field offset: 0x30
		private float _desaturateRadius; //Field offset: 0x38
		private float _minDesaturateRadius; //Field offset: 0x3C
		private float _maxDesaturateRadius; //Field offset: 0x40
		private bool _restoreDesaturateMask; //Field offset: 0x44

		public DesaturateMaskAccumulator(EffectsController effectsController, CC_Sharpen cameraEffect, Type[] types) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void UpdateAmount() { }

		private void UpdateDesaturate(bool desaturateProvider) { }

		private void UpdateDesaturateRadius(bool desaturateProvider) { }

		private void UpdateMaxEffectValue() { }

	}

	private abstract class EffectAccumulator
	{
		public List ActiveEffects; //Field offset: 0x10
		public Type[] ValidTypes; //Field offset: 0x18
		public float MaxEffectValue; //Field offset: 0x20
		public bool Enabled; //Field offset: 0x24
		protected EffectsController _controller; //Field offset: 0x28

		protected EffectAccumulator() { }

		public override void AddEffect(IHealthEffect effect) { }

		protected override float CurrentAmount() { }

		public override void DeleteEffect(IHealthEffect effect) { }

		public override void StimulatorBuff(IStimulatorBuff buff) { }

		public override void Toggle(bool value) { }

		public abstract void UpdateAmount() { }

	}

	private sealed class FlashAccumulator : EffectAccumulator
	{
		private GrenadeFlashScreenEffect _screenEffect; //Field offset: 0x30
		private List _indoorEffects; //Field offset: 0x38

		public FlashAccumulator(EffectsController effectsController, GrenadeFlashScreenEffect screenScreenEffect, Type[] types) { }

		[CompilerGenerated]
		private float <UpdateAmount>b__6_0(IHealthEffect e) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class FOV_Accumulator : EffectAccumulator
	{
		private float _cosPeriod; //Field offset: 0x30
		private float _sinPeriod; //Field offset: 0x34
		private float _startTime; //Field offset: 0x38

		public FOV_Accumulator(EffectsController effectsController, Type[] types) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private sealed class FrostbiteAccumulator : EffectAccumulator
	{
		private const float MIN_VALUE = 0.325; //Field offset: 0x0
		private const float MAX_VALUE = 1; //Field offset: 0x0
		private readonly FrostbiteEffect _effect; //Field offset: 0x30
		private bool _restore; //Field offset: 0x38

		public FrostbiteAccumulator(EffectsController controller, FrostbiteEffect effect, Type[] types) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void UpdateAmount() { }

		private void UpdateMaxEffectValue() { }

	}

	private interface IForceMaxValueOnStartAccumulator
	{

		public void ForceMaxValue(IHealthEffect effect) { }

	}

	private sealed class MotionBlurAccumulator : EffectAccumulator
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__5_0; //Field offset: 0x8
			public static Func <>9__10_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal float <CurrentAmount>b__5_0(IStimulatorBuff buff) { }

			internal float <UpdateGoalValue>b__10_0(IStimulatorBuff b) { }

		}

		private MotionBlur _effect; //Field offset: 0x30
		private Dictionary _effectsAmount; //Field offset: 0x38
		private float _goalMaxValue; //Field offset: 0x40
		private List _stimulatorBuffs; //Field offset: 0x48

		public MotionBlurAccumulator(EffectsController effectsController, MotionBlur cameraEffect, float maxEffectValue, Type[] types) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		protected virtual float CurrentAmount() { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		public virtual void StimulatorBuff(IStimulatorBuff buff) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

		private void UpdateGoalValue() { }

	}

	private sealed class TearGasAccumulator : EffectAccumulator
	{
		private static readonly Dictionary _strengthPerEffect; //Field offset: 0x0
		private readonly TearsEffect _effect; //Field offset: 0x30
		private readonly IHearingDebuffEffect _hearingDebuff; //Field offset: 0x38
		private bool _hasStrongActive; //Field offset: 0x40

		private static TearGasAccumulator() { }

		public TearGasAccumulator(EffectsController controller, TearsEffect effect, IHearingDebuffEffect hearingDebuff, Type[] types) { }

		public virtual void AddEffect(IHealthEffect effect) { }

		public virtual void DeleteEffect(IHealthEffect effect) { }

		private bool HasStrongEffect() { }

		private void RefreshHearingDebuff() { }

		public virtual void UpdateAmount() { }

		private void UpdateMaxEffectValue() { }

	}

	private sealed class ZombieInfection_Accumulator : EffectAccumulator, IForceMaxValueOnStartAccumulator
	{
		private readonly InfectionEffect _cameraEffect; //Field offset: 0x30
		private readonly float _maxTime; //Field offset: 0x38
		private readonly float _debuffPercentage; //Field offset: 0x3C
		private bool _isMaxValue; //Field offset: 0x40
		private float _timePassed; //Field offset: 0x44
		private readonly FirstPersonPlayerHearingSettings _hearingSettings; //Field offset: 0x48

		public ZombieInfection_Accumulator(EffectsController effectsController, InfectionEffect cameraEffect, Type[] types) { }

		public override void ForceMaxValue(IHealthEffect effect) { }

		public void ResetHearingDebuff() { }

		public void SetHearingDebuff(float debuffPercentage, float fadeTime = 1) { }

		public virtual void Toggle(bool value) { }

		public virtual void UpdateAmount() { }

	}

	private const float DEFAULT_FOCAL_LENGTH = 5.2; //Field offset: 0x0
	private const float AIM_PUNCH_COEFFICIENT = 11.5; //Field offset: 0x0
	private static readonly MaterialType[] SpecialSoundEffects; //Field offset: 0x0
	private const float MED_KIT_EFFECT_DURATION = 15; //Field offset: 0x0
	[SerializeField]
	private GameObject _effectsPrefab; //Field offset: 0x20
	[SerializeField]
	public AnimationCurve FastVineteFlicker; //Field offset: 0x28
	[CompilerGenerated]
	private RainScreenDrops <RainScreenDrops>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ScreenWater <ScreenWater>k__BackingField; //Field offset: 0x38
	private CC_FastVignette _vignette; //Field offset: 0x40
	private CC_DoubleVision _doubleVision; //Field offset: 0x48
	private CC_HueFocus _hueFocus; //Field offset: 0x50
	private CC_RadialBlur _radialBlur; //Field offset: 0x58
	private CC_Sharpen _sharpen; //Field offset: 0x60
	private CC_Blend _lowhHealthBlend; //Field offset: 0x68
	private CC_Blend _bloodlossBlend; //Field offset: 0x70
	private CC_Wiggle _wiggle; //Field offset: 0x78
	private MotionBlur _motionBluer; //Field offset: 0x80
	private BloodOnScreen _bloodOnScreen; //Field offset: 0x88
	private GrenadeFlashScreenEffect _grenadeFlash; //Field offset: 0x90
	private EyeBurn _eyeBurn; //Field offset: 0x98
	private FastBlur _blur; //Field offset: 0xA0
	private DepthOfField _dof; //Field offset: 0xA8
	private readonly List _effectAccumulators; //Field offset: 0xB0
	private CC_SharpenAccumulator _sharpenAccumulator; //Field offset: 0xB8
	private CC_RadialBlurAccumulator _radialBlurAccumulator; //Field offset: 0xC0
	private ChromaticAberration _chromaticAberration; //Field offset: 0xC8
	private ThermalVision _thermalVision; //Field offset: 0xD0
	private FrostbiteEffect _frostbiteEffect; //Field offset: 0xD8
	private TearsEffect _tearsEffect; //Field offset: 0xE0
	private float _maxRadialBlur; //Field offset: 0xE8
	private float _maxRedScreen; //Field offset: 0xEC
	private float _maxDoubleScreen; //Field offset: 0xF0
	private float _maxVinieteDarkness; //Field offset: 0xF4
	private float _maxWiggleScale; //Field offset: 0xF8
	private float _maxMotionBlur; //Field offset: 0xFC
	private float _maxSharpen; //Field offset: 0x100
	private DeathFade _deathFade; //Field offset: 0x108
	private Player player; //Field offset: 0x110
	private Action _sharpenBinding; //Field offset: 0x118
	private Action _unsubscribeOnDestroy; //Field offset: 0x120

	public float MaxDoubleScreen
	{
		 get { } //Length: 9
	}

	public private RainScreenDrops RainScreenDrops
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ScreenWater ScreenWater
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static EffectsController() { }

	public EffectsController() { }

	[CompilerGenerated]
	private void <Awake>b__47_0(ClientPlayerEffectsPauseEvent invokedEvent) { }

	private void Awake() { }

	public float get_MaxDoubleScreen() { }

	[CompilerGenerated]
	public RainScreenDrops get_RainScreenDrops() { }

	[CompilerGenerated]
	public ScreenWater get_ScreenWater() { }

	private void Init() { }

	private void OhSpectatingStarted() { }

	private void OnClientPlayerEffectsPauseEvent(ClientPlayerEffectsPauseEvent invokedEvent) { }

	private void OnClientStartedSpectating(StartLocalSpectatingForTeammateEvent invokedEvent) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEffectRemoved(IHealthEffect effect) { }

	private void OnEffectStarted(IHealthEffect effect) { }

	private void OnGlassesChanged(Visors glasses, bool isActive) { }

	private void OnHealthApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnHealthBurnEyes(Vector3 position, float str, float time) { }

	private void OnHealthDied(EDamageType damageType) { }

	public void OnPlayerDamaged(float damage) { }

	private void OnPlayerDamaged(float damage, EBodyPart bodyPart, EDamageType type, float damageReducedByArmor, MaterialType special = 0) { }

	public void OnScreenWaterEffect(bool isActive, float intensity = 0, float speed = 0) { }

	private void OnSharpenChangedHandler(float value) { }

	private void OnStimulatorBuff(IStimulatorBuff buff) { }

	private void PlayerCameraControllerCreated(PlayerCameraController playerCameraController, Camera camera) { }

	private void PlayerCameraControllerDestroyed() { }

	private void PlaySpecialSound(MaterialType specialMaterialType) { }

	private void ResetEffectsInstant() { }

	private static void ResetHeadEffectsInstant() { }

	[CompilerGenerated]
	private void set_RainScreenDrops(RainScreenDrops value) { }

	[CompilerGenerated]
	private void set_ScreenWater(ScreenWater value) { }

	public void SetDoFFocalDistance(int fov, float minFov, float maxFov) { }

	private void Update() { }

	[IteratorStateMachine(typeof(<UpdateRadialBlur>d__59))]
	public IEnumerator UpdateRadialBlur(bool isActive, float targetStrength, float residueTime = 0.5, float strengthFrom = 0.2, float strengthTo = 0.7) { }

}

