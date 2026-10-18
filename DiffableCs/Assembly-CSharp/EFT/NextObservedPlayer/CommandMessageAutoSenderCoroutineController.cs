namespace EFT.NextObservedPlayer;

public class CommandMessageAutoSenderCoroutineController : MonoBehaviour
{
	private List _listActiveCoroutines; //Field offset: 0x20

	public CommandMessageAutoSenderCoroutineController() { }

	private void OnDestroy() { }

	public void StartAutoSenderCoroutine(CommandMessageAutoSender autoSender) { }

	public void StopAllAutoSendersCoroutines() { }

}

