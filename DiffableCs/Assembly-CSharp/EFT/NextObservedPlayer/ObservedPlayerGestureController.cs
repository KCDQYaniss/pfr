namespace EFT.NextObservedPlayer;

public class ObservedPlayerGestureController
{
	private const float HELLO_TIMEOUT = 5; //Field offset: 0x0
	private ObservedPlayerView _observedPlayer; //Field offset: 0x10
	private float _nextAvailableHelloTime; //Field offset: 0x18

	public ObservedPlayerGestureController() { }

	private void ApplyGestureCommand(GestureCommandMessage gestureCommandMessage) { }

	private bool CheckForInteractWithMyPlayer() { }

	public void Execute(ICommandMessage command) { }

	public void Initialize(ObservedPlayerView observedPlayer) { }

}

