using UnityEngine;
using TMPro;

public class Navegacion : MonoBehaviour
{
    public TMP_Text textoDePantalla;
    private int numeroPagina = 1;

    // 👇 ¡Fíjate que aquí dice "public"! 👇
    public void PaginaSiguiente()
    {
        numeroPagina = numeroPagina + 1;
        ActualizarTexto();
    }

    // 👇 Aquí también tiene que decir "public" 👇
    public void PaginaAnterior()
    {
        if (numeroPagina > 1)
        {
            numeroPagina = numeroPagina - 1;
            ActualizarTexto();
        }
    }

    void ActualizarTexto()
    {
        if (textoDePantalla != null)
        {
            textoDePantalla.text = "Página " + numeroPagina;
        }
    }
}