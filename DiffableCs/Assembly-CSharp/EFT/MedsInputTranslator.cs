namespace EFT;

internal sealed class MedsInputTranslator : IHandsInputTranslator
{
	private readonly IMedsController _controller; //Field offset: 0x10

	internal MedsInputTranslator(IMedsController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

