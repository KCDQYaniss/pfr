//Type is in global namespace

public class DecisionQueue : BotData
{
	private readonly Queue _decisionQueue; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 65
	}

	public DecisionQueue(BotOwner owner) { }

	public void Clear() { }

	public DeferredDecision Dequeue() { }

	public void Enqueue(DeferredDecision nextDecision) { }

	public int get_Count() { }

	public bool HaveDeferredDecisions() { }

	public DeferredDecision Peek() { }

}

