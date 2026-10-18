//Type is in global namespace

public class BotActivityTerminal : MonoBehaviour
{
	public static BotActivityTerminal Instance; //Field offset: 0x0
	public bool BotsIsActive; //Field offset: 0x20
	private Action _unsubscribeOnDestroy; //Field offset: 0x28

	public BotActivityTerminal() { }

	public void Awake() { }

	private void CutSceneChangeBotStateHandler(CutSceneChangeBotState eventChaneState) { }

	private void OnDestroy() { }

}

