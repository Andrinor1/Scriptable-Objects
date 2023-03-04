using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GriffinCardDisplay : MonoBehaviour
{

    public GriffinCard griffincard;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text manaText;
    public Text attackText;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = griffincard.name;
        descriptionText.text = griffincard.description;
        artworkImage.sprite = griffincard.artwork;
        manaText.text = griffincard.manaCost.ToString(); ;
        attackText.text = griffincard.attack.ToString();
        healthText.text = griffincard.health.ToString();
    }

}
