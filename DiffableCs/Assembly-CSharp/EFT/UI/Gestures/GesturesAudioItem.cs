namespace EFT.UI.Gestures;

public sealed class GesturesAudioItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_HasOnlySituational>b__10_0(GesturesAudioSubItem x) { }

	}

	public bool GroupIsAlwaysOpen; //Field offset: 0x70
	[SerializeField]
	private LocalizedText _nameText; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private GameObject _selectionGlow; //Field offset: 0x88
	[SerializeField]
	private GameObject _subItemsContainer; //Field offset: 0x90
	[SerializeField]
	private GesturesAudioSubItem _subItemTemplate; //Field offset: 0x98
	[SerializeField]
	private List _audioSubItems; //Field offset: 0xA0
	private bool _isOpen; //Field offset: 0xA8

	public IReadOnlyList AudioSubItems
	{
		 get { } //Length: 8
	}

	public bool HasOnlySituational
	{
		 get { } //Length: 355
	}

	public bool IsOpen
	{
		 get { } //Length: 8
		 set { } //Length: 565
	}

	public string LocalizationKey
	{
		 set { } //Length: 317
	}

	public GesturesAudioItem() { }

	private void Awake() { }

	public virtual void Close() { }

	public GestureBaseItem CreateNewPhrase(EPhraseTrigger phrase, bool isSituational) { }

	public IReadOnlyList get_AudioSubItems() { }

	public bool get_HasOnlySituational() { }

	public bool get_IsOpen() { }

	public void set_IsOpen(bool value) { }

	public void set_LocalizationKey(string value) { }

	public void Show(Sprite defaultBackground, Sprite selectedBackground, Color defaultAudioColor, Color selectedAudioColor, GestureCommands binds, HashSet availablePhrases) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

