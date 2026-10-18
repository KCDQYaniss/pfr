namespace EFT;

public sealed class Firearms : ObjectInHands, IShellCollisionListener
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__51_0; //Field offset: 0x8
		public static Func <>9__89_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <RemoveMod>b__89_0(ContainerCollection x) { }

		internal bool <UpdateTacticalComboAndFlashlightVisualControllers>b__51_0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public RainCondensator[] rainCondensators; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal bool <RemoveMod>b__1(RainCondensator x) { }

	}

	[CompilerGenerated]
	private sealed class <SpawnAllShells>d__73 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Firearms <>4__this; //Field offset: 0x20
		public Vector3 playerVelocity; //Field offset: 0x28

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
		public <SpawnAllShells>d__73(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SpawnMisfiredCartridge>d__74 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Firearms <>4__this; //Field offset: 0x20
		public Vector3 playerVelocity; //Field offset: 0x28
		private AmmoPoolObject <shell>5__2; //Field offset: 0x38

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
		public <SpawnMisfiredCartridge>d__74(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SpawnShell>d__72 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Firearms <>4__this; //Field offset: 0x20
		public int shellPortIndex; //Field offset: 0x28
		public Vector3 playerVelocity; //Field offset: 0x2C
		private AmmoPoolObject <shell>5__2; //Field offset: 0x38

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
		public <SpawnShell>d__72(int <>1__state) { }

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

	public const string SHELLPORT_TRANSFORM_NAME = "shellport"; //Field offset: 0x0
	public const string PATRON_IN_WEAPON_TRANSFORM_NAME = "patron_in_weapon"; //Field offset: 0x0
	private const string SHELL_SOUND_KEY = "shell_sound"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSmoothScopeStateChanged; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnSmoothSensetivityChange; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnSmoothScopeZoomValueChanged; //Field offset: 0x48
	private FirearmsEffects _firstWeaponEffects; //Field offset: 0x50
	private readonly List _sightViews; //Field offset: 0x58
	private List _shellPortsTransforms; //Field offset: 0x60
	private Transform[] _patronInWeaponTransforms; //Field offset: 0x68
	private AmmoPoolObject[] _ammoObjectInWeapon; //Field offset: 0x70
	private TacticalComboVisualController[] _tacticalComboVisualControllers; //Field offset: 0x78
	private SightModVisualControllers[] _sightModVisualControllers; //Field offset: 0x80
	private LauncherViauslController[] _launcherViauslControllers; //Field offset: 0x88
	private BipodViewController _bipodViewController; //Field offset: 0x90
	private List _spawnShells; //Field offset: 0x98
	private Transform _weaponHierarchy; //Field offset: 0xA0
	private WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0xA8
	private int _chambersCount; //Field offset: 0xB0
	private bool _multiBarrelWeapon; //Field offset: 0xB4
	private bool _isUnderbarrelWeapon; //Field offset: 0xB5
	private Vector3 _initialShellPortPosition; //Field offset: 0xB8
	private AmmoPoolObject[] _shellsInShellPort; //Field offset: 0xC8
	private List _rainCondensators; //Field offset: 0xD0
	private BifacialTransform _fireport; //Field offset: 0xD8
	[CompilerGenerated]
	private Player <Player>k__BackingField; //Field offset: 0xE0
	private ShellExtractionData _shellExtractionData; //Field offset: 0xE8
	private Dictionary _streamingAnimators; //Field offset: 0xF0

	public event Action OnSmoothScopeStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSmoothScopeZoomValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSmoothSensetivityChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BipodViewController BipodViewController
	{
		 get { } //Length: 8
	}

	public FirearmsEffects FirearmsEffects
	{
		 get { } //Length: 5
	}

	public Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static WeaponSounds SoundsPrefab
	{
		private get { } //Length: 61
	}

	public TacticalComboVisualController[] TacticalComboVisualControllers
	{
		 get { } //Length: 5
	}

	public Firearms() { }

	[CompilerGenerated]
	public void add_OnSmoothScopeStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothScopeZoomValueChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSmoothSensetivityChange(Action value) { }

	public virtual void AfterGetFromPoolInit(ProceduralWeaponAnimation proceduralWeaponAnimation, ContainerCollectionView containerCollectionView, bool isYourPlayer) { }

	public void CreatePatronInShellPort(Ammo ammo, int chamberIndex = 0) { }

	public void DestroyAllPatronsInWeapon() { }

	public bool DestroyPatronInWeapon(int chamberNumber = 0) { }

	private void DestroyShellInWeapon(int shellIndex = 0) { }

	public BipodViewController get_BipodViewController() { }

	public FirearmsEffects get_FirearmsEffects() { }

	[CompilerGenerated]
	public Player get_Player() { }

	private static WeaponSounds get_SoundsPrefab() { }

	public TacticalComboVisualController[] get_TacticalComboVisualControllers() { }

	public Transform GetModTransform(EWeaponModType modType) { }

	public bool HasPatronInWeapon(int chamberNumber = 0) { }

	public bool HasShellInWeapon(int chamberNumber = 0) { }

	public void InitStreamingAnimators() { }

	public override void InvokeShellCollision(Vector3 position, ESurfaceSound material, ECaliber caliber) { }

	private bool IsPatronVisible() { }

	private bool IsShellVisible() { }

	public void ModFinallyRemoved(Slot slot) { }

	public void MoveAmmoFromChamberToShellPort(bool ammoIsUsed, int chamberIndex = 0) { }

	public GameObject[] MuzzleTransforms() { }

	public virtual void OnCreatePoolObject(AssetPoolObject assetPoolObject) { }

	public virtual void OnReturnToPool(AssetPoolObject assetPoolObject) { }

	public virtual void OnWeaponInit() { }

	public void OpticCalibrationSwitchDown() { }

	public void OpticCalibrationSwitchUp() { }

	public static void ParentShellToTransform(GameObject shell, Transform shellParent) { }

	public void PlayLauncherEffects() { }

	private void PlayShellSound(Vector3 position, ESurfaceSound material, ECaliber caliber) { }

	public void PlayShotEffects(bool isVisible, float sqrCameraDistance) { }

	[CompilerGenerated]
	public void remove_OnSmoothScopeStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothScopeZoomValueChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSmoothSensetivityChange(Action value) { }

	public void RemoveAllShells() { }

	public void RemoveMod(Slot slot) { }

	public void RemovePatronInWeapon(int chamberIndex = 0) { }

	public void RemoveShellInWeapon(int shellIndex = 0) { }

	[CompilerGenerated]
	public void set_Player(Player value) { }

	public void SetAiming(bool aim) { }

	public void SetFireport(BifacialTransform fireport) { }

	public void SetPatronInShellPort(AmmoPoolObject ammoObject, int shellTransformIndex = 0) { }

	public virtual void SetPointOfView(EPointOfView pointOfView) { }

	public void SetRoundIntoWeapon(Ammo ammo, int chamberNumber = 0) { }

	public void SetupMod(Slot slot, GameObject modObject) { }

	public void SetupPatronInWeaponForJam(int chamberNumber = 0) { }

	private void SetupPatronInWeaponTransform() { }

	private void SetupShellPortTransform() { }

	public void SetVisiblePatronInWeapon(bool visible, int chamberNumber = 0) { }

	private void SmoothScopeZoomValueChanged(SightComponent sightComponent, float scopeZoomValue) { }

	[IteratorStateMachine(typeof(<SpawnAllShells>d__73))]
	private IEnumerator SpawnAllShells(Vector3 playerVelocity) { }

	private AmmoPoolObject SpawnExtractingCartridge(Vector3 playerVelocity, AmmoPoolObject shell) { }

	private static AmmoPoolObject SpawnItemObject(Item ammo, IPlayer player) { }

	[IteratorStateMachine(typeof(<SpawnMisfiredCartridge>d__74))]
	private IEnumerator SpawnMisfiredCartridge(Vector3 playerVelocity) { }

	[IteratorStateMachine(typeof(<SpawnShell>d__72))]
	private IEnumerator SpawnShell(Vector3 playerVelocity, int shellPortIndex = 0) { }

	public void SpawnShellAfterJam(int chamberNumber = 0) { }

	public void StartSpawnAllShells(Vector3 playerVelocity) { }

	public void StartSpawnMisfiredCartridge(Vector3 playerVelocity) { }

	public void StartSpawnShell(Vector3 playerVelocity, int shellPortIndex = 0) { }

	public void ThrowPatronAsLoot(Item patron, IPlayer player, string source) { }

	public void UpdateBeams() { }

	private void UpdateModsVisualControllers() { }

	public void UpdateScopes(bool isAdd) { }

	public void UpdateScopesMode() { }

	private void UpdateTacticalComboAndFlashlightVisualControllers() { }

	private void UseGameObjectForShellExtraction(Vector3 force, Vector3 torque, AmmoPoolObject shell, Vector3 parentForce) { }

	public void ValidateScopeSmoothZoomUpdate(bool enableUpdate) { }

}

