//KMG_Creater
using UnityEngine;

public class KMG_Create : MonoBehaviour
{
    public GameObject _targetDestroy;
    public GameObject _munculHilang;
    public GameObject _untukSpawn;
    public GameObject _diamodWarna;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tekan tombol spasi.");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O ditekan, objek muncul.");
            _munculHilang.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan, objek hilang.");
            _munculHilang.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return)) //enter
        {
            Debug.Log("Tombol Enter ditekan, objek di-spawn.");
            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 3), 0, 0), Quaternion.Euler(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.Find("TargetDestroy");
            Debug.Log("Tombol M ditekan, objek dihancurkan.");
            Destroy(_targetDestroy);
            Destroy(hancurkan);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer sr = _diamodWarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            sr.color = warnaAcak;
        }
        
            
    }
}
