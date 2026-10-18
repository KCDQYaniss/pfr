namespace EFT;

public interface IPlayerInputTranslator
{

	public event Action OnMakeBindAction
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnMumbleDropdownStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnMumbleStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnQuickMumble
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public void add_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnQuickMumble(Action value) { }

	[CompilerGenerated]
	public void remove_OnMakeBindAction(Action value) { }

	[CompilerGenerated]
	public void remove_OnMumbleDropdownStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnMumbleStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnQuickMumble(Action value) { }

	public void TranslateAxes(ref float[] axes) { }

	public ETranslateResult TranslateCommand(ECommand command) { }

}

