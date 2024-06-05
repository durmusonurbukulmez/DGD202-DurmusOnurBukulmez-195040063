using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; //Merhaba Onur hocamm. Player hareket h�z�m�z. Playerla alakal�lar� ve di�erlerini class d���ndan, script d���ndan, inspectordan da de�i�tirebilmem i�in public yap�yorum. Player�n �zerinden h�z� de�i�tirebilicem b�ylelikle.
    private float direction; //Horizontal yani yatay eksen bilgilerimizi directionun i�ine aktarabilmemiz i�in olu�turduk
    private Rigidbody2D rb; //Player�m�z�n ger�ekten hareket edebilmesi i�in Player�n Ridigbodysinin referans�na ihtiya� duyduk. Her rb yazd���mz�da art�k unity bunu anlayacak.

    public float junpForce;


    public Transform groundCheck; //Objelerin konumlar�na eri�ebilmek i�in Transformu kulland�k. A�a��larda nas�l kulland���m�z� yaz�yorum Hocam.
    public float groundCheckRadius; //Havadayken zemine ne kadar yak�n oldu�umuzu anlayabilmemiz i�in Radius laz�m
    public LayerMask groundLayers; //Zeminlerin katmanlar�
    private bool isGrounded; //Zemine karakter temas etmesi

    private SpriteRenderer sr; // X ekseninde giderken karakterin sa�a bakmas�, Y ekseninde de sola bakmas� i�in SpriteRenderer'a ihtiyac�m�z var. Flip edicez ona g�re.
    private Animator anim; // Playera t�klad���m�zda a�a��daki Animator k�sm�na eri�ebilmemiz laz�m. anim diyoruz kullanabilmek i�in. 





    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody ve di�erlerini �a��rabilmemiz i�in onlar� getcomponent ile yaz�yoruz. Hepsini a��klasam m� bilemiyorum hocam ayn� �eyleri yazm�cam. Zaten kendim yazd���m� ve AI kullanmad���m� kan�tlamak i�in a��kl�yorum hepsini :D
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!PauseMenu.instance.isPaused) //Pauselamad���m�z zaman her �eyin devam etmesi i�in bunu koydum ama pauselad���m�z zaman bu if in i�inde

            direction = Input.GetAxis("Horizontal"); //Project settings'de Input Manager'in i�inde Horizontal k�sm�na eri�memiz gerekiyor ki hareket edebilelim. Bu bilgiyi de private float direction'un i�ine atmal�y�z. Float olmas�n�n sebebi de tamsay� olmayabilir player hareketimiz.
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y); // Y ekseni de�i�memeli, X de�i�meli ��nk� yatay hareket edicez. Y'yi z�plamada kullancaz




            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayers); //isgrounded, poziyon, radius ve layerlar� birlikte i�inde tutuyor. Kullan�caz buray� altta

            if (Input.GetButtonDown("Jump") && isGrounded) //Edit>Project Settings>Input Manager in i�inde Jump'a eri�memiz laz�m ki z�playabilelim. Ayr�ca zemine temas etti�imizde sadece �al��s�n ki havadayken birdaha z�playamayal�m.
        {
                rb.velocity = new Vector2(rb.velocity.x, junpForce); //Bu sefer hareketin aksine Y eksenini de�i�tirdik ki z�playabilelim. X sabit
            AudioManager.instance.PLaySfx(1); //z�plama indeksi Audio managerde 1 oldu�u i�in 1 yazd�m. Z�plama ses efektini �a��r�yorum
            }


            if (rb.velocity.x < 0) // h�z�m�z negatifse yani sol tarafa hareket ediyorsak, karakterimizi flip etmemiz gerek ki o y�ne baks�n.
            {
                sr.flipX = true;

            }
            else if (rb.velocity.x > 0) // sa�a gidiyorsak da X'i false yapam�z laz�m. Player�n �zerindeki Flip k�sm�ndaki kutucuk zaten buralar
            {
                sr.flipX = false;
            }
        
        anim.SetFloat("moveSpeed",Mathf.Abs(rb.velocity.x)); //Player�m�z hareket ederken �al��acak olan animasyonumuz
        anim.SetBool("isGrounded", isGrounded); //Player�m�z zemine temas ederken �al��acak olan animasyonumuz:


    }
}
