//Type is in global namespace

public class PlayerAnimationTest : MonoBehaviour
{
	[SerializeField]
	private GameObject _playerPrefab; //Field offset: 0x20
	[SerializeField]
	private int _count; //Field offset: 0x28
	private List _animators; //Field offset: 0x30
	private bool isRunning; //Field offset: 0x38
	private bool isSpam; //Field offset: 0x39

	public PlayerAnimationTest() { }

	private void Awake() { }

	private void Cleanup(GameObject gameObject) { }

	private void Idle() { }

	private void Run() { }

	private void Update() { }

}

