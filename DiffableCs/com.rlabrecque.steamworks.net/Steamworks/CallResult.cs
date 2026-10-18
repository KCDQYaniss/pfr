namespace Steamworks;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public abstract class CallResult
{

	protected CallResult() { }

	protected private abstract Type GetCallbackType() { }

	protected private abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall) { }

	protected private abstract void SetUnregistered() { }

}

