namespace uLipSync.Timeline;

[ExecuteAlways]
public class uLipSyncTimelineEvent : MonoBehaviour
{
	public LipSyncUpdateEvent onLipSyncUpdate; //Field offset: 0x20
	private BakedFrame _frame; //Field offset: 0x28
	private bool _isTimelineActive; //Field offset: 0x38

	public uLipSyncTimelineEvent() { }

	public void OnFrame(BakedFrame frame) { }

	public void OnStop() { }

	private void Update() { }

}

