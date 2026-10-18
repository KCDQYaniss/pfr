//Type is in global namespace

public abstract class AICoreNode`1 : AICoreNode
{

	protected AICoreNode`1() { }

	public override void Awake() { }

	public abstract void UpdateNodeByBrain(T data) { }

	public virtual void UpdateNodeByMain(CoreActionResultParams lastResultData) { }

}

