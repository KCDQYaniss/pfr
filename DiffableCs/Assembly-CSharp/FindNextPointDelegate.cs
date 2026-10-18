//Type is in global namespace

public sealed class FindNextPointDelegate : MulticastDelegate
{

	public FindNextPointDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(bool withSetting, bool withoutNext, int minSubTargets, bool canCut, PatrolPointFilterDelegate pointFilter, AsyncCallback callback, object object) { }

	public override PatrolPointContainer EndInvoke(IAsyncResult result) { }

	public override PatrolPointContainer Invoke(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

}

