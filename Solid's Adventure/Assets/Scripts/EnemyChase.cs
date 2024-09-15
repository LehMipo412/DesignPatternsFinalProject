using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    [SerializeField] private float _speed;
    private GameObject _target;

    private void Start()
    {
        _target = GameManager.Instance.PlayerGO;
    }

    private void Update()
    {
        if (_target != null)
        {
            transform.LookAt(_target.transform);
            transform.Translate(Vector3.forward * (Time.deltaTime * _speed));
        }
    }
}
