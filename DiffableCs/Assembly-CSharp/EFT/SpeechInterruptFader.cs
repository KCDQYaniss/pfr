namespace EFT;

public sealed class SpeechInterruptFader
{
	private bool _pendingFadeIn; //Field offset: 0x10

	public SpeechInterruptFader() { }

	public void BeginFadeOut(BetterSource src, float fadeSec, bool hasReplacement) { }

	public void TryConsumeFadeIn(BetterSource src, float fadeSec) { }

}

