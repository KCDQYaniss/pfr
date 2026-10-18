//Type is in global namespace

public class ColorBlinker : MonoBehaviour
{
	[SerializeField]
	private Image _target; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _curve; //Field offset: 0x28
	[SerializeField]
	private float _speed; //Field offset: 0x30
	public Color StartColor; //Field offset: 0x34
	public Color EndColor; //Field offset: 0x44

	public ColorBlinker() { }

	private void Update() { }

}

