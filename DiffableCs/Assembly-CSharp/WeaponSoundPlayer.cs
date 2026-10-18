//Type is in global namespace

[Obfuscation(Exclude = True)]
public class WeaponSoundPlayer : BaseSoundPlayer
{
	[CompilerGenerated]
	private sealed class <CO_AutoFireCheckLoop>d__64 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WeaponSoundPlayer <>4__this; //Field offset: 0x20

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
		public <CO_AutoFireCheckLoop>d__64(int <>1__state) { }

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

	public SoundBank Body; //Field offset: 0x88
	public SoundBank Doublet; //Field offset: 0x90
	public SoundBank BodySilenced; //Field offset: 0x98
	public SoundBank DoubletSilenced; //Field offset: 0xA0
	public bool Non_auto; //Field offset: 0xA8
	[SerializeField]
	private AnimationCurve _pitchByAmmoCurve; //Field offset: 0xB0
	[SerializeField]
	private WeaponPlaybackSettings _playbackSettings; //Field offset: 0xB8
	[SerializeField]
	private WeaponPoolSettings _poolSettings; //Field offset: 0xC0
	[SerializeField]
	private WeaponTemplateAudioSettings _templateSettings; //Field offset: 0xC8
	private bool _isSilenced; //Field offset: 0xD0
	private AudioMixerGroup _gunshotAudioMixerGroup; //Field offset: 0xD8
	private AudioMixerGroup _currentMixerGroup; //Field offset: 0xE0
	private SoundBankWithSettings _aimingSoundsBank; //Field offset: 0xE8
	private SoundBank _verticalMountSounds; //Field offset: 0xF0
	private IEnumerator _mountCoroutine; //Field offset: 0xF8
	private Coroutine _autoFireCheckCoroutine; //Field offset: 0x100
	private IAudioGunshotEmitter _soundEmitter; //Field offset: 0x108
	private IAudioGunshotEmitterFactory _emitterFactory; //Field offset: 0x110
	private Ammo _lastShotAmmo; //Field offset: 0x118
	private Vector3 _lastShotPosition; //Field offset: 0x120
	private Vector3 _lastShotDirection; //Field offset: 0x12C
	private float _lastShotRolloff; //Field offset: 0x138
	private float _lastDistanceToListener; //Field offset: 0x13C
	private float _lastShotRealTime; //Field offset: 0x140
	private float _lastShotDuration; //Field offset: 0x144
	private SoundBank _currentActiveBank; //Field offset: 0x148
	private bool _currentIsMultiShot; //Field offset: 0x150
	private bool _currentIsSilenced; //Field offset: 0x151
	private IAudioFireModeSelector _emitterFireModeSelector; //Field offset: 0x158
	private bool _initialized; //Field offset: 0x160
	[CompilerGenerated]
	private bool <IsFiring>k__BackingField; //Field offset: 0x161
	[CompilerGenerated]
	private bool <IsOccludedToListener>k__BackingField; //Field offset: 0x162

	private float DistanceToListener
	{
		private get { } //Length: 229
	}

	private bool IsAutoWeapon
	{
		private get { } //Length: 11
	}

	public private bool IsFiring
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsFirstPersonView
	{
		private get { } //Length: 84
	}

	public private bool IsOccludedToListener
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual bool IsSilenced
	{
		 get { } //Length: 8
		 set { } //Length: 759
	}

	public WeaponSoundPlayer() { }

	[CompilerGenerated]
	private double <InitializeEmitter>b__54_0() { }

	[CompilerGenerated]
	private void <InitInternal>b__50_0() { }

	private void Clear() { }

	[IteratorStateMachine(typeof(<CO_AutoFireCheckLoop>d__64))]
	private IEnumerator CO_AutoFireCheckLoop() { }

	private void EnterMountedStateHandler(float timeToMount) { }

	private void ExitMountedStateHandler(float timeToUnmount) { }

	public void FireBullet(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, bool multiShot = false) { }

	private void FireSonicSound(float rolloff, Ammo ammo, Vector3 shotPosition, Vector3 shotDirection) { }

	private float get_DistanceToListener() { }

	private bool get_IsAutoWeapon() { }

	[CompilerGenerated]
	public bool get_IsFiring() { }

	private bool get_IsFirstPersonView() { }

	[CompilerGenerated]
	public bool get_IsOccludedToListener() { }

	public virtual bool get_IsSilenced() { }

	private SoundBank GetTargetBank(bool multiShot, bool isSilenced) { }

	private void InitializeActiveBank() { }

	private void InitializeEmitter(BifacialTransform weaponTransform) { }

	protected virtual void InitInternal(BifacialTransform weaponHierarchy) { }

	protected virtual void OnApplySettings(ClientAudioSettings audioSettings) { }

	private void OnBreakLoop() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	public void PlayAimingSound(float volume) { }

	private void PlayMountSound() { }

	[CompilerGenerated]
	private void set_IsFiring(bool value) { }

	[CompilerGenerated]
	private void set_IsOccludedToListener(bool value) { }

	public virtual void set_IsSilenced(bool value) { }

	protected virtual void SetParametersFromBackend(ItemInHandsSettings settings) { }

	private void StopFiringLoop() { }

	private bool TryGetBank(bool multiShot, out SoundBank bank) { }

	private void TryPlayFireSonicSound() { }

	private bool TryReinit() { }

	private void UnsubscribeMountStateEvents() { }

	private void UpdateActiveBank(bool multiShot, bool isSilenced) { }

	private void UpdateMixerGroup() { }

}

