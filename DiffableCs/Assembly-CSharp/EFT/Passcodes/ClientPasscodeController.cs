namespace EFT.Passcodes;

public abstract class ClientPasscodeController : PasscodeController
{
	[CompilerGenerated]
	private Action OnPasscodeInteracted; //Field offset: 0x28

	public event Action OnPasscodeInteracted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected ClientPasscodeController(PasscodeLocationSettings passcodeLocationSettings) { }

	[CompilerGenerated]
	public void add_OnPasscodeInteracted(Action value) { }

	public static bool Exist(out ClientPasscodeController controller) { }

	protected abstract bool HandleSubmitPasscode(Player player, PasscodeTerminal terminal, string passcode) { }

	protected void RaiseInteractionResult(string passcodeId, bool successful) { }

	[CompilerGenerated]
	public void remove_OnPasscodeInteracted(Action value) { }

	protected void SetupHints(Dictionary generatedHints) { }

	public bool SubmitPasscode(Player player, PasscodeTerminal terminal, string passcode) { }

}

