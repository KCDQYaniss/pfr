namespace Steamworks;

public struct SteamInputActionEvent_t
{
	internal struct AnalogAction_t
	{
		public InputAnalogActionHandle_t actionHandle; //Field offset: 0x0
		public InputAnalogActionData_t analogActionData; //Field offset: 0x8

	}

	internal struct DigitalAction_t
	{
		public InputDigitalActionHandle_t actionHandle; //Field offset: 0x0
		public InputDigitalActionData_t digitalActionData; //Field offset: 0x8

	}

	internal struct OptionValue
	{
		public AnalogAction_t analogAction; //Field offset: 0x0
		public DigitalAction_t digitalAction; //Field offset: 0x0

	}

	public InputHandle_t controllerHandle; //Field offset: 0x0
	public ESteamInputActionEventType eEventType; //Field offset: 0x8
	public OptionValue m_val; //Field offset: 0x10

}

