namespace EFT;

internal sealed class KnifeInputTranslator : IHandsInputTranslator
{
	private readonly IKnifeController _controller; //Field offset: 0x10

	public KnifeInputTranslator(IKnifeController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

