namespace UnityEngine.Timeline;

public class SignalReceiver : MonoBehaviour, INotificationReceiver
{
	private class EventKeyValue
	{
		[SerializeField]
		private List m_Signals; //Field offset: 0x10
		[CustomSignalEventDrawer]
		[SerializeField]
		private List m_Events; //Field offset: 0x18

		public List events
		{
			 get { } //Length: 5
		}

		public List signals
		{
			 get { } //Length: 5
		}

		public EventKeyValue() { }

		public void Append(SignalAsset key, UnityEvent value) { }

		public List get_events() { }

		public List get_signals() { }

		public void Remove(int idx) { }

		public void Remove(SignalAsset key) { }

		public bool TryGetValue(SignalAsset key, out UnityEvent value) { }

	}

	[SerializeField]
	private EventKeyValue m_Events; //Field offset: 0x20

	public SignalReceiver() { }

	public int AddEmptyReaction(UnityEvent reaction) { }

	public void AddReaction(SignalAsset asset, UnityEvent reaction) { }

	public void ChangeReactionAtIndex(int idx, UnityEvent reaction) { }

	public void ChangeSignalAtIndex(int idx, SignalAsset newKey) { }

	public int Count() { }

	public UnityEvent GetReaction(SignalAsset key) { }

	public UnityEvent GetReactionAtIndex(int idx) { }

	public IEnumerable GetRegisteredSignals() { }

	public SignalAsset GetSignalAssetAtIndex(int idx) { }

	private void OnEnable() { }

	public override void OnNotify(Playable origin, INotification notification, object context) { }

	public void Remove(SignalAsset asset) { }

	public void RemoveAtIndex(int idx) { }

}

