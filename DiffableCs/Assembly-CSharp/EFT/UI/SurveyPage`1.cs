namespace EFT.UI;

public abstract class SurveyPage`1 : UIElement, IPage
{
	[CompilerGenerated]
	private Action backwardButtonPressed; //Field offset: 0x0
	[CompilerGenerated]
	private Action forwardButtonPressed; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _backwardButton; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _forwardButton; //Field offset: 0x0

	public override event Action backwardButtonPressed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action forwardButtonPressed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected SurveyPage`1() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	[CompilerGenerated]
	private void <Awake>b__8_1() { }

	[CompilerGenerated]
	public override void add_backwardButtonPressed(Action value) { }

	[CompilerGenerated]
	public override void add_forwardButtonPressed(Action value) { }

	private void Awake() { }

	[CompilerGenerated]
	public override void remove_backwardButtonPressed(Action value) { }

	[CompilerGenerated]
	public override void remove_forwardButtonPressed(Action value) { }

	public abstract void Show(T data) { }

}

