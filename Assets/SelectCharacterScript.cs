using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterScript : MonoBehaviour
{
    public GameObject karakter1_mavisiyah;

    public GameObject karakter2_siyahyesil;

    public GameObject character3_kirmizislime;

    public GameObject character4_mavislime;

    public GameObject character_slime;

    public GameObject character6_morslime;

    void Start() {

        karakter1_mavisiyah.SetActive(true);
        karakter2_siyahyesil.SetActive(false);
        character3_kirmizislime.SetActive(false);
        character4_mavislime.SetActive(false);
        character_slime.SetActive(false);
        character_slime.SetActive(false);
        character6_morslime.SetActive(false);

    
        
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("karaktersecici") == 1)
        {
            karakter1_mavisiyah.SetActive(true);
            karakter2_siyahyesil.SetActive(false);
            character3_kirmizislime.SetActive(false);
            character4_mavislime.SetActive(false);
            character_slime.SetActive(false);
            character6_morslime.SetActive(false);
        }


        if (PlayerPrefs.GetInt("karaktersecici") == 2)
        {
            karakter1_mavisiyah.SetActive(false);
            karakter2_siyahyesil.SetActive(true);
            character3_kirmizislime.SetActive(false);
            character4_mavislime.SetActive(false);
            character_slime.SetActive(false);
            character6_morslime.SetActive(false);
        }

        if (PlayerPrefs.GetInt("karaktersecici") == 3)
        {
            karakter1_mavisiyah.SetActive(false);
            karakter2_siyahyesil.SetActive(false);
            character3_kirmizislime.SetActive(true);
            character4_mavislime.SetActive(false);
            character_slime.SetActive(false);
            character6_morslime.SetActive(false);
        }
        
        if (PlayerPrefs.GetInt("karaktersecici") == 4)
        {
            karakter1_mavisiyah.SetActive(false);
            karakter2_siyahyesil.SetActive(false);
            character3_kirmizislime.SetActive(false);
            character4_mavislime.SetActive(true);
            character_slime.SetActive(false);
            character6_morslime.SetActive(false);

        }

        if (PlayerPrefs.GetInt("karaktersecici") == 5)
        {
            karakter1_mavisiyah.SetActive(false);
            karakter2_siyahyesil.SetActive(false);
            character3_kirmizislime.SetActive(false);
            character4_mavislime.SetActive(false);
            character_slime.SetActive(true);
            character6_morslime.SetActive(false);

        }

        if (PlayerPrefs.GetInt("karaktersecici") == 6)
        {
            karakter1_mavisiyah.SetActive(false);
            karakter2_siyahyesil.SetActive(false);
            character3_kirmizislime.SetActive(false);
            character4_mavislime.SetActive(false);
            character_slime.SetActive(false);
            character6_morslime
            .SetActive(true);
     
    }
    }
}


