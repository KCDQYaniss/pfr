namespace Diz.Skinning;

public class PluggableBone : MonoBehaviour
{
	[SerializeField]
	public string BonePath; //Field offset: 0x20

	public PluggableBone() { }

	public void Plug(Skeleton skeleton, Vector3 localPosition, Vector3 localRotation) { }

	public void Unplug() { }

}

