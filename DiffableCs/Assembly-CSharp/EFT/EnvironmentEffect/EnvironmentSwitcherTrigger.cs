namespace EFT.EnvironmentEffect;

[Obsolete]
[RequireComponent(typeof(Collider))]
public class EnvironmentSwitcherTrigger : MonoBehaviour, IPhysicsTriggerWithStay, IPhysicsTrigger
{
	[Header("Синяя стрелка (ось Z) должна указывать наружу помещения")]
	public float MaxDaylight; //Field offset: 0x20
	public bool ChangeHarmonics; //Field offset: 0x24
	public float FadeTime; //Field offset: 0x28
	public Color IndorColor; //Field offset: 0x2C
	[Space(15)]
	public float SSAOIntensity; //Field offset: 0x3C
	public int IndorShadowDistance; //Field offset: 0x40
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x48

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EnvironmentSwitcherTrigger() { }

	[CompilerGenerated]
	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private override void IPhysicsTriggerWithStay.OnTriggerStayCustom(Collider enteredCollider, Collider triggerCollider) { }

	public void OnDrawGizmos() { }

	public void OnDrawGizmosSelected() { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

}

