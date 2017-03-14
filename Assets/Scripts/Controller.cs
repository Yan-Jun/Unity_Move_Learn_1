using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	private Rigidbody _rigidbody;
	public GameObject _Wall;
	public GameObject _bullet;
	[Range(5, 20)]
	public float speed = 15;

	public enum MoveState{
		Transform,
		Rigidbody
	}
	[Header("選擇移動方式")]
	public MoveState _selectMove;

	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void Update () {

		// 發射子彈
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject obj = Instantiate (
				                 _bullet, 
				                 transform.position + Vector3.forward * 1.5f, 
				                 Quaternion.EulerAngles (-85f, 0, 0)) as GameObject;
			obj.AddComponent<Rigidbody> ().velocity = Vector3.forward * 30f;
			Destroy (obj, 5f);
		}

		// 牆壁平滑移動
		WallMove();
	}

	void FixedUpdate(){
		if (_selectMove == MoveState.Rigidbody) {
			// 使用Rigidbody的Velocity來移動 (用推的)
			_rigidbody.velocity = new Vector3 (Input.GetAxis ("Horizontal") * speed, 0, Input.GetAxis ("Vertical") * speed);

		} else if (_selectMove == MoveState.Transform) {
			// 使用Transform的Translate來移動 (強制移動)
			transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis ("Vertical") * speed * Time.deltaTime));

		}

	}

	void WallMove(){
		_Wall.transform.position = Vector3.Lerp(
			_Wall.transform.position,
			new Vector3(transform.position.x, _Wall.transform.position.y, _Wall.transform.position.z),
			0.1f);

	}
}
