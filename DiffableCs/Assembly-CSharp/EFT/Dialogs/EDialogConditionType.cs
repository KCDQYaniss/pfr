namespace EFT.Dialogs;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.EDialogConditionType>))]
public enum EDialogConditionType
{
	VariableValue = 0,
	QuestStatus = 1,
	TraderReputation = 2,
	QuestConditionStatus = 3,
	HasNewQuests = 4,
	MainLogicalGroup = 5,
	LogicalSubGroup = 6,
	HasItemForHandover = 7,
	ServiceAvailable = 8,
	CurrentTrader = 9,
	HasFreeSpecialSlot = 10,
	CompletableItem = 11,
}

