namespace EFT;

public abstract class BaseProfileVariable
{
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x10

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected BaseProfileVariable() { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	public abstract int GetValue() { }

	protected void InvokeOnValueChanged(int value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	public abstract void SetValue(int value) { }

}

