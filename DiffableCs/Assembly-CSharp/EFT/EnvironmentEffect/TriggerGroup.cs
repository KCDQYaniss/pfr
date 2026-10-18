namespace EFT.EnvironmentEffect;

public class TriggerGroup : MonoBehaviour, IAABB
{
	[SerializeField]
	public Bounds Bounds; //Field offset: 0x20
	[SerializeField]
	public List _childrenTriggers; //Field offset: 0x38
	[SerializeField]
	public List _childrenGroups; //Field offset: 0x40

	public TriggerGroup() { }

	[CompilerGenerated]
	private bool <Reinit>b__5_0(TriggerGroup t) { }

	private void Awake() { }

	[CanBeNull]
	public override IndoorTrigger Check(Vector3 pos) { }

	private void EncapsulateBounds(Bounds bound) { }

	private void OnDrawGizmosSelected() { }

	public void OnValidate() { }

	public override void Reinit() { }

}

