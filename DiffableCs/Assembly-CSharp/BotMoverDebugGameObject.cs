//Type is in global namespace

public class BotMoverDebugGameObject : MonoBehaviour
{
	private BotOwner _holder; //Field offset: 0x20
	private Vector3 _lastSetPos; //Field offset: 0x28
	private Vector3 _posToSetup; //Field offset: 0x34
	private Action _setPostion; //Field offset: 0x40
	private float _timeToSetup; //Field offset: 0x48
	private bool _needToSetup; //Field offset: 0x4C
	private bool _isDead; //Field offset: 0x4D

	public BotMoverDebugGameObject() { }

	public void Init(BotOwner holder, Action setPostion) { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	private void OnIPlayerDeadOrUnspawn(IPlayer obj) { }

	public void TeleportBotHere() { }

	private void Update() { }

}

