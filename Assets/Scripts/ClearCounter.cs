using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;



    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //no kO
            if (player.HasKitchenObject())
            {
                //player has something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //player doesnt have something
            }
        }
        else
        {
            if (player.HasKitchenObject())
            {
                //player has something
            }
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }


}
