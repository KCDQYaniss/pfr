namespace Game.Hideout;

public abstract class DynamicIterativeTextOutput : MonoBehaviour
{
	[SerializeField]
	private float _iterationShowTime; //Field offset: 0x20
	[SerializeField]
	protected int _iterationsCount; //Field offset: 0x24
	[SerializeField]
	private int _maxLinesShowCount; //Field offset: 0x28
	[SerializeField]
	private bool _loop; //Field offset: 0x2C
	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x30
	private readonly List _showingLines; //Field offset: 0x38
	private readonly List _toShowLines; //Field offset: 0x40
	private float _lastShowTime; //Field offset: 0x48
	private float _deltaShow; //Field offset: 0x4C
	private int _currentIteration; //Field offset: 0x50
	private bool _noLines; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x55

	protected override bool IsComplete
	{
		 get { } //Length: 10
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected DynamicIterativeTextOutput() { }

	private void AddNewLines() { }

	protected override void Clear() { }

	protected abstract string FormatTextLine(string text) { }

	protected override bool get_IsComplete() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	protected abstract List GetNextLines() { }

	public override void Init() { }

	public override void Restart() { }

	[CompilerGenerated]
	protected void set_IsEnabled(bool value) { }

	protected override void StartNextIteration() { }

	protected override void Stop() { }

	private void Update() { }

}

