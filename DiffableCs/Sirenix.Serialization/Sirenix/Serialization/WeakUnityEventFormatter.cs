namespace Sirenix.Serialization;

public class WeakUnityEventFormatter : WeakReflectionFormatter
{

	public WeakUnityEventFormatter(Type serializedType) { }

	protected virtual object GetUninitializedObject() { }

}

