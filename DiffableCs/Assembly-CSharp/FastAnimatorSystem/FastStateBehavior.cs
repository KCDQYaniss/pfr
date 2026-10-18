namespace FastAnimatorSystem;

public class FastStateBehavior
{
	private AbstractState _abstractState; //Field offset: 0x10

	public AbstractState AbstractState
	{
		 get { } //Length: 5
	}

	protected FastStateBehavior() { }

	public override FastStateBehavior Clone() { }

	public static TFastAnimatorBehavior Create(AbstractState state) { }

	public override void Deserialize(BinaryReader reader) { }

	public AbstractState get_AbstractState() { }

	public override void OnStateEnter(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public override void OnStateExit(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public override void OnStateMove(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public override void OnStateUpdate(FastAnimatorProcessor fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex) { }

	public override void ResetCache() { }

	public override void Serialize(BinaryWriter writer) { }

}

