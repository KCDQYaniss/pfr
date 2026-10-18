namespace EFT.Hideout;

public abstract class QTEAction : MonoBehaviour
{

	protected QTEAction() { }

	public abstract Task StartAction(QuickTimeEvent quickTimeEvent) { }

}

