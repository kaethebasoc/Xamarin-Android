package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnMenuItemSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnMenuItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemSelected:(ILcom/actionbarsherlock/view/MenuItem;)Z:GetOnMenuItemSelected_ILcom_actionbarsherlock_view_MenuItem_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnMenuItemSelectedListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnMenuItemSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnMenuItemSelectedListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnMenuItemSelectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnMenuItemSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnMenuItemSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMenuItemSelected (int p0, com.actionbarsherlock.view.MenuItem p1)
	{
		return n_onMenuItemSelected (p0, p1);
	}

	private native boolean n_onMenuItemSelected (int p0, com.actionbarsherlock.view.MenuItem p1);

	java.util.ArrayList refList;
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
