namespace EFT.Hideout.ShootingRange;

public class ShootingAreaTrigger : MonoBehaviour, IPhysicsTrigger
{
	[SerializeField]
	private InteractiveShootingRange[] _targetControllers; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x28

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ShootingAreaTrigger() { }

	[CompilerGenerated]
	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider collider) { }

	public override void OnTriggerExit(Collider collider) { }

}

