namespace RootMotion.Demos;

public class SlowMo : MonoBehaviour
{
	[SerializeField]
	private KeyCode[] keyCodes; //Field offset: 0x20
	[SerializeField]
	private bool mouse0; //Field offset: 0x28
	[SerializeField]
	private bool mouse1; //Field offset: 0x29
	[SerializeField]
	private float slowMoTimeScale; //Field offset: 0x2C

	public SlowMo() { }

	private bool IsSlowMotion() { }

	private void Update() { }

}

