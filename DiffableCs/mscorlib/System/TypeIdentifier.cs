namespace System;

internal interface TypeIdentifier : TypeName, IEquatable
{

	public string InternalName
	{
		 get { } //Length: 0
	}

	public string get_InternalName() { }

}

