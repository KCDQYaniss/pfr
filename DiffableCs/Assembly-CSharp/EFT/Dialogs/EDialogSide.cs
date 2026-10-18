namespace EFT.Dialogs;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.EDialogSide>))]
public enum EDialogSide
{
	Player = 0,
	Npc = 1,
}

