using System;
using UnityEngine;
using UnityEngine.UI;

public class Cube_spawn : MonoBehaviour
{

    [SerializeField] private InputField _speed;
    [SerializeField] private InputField _distance;
    [SerializeField] private InputField _time;
    [SerializeField] private GameObject _cube;
    
    [SerializeField] private float time_spawn;
    public float speed, distance;
    
    public void save_param()
    {
        speed = Convert.ToSingle(_speed.text);
        distance = Convert.ToSingle(_distance.text);
        time_spawn = Convert.ToSingle(_time.text);
        InvokeRepeating("spawn_cube", 0f, time_spawn);
    }

    private void spawn_cube()
    {
        GameObject _cube1 = Instantiate(_cube, Vector3.zero, Quaternion.identity);
        _cube1.AddComponent<Cube_move>();
        Cube_move _cubeMove = _cube1.GetComponent<Cube_move>();
        _cubeMove.speed = speed;
        _cubeMove.target = new Vector3(0, 0,distance);
    }
    
}
