namespace EFT.Hideout;

public sealed class HideoutAreaTrigger : MonoBehaviour, IPhysicsTrigger
{
	[SerializeField]
	private List _levelTriggers; //Field offset: 0x20
	private HideoutArea _area; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x30

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public HideoutAreaTrigger() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public void Init(HideoutArea area) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

}

