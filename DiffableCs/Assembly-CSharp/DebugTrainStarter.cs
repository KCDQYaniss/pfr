//Type is in global namespace

public class DebugTrainStarter : MonoBehaviour, IPhysicsTrigger
{
	public bool TrainComeAction; //Field offset: 0x20
	public GameObject GameObject; //Field offset: 0x28
	public GameObject TrainEffect; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x38

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DebugTrainStarter() { }

	private void Awake() { }

	[CompilerGenerated]
	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider other) { }

	public override void OnTriggerExit(Collider col) { }

}

