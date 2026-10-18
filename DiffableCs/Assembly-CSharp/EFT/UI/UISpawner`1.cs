namespace EFT.UI;

public class UISpawner`1 : UIElement
{
	[SerializeField]
	protected T _object; //Field offset: 0x0
	[SerializeField]
	protected string _headerCaption; //Field offset: 0x0
	[SerializeField]
	protected int _headerFontSize; //Field offset: 0x0
	[SerializeField]
	protected List _preservedChildren; //Field offset: 0x0
	[SerializeField]
	protected float _minWidth; //Field offset: 0x0
	[SerializeField]
	protected bool _useEllipsis; //Field offset: 0x0
	private Action _localizationSubscription; //Field offset: 0x0
	private T _spawnedObject; //Field offset: 0x0

	public T SpawnedObject
	{
		 get { } //Length: 334
	}

	public UISpawner`1() { }

	private void Cleanup() { }

	public T get_SpawnedObject() { }

	private void OnDestroy() { }

	protected override void SetEllipsis(bool useEllipsis) { }

	internal override void SetHeaderText(string caption, int size) { }

	protected override void SetMinWidth(float minWidth) { }

	protected override T SpawnObject() { }

	private void UpdateSpawnerLocale() { }

}

