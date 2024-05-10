using System.Collections;
using UnityEngine;

public class DestroyableManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _destroyableObject;
    [SerializeField]
    private float _respawnInterval;

    private Coroutine _respawnObject;

    public void RespawnDestroyable()
    {
        if (_respawnObject != null)
        {
            StopCoroutine(_respawnObject);
        }
        _respawnObject = StartCoroutine(RespawnObject());
    }

    private IEnumerator RespawnObject()
    {
        yield return new WaitForSeconds(_respawnInterval);
        Instantiate(_destroyableObject, 
                    new Vector3(_destroyableObject.transform.position.x, 3f, _destroyableObject.transform.position.z), 
                    _destroyableObject.transform.rotation);
    }

}
