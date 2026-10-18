//Type is in global namespace

[Obfuscation(Exclude = True)]
public abstract class ObjectInHandsAnimator
{
	internal enum PlayerState
	{
		None = 0,
		Idle = 1,
		Jump = 2,
		Sprint = 3,
		Prone = 4,
	}

	public const int LACTION_DROP_BACKPACK_INDEX = 300; //Field offset: 0x0
	public const int LACTION_PICKUP_INDEX = 1; //Field offset: 0x0
	private bool _inventoryLocked; //Field offset: 0x10
	protected Func _animatorGetter; //Field offset: 0x18
	protected int _animatorLayersCount; //Field offset: 0x20
	private readonly List _eventsConsumers; //Field offset: 0x28
	private readonly HashSet _existedParameters; //Field offset: 0x30

	public IAnimator Animator
	{
		 get { } //Length: 37
	}

	public override Action FireEventAction
	{
		 get { } //Length: 3
	}

	public bool IsInInteraction
	{
		 get { } //Length: 220
	}

	public bool IsInInventory
	{
		 get { } //Length: 217
	}

	public bool IsInventoryLocked
	{
		 get { } //Length: 5
	}

	protected ObjectInHandsAnimator() { }

	public void AddEventsConsumer(IEventsConsumer eventsConsumer) { }

	public void AnimatorEventHandler(int functionNameHash, AnimationEventParameter parameter) { }

	public bool CurrentStateNameIs(int layer, string sname) { }

	public void Gesture(EInteraction index) { }

	public IAnimator get_Animator() { }

	public override Action get_FireEventAction() { }

	public bool get_IsInInteraction() { }

	public bool get_IsInInventory() { }

	public bool get_IsInventoryLocked() { }

	public float GetAnimatorParameter(int hash) { }

	public float GetLayerWeight(int layerIndex) { }

	public float GetLeftHandProgress() { }

	protected bool HasParameter(int parameterHash) { }

	public void LockInventory() { }

	public void RemoveEventsConsumer(IEventsConsumer eventsConsumer) { }

	public void ResetLeftHand() { }

	public void SetActiveParam(bool active, bool resetLeftHand = true) { }

	public void SetAnimationSpeed(float speed) { }

	public override void SetAnimatorGetter(Func getter) { }

	public void SetDeflected(bool b) { }

	public void SetFastHide(bool fastHide) { }

	public void SetInventory(bool open) { }

	public void SetLActionIndex(int actionIndex) { }

	public void SetLayerWeight(int layerid, int p2) { }

	public void SetLayerWeight(int layerId, float weight) { }

	public void SetLayerWeight(string layerName, int p2) { }

	public void SetMeleeSpeed(float speed) { }

	public void SetPatrol(bool b) { }

	public void SetPlayerState(PlayerState state) { }

	public void SetPointOfViewOnSpawn(EPointOfView pointOfView) { }

	public void SetQuickFire(bool quickFire) { }

	public void ShowCompass(bool show) { }

	public void ShowRadioTransmitter(bool show) { }

	public void SkipTime(float t) { }

	public void UnlockInventory() { }

}

