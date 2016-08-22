using UnityEngine;
using System.Collections;

public class CutFruit : MonoBehaviour {

	private BoxCollider2D colloder;

	public GameObject KnifeRay;
//	public AudioClip
	public GameObject Fruit1;
	public GameObject Fruit2;

	public GameObject[] Wz;

	// Use this for initialization
	void Start () {
		colloder = GetComponent<BoxCollider2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			// 确定水果被切
			if (colloder.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition))) {

				// 绘制刀光对象
				GameObject knifeRay = Instantiate (KnifeRay,
					transform.position,
					Quaternion.AngleAxis(Random.Range(-90f,90f),Vector3.back)) as GameObject;
			
				// 1秒销毁
				Destroy(KnifeRay,1);


				// 绘制切开的水果
				GameObject fruit1 = Instantiate (Fruit1,
					transform.position,
					Quaternion.AngleAxis(Random.Range(-30f,30f),Vector3.back)) as GameObject;

				fruit1.GetComponent<Rigidbody2D>().velocity=new Vector2(
					Random.Range(-6f,-2f),
					Random.Range(2f,5f));

				Destroy(fruit1,2);

				GameObject fruit2 = Instantiate (Fruit2,
					transform.position,
					Quaternion.AngleAxis(Random.Range(-30f,30f),Vector3.back)) as GameObject;
				fruit2.GetComponent<Rigidbody2D>().velocity=new Vector2(
					Random.Range(2f,6f),
					Random.Range(2f,5f));
				Destroy(fruit2,2);

				// 绘制污渍
				GameObject wz = Instantiate(Wz[Random.Range(0,3)]) as GameObject;
				wz.transform.position = transform.position;
				Destroy (wz, 1);

				// 销毁完整的水果
				Destroy(this.gameObject);
			}
		}
	}
}
