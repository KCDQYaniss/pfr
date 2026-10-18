//Type is in global namespace

public class LookAtProxy : InteractableObject
{
	[CompilerGenerated]
	private Action OnLookAt; //Field offset: 0x48

	public event Action OnLookAt
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public LookAtProxy() { }

	[CompilerGenerated]
	public void add_OnLookAt(Action value) { }

	public void Execute() { }

	[CompilerGenerated]
	public void remove_OnLookAt(Action value) { }

}

