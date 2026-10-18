namespace EFT.UI;

public sealed class UiElementBlocker : MonoBehaviour
{
	private const string COMMON_BLOCK_SOURCE = "Common"; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup Group; //Field offset: 0x20
	[SerializeField]
	private Graphic Graphic; //Field offset: 0x28
	[SerializeField]
	private HoverTooltipAreaBase Tooltip; //Field offset: 0x30
	private readonly Dictionary _blockReasons; //Field offset: 0x38
	private string _currentReason; //Field offset: 0x40
	private bool _isBlocking; //Field offset: 0x48

	public Transform Container
	{
		 get { } //Length: 90
	}

	public bool IsBlocking
	{
		 get { } //Length: 5
	}

	public UiElementBlocker() { }

	public Transform get_Container() { }

	public bool get_IsBlocking() { }

	public void RemoveBlock(string blockSource = null) { }

	public void SetBlock(bool block, string reasonKey = null, string blockSource = null) { }

	public void StartBlock(string blockSource = null) { }

	public void StartBlock(string reason, string blockSource) { }

	public bool TryGetTooltip(out T tooltip) { }

}

