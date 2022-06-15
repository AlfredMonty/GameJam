using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    // [SerializeField] private float aggroDelay = 1f;
    [SerializeField] private float timeDelayed = 0f;

    private Rigidbody2D _rb;
    private Collider2D _collider;
    private Vector3 _spawnLocation;
    private float locationOffset = 0.02f;

    private void OnEnable() {
        timeDelayed = 0f;
    }

    // Start is called before the first frame update
    void Start() {
        target = GameObject.FindGameObjectWithTag("Player");
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        _spawnLocation = transform.position;
    }

    private void MoveToLocation(Vector3 pos) {  
        if((transform.position - pos).magnitude >= locationOffset) {
            Vector2 velocity = new Vector2((transform.position.x - pos.x), (transform.position.y - pos.y)).normalized * speed;
            _rb.velocity = -velocity;
        }
        else {
            _rb.velocity = Vector2.zero;
        }
    }

    // Update is called once per frame
    void Update() {
        timeDelayed += Time.deltaTime;
        // if (timeDelayed < aggroDelay) { return; }

        MoveToLocation(target.transform.position);
    }
}
