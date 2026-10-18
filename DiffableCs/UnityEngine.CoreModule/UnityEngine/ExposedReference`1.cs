namespace UnityEngine;

[UsedByNativeCode(Name = "ExposedReference")]
public struct ExposedReference`1
{
	[SerializeField]
	public PropertyName exposedName; //Field offset: 0x0
	[SerializeField]
	public Object defaultValue; //Field offset: 0x0

	public T Resolve(IExposedPropertyTable resolver) { }

}

