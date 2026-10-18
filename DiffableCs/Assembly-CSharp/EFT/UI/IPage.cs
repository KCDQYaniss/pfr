namespace EFT.UI;

public interface IPage
{

	public event Action backwardButtonPressed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action forwardButtonPressed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_backwardButtonPressed(Action value) { }

	[CompilerGenerated]
	public void add_forwardButtonPressed(Action value) { }

	public void Close() { }

	[CompilerGenerated]
	public void remove_backwardButtonPressed(Action value) { }

	[CompilerGenerated]
	public void remove_forwardButtonPressed(Action value) { }

}

