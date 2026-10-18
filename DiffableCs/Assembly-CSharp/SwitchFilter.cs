//Type is in global namespace

public class SwitchFilter : MonoBehaviour
{
	public float RotationSpeed; //Field offset: 0x20
	public AnimationCurve AnimationCurve; //Field offset: 0x28
	private Action _action; //Field offset: 0x30
	private float _t; //Field offset: 0x38
	private float _targetT; //Field offset: 0x3C

	public SwitchFilter() { }

	public void Deinit() { }

	public void Init(Action action) { }

	public void Set(bool isOn, bool initial) { }

	private bool ShouldChange() { }

	private void Update() { }

}

