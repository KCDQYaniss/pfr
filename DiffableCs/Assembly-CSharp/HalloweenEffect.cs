//Type is in global namespace

public abstract class HalloweenEffect : MonoBehaviour
{
	private IEnumerator _coroutine; //Field offset: 0x20

	protected HalloweenEffect() { }

	protected void Abort() { }

	public void Process() { }

	protected abstract IEnumerator RunProcess() { }

}

