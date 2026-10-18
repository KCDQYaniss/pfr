namespace Cutscene;

public class InteractiveObjectCutsceneTrigger : BaseCutsceneTrigger
{
	private class StartCutsceneCondition
	{
		public EDoorState prevObjectState; //Field offset: 0x10
		public EDoorState nextObjectState; //Field offset: 0x11

		public StartCutsceneCondition() { }

		public bool IsPassingCondition(EDoorState prevState, EDoorState nextState) { }

	}

	[SerializeField]
	private WorldInteractiveObject interactiveObject; //Field offset: 0x80
	[SerializeField]
	private StartCutsceneCondition condition; //Field offset: 0x88

	public InteractiveObjectCutsceneTrigger() { }

	protected virtual void Awake() { }

	private void OnDoorStartOpening() { }

	private void OnDoorStateChanged(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

}

