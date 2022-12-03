using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscControl : MonoBehaviour
{

    [SerializeField] private BrownBook brownBook;
    [SerializeField] private Painting painting;
    [SerializeField] private Sign sign;
    [SerializeField] private Disc disc;
    [SerializeField] private FlowerPot flowerPot;

    public void AddBook()
    {
        //BrownBook newBrownBook = Instantiate(brownBook);
        brownBook.Collect();
    }

    public void AddPainting()
    {
        //Painting newPainting = Instantiate(painting);
        painting.Collect();
    }

    public void AddSign()
    {
        //Sign newSign = Instantiate(sign);
        sign.Collect();
    }

    public void AddDisc()
    {
        //Disc newDisc = Instantiate(disc);
        disc.Collect();
    }

    public void AddFlowerPot()
    {
        //FlowerPot newFlowerPot = Instantiate(flowerPot);
        flowerPot.Collect();
    }
}
