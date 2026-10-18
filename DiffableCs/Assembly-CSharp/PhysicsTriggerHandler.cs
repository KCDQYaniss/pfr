//Type is in global namespace

public class PhysicsTriggerHandler : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private Action OnTriggerEnter; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnTriggerExit; //Field offset: 0x28
	public Collider trigger; //Field offset: 0x30

	public event Action OnTriggerEnter
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTriggerExit
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override string Description
	{
		 get { } //Length: 49
	}

	public PhysicsTriggerHandler() { }

	[CompilerGenerated]
	public void add_OnTriggerEnter(Action value) { }

	[CompilerGenerated]
	public void add_OnTriggerExit(Action value) { }

	private void Awake() { }

	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.OnTriggerEnter(Collider col) { }

	private override void IPhysicsTrigger.OnTriggerExit(Collider col) { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void remove_OnTriggerEnter(Action value) { }

	[CompilerGenerated]
	public void remove_OnTriggerExit(Action value) { }

}

