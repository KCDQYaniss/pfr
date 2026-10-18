//Type is in global namespace

[ScriptOrder(21000)]
public abstract class DisablerCullingObjectBase : UpdateInEditorSystemComponent, IPreProcessHandler
{
	[CompilerGenerated]
	private static int <SpectatingTargetRaidId>k__BackingField; //Field offset: 0x0
	[SerializeField]
	protected List _colliders; //Field offset: 0x20
	[SerializeField]
	protected List _inverseColliders; //Field offset: 0x28
	protected List _enteredColliders; //Field offset: 0x30
	protected List _enteredInverseColliders; //Field offset: 0x38
	protected List _colliderReporters; //Field offset: 0x40
	protected List _inverseColliderReporters; //Field offset: 0x48
	protected bool _updateComponentsStatus; //Field offset: 0x50

	public override bool HasEntered
	{
		 get { } //Length: 92
	}

	internal static int SpectatingTargetRaidId
	{
		[CompilerGenerated]
		internal get { } //Length: 58
		[CompilerGenerated]
		private set { } //Length: 63
	}

	protected DisablerCullingObjectBase() { }

	protected override void Awake() { }

	protected void CollidersNullCheck() { }

	protected void CollidersNullCheck(ref List colliders) { }

	public override bool get_HasEntered() { }

	[CompilerGenerated]
	internal static int get_SpectatingTargetRaidId() { }

	internal static ICharacterController GetTargetCharacterController(int raidId) { }

	protected bool IsRightCollider(Collider col) { }

	public virtual void ManualUpdate(float dt) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnEnable() { }

	public override void OnPreProcess() { }

	protected override void OnSpectatorTriggerStateReset() { }

	protected override void OnTriggerEnterEvent(ColliderReporter colliderReporter, Collider collider) { }

	private void OnTriggerEnterEvent(List enteredColliders, ColliderReporter colliderReporter, Collider collider) { }

	protected override void OnTriggerExitEvent(ColliderReporter colliderReporter, Collider collider) { }

	private void OnTriggerExitEvent(List enteredColliders, ColliderReporter colliderReporter, Collider collider) { }

	private void OnValidate() { }

	public override void PrepareCullingObject() { }

	internal void ResetSpectatorTriggerState() { }

	[CompilerGenerated]
	private static void set_SpectatingTargetRaidId(int value) { }

	protected abstract void SetComponentsEnabled(bool hasEntered) { }

	internal static void SetSpectatingTargetRaidId(int raidId) { }

	protected override void UpdateComponentsStatusOnUpdate() { }

	protected override void Validate() { }

	private void Validate(List colliders, List colliderReporters, bool inverse) { }

}

