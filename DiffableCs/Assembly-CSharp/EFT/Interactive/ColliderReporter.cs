namespace EFT.Interactive;

[RequireComponent(typeof(Collider))]
public class ColliderReporter : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private Action OnTriggerEnterEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnTriggerExitEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Collider <Collider>k__BackingField; //Field offset: 0x30
	public List Owners; //Field offset: 0x38
	public bool IsInverse; //Field offset: 0x40
	public bool Entered; //Field offset: 0x41
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x48

	public event Action OnTriggerEnterEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTriggerExitEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private Collider Collider
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ColliderReporter() { }

	[CompilerGenerated]
	public void add_OnTriggerEnterEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnTriggerExitEvent(Action value) { }

	public void AddOwner(MonoBehaviour disablerCullingObject) { }

	private void Awake() { }

	[CompilerGenerated]
	public Collider get_Collider() { }

	[CompilerGenerated]
	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	[Conditional("UNITY_EDITOR")]
	private void NullChecks() { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	[CompilerGenerated]
	public void remove_OnTriggerEnterEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnTriggerExitEvent(Action value) { }

	public void RemoveOwner(MonoBehaviour disablerCullingObject) { }

	[CompilerGenerated]
	private void set_Collider(Collider value) { }

}

