namespace EFT.Hideout;

[RequireComponent(typeof(QTEController))]
public sealed class HideoutAreaQTEOverlay : UIScreen, IAreaSpecialActionScreen
{
	public static QTEController QteController; //Field offset: 0x0
	private HideoutCameraController _hideoutCameraController; //Field offset: 0x90

	public HideoutAreaQTEOverlay() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public override void Show(HideoutPlayerOwner player, AreaData areaData, HideoutScreenRear hideoutRear) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

