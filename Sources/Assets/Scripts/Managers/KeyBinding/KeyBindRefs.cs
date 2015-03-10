using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class KeyBindRefs
{

    public static Dictionary<KeyConfig, List<string>> DefaultBindsRefs
    {
        get
        {
            var temp = new Dictionary<KeyConfig, List<string>>();
            temp.Add(new KeyConfig(KeyCode.A), new List<string> { "Alpha1" });
            temp.Add(new KeyConfig(KeyCode.Z), new List<string> { "Alpha2" });
            temp.Add(new KeyConfig(KeyCode.E), new List<string> { "Alpha3" });
            temp.Add(new KeyConfig(KeyCode.R), new List<string> { "Alpha4" });
            temp.Add(new KeyConfig(KeyCode.T), new List<string> { "Alpha5" });
            temp.Add(new KeyConfig(KeyCode.Y), new List<string> { "Alpha6" });
            temp.Add(new KeyConfig(KeyCode.U), new List<string> { "Alpha7" });
            temp.Add(new KeyConfig(KeyCode.I), new List<string> { "Alpha8" });
            temp.Add(new KeyConfig(KeyCode.Mouse0), new List<string> { "MouseLeftClick" });
            temp.Add(new KeyConfig(KeyCode.Tab), new List<string> { "KeyBindGUI" });

            return temp;
        }
    }

    public static Dictionary<string, ActionConfig> DefaultBinds
    {
        get
        {
            var temp = new Dictionary<string, ActionConfig>();
            temp.Add("Alpha1", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha2", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha3", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha4", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha5", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha6", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha7", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("Alpha8", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("MouseLeftClick", new KeyActionConfig(KeyType.Action, 0, null, null));
            temp.Add("KeyBindGUI", new KeyActionConfig(KeyType.Menu, 0, null, null));

            return temp;
        }
    }

    public static List<string> Axes
    {
        get
        {
            return new List<string>
            {   
				"MouseX",
				"MouseY",
                "Horizontal",
                "Vertical",
                "Horizontal_1",
                "Vertical_1",
                "Horizontal_2",
                "Vertical_2",
                "TriggerLeft",
                "TriggerRight",
                "Steering",
                "Brake"
            };
        }
    }

	public static string ChangingKey = "";
	public static KeyConfig LastInput;

}
