namespace EFT;

public interface IHandsInputTranslator
{

	public void TranslateAxes(ref float[] axes) { }

	public ETranslateResult TranslateCommand(ECommand command) { }

}

