//Type is in global namespace

public abstract class AICoreNode
{

	protected AICoreNode() { }

	public override void Dispose() { }

	public abstract void UpdateNodeByMain(CoreActionResultParams lastResultData) { }

}

