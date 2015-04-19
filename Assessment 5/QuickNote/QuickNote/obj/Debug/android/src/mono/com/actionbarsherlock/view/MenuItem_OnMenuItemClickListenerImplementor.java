package mono.com.actionbarsherlock.view;


public class MenuItem_OnMenuItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.view.MenuItem.OnMenuItemClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemClick:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnMenuItemClick_Lcom_actionbarsherlock_view_MenuItem_Handler:Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnMenuItemClickListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnMenuItemClickListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MenuItem_OnMenuItemClickListenerImplementor.class, __md_methods);
	}


	public MenuItem_OnMenuItemClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MenuItem_OnMenuItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnMenuItemClickListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMenuItemClick (com.actionbarsherlock.view.MenuItem p0)
	{
		return n_onMenuItemClick (p0);
	}

	private native boolean n_onMenuItemClick (com.actionbarsherlock.view.MenuItem p0);

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
