//Type is in global namespace

[ExecuteInEditMode]
public abstract class UpdateInEditorSystemComponent`1 : BaseSystemComponent
{

	protected UpdateInEditorSystemComponent`1() { }

	public abstract void ManualUpdate(float deltaTime) { }

	protected override void OnDestroy() { }

}

