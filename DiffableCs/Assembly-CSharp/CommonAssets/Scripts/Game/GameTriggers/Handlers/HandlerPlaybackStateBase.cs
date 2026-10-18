namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public abstract class HandlerPlaybackStateBase : HandlerStateBase
{

	protected override bool IsPlaybackActive
	{
		 get { } //Length: 3
	}

	protected HandlerPlaybackStateBase() { }

	protected override void ApplyPlaybackElapsed(double elapsedSeconds) { }

	public void ApplyPlaybackSnapshot(in PlaybackSnapshot playbackSnapshot) { }

	protected override bool get_IsPlaybackActive() { }

	protected override void StopPlayback() { }

}

