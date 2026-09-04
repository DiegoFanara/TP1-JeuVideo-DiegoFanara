using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO : valider la référence, puis cacher la porte au démarrage.

        if (porteSortie == null){
            Debug.LogError("La porte de sortie n'est pas assignée.");
        }

        porteSortie.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer les objets qui ne sont pas des batteries.
        // TODO : ramasser la batterie et mettre le compteur à jour.

        if (!autre.CompareTag("Batterie")){
            Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
            batteriesCollectees++;
            Debug.Log($"Batteries : {batteriesCollectees} 2");
        }
        
        Debug.Log($"Batteries : {batteriesCollectees} 3");
        // TODO : déverrouiller la porte lorsque l'objectif est atteint.

        if (batteriesCollectees >= objectif){
            porteSortie.SetActive(true);
            Debug.Log("PORTE DÉVERROUILLÉE !");
        }

    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Certaines lignes doivent être placées à l'intérieur d'un if.
     * Ajoutez les accolades et l'indentation nécessaires.
     *
     * Debug.Log("PORTE DÉVERROUILLÉE !");
     * return;
     * porteSortie.SetActive(false); 
     * if (batteriesCollectees >= objectif) OK
     * batteriesCollectees++;
     * Debug.LogError("La porte de sortie n'est pas assignée."); OK
     * if (!autre.CompareTag("Batterie"))
     * porteSortie.SetActive(true); OK
     * Destroy(autre.gameObject);
     * if (porteSortie == null) OK
     * Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
     * return;
     */
}
