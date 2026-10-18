namespace EFT.NextObservedPlayer;

public class ObserverPlayerCulling : BasePlayerCulling
{
	private const float ACTIVATION_FALLBACK_DELAY = 30; //Field offset: 0x0
	private ObservedPlayerView _view; //Field offset: 0x30
	private ObservedPlayerHandsController _handsController; //Field offset: 0x38
	private Action _unsubscribeFromEvent; //Field offset: 0x40
	private int _lastStateAnimatorIndex; //Field offset: 0x48
	private AnimationStateHashDictionary _animationStateHashDictionary; //Field offset: 0x50
	private bool _awaitActivation; //Field offset: 0x58
	private Nullable _awaitState; //Field offset: 0x59
	private float _awaitActivationRaidStartedTime; //Field offset: 0x5C

	public ObserverPlayerCulling(ObservedPlayerView view, AnimationStateHashDictionary animationStateHashDictionary) { }

	[CompilerGenerated]
	private void <Initialize>b__11_0(ObservedPlayerChangedEquipEvent raisedEvent) { }

	[CompilerGenerated]
	private void <Initialize>b__11_1(TurnAutoCullingOnSpawnedObserverPlayerEvent raisedEvent) { }

	private void Activate(string fallbackReason = null) { }

	public void Apply(ObservedPlayerMovementModel model) { }

	protected virtual void ApplyVisibleState() { }

	public virtual void Dispose() { }

	public void HideUntilActivated() { }

	public void Initialize(ObservedPlayerHandsController handsController, PlayerBones playerBones) { }

	private void OnWeaponChanged(ValueTuple prev, ValueTuple next) { }

	public void Reset() { }

	private void ResetWeaponAnimatorToIdle() { }

	private void SafeSetForceRenderingOffState(List renderers, int index, bool state) { }

	public virtual bool SetMode(EMode mode) { }

	private void SyncBodyAnimator() { }

	private void UpdateActivationFallback(EPlayerState state) { }

}

