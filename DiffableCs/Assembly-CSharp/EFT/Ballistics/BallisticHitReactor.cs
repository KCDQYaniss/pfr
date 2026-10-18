namespace EFT.Ballistics;

public class BallisticHitReactor : IDisposable
{
	private readonly BallisticColliderComposer _collider; //Field offset: 0x10

	public BallisticHitReactor(BallisticColliderComposer collider, Action damageCallback) { }

	public override void Dispose() { }

}

