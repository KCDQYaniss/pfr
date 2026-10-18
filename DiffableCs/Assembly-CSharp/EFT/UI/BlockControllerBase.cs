namespace EFT.UI;

public abstract class BlockControllerBase : IDisposable
{
	private readonly string _blockKey; //Field offset: 0x10
	private readonly string _blockReason; //Field offset: 0x18
	protected readonly List Blockers; //Field offset: 0x20
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x28

	public BlockControllerBase(string blockKey, string blockReason, CompositeDisposable dispose) { }

	public void AddBlocker(UiElementBlocker blocker, bool validate = true) { }

	protected void Block(UiElementBlocker blocker, bool block) { }

	public override void Dispose() { }

	protected abstract bool IsBlocking() { }

	public void Validate() { }

}

