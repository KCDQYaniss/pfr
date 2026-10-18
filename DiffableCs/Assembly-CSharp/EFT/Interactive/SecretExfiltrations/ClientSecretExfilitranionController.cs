namespace EFT.Interactive.SecretExfiltrations;

public class ClientSecretExfilitranionController : SecretExfilitranionController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SecretExfiltrationPointFoundShareEvent data; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <OnNewExitFoundShared>b__0(SecretExfiltrationPoint point) { }

	}

	private readonly Action _unsub; //Field offset: 0x18

	public ClientSecretExfilitranionController(ExfiltrationController exfiltrationController) { }

	public virtual void Dispose() { }

	private bool IsTargetPlayer(string teamId, string groupId) { }

	private void OnNewExitFoundSelf(string exitName, bool shareExit) { }

	private void OnNewExitFoundShared(SecretExfiltrationPointFoundShareEvent data) { }

}

