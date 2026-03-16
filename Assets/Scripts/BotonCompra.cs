using UnityEngine;

public class BotonCompra : MonoBehaviour
{
    public string urlCompra = "https://jcg0068.github.io/aerosound-web/";

    void OnMouseDown()
    {
        Application.OpenURL(urlCompra);
        Debug.Log("Redirigiendo al Ecommerce...");
    }
}
