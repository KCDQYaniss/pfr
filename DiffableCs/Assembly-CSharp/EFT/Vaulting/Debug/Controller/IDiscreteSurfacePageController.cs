namespace EFT.Vaulting.Debug.Controller;

public interface IDiscreteSurfacePageController
{

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnParametersChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnParametersChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnParametersChanged(Action value) { }

	public void SetAsCurrent() { }

}

