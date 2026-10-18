namespace AnimationEventSystem;

[CreateAssetMenu]
public class AnimatorControllerStaticData : ScriptableObject
{
	[SerializeField]
	private List _stateHashToEventsCollection; //Field offset: 0x18
	[SerializeField]
	private List _stateHashToLActionSetups; //Field offset: 0x20

	public AnimatorControllerStaticData() { }

	[CanBeNull]
	public List GetEventsByIndex(int index) { }

	public LActionSetup GetLActionSetupById(int lActionSetupId) { }

	public bool IsValidListIndex(int index) { }

}

