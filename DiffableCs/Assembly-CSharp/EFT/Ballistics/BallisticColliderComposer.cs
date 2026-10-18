namespace EFT.Ballistics;

public class BallisticColliderComposer : BallisticCollider
{
	[SerializeField]
	private BallisticCollider[] _ballisticColliders; //Field offset: 0x58

	public BallisticColliderComposer() { }

	public void SubscribeHitAction(Action onHitAction) { }

	public virtual void UnsubscribeHitAction() { }

}

