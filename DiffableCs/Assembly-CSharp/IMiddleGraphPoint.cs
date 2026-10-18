//Type is in global namespace

public interface IMiddleGraphPoint : IMiddleGraphPointIncome, IAICorePointLink
{

	public int CorePointId
	{
		 get { } //Length: 0
	}

	public IReadOnlyList OutgoingWays
	{
		 get { } //Length: 0
	}

	public int get_CorePointId() { }

	public IReadOnlyList get_OutgoingWays() { }

}

