namespace EFT;

internal sealed class DummyHandsInputTranslator : IHandsInputTranslator
{

	public DummyHandsInputTranslator() { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

