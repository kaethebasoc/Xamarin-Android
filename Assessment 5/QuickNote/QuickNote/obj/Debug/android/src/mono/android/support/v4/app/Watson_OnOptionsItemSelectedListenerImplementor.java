package mono.android.support.v4.app;


public class Watson_OnOptionsItemSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app.Watson.OnOptionsItemSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onOptionsItemSelected:(Lcom/actionbarsherlock/view/MenuItem;)Z:GetOnOptionsItemSelected_Lcom_actionbarsherlock_view_MenuItem_Handler:Android.Support.V4.App.Watson/IOnOptionsItemSelectedListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App.Watson/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Watson_OnOptionsItemSelectedListenerImplementor.class, __md_methods);
	}


	public Watson_OnOptionsItemSelectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Watson_OnOptionsItemSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App.Watson/IOnOptionsItemSelectedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onOptionsItemSelected (com.actionbarsherlock.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (com.actionbarsherlock.view.MenuItem p0);

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
