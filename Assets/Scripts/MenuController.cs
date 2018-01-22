using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour {

    public AudioClip UIButtonPressed;
    AudioSource MenuControls;
    public GameObject HomePanel, homeSelected, RecordPanel, recordSelected, SavePanel, saveSelected,SendPanel,sendSelected;
    // Use this for initialization
	void Start () {
       MenuControls = this.gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void ProceedButtonPressed()
    {
        MenuControls.PlayOneShot(UIButtonPressed);
        HomePanel.SetActive(false);
        homeSelected.SetActive(false);
        RecordButtonPressed();
    }
    public void RecordButtonPressed()
    {
        recordSelected.SetActive(true);
        RecordPanel.SetActive(true);
    }
  
}
