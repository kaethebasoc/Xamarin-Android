package mono.com.actionbarsherlock.widget;


public class ShareActionProvider_OnShareTargetSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.widget.ShareActionProvider.OnShareTargetSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onShareTargetSelected:(Lcom/actionbarsherlock/widget/ShareActionProvider;Landroid/content/Intent;)Z:GetOnShareTargetSelected_Lcom_actionbarsherlock_widget_ShareActionProvider_Landroid_content_Intent_Handler:Xamarin.ActionbarSherlockBinding.Widget.ShareActionProvider/IOnShareTargetSelectedListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.Widget.ShareActionProvider/IOnShareTargetSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ShareActionProvider_OnShareTargetSelectedListenerImplementor.class, __md_methods);
	}


	public ShareActionProvider_OnShareTargetSelectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ShareActionProvider_OnShareTargetSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.Widget.ShareActionProvider/IOnShareTargetSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onShareTargetSelected (com.actionbarsherlock.widget.ShareActionProvider p0, android.content.Intent p1)
	{
		return n_onShareTargetSelected (p0, p1);
	}

	private native boolean n_onShareTargetSelected (com.actionbarsherlock.widget.ShareActionProvider p0, android.content.Intent p1);

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
