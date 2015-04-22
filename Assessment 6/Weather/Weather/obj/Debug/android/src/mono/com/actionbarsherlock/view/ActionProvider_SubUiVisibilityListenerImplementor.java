package mono.com.actionbarsherlock.view;


public class ActionProvider_SubUiVisibilityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.view.ActionProvider.SubUiVisibilityListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSubUiVisibilityChanged:(Z)V:GetOnSubUiVisibilityChanged_ZHandler:Xamarin.ActionbarSherlockBinding.Views.ActionProvider/ISubUiVisibilityListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.Views.ActionProvider/ISubUiVisibilityListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionProvider_SubUiVisibilityListenerImplementor.class, __md_methods);
	}


	public ActionProvider_SubUiVisibilityListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionProvider_SubUiVisibilityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.Views.ActionProvider/ISubUiVisibilityListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSubUiVisibilityChanged (boolean p0)
	{
		n_onSubUiVisibilityChanged (p0);
	}

	private native void n_onSubUiVisibilityChanged (boolean p0);

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
