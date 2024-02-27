using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject _player;
    private Vector3 _offset = new Vector3 (0, 5, -7);
    private int _flag_for_switch = 3; //3 - third_person; 1 - first_person

    void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (_flag_for_switch == 3)
            {
                _offset = new Vector3 (0, 5, -7);
                _flag_for_switch = 1;
            }
            else if (_flag_for_switch == 1)
            {
                _offset = new Vector3(0, 2, 1.5f);
                _flag_for_switch = 3;
            }
        }
    }
}
