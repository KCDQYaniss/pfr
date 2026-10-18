namespace Audio.NPC.BtrDriver;

public class BtrDriverDialogueEventHandler : IDialogueEventHandler, IDisposable
{
	private readonly IQueueSpeaker _speaker; //Field offset: 0x10
	[CompilerGenerated]
	private Action EventReceived; //Field offset: 0x18
	private Action _unsubscribeOnDispose; //Field offset: 0x20

	public override event Action EventReceived
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public BtrDriverDialogueEventHandler(IQueueSpeaker speaker) { }

	[CompilerGenerated]
	public override void add_EventReceived(Action value) { }

	public override void Dispose() { }

	private EBtrDriverPhraseTrigger GetStationTrigger(string point) { }

	private void HandleReceivedEvent(EBtrDriverPhraseTrigger trigger) { }

	private void OnBtrFirstPassengerGoIn(BtrFirstPassengerGoInEvent goInEvent) { }

	private void OnBtrIncomingToDestination(BtrIncomingToDestinationGlobalEvent incomingToDestinationEvent) { }

	private void OnBtrReadyToDeparture(BtrReadyToDepartureEvent readyToDepartureEvent) { }

	[CompilerGenerated]
	public override void remove_EventReceived(Action value) { }

	private void SubscribeToEvents() { }

	private void Unsubscribe() { }

}

