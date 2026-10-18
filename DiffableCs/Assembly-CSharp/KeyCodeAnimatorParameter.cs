//Type is in global namespace

public class KeyCodeAnimatorParameter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Animator animator; //Field offset: 0x10
		public KeyCodeAnimatorParameter <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <SetupBoolActions>b__0() { }

		internal void <SetupBoolActions>b__1() { }

	}

	public KeyCode PositiveKeyCode; //Field offset: 0x10
	public KeyCode NegativeKeyCode; //Field offset: 0x14
	public string Parameter; //Field offset: 0x18
	private Action PositiveAction; //Field offset: 0x20
	private Action NegativeAction; //Field offset: 0x28
	[SerializeField]
	private bool _isSetted; //Field offset: 0x30

	public KeyCodeAnimatorParameter() { }

	[CompilerGenerated]
	private bool <SetupActions>b__7_0(AnimatorControllerParameter parameter) { }

	public void ProcessInput(Animator animator) { }

	private void SetupActions(Animator animator) { }

	private void SetupBoolActions(Animator animator) { }

}

