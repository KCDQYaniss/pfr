namespace EFT.UI;

public class UITutorialFocusArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action mainClick; //Field offset: 0x10
		public Action shadowClick; //Field offset: 0x18
		public UnityAction <>9__0; //Field offset: 0x20
		public UnityAction <>9__1; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal void <Subscribe>b__0() { }

		internal void <Subscribe>b__1() { }

	}

	[SerializeField]
	private Button[] _mainAreas; //Field offset: 0x20
	[SerializeField]
	private Button[] _shadowAreas; //Field offset: 0x28

	public UITutorialFocusArea() { }

	public void Subscribe(Action mainClick, Action shadowClick) { }

	public void Unsubscribe() { }

}

