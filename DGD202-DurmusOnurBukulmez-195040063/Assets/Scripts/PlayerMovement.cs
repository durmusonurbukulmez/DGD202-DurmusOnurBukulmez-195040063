using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; //Merhaba Onur hocamm. Player hareket hýzýmýz. Playerla alakalýlarý ve diðerlerini class dýþýndan, script dýþýndan, inspectordan da deðiþtirebilmem için public yapýyorum. Playerýn üzerinden hýzý deðiþtirebilicem böylelikle.
    private float direction; //Horizontal yani yatay eksen bilgilerimizi directionun içine aktarabilmemiz için oluþturduk
    private Rigidbody2D rb; //Playerýmýzýn gerçekten hareket edebilmesi için Playerýn Ridigbodysinin referansýna ihtiyaç duyduk. Her rb yazdýðýmzýda artýk unity bunu anlayacak.

    public float junpForce;


    public Transform groundCheck; //Objelerin konumlarýna eriþebilmek için Transformu kullandýk. Aþaðýlarda nasýl kullandýðýmýzý yazýyorum Hocam.
    public float groundCheckRadius; //Havadayken zemine ne kadar yakýn olduðumuzu anlayabilmemiz için Radius lazým
    public LayerMask groundLayers; //Zeminlerin katmanlarý
    private bool isGrounded; //Zemine karakter temas etmesi

    private SpriteRenderer sr; // X ekseninde giderken karakterin saða bakmasý, Y ekseninde de sola bakmasý için SpriteRenderer'a ihtiyacýmýz var. Flip edicez ona göre.
    private Animator anim; // Playera týkladýðýmýzda aþaðýdaki Animator kýsmýna eriþebilmemiz lazým. anim diyoruz kullanabilmek için. 





    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody ve diðerlerini çaðýrabilmemiz için onlarý getcomponent ile yazýyoruz. Hepsini açýklasam mý bilemiyorum hocam ayný þeyleri yazmýcam. Zaten kendim yazdýðýmý ve AI kullanmadýðýmý kanýtlamak için açýklýyorum hepsini :D
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!PauseMenu.instance.isPaused) //Pauselamadýðýmýz zaman her þeyin devam etmesi için bunu koydum ama pauseladýðýmýz zaman bu if in içinde

            direction = Input.GetAxis("Horizontal"); //Project settings'de Input Manager'in içinde Horizontal kýsmýna eriþmemiz gerekiyor ki hareket edebilelim. Bu bilgiyi de private float direction'un içine atmalýyýz. Float olmasýnýn sebebi de tamsayý olmayabilir player hareketimiz.
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y); // Y ekseni deðiþmemeli, X deðiþmeli çünkü yatay hareket edicez. Y'yi zýplamada kullancaz




            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayers); //isgrounded, poziyon, radius ve layerlarý birlikte içinde tutuyor. Kullanýcaz burayý altta

            if (Input.GetButtonDown("Jump") && isGrounded) //Edit>Project Settings>Input Manager in içinde Jump'a eriþmemiz lazým ki zýplayabilelim. Ayrýca zemine temas ettiðimizde sadece çalýþsýn ki havadayken birdaha zýplayamayalým.
        {
                rb.velocity = new Vector2(rb.velocity.x, junpForce); //Bu sefer hareketin aksine Y eksenini deðiþtirdik ki zýplayabilelim. X sabit
            AudioManager.instance.PLaySfx(1); //zýplama indeksi Audio managerde 1 olduðu için 1 yazdým. Zýplama ses efektini çaðýrýyorum
            }


            if (rb.velocity.x < 0) // hýzýmýz negatifse yani sol tarafa hareket ediyorsak, karakterimizi flip etmemiz gerek ki o yöne baksýn.
            {
                sr.flipX = true;

            }
            else if (rb.velocity.x > 0) // saða gidiyorsak da X'i false yapamýz lazým. Playerýn üzerindeki Flip kýsmýndaki kutucuk zaten buralar
            {
                sr.flipX = false;
            }
        
        anim.SetFloat("moveSpeed",Mathf.Abs(rb.velocity.x)); //Playerýmýz hareket ederken çalýþacak olan animasyonumuz
        anim.SetBool("isGrounded", isGrounded); //Playerýmýz zemine temas ederken çalýþacak olan animasyonumuz:


    }
}
