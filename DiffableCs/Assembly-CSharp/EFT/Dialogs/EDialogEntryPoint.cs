namespace EFT.Dialogs;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.EDialogEntryPoint>))]
public enum EDialogEntryPoint
{
	InLobby = 0,
	InRaid = 1,
	ViaRadio = 2,
	ViaNotebook = 3,
}

