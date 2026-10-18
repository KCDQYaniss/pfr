namespace EFT.UI.Matchmaker;

public sealed class MatchmakerRaidSettingView : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _valueText; //Field offset: 0x20
	private CanvasGroup _selfCanvasGroup; //Field offset: 0x28

	public MatchmakerRaidSettingView() { }

	private void Awake() { }

	public void Refresh(string value, bool isActive) { }

}

