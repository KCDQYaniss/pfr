namespace Dissonance;

public abstract class BaseCommsTrigger : MonoBehaviour, IAccessTokenCollection
{
	protected readonly Log Log; //Field offset: 0x20
	private bool _wasColliderTriggered; //Field offset: 0x28
	private readonly List _entitiesInCollider; //Field offset: 0x30
	[SerializeField]
	private TokenSet _tokens; //Field offset: 0x38
	private Nullable _cachedTokenActivation; //Field offset: 0x40
	private DissonanceComms _comms; //Field offset: 0x48

	public abstract bool CanTrigger
	{
		 get { } //Length: 0
	}

	protected private DissonanceComms Comms
	{
		 get { } //Length: 5
		private set { } //Length: 1252
	}

	public bool IsColliderTriggered
	{
		 get { } //Length: 101
	}

	protected bool TokenActivationState
	{
		 get { } //Length: 347
	}

	public override IEnumerable Tokens
	{
		 get { } //Length: 5
	}

	public abstract bool UseColliderTrigger
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[Obsolete("Replaced with UseColliderTrigger")]
	public bool UseTrigger
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	protected BaseCommsTrigger() { }

	public override bool AddToken(string token) { }

	[UsedImplicitly]
	protected override void Awake() { }

	protected bool CheckVoiceComm() { }

	protected override void ColliderTriggerChanged() { }

	protected override bool ColliderTriggerFilter(Collider other) { }

	protected override bool ColliderTriggerFilter2D(Collider2D other) { }

	public override bool ContainsToken(string token) { }

	public abstract bool get_CanTrigger() { }

	protected DissonanceComms get_Comms() { }

	public bool get_IsColliderTriggered() { }

	protected bool get_TokenActivationState() { }

	public override IEnumerable get_Tokens() { }

	public abstract bool get_UseColliderTrigger() { }

	public bool get_UseTrigger() { }

	[UsedImplicitly]
	protected override void OnDestroy() { }

	[UsedImplicitly]
	protected override void OnDisable() { }

	[UsedImplicitly]
	protected override void OnEnable() { }

	[UsedImplicitly]
	private void OnTriggerEnter(Collider other) { }

	[UsedImplicitly]
	private void OnTriggerEnter2D(Collider2D other) { }

	[UsedImplicitly]
	private void OnTriggerExit(Collider other) { }

	[UsedImplicitly]
	private void OnTriggerExit2D(Collider2D other) { }

	public override bool RemoveToken(string token) { }

	private void set_Comms(DissonanceComms value) { }

	public abstract void set_UseColliderTrigger(bool value) { }

	public void set_UseTrigger(bool value) { }

	[UsedImplicitly]
	protected override void Start() { }

	protected override void TokensModified(string token) { }

	[UsedImplicitly]
	protected override void Update() { }

}

