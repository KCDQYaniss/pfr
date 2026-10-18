//Type is in global namespace

[Obfuscation(Exclude = True)]
public class BaseSoundPlayer : MonoBehaviour, IEventsConsumer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string soundName; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <SoundEventHandler>b__0(SoundElement soundElement) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public string soundName; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <SoundAtPointEventHandler>b__0(SoundElement elem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public string eventName; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <EventReceiver>b__0(SoundElement soundElement) { }

		internal bool <EventReceiver>b__1(SoundElement soundElement) { }

	}

	internal interface IObserverToPlayerBridge : IDisposable
	{

		public event Action BreakLoop
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public IPlayerCustomAudioSettings CustomAudioSettings
		{
			 get { } //Length: 0
		}

		public EnvironmentType Environment
		{
			 get { } //Length: 0
		}

		public FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 0
		}

		public IPlayer iPlayer
		{
			 get { } //Length: 0
		}

		public bool IsVisible
		{
			 get { } //Length: 0
		}

		public bool isWeaponTriggerPressed
		{
			 get { } //Length: 0
		}

		public AbstractMovementContextAdapter MovementContextAdapter
		{
			 get { } //Length: 0
		}

		public EPointOfView PointOfView
		{
			 get { } //Length: 0
		}

		public SoundElement PropIn
		{
			 get { } //Length: 0
		}

		public SoundElement PropOut
		{
			 get { } //Length: 0
		}

		public bool UseSimplifiedSkeleton
		{
			 get { } //Length: 0
		}

		public float VolumeMultByWeaponErgonomic
		{
			 get { } //Length: 0
		}

		public Weapon Weapon
		{
			 get { } //Length: 0
		}

		public float WorldTime
		{
			 get { } //Length: 0
		}

		[CompilerGenerated]
		public void add_BreakLoop(Action value) { }

		public IPlayerCustomAudioSettings get_CustomAudioSettings() { }

		public EnvironmentType get_Environment() { }

		public FirearmsAnimator get_FirearmsAnimator() { }

		public IPlayer get_iPlayer() { }

		public bool get_IsVisible() { }

		public bool get_isWeaponTriggerPressed() { }

		public AbstractMovementContextAdapter get_MovementContextAdapter() { }

		public EPointOfView get_PointOfView() { }

		public SoundElement get_PropIn() { }

		public SoundElement get_PropOut() { }

		public bool get_UseSimplifiedSkeleton() { }

		public float get_VolumeMultByWeaponErgonomic() { }

		public Weapon get_Weapon() { }

		public float get_WorldTime() { }

		[CompilerGenerated]
		public void remove_BreakLoop(Action value) { }

	}

	internal class ObserverBridge : IObserverToPlayerBridge, IDisposable
	{
		[CompilerGenerated]
		private Action BreakLoop; //Field offset: 0x10
		[CompilerGenerated]
		private readonly Weapon <Weapon>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly AbstractMovementContextAdapter <MovementContextAdapter>k__BackingField; //Field offset: 0x20
		private ObservedPlayerView _observedPlayer; //Field offset: 0x28
		private readonly ObservedPlayerHandsController _handsController; //Field offset: 0x30

		public override event Action BreakLoop
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override IPlayerCustomAudioSettings CustomAudioSettings
		{
			 get { } //Length: 51
		}

		public override EnvironmentType Environment
		{
			 get { } //Length: 47
		}

		public override FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 30
		}

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		public override bool IsVisible
		{
			 get { } //Length: 29
		}

		public override bool isWeaponTriggerPressed
		{
			 get { } //Length: 303
		}

		public override AbstractMovementContextAdapter MovementContextAdapter
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override EPointOfView PointOfView
		{
			 get { } //Length: 34
		}

		public override SoundElement PropIn
		{
			 get { } //Length: 48
		}

		public override SoundElement PropOut
		{
			 get { } //Length: 48
		}

		public override bool UseSimplifiedSkeleton
		{
			 get { } //Length: 30
		}

		public override float VolumeMultByWeaponErgonomic
		{
			 get { } //Length: 50
		}

		public override Weapon Weapon
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override float WorldTime
		{
			 get { } //Length: 28
		}

		public ObserverBridge(ObservedPlayerView player) { }

		[CompilerGenerated]
		public override void add_BreakLoop(Action value) { }

		private void CallBreakLoop() { }

		public override void Dispose() { }

		public override IPlayerCustomAudioSettings get_CustomAudioSettings() { }

		public override EnvironmentType get_Environment() { }

		public override FirearmsAnimator get_FirearmsAnimator() { }

		public override IPlayer get_iPlayer() { }

		public override bool get_IsVisible() { }

		public override bool get_isWeaponTriggerPressed() { }

		[CompilerGenerated]
		public override AbstractMovementContextAdapter get_MovementContextAdapter() { }

		public override EPointOfView get_PointOfView() { }

		public override SoundElement get_PropIn() { }

		public override SoundElement get_PropOut() { }

		public override bool get_UseSimplifiedSkeleton() { }

		public override float get_VolumeMultByWeaponErgonomic() { }

		[CompilerGenerated]
		public override Weapon get_Weapon() { }

		public override float get_WorldTime() { }

		[CompilerGenerated]
		public override void remove_BreakLoop(Action value) { }

	}

	internal class PlayerBridge : IObserverToPlayerBridge, IDisposable
	{
		[CompilerGenerated]
		private Action BreakLoop; //Field offset: 0x10
		[CompilerGenerated]
		private readonly Weapon <Weapon>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly AbstractMovementContextAdapter <MovementContextAdapter>k__BackingField; //Field offset: 0x20
		private Player _player; //Field offset: 0x28
		private IHandsController _handsController; //Field offset: 0x30
		private FirearmController _firearm; //Field offset: 0x38

		public override event Action BreakLoop
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override IPlayerCustomAudioSettings CustomAudioSettings
		{
			 get { } //Length: 30
		}

		public override EnvironmentType Environment
		{
			 get { } //Length: 29
		}

		public override FirearmsAnimator FirearmsAnimator
		{
			 get { } //Length: 78
		}

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		public override bool IsVisible
		{
			 get { } //Length: 3
		}

		public override bool isWeaponTriggerPressed
		{
			 get { } //Length: 42
		}

		public override AbstractMovementContextAdapter MovementContextAdapter
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override EPointOfView PointOfView
		{
			 get { } //Length: 42
		}

		public override SoundElement PropIn
		{
			 get { } //Length: 30
		}

		public override SoundElement PropOut
		{
			 get { } //Length: 30
		}

		public override bool UseSimplifiedSkeleton
		{
			 get { } //Length: 30
		}

		public override float VolumeMultByWeaponErgonomic
		{
			 get { } //Length: 29
		}

		public override Weapon Weapon
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override float WorldTime
		{
			 get { } //Length: 137
		}

		public PlayerBridge(Player player, IHandsController handsController) { }

		[CompilerGenerated]
		public override void add_BreakLoop(Action value) { }

		private void CallBreakLoop() { }

		public override void Dispose() { }

		public override IPlayerCustomAudioSettings get_CustomAudioSettings() { }

		public override EnvironmentType get_Environment() { }

		public override FirearmsAnimator get_FirearmsAnimator() { }

		public override IPlayer get_iPlayer() { }

		public override bool get_IsVisible() { }

		public override bool get_isWeaponTriggerPressed() { }

		[CompilerGenerated]
		public override AbstractMovementContextAdapter get_MovementContextAdapter() { }

		public override EPointOfView get_PointOfView() { }

		public override SoundElement get_PropIn() { }

		public override SoundElement get_PropOut() { }

		public override bool get_UseSimplifiedSkeleton() { }

		public override float get_VolumeMultByWeaponErgonomic() { }

		[CompilerGenerated]
		public override Weapon get_Weapon() { }

		public override float get_WorldTime() { }

		[CompilerGenerated]
		public override void remove_BreakLoop(Action value) { }

	}

	internal class SoundElement
	{
		public string EventName; //Field offset: 0x10
		public int RollOff; //Field offset: 0x18
		public float Volume; //Field offset: 0x1C
		public AudioClip[] SoundClips; //Field offset: 0x20

		public AudioClip RandomSoundClip
		{
			 get { } //Length: 142
		}

		public SoundElement() { }

		public AudioClip get_RandomSoundClip() { }

	}

	private const double CLIP_SOURCE_RELEASE_DELAY = 1; //Field offset: 0x0
	protected IObserverToPlayerBridge playersBridge; //Field offset: 0x20
	private BetterSource _clipsSource; //Field offset: 0x28
	protected BifacialTransform _weaponHierarchy; //Field offset: 0x30
	private bool _isClipSourceReleased; //Field offset: 0x38
	private bool _isClipSourceStartPlaying; //Field offset: 0x39
	private double _clipSourceReleaseTime; //Field offset: 0x40
	protected AudioSourcePriorityCalculator PriorityCalculator; //Field offset: 0x48
	[SerializeField]
	public List AdditionalSounds; //Field offset: 0x50
	[SerializeField]
	public SoundElement[] MainSounds; //Field offset: 0x58
	private FirearmsAnimator _firearmsAnimator; //Field offset: 0x60
	protected PointOfViewSoundValue _volumeMult; //Field offset: 0x68
	protected PointOfViewSoundValue _spatialBlend; //Field offset: 0x70
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsSilenced>k__BackingField; //Field offset: 0x80

	public override bool IsSilenced
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected Vector3 WeaponPosition
	{
		 get { } //Length: 206
	}

	protected Transform WeaponTransform
	{
		 get { } //Length: 163
	}

	public BaseSoundPlayer() { }

	[CompilerGenerated]
	private void <InitInternal>b__24_0() { }

	public override void AimReady() { }

	private void ApplySettingsFromBackend() { }

	public override void DropWeapon() { }

	public void EventReceiver(string eventName) { }

	[CompilerGenerated]
	public override bool get_IsSilenced() { }

	protected Vector3 get_WeaponPosition() { }

	protected Transform get_WeaponTransform() { }

	public override void IdleReady() { }

	private override void IEventsConsumer.BipodClose() { }

	private override void IEventsConsumer.BipodOpen() { }

	private override void IEventsConsumer.OnAddAmmoInChamber() { }

	private override void IEventsConsumer.OnAddAmmoInMag() { }

	private override void IEventsConsumer.OnArm() { }

	private override void IEventsConsumer.OnBackpackDrop() { }

	private override void IEventsConsumer.OnComboPlanning() { }

	private override void IEventsConsumer.OnCook() { }

	private override void IEventsConsumer.OnCurrentAnimStateEnded() { }

	private override void IEventsConsumer.OnDeactivateObject(int objectID) { }

	private override void IEventsConsumer.OnDelAmmoChamber() { }

	private override void IEventsConsumer.OnDelAmmoFromMag() { }

	private override void IEventsConsumer.OnDisarm() { }

	private override void IEventsConsumer.OnFireEnd() { }

	private override void IEventsConsumer.OnFiringBullet() { }

	private override void IEventsConsumer.OnFoldOff() { }

	private override void IEventsConsumer.OnFoldOn() { }

	private override void IEventsConsumer.OnIdleStart() { }

	private override void IEventsConsumer.OnLauncherAppeared() { }

	private override void IEventsConsumer.OnLauncherDisappeared() { }

	private override void IEventsConsumer.OnMagHide() { }

	private override void IEventsConsumer.OnMagIn() { }

	private override void IEventsConsumer.OnMagOut() { }

	private override void IEventsConsumer.OnMagShow() { }

	private override void IEventsConsumer.OnMalfunctionOff() { }

	private override void IEventsConsumer.OnMessageName() { }

	private override void IEventsConsumer.OnModChanged() { }

	private override void IEventsConsumer.OnOffBoltCatch() { }

	private override void IEventsConsumer.OnOnBoltCatch() { }

	private override void IEventsConsumer.OnPutMagToRig() { }

	private override void IEventsConsumer.OnRemoveShell() { }

	private override void IEventsConsumer.OnReplaceSecondMag() { }

	private override void IEventsConsumer.OnSetActiveObject(int objectID) { }

	private override void IEventsConsumer.OnShellEject() { }

	private override void IEventsConsumer.OnShowAmmo(bool BoolParam) { }

	private override void IEventsConsumer.OnShowMag() { }

	private override void IEventsConsumer.OnSound(string StringParam) { }

	private override void IEventsConsumer.OnSoundAtPoint(string StringParam) { }

	private override void IEventsConsumer.OnStartUtilityOperation() { }

	private override void IEventsConsumer.OnThirdAction(int IntParam) { }

	private override void IEventsConsumer.OnUseProp(bool boolParam) { }

	private override void IEventsConsumer.OnUseSecondMagForReload() { }

	private override void IEventsConsumer.OnWeapIn() { }

	private override void IEventsConsumer.OnWeapOut() { }

	private override void IEventsConsumer.OutUse() { }

	private override void IEventsConsumer.ReloadTest() { }

	public void Init(IHandsController handsController, BifacialTransform weaponHierarchy, Player player) { }

	public void Init(BifacialTransform weaponHierarchy, ObservedPlayerView player) { }

	protected override void InitInternal(BifacialTransform weaponHierarchy) { }

	protected override void OnApplySettings(ClientAudioSettings audioSettings) { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	public override void OnSliderOut() { }

	protected void PlayClip(AudioClip clip, int rolloff, float volume) { }

	private void PlayClipInternal(AudioClip clip, int rolloff, float volume, int priority, bool stereo, float spatialBlend) { }

	private void PlayRandomClip(SoundElement soundElement) { }

	private void ReleaseClipSourceDelayed() { }

	private void ReleaseClipsSource() { }

	[CompilerGenerated]
	public override void set_IsSilenced(bool value) { }

	protected override void SetParametersFromBackend(ItemInHandsSettings settings) { }

	private void SetupClipSource(AudioClip clip) { }

	private void SoundAtPointEventHandler(string soundName) { }

	private void SoundEventHandler(string soundName) { }

	public override void Update() { }

}

