﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_DropdownWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Dropdown), typeof(UnityEngine.UI.Selectable));
		L.RegFunction("SetValueWithoutNotify", SetValueWithoutNotify);
		L.RegFunction("RefreshShownValue", RefreshShownValue);
		L.RegFunction("AddOptions", AddOptions);
		L.RegFunction("ClearOptions", ClearOptions);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnSubmit", OnSubmit);
		L.RegFunction("OnCancel", OnCancel);
		L.RegFunction("Show", Show);
		L.RegFunction("Hide", Hide);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("template", get_template, set_template);
		L.RegVar("captionText", get_captionText, set_captionText);
		L.RegVar("captionImage", get_captionImage, set_captionImage);
		L.RegVar("itemText", get_itemText, set_itemText);
		L.RegVar("itemImage", get_itemImage, set_itemImage);
		L.RegVar("options", get_options, set_options);
		L.RegVar("onValueChanged", get_onValueChanged, set_onValueChanged);
		L.RegVar("alphaFadeSpeed", get_alphaFadeSpeed, set_alphaFadeSpeed);
		L.RegVar("value", get_value, set_value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetValueWithoutNotify(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetValueWithoutNotify(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshShownValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			obj.RefreshShownValue();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddOptions(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.UI.Dropdown), typeof(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>)))
			{
				UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.ToObject(L, 1);
				System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> arg0 = (System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>)ToLua.ToObject(L, 2);
				obj.AddOptions(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.UI.Dropdown), typeof(System.Collections.Generic.List<string>)))
			{
				UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.ToObject(L, 1);
				System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.ToObject(L, 2);
				obj.AddOptions(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.UI.Dropdown), typeof(System.Collections.Generic.List<UnityEngine.Sprite>)))
			{
				UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.ToObject(L, 1);
				System.Collections.Generic.List<UnityEngine.Sprite> arg0 = (System.Collections.Generic.List<UnityEngine.Sprite>)ToLua.ToObject(L, 2);
				obj.AddOptions(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.Dropdown.AddOptions");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearOptions(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			obj.ClearOptions();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSubmit(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCancel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnCancel(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Show(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			obj.Show();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Hide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Dropdown));
			obj.Hide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_template(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.RectTransform ret = obj.template;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index template on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captionText(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Text ret = obj.captionText;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index captionText on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captionImage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Image ret = obj.captionImage;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index captionImage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemText(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Text ret = obj.itemText;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index itemText on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemImage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Image ret = obj.itemImage;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index itemImage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_options(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> ret = obj.options;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index options on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Dropdown.DropdownEvent ret = obj.onValueChanged;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alphaFadeSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			float ret = obj.alphaFadeSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index alphaFadeSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			int ret = obj.value;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index value on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_template(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.RectTransform));
			obj.template = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index template on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captionText(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			obj.captionText = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index captionText on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captionImage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Image));
			obj.captionImage = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index captionImage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemText(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			obj.itemText = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index itemText on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemImage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Image));
			obj.itemImage = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index itemImage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_options(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> arg0 = (System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>));
			obj.options = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index options on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			UnityEngine.UI.Dropdown.DropdownEvent arg0 = (UnityEngine.UI.Dropdown.DropdownEvent)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.Dropdown.DropdownEvent));
			obj.onValueChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alphaFadeSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.alphaFadeSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index alphaFadeSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Dropdown obj = (UnityEngine.UI.Dropdown)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index value on a nil value" : e.Message);
		}
	}
}

