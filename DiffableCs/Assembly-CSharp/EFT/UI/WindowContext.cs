namespace EFT.UI;

public class WindowContext : IDisposable
{
	[CompilerGenerated]
	private Action OnSelected; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnClose; //Field offset: 0x18

	public event Action OnClose
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public WindowContext() { }

	[CompilerGenerated]
	public void add_OnClose(Action value) { }

	[CompilerGenerated]
	public void add_OnSelected(Action value) { }

	public override void Close() { }

	[CompilerGenerated]
	public void remove_OnClose(Action value) { }

	[CompilerGenerated]
	public void remove_OnSelected(Action value) { }

	public void SetSelected() { }

	private override void System.IDisposable.Dispose() { }

}

