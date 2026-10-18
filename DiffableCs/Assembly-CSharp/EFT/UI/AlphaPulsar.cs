namespace EFT.UI;

public class AlphaPulsar : MonoBehaviour
{
	[SerializeField]
	public float _minAlpha; //Field offset: 0x20
	[SerializeField]
	public float _maxAlpha; //Field offset: 0x24
	[SerializeField]
	public float _duration; //Field offset: 0x28
	[SerializeField]
	private Image _image; //Field offset: 0x30
	[SerializeField]
	private bool _autoControl; //Field offset: 0x38
	private Tween _alphaTween; //Field offset: 0x40

	public AlphaPulsar() { }

	private void Init() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Restart() { }

	public void StartPulse() { }

	public void StopPulse() { }

}

