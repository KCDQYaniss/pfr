//Type is in global namespace

[UsedImplicitly]
public class TimerText : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x20
	private DateTime _startTime; //Field offset: 0x28

	public TimerText() { }

	public void Hide() { }

	public void Show(DateTime startTime) { }

	[UsedImplicitly]
	private void Update() { }

}

