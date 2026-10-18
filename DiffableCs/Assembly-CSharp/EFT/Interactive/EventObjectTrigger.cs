namespace EFT.Interactive;

public class EventObjectTrigger : MonoBehaviour, IPhysicsTrigger
{
	[SerializeField]
	private EventObject _object; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Inside>k__BackingField; //Field offset: 0x28

	public override string Description
	{
		 get { } //Length: 201
	}

	public private bool Inside
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EventObjectTrigger() { }

	public override string get_Description() { }

	[CompilerGenerated]
	public bool get_Inside() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private static bool IsLocalPlayer(Collider col, out Player player) { }

	private bool IsValid(Player player) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	[CompilerGenerated]
	private void set_Inside(bool value) { }

	private static bool TryGetPlayer(Collider col, out Player player) { }

}

