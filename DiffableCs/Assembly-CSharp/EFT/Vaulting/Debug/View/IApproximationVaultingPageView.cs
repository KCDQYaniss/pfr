namespace EFT.Vaulting.Debug.View;

public interface IApproximationVaultingPageView : IVaultingDebugPageView
{

	public event Action OnClickBackButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnClickSubmitButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnClickBackButtonEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnClickSubmitButtonEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickBackButtonEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickSubmitButtonEvent(Action value) { }

	public void SetParameters(ApproximationVaultingDataModel model) { }

	public bool TryToApplyParameters(out ApproximationVaultingDataModel newModel) { }

}

