namespace EFT.UI;

public interface IConditionalObjectivesView
{

	public void CloseView() { }

	public void Show(ConditionalController controller, ItemController itemController, ConditionCollection conditions, IConditional conditional) { }

}

