using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public float levens = 100;
    public float warmte = 100;
    public float energie = 100;

    public bool krijg_warm = false;
    public bool slaap = false;
    public bool krijg_heal = false;

    public bool select_chicken;
    public bool select_bandage;
    public bool select_berry;
    public bool select_oil;

    public Slider Energy_Bar;
    public Slider Health_Bar;
    public Slider Heat_Bar;

    public GameObject broken_heart;
    public GameObject low_energy;
    public GameObject low_heat;

    public GameObject arrow_chicken;
    public GameObject arrow_berry;
    public GameObject arrow_oil;
    public GameObject arrow_bandage;


    public int Berry_N;
    public int Chicken_N;
    public int Bandage_N;
    public int Oil_N;

    public int select;

    public Text Berry_Text;
    public Text Bandage_Text;
    public Text Oil_Text;
    public Text Chicken_Text;

    public Light lantern;

    // Use this for initialization
    void Start()
    {
        select = 1;
    }

    // Update is called once per frame
    void Update()
    {

        Bandage_Text.text = Bandage_N.ToString();
        Berry_Text.text = Berry_N.ToString();
        Chicken_Text.text = Chicken_N.ToString();
        Oil_Text.text = Oil_N.ToString();

        Energy_Bar.value = energie;
        Health_Bar.value = levens;
        Heat_Bar.value = warmte;

        if (slaap == false)
        {
            energie -= 0.7f * Time.deltaTime;
        }
        if (krijg_warm == false)
        {
            warmte -= 1 * Time.deltaTime;
        }
        if (slaap == true)
        {
            energie += 3 * Time.deltaTime;
        }
        if (krijg_heal == true)
        {
            levens += 0.05f;
        }
        if (krijg_warm == true)
        {
            warmte += 5 * Time.deltaTime;
        }
        if (slaap == true)
        {
            energie += 3 * Time.deltaTime;
        }

        if (levens < 0)
        {
            levens = 0;
        }
        if (energie < 0)
        {
            energie = 0;
        }
        if (warmte < 0)
        {
            warmte = 0;
        }
        if (warmte > 100)
        {
            warmte = 100;
        }
        if (levens > 100)
        {
            levens = 100;
        }
        if (energie > 100)
        {
            energie = 100;
        }
        if (levens > 30)
        {
            broken_heart.SetActive(false);
        }
        if (levens < 30)
        {
            broken_heart.SetActive(true);
        }
        if (warmte == 0)
        {
            levens -= 0.3f * Time.deltaTime;
        }
        if (energie == 0)
        {
            levens -= 0.2f * Time.deltaTime;
        }
        if (energie > 30)
        {
            low_energy.SetActive(false);
        }
        if (energie < 30)
        {
            low_energy.SetActive(true);
        }
        if (warmte > 30)
        {
            low_heat.SetActive(false);
        }
        if (warmte < 30)
        {
            low_heat.SetActive(true);
        }
        if (warmte > 80 && energie > 80)
        {
            levens += 0.5f * Time.deltaTime;
        }
        if (Bandage_N > 0 && Input.GetKeyDown(KeyCode.S) && select_bandage == true)
        {
            Bandage_N--;
            levens += 20;
        }
        if (Berry_N > 0 && Input.GetKeyDown(KeyCode.S) && select_berry == true)
        {
            Berry_N--;
            energie += 10;
            levens += 5;
        }
        if (Chicken_N > 0 && Input.GetKeyDown(KeyCode.S) && select_chicken == true)
        {
            Chicken_N--;
            levens += 7;
            warmte += 10;
            energie += 15;
        }
        if (Oil_N > 0 && Input.GetKeyDown(KeyCode.S) && select_oil == true)
        {
            Oil_N--;
            lantern.intensity += 10;
        }
        if(levens < 1)
        {
            SceneManager.LoadScene(2);
        }
        if(select == 1)
        {
            select_chicken = true;
            select_berry = false;
            select_oil = false;
            select_bandage = false;
            arrow_chicken.SetActive(true);
            arrow_berry.SetActive(false);
            arrow_oil.SetActive(false);
            arrow_bandage.SetActive(false);
        }
        if (select == 2)
        {
            select_chicken = false;
            select_berry = true;
            select_oil = false;
            select_bandage = false;
            arrow_chicken.SetActive(false);
            arrow_berry.SetActive(true);
            arrow_oil.SetActive(false);
            arrow_bandage.SetActive(false);
        }
        if (select == 3)
        {
            select_chicken = false;
            select_berry = false;
            select_oil = true;
            select_bandage = false;
            arrow_chicken.SetActive(false);
            arrow_berry.SetActive(false);
            arrow_oil.SetActive(true);
            arrow_bandage.SetActive(false);
        }
        if (select == 4)
        {
            select_chicken = false;
            select_berry = false;
            select_oil = false;
            select_bandage = true;
            arrow_chicken.SetActive(false);
            arrow_berry.SetActive(false);
            arrow_oil.SetActive(false);
            arrow_bandage.SetActive(true);
        }
        if(select > 4)
        {
            select = 1;
        }
        if(select < 1)
        {
            select = 4;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            select++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            select--;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Berry")
        {
            Berry_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Oli")
        {
            Oil_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Bandage")
        {
            Bandage_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Chicken")
        {
            Chicken_N++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(2);
        }

    }
}
