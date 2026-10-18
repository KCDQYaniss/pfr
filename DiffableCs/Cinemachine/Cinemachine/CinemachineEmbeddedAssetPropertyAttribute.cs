namespace Cinemachine;

public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
{
	public bool WarnIfNull; //Field offset: 0x18

	public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false) { }

}

