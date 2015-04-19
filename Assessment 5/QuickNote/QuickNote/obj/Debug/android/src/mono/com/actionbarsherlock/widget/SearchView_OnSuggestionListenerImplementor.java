package mono.com.actionbarsherlock.widget;


public class SearchView_OnSuggestionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.widget.SearchView.OnSuggestionListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSuggestionClick:(I)Z:GetOnSuggestionClick_IHandler:Xamarin.ActionbarSherlockBinding.Widget.SearchView/IOnSuggestionListenerInvoker, ActionBarSherlock\n" +
			"n_onSuggestionSelect:(I)Z:GetOnSuggestionSelect_IHandler:Xamarin.ActionbarSherlockBinding.Widget.SearchView/IOnSuggestionListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.Widget.SearchView/IOnSuggestionListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SearchView_OnSuggestionListenerImplementor.class, __md_methods);
	}


	public SearchView_OnSuggestionListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SearchView_OnSuggestionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.Widget.SearchView/IOnSuggestionListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onSuggestionClick (int p0)
	{
		return n_onSuggestionClick (p0);
	}

	private native boolean n_onSuggestionClick (int p0);


	public boolean onSuggestionSelect (int p0)
	{
		return n_onSuggestionSelect (p0);
	}

	private native boolean n_onSuggestionSelect (int p0);

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
