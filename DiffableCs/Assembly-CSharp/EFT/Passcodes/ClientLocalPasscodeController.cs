namespace EFT.Passcodes;

public class ClientLocalPasscodeController : ClientPasscodeController
{
	private Dictionary _generatedPasscodes; //Field offset: 0x30
	private Dictionary _generatedHints; //Field offset: 0x38

	public ClientLocalPasscodeController(PasscodeLocationSettings passcodeLocationSettings) { }

	protected virtual bool HandleSubmitPasscode(Player player, PasscodeTerminal terminal, string passcode) { }

}

