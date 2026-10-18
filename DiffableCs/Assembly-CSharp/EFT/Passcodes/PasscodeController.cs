namespace EFT.Passcodes;

public abstract class PasscodeController : IDisposable
{
	protected Dictionary _passcodeTerminals; //Field offset: 0x10
	protected Dictionary _hintGroups; //Field offset: 0x18
	protected readonly PasscodeLocationSettings _passcodeLocationSettings; //Field offset: 0x20

	protected PasscodeController(PasscodeLocationSettings passcodeLocationSettings) { }

	public override void Dispose() { }

	protected Dictionary GenerateHints(Dictionary generatedPasscodes) { }

	private void GetAllHintGroups() { }

	private void GetAllTerminals() { }

}

