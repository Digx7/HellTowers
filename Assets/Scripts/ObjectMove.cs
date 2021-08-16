// Digx7
// Will move an object using a Rigidbody
using UnityEngine;

public class ObjectMove : MonoBehaviour {

    [Tooltip("If this ObjectMover is activated")]
    [SerializeField] private bool isOn = false;

    [SerializeField] private bool StartOnAwake = false;

    [Header("Movement")]
    [SerializeField] private int moveSpeed;

    [SerializeField] private Rigidbody rb;

    public enum TargetMode {Direction, Object}
    public enum MovementMode {Toward, Away}

    [Tooltip("Direction: Move in one preset direction\nObject: Move toward/away a given GameObject")]
    [SerializeField] private TargetMode targetMode = TargetMode.Direction;
    [Tooltip("Toward: Move closer to the target\nObject: Move away from the target")]
    [SerializeField] private MovementMode movementMode = MovementMode.Toward;

    public enum MomentumMode { Velocity, AddForce }

    [Tooltip("Velocity: Move at constant speed\nAddForce: Move at faster and faster rate")]
    [SerializeField] private MomentumMode momentumMode = MomentumMode.Velocity;

    [Space]
    [Header("Direction Mode")]
    [Tooltip("Only works in TowardDirection Movement Mode")]
    [SerializeField] private Vector3 directionToMove;

    [SerializeField] private bool useLocalSpace = false;

    [Header("Object Mode")]
    [Tooltip("Only works in TowardObject Movement Mode")]
    [SerializeField] private GameObject objectToMoveTowards;

    [SerializeField] private bool lookForGameObjectOnAwake = false;
    [SerializeField] private string tagOfGameObjectToLookFor;

    private Vector3 forwardVel;
    private Vector3 horizontalVel;

    [SerializeField]private Vector3 tempVector;

    public void Awake() {
        if (lookForGameObjectOnAwake) findGameObjectWithTag();
        if (StartOnAwake) isOn = true;
    }

    public void FixedUpdate() {
        moveObject();
    }

    public void moveObject() {
      Debug.Log("moveObject is called");
      if (isOn && targetMode == TargetMode.Direction) {
        Debug.Log("Calling move in a direction");
          if (!useLocalSpace) {
            if(momentumMode == MomentumMode.Velocity) rb.velocity = applyMovementMode(directionToMove) * moveSpeed;
            else rb.AddForce(applyMovementMode(directionToMove) * moveSpeed,  ForceMode.Impulse);
          }
          else {
              forwardVel = transform.right * moveSpeed * directionToMove.x;
              horizontalVel = transform.up * moveSpeed * directionToMove.y;

              if(momentumMode == MomentumMode.Velocity) rb.velocity = applyMovementMode(forwardVel + horizontalVel);
              else rb.AddForce(applyMovementMode(forwardVel + horizontalVel),  ForceMode.Impulse);
          }
      } else if (isOn && targetMode == TargetMode.Object) {
        Debug.Log("Calling move based on a object");
          directionToMove = objectToMoveTowards.transform.position - gameObject.transform.position;
          Vector3.Normalize(directionToMove);

          if(momentumMode == MomentumMode.Velocity) rb.velocity = applyMovementMode(directionToMove) * moveSpeed;
          else rb.AddForce(applyMovementMode(directionToMove) * moveSpeed,  ForceMode.Impulse);
      }
    }

    public void toggleIsOn() {
        isOn = !isOn;
    }

    private Vector3 applyMovementMode(Vector3 input){
      if(movementMode == MovementMode.Toward) return input;
      else return -input;
    }

    private Vector3 directionReWiring(Vector3 input){
      tempVector = input;
      input.z = tempVector.y;
      //input.y = 0.0f;
      return input;
    }

    // --- Get and Set Funtions ---------------------------
    public int getMoveSpeed() {
        return moveSpeed;
    }

    public bool getIsOn() {
        return isOn;
    }

    public void setIsOn(bool input) {
        isOn = input;
    }

    public void zeroOutVelocity() {
        rb.velocity = new Vector3(0, 0, 0);
    }

    public Rigidbody getRB() {
        return rb;
    }

    public void setRB(Rigidbody _rb) {
        rb = _rb;
    }

    public void setDirectionToMoveTo(Vector3 direction) {
        directionToMove = direction;
    }

    public void setDirectionToMoveToXY(Vector2 direction) {
        directionToMove = new Vector3(direction.x, direction.y, 0);
    }

    public void setDirectionToMoveToXZ(Vector2 direction) {
        directionToMove = new Vector3(direction.x, 0, direction.y);
    }

    public void setObjectToMoveTowards(GameObject target) {
        objectToMoveTowards = target;
    }

    // --- Auto set Object -----------------

    public bool doesThisObjectHaveTagImLookingFor(GameObject obj) {
        if (obj.tag == tagOfGameObjectToLookFor) return true;
        return false;
    }

    public void findGameObjectWithTag() {
        GameObject[] _object = GameObject.FindGameObjectsWithTag(tagOfGameObjectToLookFor);

        int i = 1;
        if (i == _object.Length) {
            objectToMoveTowards = _object[0];
        }
    }
}
