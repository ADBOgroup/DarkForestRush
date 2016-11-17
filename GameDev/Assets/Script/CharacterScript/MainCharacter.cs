using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//kelas untuk mengatur pergerakan dari karakter pemain

public class MainCharacter : MonoBehaviour {
	//tinggi lompatan karakter
	public Vector2 jumpPower = new Vector2(0,200);
	public Rigidbody2D rb;


	//fungsi boolean untuk memeriksa posisi karakter
	//true jika karakter tidak sedang lompat
	public bool grounded = true;

    /// <summary>
    /// start MainCharacter.cs ketika dipanggil
    /// </summary>
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	/// <summary>
    /// pindah ke scene lain jika terjadi tabrakan antara 
    /// main character dengan obstacle
    /// </summary>
    /// <param name="coll"></param>
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			this.grounded = true;
		}
		if (coll.gameObject.name == "Obstacle") {
			rb.constraints = RigidbodyConstraints2D.FreezeAll;
			Application.LoadLevel ("Retry");
		}
	}


	/// <summary>
    /// menekan tombol ↑ untuk melompat
    /// menekan tombol ↓ untuk menghindari obstacle terbang dengan cara mengecil
    /// </summary>
	void Update () {
		
		//jika karakter menyentuh tanah, karakter lompat 1x
		if (Input.GetKeyDown ("up") && this.grounded) {
			jump ();
		}
		//Pencet "down"
		if(Input.GetKeyDown("down")){
			crouch();
		}
		
		if(Input.GetKeyUp("down")){
			stand ();
		}
	}
    /// <summary>
    /// jump
    /// </summary>
	private void jump(){
		rb.AddForce (jumpPower);
		this.grounded = false;
		rb.gravityScale = 1f;
		transform.localScale = new Vector2 (3f, 3f);
	}
    /// <summary>
    /// setting ukuran dari horseman jika menunduk
    /// </summary>
	private void crouch()
    {
        if (!this.grounded)
        {
            rb.gravityScale = 6;
            transform.localScale = new Vector2(1.8f, 1.8f);
        }
        //waktu di tanah karakter menjadi kecil untuk menghindari obstacle terbang
        else
        {
            rb.gravityScale = 1f;
            transform.localScale = new Vector2(1.8f, 1.8f);
        }
    }
    /// <summary>
    /// posisi awal ketika tidak ditekan tombol apapun
    /// </summary>
	private void stand(){
		rb.gravityScale = 1f;
		transform.localScale = new Vector2(3f,3f);
	}
}
