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

	//Score
	private int count;
	public GameObject score;
	private Text scoreText;

	//HighScore
	private int highScoreCount;
	public GameObject highScore;
	private Text highScoreText;

    /// <summary>
    /// method yang digunakan untuk menjalankan game
    /// </summary>
    void Start(){
		rb = GetComponent<Rigidbody2D> ();
		count = 0;
		scoreText = score.GetComponent<Text> ();
		highScoreText = highScore.GetComponent<Text> ();

		setScore ();
		InvokeRepeating ("incCount", 0.0f, 0.1f);
		PlayerPrefs.SetInt("highScoreCount" , highScoreCount);
		highScoreText.text = "High Score: " + highScoreCount.ToString ();


	}

    /// <summary>
    /// //method untuk memeriksa collision dari karakter
    ///jika karakter collision dengan ground, grounded = true
    ///jika karakter collision dengan obstacle maka permainan berhenti
    ///@Override
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
    /// method yang digunakan character untuk melakukan lompatan jika  dan 
    /// menunduk jika dilakukan key press
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
		//karakter mengecil untuk menghindari obstacle terbang
		if(Input.GetKeyUp("down")){
			stand ();
		}
		setHighScore ();
		setScore ();

	}
    ///<summary>
    ///method yang digunakan untuk mengubah high score
    ///</summary>

    private void setHighScore(){
		if (count > highScoreCount) {
			highScoreCount = count;
			PlayerPrefs.SetInt("highScoreCount" , highScoreCount);
			highScoreText.text = "High Score: " + highScoreCount.ToString ();
		}
	}
    ///<summary>
    ///method yang digunakan untuk menetapkan score
    ///</summary>>

    private void setScore (){
		scoreText.text = "Score: " + count.ToString ();
	}
}
   ///<summary>
   ///method yang digunakan untuk menambakan variable count
  /// </summary>
private void incCount(){
		count++;
	}
/// <summary>
/// method yang digunakan agara karakter melompat ketika menekan tombol ↑
/// </summary>
	private void jump(){
		rb.AddForce (jumpPower);
		this.grounded = false;
		rb.gravityScale = 1f;
		transform.localScale = new Vector2 (3f, 3f);
	}
/// <summary>
/// method yang digunakan agar karakter menunduk ketika menekan tombol ↓
/// </summary>
	private void crouch(){
				if(!this.grounded){
					rb.gravityScale = 6;
					transform.localScale = new Vector2(1.8f,1.8f);
				}
				//waktu di tanah karakter menjadi kecil untuk menghindari obstacle terbang
				else{
					rb.gravityScale = 1f;
					transform.localScale = new Vector2(1.8f,1.8f);
				}
	}
/// <summary>
/// method yang digunakan agar karakter berdiri  yang dilakukan ketika tidak ada tombol yang ditekan
/// </summary>
	private void stand(){
		rb.gravityScale = 1f;
		transform.localScale = new Vector2(3f,3f);
	}
}
