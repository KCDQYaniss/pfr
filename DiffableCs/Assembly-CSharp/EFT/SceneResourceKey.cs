namespace EFT;

[GenerateBinarySerialization]
public class SceneResourceKey : ResourceKey, ISceneResource
{
	[SerializeField]
	private bool _onlyOffline; //Field offset: 0x20

	[IgnoreBinarySerialization]
	public override bool onlyOffline
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public SceneResourceKey() { }

	protected bool Equals(SceneResourceKey other) { }

	public virtual bool Equals(object obj) { }

	public override bool get_onlyOffline() { }

	public void set_onlyOffline(bool value) { }

}

