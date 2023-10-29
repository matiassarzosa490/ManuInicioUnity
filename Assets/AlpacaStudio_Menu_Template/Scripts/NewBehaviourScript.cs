using UnityEngine;
using UnityEngine.UI;

public class MostrarDialogo : MonoBehaviour
{
    public GameObject panelDialogo;

    public void MostrarOcultarDialogo()
    {
        panelDialogo.SetActive(!panelDialogo.activeSelf);
    }
}
