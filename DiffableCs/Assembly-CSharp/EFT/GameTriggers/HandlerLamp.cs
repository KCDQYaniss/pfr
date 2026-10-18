namespace EFT.GameTriggers;

public class HandlerLamp : BaseTriggerHandler
{
	[SerializeField]
	private ControlledLampGroup[] _controlledLampGroups; //Field offset: 0x28
	[SerializeField]
	private LampController[] _lampControllers; //Field offset: 0x30
	[SerializeField]
	private string[] _lampControllerIDs; //Field offset: 0x38
	[SerializeField]
	private ulong[] _controlledLampGroupIDs; //Field offset: 0x40
	[SerializeField]
	private bool _state; //Field offset: 0x48
	[SerializeField]
	private bool _isToggleMode; //Field offset: 0x49

	public HandlerLamp() { }

	private void OnTriggerEvent() { }

	private void SetControlledLampGroupState(ControlledLampGroup controlledLampGroup) { }

	private void SetLampControllerState(LampController lampController) { }

	private void Start() { }

}

