namespace Diz.Skinning;

public abstract class AbstractSkin : MonoBehaviour
{
	protected Action _unsubscribe; //Field offset: 0x20

	public abstract SkinnedMeshRenderer SkinnedMeshRenderer
	{
		 get { } //Length: 0
	}

	protected AbstractSkin() { }

	public abstract void ApplySkin() { }

	public abstract SkinnedMeshRenderer get_SkinnedMeshRenderer() { }

	public abstract void Unskin() { }

	protected void Unsubscribe() { }

}

