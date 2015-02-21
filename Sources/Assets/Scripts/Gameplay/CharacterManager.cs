using UnityEngine;
using System.Collections;

public class CharacterManager : MonoBehaviour
{
    public DraftRunner[] _characters;

    void Start()
    {
        KeyBinder.Instance.DefineActions("Alpha1", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[0].SwitchCurve(true); }));
        KeyBinder.Instance.DefineActions("Alpha2", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[0].SwitchCurve(false); }));


        KeyBinder.Instance.DefineActions("Alpha3", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[1].SwitchCurve(true); }));
        KeyBinder.Instance.DefineActions("Alpha4", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[1].SwitchCurve(false); }));


        KeyBinder.Instance.DefineActions("Alpha5", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[2].SwitchCurve(true); }));
        KeyBinder.Instance.DefineActions("Alpha6", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[2].SwitchCurve(false); }));


        KeyBinder.Instance.DefineActions("Alpha7", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[3].SwitchCurve(true); }));
        KeyBinder.Instance.DefineActions("Alpha8", new KeyActionConfig(KeyType.Action, 0, null, () => { _characters[3].SwitchCurve(false); }));
    }
}
