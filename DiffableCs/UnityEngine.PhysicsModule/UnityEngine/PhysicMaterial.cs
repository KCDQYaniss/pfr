namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicMaterial.h")]
public class PhysicMaterial : Object
{

	public PhysicMaterialCombine bounceCombine
	{
		 set { } //Length: 91
	}

	public float bounciness
	{
		 set { } //Length: 94
	}

	public float dynamicFriction
	{
		 set { } //Length: 94
	}

	public PhysicMaterialCombine frictionCombine
	{
		 set { } //Length: 91
	}

	public float staticFriction
	{
		 set { } //Length: 94
	}

	public PhysicMaterial() { }

	public PhysicMaterial(string name) { }

	private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }

	public void set_bounceCombine(PhysicMaterialCombine value) { }

	public void set_bounciness(float value) { }

	public void set_dynamicFriction(float value) { }

	public void set_frictionCombine(PhysicMaterialCombine value) { }

	public void set_staticFriction(float value) { }

}

