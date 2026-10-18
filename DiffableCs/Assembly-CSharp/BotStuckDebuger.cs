//Type is in global namespace

public class BotStuckDebuger : MonoBehaviour
{
	private Dictionary _lastFrame; //Field offset: 0x20
	private Dictionary _collected; //Field offset: 0x28
	private Dictionary _collectedFrames; //Field offset: 0x30
	private IBotGame _botsData; //Field offset: 0x38
	private float _nextError; //Field offset: 0x40

	public Dictionary Collected
	{
		 get { } //Length: 5
	}

	public BotStuckDebuger() { }

	private void Awake() { }

	public Dictionary get_Collected() { }

	private void Update() { }

}

