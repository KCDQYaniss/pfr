namespace EFT.UI.Screens;

public abstract class BaseScreen`3 : UIScreen
{
	protected TController ScreenController; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; //Field offset: 0x0

	public private bool Destroyed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected BaseScreen`3() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public bool get_Destroyed() { }

	internal void Init(TController controller) { }

	protected virtual void OnDestroy() { }

	[CompilerGenerated]
	private void set_Destroyed(bool value) { }

	public abstract void Show(TController controller) { }

}

