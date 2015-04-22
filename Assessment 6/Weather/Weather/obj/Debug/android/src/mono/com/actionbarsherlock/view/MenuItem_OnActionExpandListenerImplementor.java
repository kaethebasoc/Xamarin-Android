package mono.com.actionbarsherlock.view;


public class MenuItem_OnActionExpandListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.view.MenuItem.OnActionExpandListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMenuItemActionCollapse:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnMenuItemActionCollapse_Lcom_actionbarsherlock_view_MenuItem_Handler:Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnActionExpandListenerInvoker, ActionBarSherlock\n" +
			"n_onMenuItemActionExpand:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnMenuItemActionExpand_Lcom_actionbarsherlock_view_MenuItem_Handler:Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnActionExpandListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnActionExpandListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MenuItem_OnActionExpandListenerImplementor.class, __md_methods);
	}


	public MenuItem_OnActionExpandListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MenuItem_OnActionExpandListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.Views.IMenuItemOnActionExpandListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMenuItemActionCollapse (com.actionbarsherlock.view.MenuItem p0)
	{
		return n_onMenuItemActionCollapse (p0);
	}

	private native boolean n_onMenuItemActionCollapse (com.actionbarsherlock.view.MenuItem p0);


	public boolean onMenuItemActionExpand (com.actionbarsherlock.view.MenuItem p0)
	{
		return n_onMenuItemActionExpand (p0);
	}

	private native boolean n_onMenuItemActionExpand (com.actionbarsherlock.view.MenuItem p0);

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
