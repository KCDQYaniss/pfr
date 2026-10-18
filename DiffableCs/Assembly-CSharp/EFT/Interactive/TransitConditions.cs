namespace EFT.Interactive;

public sealed class TransitConditions
{
	public bool NeedTimeWindowCondition; //Field offset: 0x10
	public int StartHour; //Field offset: 0x14
	public int EndHour; //Field offset: 0x18
	public string TimeTipKey; //Field offset: 0x20
	public bool NeedConditionalItemCondition; //Field offset: 0x28
	public string FirstItemID; //Field offset: 0x30
	public string SecondItemID; //Field offset: 0x38
	public string ConditionalTipKey; //Field offset: 0x40
	public bool NeedConfirmWindowCondition; //Field offset: 0x48
	public string ConfirmWindowTipKey; //Field offset: 0x50
	public bool CanPassParties; //Field offset: 0x58
	public string CanPassPartiesTip; //Field offset: 0x60
	public bool NeedQuestRequirement; //Field offset: 0x68
	public GlobalsArray QuestTemplateIds; //Field offset: 0x70
	public string QuestRequirementTipKey; //Field offset: 0x78

	public TransitConditions() { }

}

