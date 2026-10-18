namespace EFT.UI;

public class NotesTaskFavoriteButton : UIElement
{
	[SerializeField]
	private GameObject _favoriteRoot; //Field offset: 0x70
	[SerializeField]
	private GameObject _notFavoriteRoot; //Field offset: 0x78
	[SerializeField]
	private Button _favoriteButton; //Field offset: 0x80
	[SerializeField]
	private Button _notFavoriteButton; //Field offset: 0x88
	[SerializeField]
	private Image _favoriteBackground; //Field offset: 0x90
	[SerializeField]
	private Color _openColor; //Field offset: 0x98
	[SerializeField]
	private Color _closeColor; //Field offset: 0xA8
	private FavoriteQuestManager _favoriteQuests; //Field offset: 0xB8
	private string _questId; //Field offset: 0xC0

	public NotesTaskFavoriteButton() { }

	public void Init(string questId, FavoriteQuestManager favoriteQuests) { }

	public void SetOpenState(bool isOpen) { }

	private void Start() { }

	private void ToggleFavorite() { }

	private void ValidateFavorite() { }

}

