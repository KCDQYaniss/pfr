namespace EFT.UI;

public sealed class EditTagWindowContext : WindowContext
{
	[CompilerGenerated]
	private Action OnSave; //Field offset: 0x20

	public event Action OnSave
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public EditTagWindowContext() { }

	[CompilerGenerated]
	public void add_OnSave(Action value) { }

	[CompilerGenerated]
	public void remove_OnSave(Action value) { }

	public void Save(string tag, int index) { }

}

