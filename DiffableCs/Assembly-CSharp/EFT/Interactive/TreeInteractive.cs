namespace EFT.Interactive;

public class TreeInteractive : MonoBehaviour, IPhysicsTriggerWithStay, IPhysicsTrigger
{
	private struct BushSoundState
	{
		public BetterSource Source; //Field offset: 0x0
		public IObserverToPlayerBridge Player; //Field offset: 0x8
		public float LastVolume; //Field offset: 0x10

	}

	private const float FADE_TIME = 1; //Field offset: 0x0
	private const float MAGNITUDE_AT_MIN = -0.33; //Field offset: 0x0
	private const float MAGNITUDE_AT_MAX = 4.5; //Field offset: 0x0
	private const float RANDOM_PITCH = 0.1; //Field offset: 0x0
	private const float LOWER_VOLUME_SPEED = 0.0233; //Field offset: 0x0
	private const float PLAY_NEXT_SOUND_IF_DELTA_IS_BIGGER_THEN = 0.5; //Field offset: 0x0
	[SerializeField]
	public SoundBank _soundBank; //Field offset: 0x20
	private Dictionary _enteredPlayers; //Field offset: 0x28
	private Dictionary _states; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x38

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TreeInteractive() { }

	private void EnterBush(IObserverToPlayerBridge player) { }

	private void ExitBush(IObserverToPlayerBridge player) { }

	[CompilerGenerated]
	public override string get_Description() { }

	private float GetEffectiveRolloff(IObserverToPlayerBridge player) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private override void IPhysicsTriggerWithStay.OnTriggerStayCustom(Collider col, Collider triggerCollider) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	private void PlaySoundBank(Vector3 soundPosition, BushSoundState state, float effectiveRolloff, bool forceStereo = false) { }

}

