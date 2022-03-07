using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class scr_TransformCar : MonoBehaviour
{
    public static scr_TransformCar Instance;

    public List<GameObject> carList;
    [SerializeField] ParticleSystem carChangeParticle;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(Instance);
        }
    }

    public void CarTransformChange(int indexCarOld, int indexCarNew)
    {
        if (indexCarOld!=indexCarNew)
        {

            if (indexCarNew > carList.Count - 1)
            {
                indexCarNew = carList.Count - 1;
            }

            carList[indexCarOld].transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), .1f)
                .OnComplete(() =>
                {
                    carList[indexCarOld].SetActive(false);
                    carList[indexCarNew].transform.localScale = new Vector3(0.1f, .1f, .1f);
                    carChangeParticle.Play();
                    carList[indexCarNew].SetActive(true);
                    carList[indexCarNew].transform.DOScale(new Vector3(.75f, .75f, .75f), .1f);
                });
        }



    }


}
