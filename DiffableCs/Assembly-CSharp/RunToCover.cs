//Type is in global namespace

public class RunToCover : MoveNode
{
	public bool CanChangeDecision; //Field offset: 0x28

	protected override bool UseZigZag
	{
		 get { } //Length: 3
	}

	public RunToCover(BotOwner bot) { }

	protected override bool get_UseZigZag() { }

	public virtual void UpdateNodeByBrain(MoveToCoverActionResultData data) { }

}

