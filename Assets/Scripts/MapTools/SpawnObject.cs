using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public static void Spawn(GameObject obj, Vector3 location, float angle)
    {
        var spawned = GetNewObject(obj, location);
        spawned.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
    
    public static void Spawn(GameObject obj, Vector3 location, Quaternion rotation)
    {
        var spawned = GetNewObject(obj, location);
        spawned.transform.rotation = rotation;
    }
    
    public static void Spawn(GameObject obj, Vector3 location)
    {
        GetNewObject(obj, location);
    }

    private static GameObject GetNewObject(GameObject obj, Vector3 location)
    {
        var spawned = Instantiate(obj, GameObject.Find("Map").transform);
        spawned.transform.localPosition = location;
        spawned.name = $"{obj.name}X{location.x}Y{location.y}";
        return spawned;
    }
}
