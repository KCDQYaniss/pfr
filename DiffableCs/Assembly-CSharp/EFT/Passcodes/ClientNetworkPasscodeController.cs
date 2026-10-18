namespace EFT.Passcodes;

public sealed class ClientNetworkPasscodeController : ClientPasscodeController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action unsubAttempt; //Field offset: 0x10
		public Action unsubHints; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <.ctor>b__0() { }

	}

	private readonly Action _unsubscribe; //Field offset: 0x30
	private int _nextRequestId; //Field offset: 0x38
	private string _pendingPasscodeId; //Field offset: 0x40
	private bool _awaitingResponse; //Field offset: 0x48
	private bool _isInit; //Field offset: 0x49

	public ClientNetworkPasscodeController(PasscodeLocationSettings passcodeLocationSettings) { }

	public virtual void Dispose() { }

	protected virtual bool HandleSubmitPasscode(Player player, PasscodeTerminal terminal, string passcode) { }

	private static bool IsTargetPlayer(int playerRaidId) { }

	private void OnPasscodeAttemptResult(PasscodeAttemptResultEvent resultEvent) { }

	private void OnPasscodeInitSync(PasscodeInitSyncEvent initSyncEvent) { }

	private void PlayObserverTerminalSounds(string passcodeId, bool successful, int terminalNetId) { }

}

