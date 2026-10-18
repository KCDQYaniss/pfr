//Type is in global namespace

public class ManualCoroutine
{
	public BotOwner Bo; //Field offset: 0x10
	private readonly List _myCoroutines; //Field offset: 0x18

	public ManualCoroutine() { }

	public void StartCoroutine(IEnumerator coroutine) { }

	public void Update() { }

	private void UpdateCoroutine(Stack coroutineStack) { }

}

