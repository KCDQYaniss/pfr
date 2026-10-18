namespace EFT.UI;

public sealed class BlockController : BlockControllerBase
{
	private Func _isBlockingFunc; //Field offset: 0x30

	public BlockController(Func isBlockingFunc, CompositeDisposable dispose, string blockKey, string blockReason) { }

	public virtual void Dispose() { }

	protected virtual bool IsBlocking() { }

}

