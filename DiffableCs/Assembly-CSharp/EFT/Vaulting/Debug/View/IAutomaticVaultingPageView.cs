namespace EFT.Vaulting.Debug.View;

public interface IAutomaticVaultingPageView : IVaultingDebugPageView
{

	public event Action OnClickAutomaticClimbToggle
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnClickAutomaticVaultToggle
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnClickSublitButton
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnClickAutomaticClimbToggle(Action value) { }

	[CompilerGenerated]
	public void add_OnClickAutomaticVaultToggle(Action value) { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnClickSublitButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickAutomaticClimbToggle(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickAutomaticVaultToggle(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnClickSublitButton(Action value) { }

	public void SetParameters(AutomaticVaultingDataModel model) { }

	public bool TryUpdateGridOptions(out AutomaticVaultingDataModel model) { }

}

