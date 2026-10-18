namespace EFT;

public abstract class BaseEventConsumer : IPlayerEventsConsumer
{
	protected Dictionary _bindedFunctions; //Field offset: 0x10

	public override Dictionary BindedFunctions
	{
		 get { } //Length: 5
	}

	protected BaseEventConsumer() { }

	public override Dictionary get_BindedFunctions() { }

}

