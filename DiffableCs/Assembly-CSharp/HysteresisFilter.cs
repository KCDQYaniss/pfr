//Type is in global namespace

public class HysteresisFilter : MonoBehaviour
{
	public AnimationCurve Forward; //Field offset: 0x20
	public AnimationCurve Backward; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnEnd; //Field offset: 0x30
	private Action _action; //Field offset: 0x38
	private bool _direction; //Field offset: 0x40
	private float _t; //Field offset: 0x44
	private float _targetT; //Field offset: 0x48
	private float _currentValue; //Field offset: 0x4C
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x50

	public event Action OnEnd
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool Direction
	{
		 get { } //Length: 5
	}

	public HysteresisFilter() { }

	[CompilerGenerated]
	public void add_OnEnd(Action value) { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	public void Deinit() { }

	public bool get_Direction() { }

	public void Init(Action action) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnEnd(Action value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	public void Set(bool isOn, bool initial) { }

	private bool ShouldChange() { }

	private void Update() { }

}

