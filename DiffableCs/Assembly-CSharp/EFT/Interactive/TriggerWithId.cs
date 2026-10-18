namespace EFT.Interactive;

public class TriggerWithId : MonoBehaviour, IPhysicsTrigger, IInteractive
{
	[SerializeField]
	private string _id; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x28

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Id
	{
		 get { } //Length: 5
	}

	public TriggerWithId() { }

	protected override void Awake() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public string get_Id() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	public void SetId(string id) { }

	protected override void TriggerEnter(Player player) { }

	protected override void TriggerExit(Player player) { }

}

