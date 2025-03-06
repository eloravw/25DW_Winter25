using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullClick : MonoBehaviour
{

    public SkullManager manager;

    private GameObject leftClickedObject;
    private GameObject rightClickedObject;
    private RaycastHit2D frontmostRaycastHit;

    private SpriteRenderer spriteRenderer;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            frontmostRaycastHit = GetFrontmostRaycastHit();

            if (frontmostRaycastHit)
            {
                leftClickedObject = frontmostRaycastHit.collider.gameObject;

                if (leftClickedObject.CompareTag("Skull"))
                {
                    manager.OnLeftClick(leftClickedObject);
                    leftClickedObject.SendMessage("Shake");
                }
            }
        }
    }

    RaycastHit2D GetFrontmostRaycastHit()
    {

        Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D[] hits = Physics2D.LinecastAll(clickPosition, clickPosition);

        if (hits.Length != 0)
        {
            int topSortingLayer = 0;
            int indexOfTopSortingLayer;
            int[] sortingLayerIDArray = new int[hits.Length];
            int[] sortingOrderArray = new int[hits.Length];
            int topSortingOrder = 0;
            int indexOfTopSortingOrder = 0;

            for (int i = 0; i < hits.Length; i++)
            {
                spriteRenderer = hits[i].collider.gameObject.GetComponent<SpriteRenderer>();

                sortingLayerIDArray[i] = spriteRenderer.sortingLayerID;

                sortingOrderArray[i] = spriteRenderer.sortingOrder;
            }

            for (int j = 0; j < sortingLayerIDArray.Length; j++)
            {
                if (sortingLayerIDArray[j] >= topSortingLayer)
                {
                    topSortingLayer = sortingLayerIDArray[j];
                    indexOfTopSortingLayer = j;
                }
            }

            for (var k = 0; k < sortingOrderArray.Length; k++)
            {
                if (sortingOrderArray[k] >= topSortingOrder && sortingLayerIDArray[k] == topSortingLayer)
                {
                    topSortingOrder = sortingOrderArray[k];
                    indexOfTopSortingOrder = k;
                }
            }

            return hits[indexOfTopSortingOrder];
        }

        else
        {
            Debug.Log("Nothing clicked.");
            return hits[0];
        }
    }
}
