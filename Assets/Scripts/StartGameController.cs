using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour
{
    public TextMeshProUGUI textoComenzar;
    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI textoFinalizado;
    public TextMeshProUGUI textoGanador;
    public float tiempoVisible = 2f;
    public GameObject confetiPrefab;
    public Camera mainCamera;

    public AudioSource sonidoComenzar;
    public AudioSource sonidoGanador;
    public AudioSource sonidoFinTiempo;

    private List<GameObject> bolas; // Cambiar a 'bolas' para reflejar el nuevo tag
    private bool juegoTerminado = false;

    // Posición Y de la plataforma
    private float alturaPlataforma = 224.93f;

    void Start()
    {
        bolas = new List<GameObject>(GameObject.FindGameObjectsWithTag("Ball")); // Usar el tag "Ball"
        Debug.Log("Bolas iniciales: " + bolas.Count);
        StartCoroutine(MostrarTextoComenzar());
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            RevisarGanador();
        }
    }

    IEnumerator MostrarTextoComenzar()
    {
        sonidoComenzar.Play();
        textoComenzar.gameObject.SetActive(true);
        yield return new WaitForSeconds(tiempoVisible);
        textoComenzar.gameObject.SetActive(false);

        if (!juegoTerminado)
        {
            StartCoroutine(ContadorRegresivo());
        }
    }

    IEnumerator ContadorRegresivo()
    {
        int tiempo = 60;
        textoContador.gameObject.SetActive(true);

        while (tiempo > 0 && !juegoTerminado)
        {
            // Verificar cuántas bolas activas hay en la plataforma
            List<GameObject> bolasActivas = new List<GameObject>();

            foreach (GameObject bola in bolas)
            {
                if (bola != null && bola.transform.position.y > alturaPlataforma)
                {
                    bolasActivas.Add(bola);
                    Debug.Log("Bola activa: " + bola.name);
                }
                else if (bola != null)
                {
                    Debug.Log("Bola caída: " + bola.name);
                }
            }

            // Mostrar cuántas bolas están activas
            Debug.Log("Bolas activas: " + bolasActivas.Count);

            if (bolasActivas.Count == 0)
            {
                textoContador.gameObject.SetActive(false);
                StartCoroutine(VolverAlMenu());
                yield break; // Salir de la corutina
            }

            textoContador.text = tiempo.ToString();
            yield return new WaitForSeconds(1);
            tiempo--;
        }

        textoContador.gameObject.SetActive(false);

        if (!juegoTerminado)
        {
            textoFinalizado.gameObject.SetActive(true);
            sonidoFinTiempo.Play();
            RevisarGanador();
        }
    }

    void RevisarGanador()
    {
        List<GameObject> bolasActivas = new List<GameObject>();

        foreach (GameObject bola in bolas)
        {
            if (bola != null && bola.transform.position.y > alturaPlataforma)
            {
                bolasActivas.Add(bola);
                Debug.Log("Bola activa (RevisarGanador): " + bola.name);
            }
            else if (bola != null)
            {
                Debug.Log("Bola caída (RevisarGanador): " + bola.name);
            }
        }

        Debug.Log("Bolas activas al revisar ganador: " + bolasActivas.Count);

        if (bolasActivas.Count == 1 && !juegoTerminado)
        {
            MostrarGanador(bolasActivas[0]);
        }
        else if (bolasActivas.Count == 0 && !juegoTerminado)
        {
            StartCoroutine(VolverAlMenu());
        }
    }

    void MostrarGanador(GameObject bolaGanadora)
    {
        juegoTerminado = true;
        StopAllCoroutines();
        textoContador.gameObject.SetActive(false);
        sonidoGanador.Play();
        textoGanador.gameObject.SetActive(true);
        textoGanador.text = "¡Ganador: " + bolaGanadora.name + "!";
        Instantiate(confetiPrefab, bolaGanadora.transform.position, Quaternion.identity);
        StartCoroutine(MoverCamaraHaciaGanador(bolaGanadora));
        StartCoroutine(SaltarEsferaGanadora(bolaGanadora));
        StartCoroutine(VolverAlMenu());
    }

    IEnumerator MoverCamaraHaciaGanador(GameObject bolaGanadora)
    {
        Vector3 posicionInicial = mainCamera.transform.position;
        Vector3 posicionFinal = bolaGanadora.transform.position + new Vector3(0, 2, -5);
        float duracion = 2f;
        float tiempo = 0;

        while (tiempo < duracion)
        {
            tiempo += Time.deltaTime;
            mainCamera.transform.position = Vector3.Lerp(posicionInicial, posicionFinal, tiempo / duracion);
            yield return null;
        }
    }

    IEnumerator SaltarEsferaGanadora(GameObject bolaGanadora)
    {
        Rigidbody rb = bolaGanadora.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
        yield return null;
    }

    IEnumerator VolverAlMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MenuScene");
    }
}



