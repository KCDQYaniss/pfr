namespace EFT.UI;

public sealed class BlockBySettingController`1 : BlockControllerBase
{
	private GameSetting _setting; //Field offset: 0x0
	private Func _isBlockingFunc; //Field offset: 0x0

	public BlockBySettingController`1(GameSetting setting, Func isBlockingFunc, CompositeDisposable dispose, string blockKey, string blockReason) { }

	public virtual void Dispose() { }

	protected virtual bool IsBlocking() { }

	public void Validate(T settingValue) { }

}

