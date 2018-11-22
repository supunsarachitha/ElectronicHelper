package md513310e207aca80b58e8a2982bc5d83a6;


public class Eor
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ElectronicHelper.GatesActivities.Eor, ElectronicHelper", Eor.class, __md_methods);
	}


	public Eor ()
	{
		super ();
		if (getClass () == Eor.class)
			mono.android.TypeManager.Activate ("ElectronicHelper.GatesActivities.Eor, ElectronicHelper", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
