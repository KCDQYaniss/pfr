namespace EFT.Vaulting.Debug.View;

public interface IDiscreteSurfacePageView : IVaultingDebugPageView
{

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnClickSubmitButton
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnNeedUpdateData
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickSubmitButton(Action value) { }

	[CompilerGenerated]
	public void add_OnNeedUpdateData(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickSubmitButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnNeedUpdateData(Action value) { }

	public void SetParameters(DiscreteSurfaceDataModel model) { }

	public bool TryUpdateGridOptions(out DiscreteSurfaceDataModel model) { }

}

