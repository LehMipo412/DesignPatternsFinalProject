using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] EventsContainers _eventsContainers;
    
    private float _hitCooldown = 0.8f;
    private bool _playerAlreadyHit = false;
    private bool _isEnemyStillInContact = false;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy collided with player");
            _isEnemyStillInContact = true;
            if (!_playerAlreadyHit)
            {
                _eventsContainers.TakeDamageEvent.Invoke();
                _playerAlreadyHit = true;
                StartCoroutine(HitWithCooldown());
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _isEnemyStillInContact = false;
        }
    }

    private IEnumerator HitWithCooldown()
    {
        yield return new WaitForSeconds(_hitCooldown);
        _playerAlreadyHit = false;
        if (_isEnemyStillInContact && !_playerAlreadyHit)
        {
            _eventsContainers.TakeDamageEvent.Invoke();
            _playerAlreadyHit = true;
            StartCoroutine(HitWithCooldown());
        }
    }
}
